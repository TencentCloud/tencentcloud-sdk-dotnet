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

    public class HostsCertificate : AbstractModel
    {
        
        /// <summary>
        /// 域名。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// 配置证书的模式，取值有：
        /// <li>disable：不配置证书；</li>
        /// <li>eofreecert：配置 EdgeOne 免费证书；</li> 
        /// <li>sslcert：配置 SSL 证书；</li> 
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 服务端证书配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostCertInfo")]
        public HostCertInfo[] HostCertInfo{ get; set; }

        /// <summary>
        /// 申请类型，取值有：
        /// <li>apply：托管EdgeOne；</li>
        /// <li>none：不托管EdgeOne。</li>不填，默认取值为none。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplyType")]
        [System.Obsolete]
        public string ApplyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamArrayObj(map, prefix + "HostCertInfo.", this.HostCertInfo);
            this.SetParamSimple(map, prefix + "ApplyType", this.ApplyType);
        }
    }
}

