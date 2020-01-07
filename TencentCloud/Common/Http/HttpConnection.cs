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
using Pathoschild.Http.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TencentCloud.Common.Http
{
    public class HttpConnection
    {
        private IClient client;

        private readonly string proxy;

        private readonly int timeout;

        public HttpConnection(string baseUrl, int timeout,string proxy="")
        {
            this.proxy = proxy;
            this.timeout = timeout;
            if (!string.IsNullOrEmpty(proxy))
            {
                client = new FluentClient(baseUrl, new WebProxy(proxy));
            }
            else
            {
                client = new FluentClient(baseUrl);
            }
            client.BaseClient.Timeout = TimeSpan.FromSeconds(timeout);
            client.SetOptions(new FluentClientOptions() { });
        }

        private HttpWebRequest CreateHttp(string url, HttpMethod method)
        {
            HttpWebRequest request = WebRequest.CreateHttp(url);
            request.Timeout = this.timeout * 1000;
            request.Method = method.Method;
            if (!string.IsNullOrEmpty(proxy))
            {
                request.Proxy = new WebProxy(proxy);
            }
            return request;
        }

        private HttpWebRequest CreateHttp(string url, HttpMethod method, Dictionary<string, string> headers)
        {
            HttpWebRequest request = this.CreateHttp(url, method);
            request.PreAuthenticate = true;
            string contentTypeName = "Content-Type";
            // 计算签名时将charset添加到了Content-Type中
            request.ContentType = headers[contentTypeName] + "; charset=utf-8";
            headers.Remove(contentTypeName);
            foreach (KeyValuePair<string, string> kvp in headers)
            {
                request.Headers.Add(kvp.Key, kvp.Value);
            }
            // 为了和异步接口保持一致，删除headers中的Authorization信息
            headers.Remove("Authorization");
            return request;
        }

        private static string AppendQuery(StringBuilder builder, Dictionary<string, string> param)
        {
            foreach (KeyValuePair<string, string> kvp in param)
            {
                builder.Append($"{WebUtility.UrlEncode(kvp.Key)}={WebUtility.UrlEncode(kvp.Value)}&");
            }
            return builder.ToString().TrimEnd('&');
        }

        public async Task<IResponse> GetRequest(string url, Dictionary<string, string> param)
        {        
            StringBuilder urlBuilder = new StringBuilder($"{client.BaseClient.BaseAddress.AbsoluteUri.TrimEnd('/')}{url}?");
            string fullUrl = AppendQuery(urlBuilder, param);
            IResponse response = await client.GetAsync(fullUrl);
            return response;
        }

        public HttpWebResponse GetRequestSync(string url, Dictionary<string, string> param)
        { 
            StringBuilder urlBuilder = new StringBuilder($"{client.BaseClient.BaseAddress.AbsoluteUri.TrimEnd('/')}{url}?");
            string fullUrl = AppendQuery(urlBuilder, param);
            HttpWebRequest request = this.CreateHttp(fullUrl, HttpMethod.Get);
            return (HttpWebResponse)request.GetResponse();
        }

        public async Task<IResponse> GetRequest(string path, string queryString, Dictionary<string, string> headers)
        {
            StringBuilder urlBuilder = new StringBuilder($"{client.BaseClient.BaseAddress.AbsoluteUri.TrimEnd('/')}{path}?{queryString}");
            IRequest request = client.GetAsync(urlBuilder.ToString());
            request = request.WithAuthentication("TC3-HMAC-SHA256", headers["Authorization"].Substring("TC3-HMAC-SHA256".Length));
            headers.Remove("Authorization");
            StringContent body = new StringContent("", Encoding.UTF8, headers["Content-Type"]);
            request = request.WithBodyContent(body);
            headers.Remove("Content-Type");
            foreach (KeyValuePair<string, string> kvp in headers)
            {
                request = request.WithHeader(kvp.Key, kvp.Value);
            }
            return await request;
        }

        public HttpWebResponse GetRequestSync(string path, string queryString, Dictionary<string, string> headers)
        {
            StringBuilder urlBuilder = new StringBuilder($"{client.BaseClient.BaseAddress.AbsoluteUri.TrimEnd('/')}{path}?{queryString}");
            HttpWebRequest request = this.CreateHttp(urlBuilder.ToString(), HttpMethod.Get, headers);
            return (HttpWebResponse)request.GetResponse();
        }

        public async Task<IResponse> PostRequest(string path, string payload, Dictionary<string, string> headers)
        {
            StringBuilder urlBuilder = new StringBuilder($"{client.BaseClient.BaseAddress.AbsoluteUri.TrimEnd('/')}{path}");
            IRequest request = client.PostAsync(urlBuilder.ToString());
            request = request.WithAuthentication("TC3-HMAC-SHA256", headers["Authorization"].Substring("TC3-HMAC-SHA256".Length));
            headers.Remove("Authorization");
            StringContent body = new StringContent(payload, Encoding.UTF8, headers["Content-Type"]);
            request = request.WithBodyContent(body);
            headers.Remove("Content-Type");
            foreach (KeyValuePair<string, string> kvp in headers)
            {
                request = request.WithHeader(kvp.Key, kvp.Value);
            }
            return await request.AsResponse();
        }

        public HttpWebResponse PostRequestSync(string path, string payload, Dictionary<string, string> headers)
        {
            StringBuilder urlBuilder = new StringBuilder($"{client.BaseClient.BaseAddress.AbsoluteUri.TrimEnd('/')}{path}");
            HttpWebRequest request = this.CreateHttp(urlBuilder.ToString(), HttpMethod.Post, headers);
            using (Stream reqStream = request.GetRequestStream())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(payload);
                reqStream.Write(bytes, 0, bytes.Length);
            }
            return (HttpWebResponse)request.GetResponse();
        }

        public async Task<IResponse> PostRequest(string url, Dictionary<string, string> param)
        {
            // set up
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage message = new HttpRequestMessage(method, url);
            // System.UriFormatException: Invalid URI: The Uri string is too long.
            // var postbody = new FormUrlEncodedContent(param);
            StringBuilder bodysb = new StringBuilder();
            string body = AppendQuery(bodysb, param);
            message.Content = new StringContent(body, Encoding.UTF8, "application/x-www-form-urlencoded");

            IRequest request =  client.SendAsync(message);
            var response = await request.AsResponse();
            return response;
        }

        public HttpWebResponse PostRequestSync(string url, Dictionary<string, string> param)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>
            {
                ["Content-Type"] = "application/x-www-form-urlencoded"
            };
            StringBuilder urlBuilder = new StringBuilder($"{client.BaseClient.BaseAddress.AbsoluteUri.TrimEnd('/')}{url}?");
            HttpWebRequest request = this.CreateHttp(urlBuilder.ToString(), HttpMethod.Post, headers);
            StringBuilder bodysb = new StringBuilder();
            string body = AppendQuery(bodysb, param);
            using (Stream reqStream = request.GetRequestStream())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(body);
                reqStream.Write(bytes, 0, bytes.Length);
            }
            return (HttpWebResponse)request.GetResponse();
        }
    }
}
