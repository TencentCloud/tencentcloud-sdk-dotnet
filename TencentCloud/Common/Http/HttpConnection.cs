/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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
    public class HttpConnection
    {
        private static readonly ConcurrentDictionary<Tuple<string, string>, HttpClient> HttpClients = new ConcurrentDictionary<Tuple<string, string>, HttpClient>();

        private readonly HttpClient _http;
        private readonly int _timeout;

        public HttpConnection(string baseUrl, int timeout, string proxy, HttpClient http)
        {
            this._timeout = timeout;
            this._http = http ?? HttpClients.GetOrAdd(Tuple.Create(baseUrl, proxy), CreatHttpClient);
        }

        private static HttpClient CreatHttpClient(Tuple<string, string> tuple)
        {
            var baseUrl = tuple.Item1;
            var proxy = tuple.Item2;
            
            var baseAddress = new Uri(baseUrl.TrimEnd('/'));
            IWebProxy webProxy = null;
            if (!string.IsNullOrEmpty(proxy))
            {
                webProxy = new WebProxy(proxy);
            }

            // https://www.siakabaro.com/how-to-manage-httpclient-connections-in-net/
            var servicePoint = ServicePointManager.FindServicePoint(baseAddress, webProxy);
            servicePoint.ConnectionLeaseTimeout = 1000 * 60 * 5; // 5 min

            if (webProxy != null)
            {
                var httpClientHandler = new HttpClientHandler
                {
                    Proxy = webProxy,
                };

                return new HttpClient(httpClientHandler, true)
                {
                    BaseAddress = baseAddress
                };
            }

            return new HttpClient
            {
                BaseAddress = baseAddress
            };
        }

        private static string AppendQuery(StringBuilder builder, Dictionary<string, string> param)
        {
            foreach (var kvp in param)
            {
                builder.Append($"{WebUtility.UrlEncode(kvp.Key)}={WebUtility.UrlEncode(kvp.Value)}&");
            }

            return builder.ToString().TrimEnd('&');
        }

        public async Task<HttpResponseMessage> GetRequestAsync(string url, Dictionary<string, string> param)
        {
            var urlBuilder = new StringBuilder($"{url}?");
            var fullUrl = AppendQuery(urlBuilder, param);
            var headers = new Dictionary<string, string>();
            return await Send(HttpMethod.Get, fullUrl, string.Empty, headers).ConfigureAwait(false);
        }

        public async Task<HttpResponseMessage> GetRequestAsync(string path, string queryString,
            Dictionary<string, string> headers)
        {
            return await Send(HttpMethod.Get, $"{path}?{queryString}", string.Empty, headers).ConfigureAwait(false);
        }

        public async Task<HttpResponseMessage> PostRequestAsync(string path, string payload,
            Dictionary<string, string> headers)
        {
            return await Send(HttpMethod.Post, path, payload, headers).ConfigureAwait(false);
        }

        public async Task<HttpResponseMessage> PostRequestAsync(string path, byte[] payload,
            Dictionary<string, string> headers)
        {
            return await Send(HttpMethod.Post, path, payload, headers).ConfigureAwait(false);
        }

        public async Task<HttpResponseMessage> PostRequestAsync(string url, Dictionary<string, string> param)
        {
            var payloadBuilder = new StringBuilder();
            var payload = AppendQuery(payloadBuilder, param);
            var headers = new Dictionary<string, string>
            {
                ["Content-Type"] = "application/x-www-form-urlencoded"
            };
            return await Send(HttpMethod.Post, url, payload, headers).ConfigureAwait(false);
        }

        private async Task<HttpResponseMessage> Send(HttpMethod method, 
            string url, 
            string payload,
            Dictionary<string, string> headers)
        {
            return await Send(method, url, Encoding.UTF8.GetBytes(payload), headers).ConfigureAwait(false);
        }

        private async Task<HttpResponseMessage> Send(
            HttpMethod method, string url, byte[] payload, Dictionary<string, string> headers)
        {
            using (var cts = new System.Threading.CancellationTokenSource(_timeout * 1000))
            {
                using (var msg = new HttpRequestMessage(method, url))
                {
                    foreach (var kvp in headers)
                    {
                        if (kvp.Key.Equals("Content-Type"))
                        {
                            var content = new ByteArrayContent(payload);
                            content.Headers.Remove("Content-Type");
                            content.Headers.Add("Content-Type", kvp.Value);
                            msg.Content = content;
                        }
                        else if (kvp.Key.Equals("Host"))
                        {
                            msg.Headers.Host = kvp.Value;
                        }
                        else if (kvp.Key.Equals("Authorization"))
                        {
                            msg.Headers.Authorization = new AuthenticationHeaderValue("TC3-HMAC-SHA256",
                                kvp.Value.Substring("TC3-HMAC-SHA256".Length));
                        }
                        else
                        {
                            msg.Headers.Add(kvp.Key, kvp.Value);
                        }
                    }

                    return await _http.SendAsync(msg, HttpCompletionOption.ResponseHeadersRead, cts.Token)
                        .ConfigureAwait(false);
                }
            }
        }
    }
}