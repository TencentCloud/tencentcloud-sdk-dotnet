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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BindSubDomainRequest : AbstractModel
    {
        
        /// <summary>
        /// 服务唯一 ID。
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// 待绑定的自定义的域名。
        /// </summary>
        [JsonProperty("SubDomain")]
        public string SubDomain{ get; set; }

        /// <summary>
        /// 服务支持协议，可选值为http、https、http&https。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 网络类型，可选值为OUTER、INNER。
        /// </summary>
        [JsonProperty("NetType")]
        public string NetType{ get; set; }

        /// <summary>
        /// 是否使用默认路径映射，默认为 true。为 false 时，表示自定义路径映射，此时 PathMappingSet 必填。
        /// </summary>
        [JsonProperty("IsDefaultMapping")]
        public bool? IsDefaultMapping{ get; set; }

        /// <summary>
        /// 默认域名。
        /// </summary>
        [JsonProperty("NetSubDomain")]
        public string NetSubDomain{ get; set; }

        /// <summary>
        /// 待绑定自定义域名的证书唯一 ID。针对Protocol 为https或http&https可以选择上传。
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// 自定义域名路径映射，最多输入三个Environment，并且只能分别取值“test”、 ”prepub“、”release“。
        /// </summary>
        [JsonProperty("PathMappingSet")]
        public PathMapping[] PathMappingSet{ get; set; }

        /// <summary>
        /// 是否将HTTP请求强制跳转 HTTPS，默认为false。参数为 true时，API网关会将所有使用该自定义域名的 HTTP 协议的请求重定向至 HTTPS 协议进行转发。
        /// </summary>
        [JsonProperty("IsForcedHttps")]
        public bool? IsForcedHttps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "SubDomain", this.SubDomain);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
            this.SetParamSimple(map, prefix + "IsDefaultMapping", this.IsDefaultMapping);
            this.SetParamSimple(map, prefix + "NetSubDomain", this.NetSubDomain);
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamArrayObj(map, prefix + "PathMappingSet.", this.PathMappingSet);
            this.SetParamSimple(map, prefix + "IsForcedHttps", this.IsForcedHttps);
        }
    }
}

