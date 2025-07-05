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

    public class ModifyCloudNativeAPIGatewayCertificateRequest : AbstractModel
    {
        
        /// <summary>
        /// 网关ID
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// 证书id
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 证书名称，即将废弃
        /// </summary>
        [JsonProperty("Name")]
        [System.Obsolete]
        public string Name{ get; set; }

        /// <summary>
        /// 证书私钥，CertSource为native时必填。
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 证书pem格式，CertSource为native时必填。
        /// </summary>
        [JsonProperty("Crt")]
        public string Crt{ get; set; }

        /// <summary>
        /// 绑定的域名，即将废弃
        /// </summary>
        [JsonProperty("BindDomains")]
        [System.Obsolete]
        public string[] BindDomains{ get; set; }

        /// <summary>
        /// ssl平台证书 Id，CertSource为ssl时必填。
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// 证书来源
        /// - ssl (ssl平台证书)，默认值
        /// - native (kong自定义证书) 
        /// </summary>
        [JsonProperty("CertSource")]
        public string CertSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Crt", this.Crt);
            this.SetParamArraySimple(map, prefix + "BindDomains.", this.BindDomains);
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "CertSource", this.CertSource);
        }
    }
}

