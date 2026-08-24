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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCloudNativeAPIGatewayCertificateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>网关ID</p>
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// <p>ssl平台证书 Id</p>
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// <p>绑定的域名</p>
        /// </summary>
        [JsonProperty("BindDomains")]
        public string[] BindDomains{ get; set; }

        /// <summary>
        /// <p>证书名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>证书类型</p><p>枚举值：</p><ul><li>SVR： 服务证书</li><li>CA： CA证书</li></ul>
        /// </summary>
        [JsonProperty("CertType")]
        public string CertType{ get; set; }

        /// <summary>
        /// <p>证书用途</p><p>枚举值：</p><ul><li>SERVER： 用作服务端证书</li><li>CLIENT： 用作客户端证书</li></ul>
        /// </summary>
        [JsonProperty("CertUsage")]
        public string CertUsage{ get; set; }

        /// <summary>
        /// <p>证书私钥</p>
        /// </summary>
        [JsonProperty("Key")]
        [System.Obsolete]
        public string Key{ get; set; }

        /// <summary>
        /// <p>证书pem格式</p>
        /// </summary>
        [JsonProperty("Crt")]
        [System.Obsolete]
        public string Crt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamArraySimple(map, prefix + "BindDomains.", this.BindDomains);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
            this.SetParamSimple(map, prefix + "CertUsage", this.CertUsage);
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Crt", this.Crt);
        }
    }
}

