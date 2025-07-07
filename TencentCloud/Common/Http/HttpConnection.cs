/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TencentCloud.Common.Http
{
    /// <summary>
    ///   Provides HTTP client functionality for making requests to Tencent Cloud APIs.
    ///   Handles connection management, including connection pooling and reuse,
    ///   proxy support, and request sending with headers and payloads.
    /// </summary>
    public class HttpConnection
    {
        /// <summary>
        ///   Manages a pool of HttpClient instances to improve performance
        ///   by reusing connections.  Connections are cached based on proxy
        ///   settings and timeout values.  Connections are also periodically
        ///   recreated to avoid potential DNS caching issues.
        /// </summary>
        private class HttpClientHolder
        {
            /// <summary>
            ///   A key used to cache HttpClient instances.  The key includes
            ///   the proxy setting and the timeout value.
            /// </summary>
            private struct CacheKey : IEquatable<CacheKey>
            {
                public string Proxy;
                public int Timeout;

                public CacheKey(string proxy, int timeout)
                {
                    Proxy = string.IsNullOrEmpty(proxy) ? "" : proxy;
                    Timeout = timeout;
                }

                public bool Equals(CacheKey other)
                {
                    return Proxy == other.Proxy && Timeout == other.Timeout;
                }

                public override bool Equals(object obj)
                {
                    return obj is CacheKey other && Equals(other);
                }

                public override int GetHashCode()
                {
                    unchecked
                    {
                        return ((Proxy != null ? Proxy.GetHashCode() : 0) * 397) ^ Timeout;
                    }
                }
            }

            /// <summary>
            ///   A concurrent dictionary to store HttpClient instances,
            ///   keyed by the CacheKey.
            /// </summary>
            private static readonly ConcurrentDictionary<CacheKey, HttpClientHolder> httpclients =
                new ConcurrentDictionary<CacheKey, HttpClientHolder>();

            /// <summary>
            ///   Retrieves an HttpClient instance from the cache, or creates a new one
            ///   if one doesn't exist.  HttpClient instances are reused to improve
            ///   performance.  To mitigate potential DNS caching issues, connections
            ///   are recreated every 5 minutes.
            /// </summary>
            /// <param name="proxy">The proxy server to use (or null for no proxy).</param>
            /// <param name="timeout">The request timeout in seconds.</param>
            /// <returns>An HttpClient instance.</returns>
            public static HttpClient GetClient(string proxy, int timeout)
            {
                CacheKey key = new CacheKey(proxy, timeout);
                HttpClientHolder result = httpclients.GetOrAdd(key, (k) => { return new HttpClientHolder(key); });
                TimeSpan timeSpan = DateTime.Now - result.createTime;

                // A new connection is created every 5 minutes
                // and old connections are discarded to avoid DNS flushing issues.
                while (timeSpan.TotalSeconds > 300)
                {
                    ICollection<KeyValuePair<CacheKey, HttpClientHolder>> kv = httpclients;
                    kv.Remove(new KeyValuePair<CacheKey, HttpClientHolder>(key, result));
                    result = httpclients.GetOrAdd(key, (k) => { return new HttpClientHolder(k); });
                    timeSpan = DateTime.Now - result.createTime;
                }

                return result.client;
            }

            /// <summary>
            ///   The HttpClient instance.
            /// </summary>
            public readonly HttpClient client;

            /// <summary>
            ///   The time the HttpClient instance was created.
            /// </summary>
            public readonly DateTime createTime;

            /// <summary>
            ///   Constructor for HttpClientHolder.  Creates a new HttpClient instance,
            ///   optionally configuring it with a proxy.
            /// </summary>
            /// <param name="key">The CacheKey associated with this client.</param>
            private HttpClientHolder(CacheKey key)
            {
                if (string.IsNullOrEmpty(key.Proxy))
                {
                    this.client = new HttpClient();
                }
                else
                {
                    var httpClientHandler = new HttpClientHandler
                    {
                        Proxy = new WebProxy(key.Proxy),
                    };

                    this.client = new HttpClient(handler: httpClientHandler, disposeHandler: true);
                }

                this.client.Timeout = TimeSpan.FromSeconds(key.Timeout);
                this.createTime = DateTime.Now;
            }
        }

        /// <summary>
        ///   The HttpClient instance used for making requests.
        /// </summary>
        private readonly HttpClient http;

        /// <summary>
        ///   The base URL for API requests.
        /// </summary>
        private readonly string baseUrl;

        /// <summary>
        ///   The proxy server to use (or null for no proxy).
        /// </summary>
        private readonly string proxy;

        /// <summary>
        ///   The request timeout in seconds.
        /// </summary>
        private readonly int timeout;

        /// <summary>
        ///   Constructor for HttpConnection.
        /// </summary>
        /// <param name="baseUrl">The base URL for API requests.</param>
        /// <param name="timeout">The request timeout in seconds.</param>
        /// <param name="proxy">The proxy server to use (or null for no proxy).</param>
        /// <param name="http">An existing HttpClient instance to use (or null to create a new one).</param>
        public HttpConnection(string baseUrl, int timeout, string proxy, HttpClient http)
        {
            this.proxy = string.IsNullOrEmpty(proxy) ? "" : proxy;
            this.timeout = timeout;
            this.baseUrl = baseUrl;
            if (http != null)
            {
                this.http = http;
            }
            else
            {
                this.http = HttpClientHolder.GetClient(this.proxy, this.timeout);
            }
        }

        /// <summary>
        ///   Appends query parameters to a URL.
        /// </summary>
        /// <param name="builder">The StringBuilder to append to.</param>
        /// <param name="param">The dictionary of query parameters.</param>
        /// <returns>The URL with appended query parameters.</returns>
        private static string AppendQuery(StringBuilder builder, Dictionary<string, string> param)
        {
            foreach (KeyValuePair<string, string> kvp in param)
            {
                builder.Append($"{WebUtility.UrlEncode(kvp.Key)}={WebUtility.UrlEncode(kvp.Value)}&");
            }

            return builder.ToString().TrimEnd('&');
        }

        /// <summary>
        ///   Sends a GET request to the specified URL with the given parameters.
        /// </summary>
        /// <param name="url">The URL to send the request to (relative to the base URL).</param>
        /// <param name="param">The query parameters to include in the request.</param>
        /// <returns>The HTTP response message.</returns>
        public async Task<HttpResponseMessage> GetRequestAsync(string url, Dictionary<string, string> param)
        {
            StringBuilder urlBuilder = new StringBuilder($"{baseUrl.TrimEnd('/')}{url}?");
            string fullurl = AppendQuery(urlBuilder, param);
            string payload = "";
            Dictionary<string, string> headers = new Dictionary<string, string>();
            return await this.Send(HttpMethod.Get, fullurl, payload, headers).ConfigureAwait(false);
        }

        /// <summary>
        ///   Sends a GET request to the specified path with the given query string and headers.
        /// </summary>
        /// <param name="path">The path to send the request to (relative to the base URL).</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="headers">The headers to include in the request.</param>
        /// <returns>The HTTP response message.</returns>
        public async Task<HttpResponseMessage> GetRequestAsync(string path, string queryString,
            Dictionary<string, string> headers)
        {
            string fullurl = $"{this.baseUrl.TrimEnd('/')}{path}?{queryString}";
            string payload = "";
            return await this.Send(HttpMethod.Get, fullurl, payload, headers).ConfigureAwait(false);
        }

        /// <summary>
        ///   Sends a POST request to the specified path with the given payload and headers.
        /// </summary>
        /// <param name="path">The path to send the request to (relative to the base URL).</param>
        /// <param name="payload">The payload to include in the request.</param>
        /// <param name="headers">The headers to include in the request.</param>
        /// <returns>The HTTP response message.</returns>
        public async Task<HttpResponseMessage> PostRequestAsync(string path, string payload,
            Dictionary<string, string> headers)
        {
            string fullurl = $"{baseUrl.TrimEnd('/')}{path}";
            return await this.Send(HttpMethod.Post, fullurl, payload, headers).ConfigureAwait(false);
        }

        /// <summary>
        ///   Sends a POST request to the specified path with the given byte array payload and headers.
        /// </summary>
        /// <param name="path">The path to send the request to (relative to the base URL).</param>
        /// <param name="payload">The byte array payload to include in the request.</param>
        /// <param name="headers">The headers to include in the request.</param>
        /// <returns>The HTTP response message.</returns>
        public async Task<HttpResponseMessage> PostRequestAsync(string path, byte[] payload,
            Dictionary<string, string> headers)
        {
            string fullurl = $"{baseUrl.TrimEnd('/')}{path}";
            return await this.Send(HttpMethod.Post, fullurl, payload, headers).ConfigureAwait(false);
        }

        /// <summary>
        ///   Sends a POST request to the specified URL with the given parameters,
        ///   using application/x-www-form-urlencoded content type.
        /// </summary>
        /// <param name="url">The URL to send the request to (relative to the base URL).</param>
        /// <param name="param">The parameters to include in the request.</param>
        /// <returns>The HTTP response message.</returns>
        public async Task<HttpResponseMessage> PostRequestAsync(string url, Dictionary<string, string> param)
        {
            string fullurl = $"{this.baseUrl.TrimEnd('/')}{url}?";
            StringBuilder payloadBuilder = new StringBuilder();
            string payload = AppendQuery(payloadBuilder, param);
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers["Content-Type"] = "application/x-www-form-urlencoded";
            return await this.Send(HttpMethod.Post, fullurl, payload, headers).ConfigureAwait(false);
        }

        /// <summary>
        ///   Sends an HTTP request with the specified method, URL, string payload, and headers.
        /// </summary>
        /// <param name="method">The HTTP method to use (e.g., GET, POST).</param>
        /// <param name="url">The full URL to send the request to.</param>
        /// <param name="payload">The string payload to include in the request.</param>
        /// <param name="headers">The headers to include in the request.</param>
        /// <returns>The HTTP response message.</returns>
        private async Task<HttpResponseMessage> Send(HttpMethod method, string url, string payload,
            Dictionary<string, string> headers)
        {
            return await Send(method, url, Encoding.UTF8.GetBytes(payload), headers).ConfigureAwait(false);
        }

        /// <summary>
        ///   Sends an HTTP request with the specified method, URL, byte array payload, and headers.
        ///   This is the core method for sending requests.
        /// </summary>
        /// <param name="method">The HTTP method to use (e.g., GET, POST).</param>
        /// <param name="url">The full URL to send the request to.</param>
        /// <param name="payload">The byte array payload to include in the request.</param>
        /// <param name="headers">The headers to include in the request.</param>
        /// <returns>The HTTP response message.</returns>
        private async Task<HttpResponseMessage> Send(
            HttpMethod method, string url, byte[] payload, Dictionary<string, string> headers)
        {
            using (var cts = new System.Threading.CancellationTokenSource(timeout * 1000))
            {
                using (var msg = new HttpRequestMessage(method, url))
                {
                    // Apply headers to the request message.
                    foreach (KeyValuePair<string, string> kvp in headers)
                    {
                        if (kvp.Key.Equals("Content-Type"))
                        {
                            // Set the Content-Type header with a ByteArrayContent.
                            ByteArrayContent content = new ByteArrayContent(payload);
                            content.Headers.Remove("Content-Type");
                            content.Headers.Add("Content-Type", kvp.Value);
                            msg.Content = content;
                        }
                        else if (kvp.Key.Equals("Host"))
                        {
                            // Set the Host header.
                            msg.Headers.Host = kvp.Value;
                        }
                        else if (kvp.Key.Equals("Authorization"))
                        {
                            // Set the Authorization header for TC3-HMAC-SHA256.
                            msg.Headers.Authorization = new AuthenticationHeaderValue("TC3-HMAC-SHA256",
                                kvp.Value.Substring("TC3-HMAC-SHA256".Length));
                        }
                        else
                        {
                            // Add other headers.
                            msg.Headers.Add(kvp.Key, kvp.Value);
                        }
                    }

                    // Send the request and return the response.
                    return await http.SendAsync(msg, HttpCompletionOption.ResponseHeadersRead, cts.Token)
                        .ConfigureAwait(false);
                }
            }
        }
    }
}