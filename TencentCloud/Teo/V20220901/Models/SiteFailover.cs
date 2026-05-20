/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SiteFailover : AbstractModel
    {
        
        /// <summary>
        /// 源站故障转移类型。取值有：
        /// <li>FailoverToHost:回源到指定 IP/域名；</li>
        /// <li> FailoverToCOS:回源到腾讯云 COS；</li>
        /// <li>FailoverToS3CompatibleObjectStorage:回源到 S3 兼容；</li>
        /// <li> FailoverRedirectToURL :重定向至指定 URL；</li>
        /// <li> FailoverCustomResponsePage:使用自定义响应页面。</li>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 源站地址，根据 Mode 的取值分为以下情况：
        /// <li>当 Mode = FailoverToHost 时，该参数请填写 IPV4、IPV6 地址或域名；</li>
        /// <li>当 Mode = FailoverToCOS 时，该参数请填写 COS 桶的访问域名；</li>
        /// <li>当 Mode = FailoverToS3CompatibleObjectStorage，该参数请填写 S3 桶的访问域名。</li>
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// 回源协议配置。当 Mode 取值为 FailoverToHost 时该参数必填。取值有：
        /// <li>http：使用 HTTP 协议；</li>
        /// <li>https：使用 HTTPS 协议；</li>
        /// <li>follow：协议跟随。</li>
        /// </summary>
        [JsonProperty("OriginProtocol")]
        public string OriginProtocol{ get; set; }

        /// <summary>
        /// HTTP 回源端口，取值范围 1～65535。当回源协议 OriginProtocol 为 http 或者 follow 时该参数必填。
        /// </summary>
        [JsonProperty("HTTPOriginPort")]
        public long? HTTPOriginPort{ get; set; }

        /// <summary>
        /// HTTPS 回源端口，取值范围 1～65535。当回源协议 OriginProtocol 为 https 或者 follow 时该参数必填。
        /// </summary>
        [JsonProperty("HTTPSOriginPort")]
        public long? HTTPSOriginPort{ get; set; }

        /// <summary>
        /// 回源Host Header 重写配置，
        /// </summary>
        [JsonProperty("UpstreamHostHeader")]
        public HostHeaderParameters UpstreamHostHeader{ get; set; }

        /// <summary>
        /// 回源 URL 重写配置。
        /// </summary>
        [JsonProperty("UpstreamURLRewrite")]
        public UpstreamURLRewriteParameters UpstreamURLRewrite{ get; set; }

        /// <summary>
        /// 回源请求参数配置。
        /// </summary>
        [JsonProperty("UpstreamRequestParameters")]
        public UpstreamRequestParameters UpstreamRequestParameters{ get; set; }

        /// <summary>
        /// HTTP2 回源配置参数。
        /// </summary>
        [JsonProperty("UpstreamHTTP2Parameters")]
        public UpstreamHTTP2Parameters UpstreamHTTP2Parameters{ get; set; }

        /// <summary>
        /// 指定是否允许访问私有对象存储源站，当源站类型 Mode = FailoverToCOS 或 FailoverToS3CompatibleObjectStorage 时该参数必填，取值有：
        /// <li>on：使用私有鉴权；</li>
        /// <li>off：不使用私有鉴权。</li>
        /// </summary>
        [JsonProperty("PrivateAccess")]
        public string PrivateAccess{ get; set; }

        /// <summary>
        /// 私有鉴权使用参数，该参数仅当 Mode = FailoverToS3CompatibleObjectStorage 且 PrivateAccess = on 时会生效。
        /// </summary>
        [JsonProperty("PrivateParameters")]
        public OriginPrivateParameters PrivateParameters{ get; set; }

        /// <summary>
        /// 重定向目标 URL。当 Mode 取值为 FailoverRedirectToURL 时该参数必填。
        /// </summary>
        [JsonProperty("RedirectURL")]
        public string RedirectURL{ get; set; }

        /// <summary>
        /// 响应页面 ID。当 Mode 取值为 FailoverCustomResponsePage 时该参数必填。
        /// </summary>
        [JsonProperty("ResponsePageId")]
        public string ResponsePageId{ get; set; }

        /// <summary>
        /// 响应状态码。当 Mode 取值为 FailoverRedirectToURL 或 FailoverCustomResponsePage 时该参数必填。取值有：
        /// <li>当 Mode = FailoverRedirectToURL 时，该参数取值为 301、302、303、307、308 之一；</li>
        /// <li>当 Mode = FailoverCustomResponsePage 时，该参数取值为 400、403、404、405、414、416、451、500、501、502、503、504 之一。</li>
        /// </summary>
        [JsonProperty("StatusCode")]
        public long? StatusCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Origin", this.Origin);
            this.SetParamSimple(map, prefix + "OriginProtocol", this.OriginProtocol);
            this.SetParamSimple(map, prefix + "HTTPOriginPort", this.HTTPOriginPort);
            this.SetParamSimple(map, prefix + "HTTPSOriginPort", this.HTTPSOriginPort);
            this.SetParamObj(map, prefix + "UpstreamHostHeader.", this.UpstreamHostHeader);
            this.SetParamObj(map, prefix + "UpstreamURLRewrite.", this.UpstreamURLRewrite);
            this.SetParamObj(map, prefix + "UpstreamRequestParameters.", this.UpstreamRequestParameters);
            this.SetParamObj(map, prefix + "UpstreamHTTP2Parameters.", this.UpstreamHTTP2Parameters);
            this.SetParamSimple(map, prefix + "PrivateAccess", this.PrivateAccess);
            this.SetParamObj(map, prefix + "PrivateParameters.", this.PrivateParameters);
            this.SetParamSimple(map, prefix + "RedirectURL", this.RedirectURL);
            this.SetParamSimple(map, prefix + "ResponsePageId", this.ResponsePageId);
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
        }
    }
}

