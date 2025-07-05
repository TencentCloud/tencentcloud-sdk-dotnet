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

    public class ModifyHostsCertificateRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 需要修改证书配置的加速域名。
        /// </summary>
        [JsonProperty("Hosts")]
        public string[] Hosts{ get; set; }

        /// <summary>
        /// 配置服务端证书的模式，取值有：
        /// <li>disable：不配置服务端证书；</li>
        /// <li>eofreecert：配置 EdgeOne 免费服务端证书；</li>
        /// <li>sslcert：配置 SSL 托管服务端证书；</li>
        /// 不填写表示服务端证书保持原有配置。
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// SSL 证书配置，本参数仅在 mode 为 sslcert 时生效，传入对应证书的 CertId 即可。您可以前往 [SSL 证书列表](https://console.cloud.tencent.com/ssl) 查看 CertId。
        /// </summary>
        [JsonProperty("ServerCertInfo")]
        public ServerCertInfo[] ServerCertInfo{ get; set; }

        /// <summary>
        /// 托管类型，取值有：
        /// <li>none：不托管EO；</li>
        /// <li>apply：托管EO</li>
        /// 不填，默认取值为none。
        /// </summary>
        [JsonProperty("ApplyType")]
        [System.Obsolete]
        public string ApplyType{ get; set; }

        /// <summary>
        /// 在边缘双向认证场景下，该字段为客户端的 CA 证书，部署在 EO 节点内，用于客户端对 EO 节点进行认证。默认关闭，不填写表示保持原有配置。
        /// </summary>
        [JsonProperty("ClientCertInfo")]
        public MutualTLS ClientCertInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArraySimple(map, prefix + "Hosts.", this.Hosts);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamArrayObj(map, prefix + "ServerCertInfo.", this.ServerCertInfo);
            this.SetParamSimple(map, prefix + "ApplyType", this.ApplyType);
            this.SetParamObj(map, prefix + "ClientCertInfo.", this.ClientCertInfo);
        }
    }
}

