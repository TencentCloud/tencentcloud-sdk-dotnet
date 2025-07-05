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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Certificate : AbstractModel
    {
        
        /// <summary>
        /// 证书ID
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// 证书绑定的域名
        /// </summary>
        [JsonProperty("DnsNames")]
        public string[] DnsNames{ get; set; }

        /// <summary>
        /// 根证书ID
        /// </summary>
        [JsonProperty("CertCaId")]
        public string CertCaId{ get; set; }

        /// <summary>
        /// 证书认证模式：UNIDIRECTIONAL单向认证，MUTUAL双向认证
        /// </summary>
        [JsonProperty("SSLMode")]
        public string SSLMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamArraySimple(map, prefix + "DnsNames.", this.DnsNames);
            this.SetParamSimple(map, prefix + "CertCaId", this.CertCaId);
            this.SetParamSimple(map, prefix + "SSLMode", this.SSLMode);
        }
    }
}

