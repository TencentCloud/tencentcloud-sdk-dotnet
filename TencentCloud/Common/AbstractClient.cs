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
using Newtonsoft.Json;
using Pathoschild.Http.Client;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TencentCloud.Common.Http;
using TencentCloud.Common.Profile;

namespace TencentCloud.Common
{
    public class AbstractClient
    {
        public const int HTTP_RSP_OK = 200;
        public const string SDK_VERSION = "SDK_NET_3.0.0";

        public AbstractClient(string endpoint, string version, Credential credential, string region, ClientProfile profile)
        {
            this.Credential = credential;
            this.Profile = profile;
            this.Endpoint = endpoint;
            this.Region = region;
            this.Path = "/";
            this.SdkVersion = SDK_VERSION;
            this.ApiVersion = version;
        }

        /// <summary>
        /// 认证信息实例
        /// </summary>
        public Credential Credential { get; set; }

        /// <summary>
        /// 配置实例
        /// </summary>
        public ClientProfile Profile { get; set; }

        /// <summary>
        /// 服务端点
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// 产品地域
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// 路径
        /// </summary>
        public string Path { get; private set; }

        /// <summary>
        /// SDK版本
        /// </summary>
        public string SdkVersion { get; set; }

        /// <summary>
        /// API版本
        /// </summary>
        public string ApiVersion { get; set; }

        protected async Task<string> InternalRequest(AbstractModel request, string actionName)
        {
            IResponse okRsp = null;
            string endpoint = this.Endpoint;
            if (!string.IsNullOrEmpty(this.Profile.HttpProfile.Endpoint)) {
                endpoint = this.Profile.HttpProfile.Endpoint;
            }
            Dictionary<string, string> param = new Dictionary<string, string>();
            request.ToMap(param, "");
            // inplace change
            this.FormatRequestData(actionName, param);
            using (HttpConnection conn = new HttpConnection($"{this.Profile.HttpProfile.Protocol }{endpoint}", this.Profile.HttpProfile.Timeout, this.Profile.HttpProfile.WebProxy))
            {

                if ((this.Profile.HttpProfile.ReqMethod != HttpProfile.REQ_GET) && (this.Profile.HttpProfile.ReqMethod != HttpProfile.REQ_POST))
                {
                    throw new TencentCloudSDKException("Method only support (GET, POST)");
                }
                try
                {
                    if (this.Profile.HttpProfile.ReqMethod == HttpProfile.REQ_GET)
                    {
                        okRsp = await conn.GetRequest($"{this.Path}", param);
                    }
                    else if (this.Profile.HttpProfile.ReqMethod == HttpProfile.REQ_POST)
                    {
                        okRsp = await conn.PostRequest(this.Path, param);
                    }
                }
                catch (Exception ex)
                {
                    throw new TencentCloudSDKException($"The request with exception: {ex.Message }");
                }

                if ((int)okRsp.Status != HTTP_RSP_OK)
                {
                    throw new TencentCloudSDKException(okRsp.Status + await okRsp.Message.Content.ReadAsStringAsync());
                }
                string strResp = null;
                try
                {
                    strResp = await okRsp.AsString();
                }
                catch (ApiException ex)
                {
                    string responseText = await ex.Response.AsString();
                    throw new TencentCloudSDKException($"The API responded with HTTP {ex.Response.Status}: {responseText}");
                }

                JsonResponseModel<JsonResponseErrModel> errResp = null;
                try
                {
                    errResp = JsonConvert.DeserializeObject<JsonResponseModel<JsonResponseErrModel>>(strResp);
                }
                catch (JsonSerializationException e)
                {
                    throw new TencentCloudSDKException(e.Message);
                }
                if (errResp.Response.Error != null)
                {
                    throw new TencentCloudSDKException($"code:{errResp.Response.Error.Code} message:{errResp.Response.Error.Message} ",
                            errResp.Response.RequestId);
                }
                return strResp;
            }
        }

        private Dictionary<string, string> FormatRequestData(string action, Dictionary<string, string> param)
        {
            param.Add("Action", action);
            param.Add("RequestClient", this.SdkVersion);
            param.Add("Nonce", Math.Abs(new Random().Next()).ToString());
            
            long unixTime = ToTimestamp();
            param.Add("Timestamp", (unixTime / 1000).ToString());
            param.Add("Version", this.ApiVersion);

            if (!string.IsNullOrEmpty(this.Credential.SecretId))
            {
                param.Add("SecretId", this.Credential.SecretId);
            }

            if (!string.IsNullOrEmpty(this.Region))
            {
                param.Add("Region", this.Region);
            }

            if (!string.IsNullOrEmpty(this.Profile.SignMethod))
            {
                param.Add("SignatureMethod", this.Profile.SignMethod);
            }

            if (!string.IsNullOrEmpty(this.Credential.Token))
            {
                param.Add("Token", this.Credential.Token);
            }

            string endpoint = this.Endpoint;
            if (!string.IsNullOrEmpty(this.Profile.HttpProfile.Endpoint)) {
                endpoint = this.Profile.HttpProfile.Endpoint;
            }

            string sigInParam = SignHelper.MakeSignPlainText(new SortedDictionary<string, string>(param),
                this.Profile.HttpProfile.ReqMethod, endpoint, this.Path);
            string sigOutParam = SignHelper.Sign(this.Credential.SecretKey, sigInParam, this.Profile.SignMethod);
            param.Add("Signature", sigOutParam);
            return param;
        }

        public long ToTimestamp()
        {
#if NET45
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0));
            DateTime nowTime = DateTime.Now;
            long unixTime = (long)Math.Round((nowTime - startTime).TotalMilliseconds, MidpointRounding.AwayFromZero);
            return unixTime;
#endif

#if NS2 || NETSTANDARD2_0
            DateTimeOffset expiresAtOffset = DateTimeOffset.Now;
            var totalSeconds = expiresAtOffset.ToUnixTimeMilliseconds();
            return totalSeconds;
#endif

        }
    }
}
