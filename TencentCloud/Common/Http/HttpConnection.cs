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
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TencentCloud.Common.Http
{
    public class HttpConnection: IDisposable
    {
        private IClient client;

        public HttpConnection(string baseUrl, int timeout, string proxy = "")
        {
            var tokenSource = new CancellationTokenSource();
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
            client.SetRequestCoordinator(maxRetries: 3, shouldRetry: request => request.StatusCode != HttpStatusCode.OK,
                getDelay: (attempt, response) => { return TimeSpan.FromSeconds(attempt*attempt); });
        }

        public async Task<IResponse> GetRequest(string url, Dictionary<string, string> param, CancellationToken token = default(CancellationToken))
        {        
            StringBuilder urlBuilder = new StringBuilder($"{client.BaseClient.BaseAddress.AbsoluteUri.TrimEnd('/')}{url}?");

            foreach (KeyValuePair<string, string> kvp in param)
            {
                urlBuilder.Append($"{WebUtility.UrlEncode(kvp.Key)}={WebUtility.UrlEncode(kvp.Value)}&");
            }

            IResponse response = await client.GetAsync(urlBuilder.ToString().TrimEnd('&'))
                .WithCancellationToken(token);
            return response;
        }

        public async Task<IResponse> PostRequest(string url, Dictionary<string, string> param, CancellationToken token = default(CancellationToken))
        {
            // set up
            HttpMethod method = new HttpMethod("POST");
            HttpRequestMessage message = new HttpRequestMessage(method, url);
            var postbody = new FormUrlEncodedContent(param);
            message.Content = postbody;

            IRequest request =  this.client.SendAsync(message)
                .WithCancellationToken(token);
            var response = await request.AsResponse();
            return response;
        }

        #region IDisposable Support
        private bool disposedValue = false; // 要检测冗余调用

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    client.Dispose();
                }
                client = null;
                disposedValue = true;
            }
        }

        // 添加此代码以正确实现可处置模式。
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}
