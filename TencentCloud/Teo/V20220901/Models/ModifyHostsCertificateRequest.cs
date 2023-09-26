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
        /// 配置证书的模式，取值有：
        /// <li>disable：不配置证书；</li>
        /// <li>eofreecert：配置 EdgeOne 免费证书；</li>
        /// <li>sslcert：配置 SSL 证书。</li>不填时默认取值为 disable。
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// SSL 证书配置，本参数仅在 mode = sslcert 时生效，传入对应证书的 CertId 即可。您可以前往 [SSL 证书列表](https://console.cloud.tencent.com/certoverview) 查看 CertId。
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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArraySimple(map, prefix + "Hosts.", this.Hosts);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamArrayObj(map, prefix + "ServerCertInfo.", this.ServerCertInfo);
            this.SetParamSimple(map, prefix + "ApplyType", this.ApplyType);
        }
    }
}

