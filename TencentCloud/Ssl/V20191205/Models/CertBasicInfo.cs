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

    public class CertBasicInfo : AbstractModel
    {
        
        /// <summary>
        /// 颁发者
        /// </summary>
        [JsonProperty("Issuer")]
        public string Issuer{ get; set; }

        /// <summary>
        /// 颁发给
        /// </summary>
        [JsonProperty("Subject")]
        public string Subject{ get; set; }

        /// <summary>
        /// 证书指纹
        /// </summary>
        [JsonProperty("Fingerprint")]
        public string Fingerprint{ get; set; }

        /// <summary>
        /// 证书有效期开始时间
        /// </summary>
        [JsonProperty("ValidFrom")]
        public string ValidFrom{ get; set; }

        /// <summary>
        /// 证书有效期结束时间
        /// </summary>
        [JsonProperty("ValidTo")]
        public string ValidTo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Issuer", this.Issuer);
            this.SetParamSimple(map, prefix + "Subject", this.Subject);
            this.SetParamSimple(map, prefix + "Fingerprint", this.Fingerprint);
            this.SetParamSimple(map, prefix + "ValidFrom", this.ValidFrom);
            this.SetParamSimple(map, prefix + "ValidTo", this.ValidTo);
        }
    }
}

