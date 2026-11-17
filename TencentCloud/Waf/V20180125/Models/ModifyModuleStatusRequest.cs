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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyModuleStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>需要设置的domain</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>Web 安全模块开关，0或1</p>
        /// </summary>
        [JsonProperty("WebSecurity")]
        public ulong? WebSecurity{ get; set; }

        /// <summary>
        /// <p>访问控制模块开关，0或者1</p>
        /// </summary>
        [JsonProperty("AccessControl")]
        public ulong? AccessControl{ get; set; }

        /// <summary>
        /// <p>CC模块开关，0或者1</p>
        /// </summary>
        [JsonProperty("CcProtection")]
        public ulong? CcProtection{ get; set; }

        /// <summary>
        /// <p>API安全模块开关，0或者1</p>
        /// </summary>
        [JsonProperty("ApiProtection")]
        public ulong? ApiProtection{ get; set; }

        /// <summary>
        /// <p>API安全检测开关，0关闭1开启</p>
        /// </summary>
        [JsonProperty("ApiDetect")]
        public ulong? ApiDetect{ get; set; }

        /// <summary>
        /// <p>防篡改模块开关，0或者1</p>
        /// </summary>
        [JsonProperty("AntiTamper")]
        public ulong? AntiTamper{ get; set; }

        /// <summary>
        /// <p>防泄漏模块开关，0或者1</p>
        /// </summary>
        [JsonProperty("AntiLeakage")]
        public ulong? AntiLeakage{ get; set; }

        /// <summary>
        /// <p>限流模块开关，0或1</p>
        /// </summary>
        [JsonProperty("RateLimit")]
        public ulong? RateLimit{ get; set; }

        /// <summary>
        /// <p>gzip 开关</p>
        /// </summary>
        [JsonProperty("GzipAnalysis")]
        public ulong? GzipAnalysis{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "WebSecurity", this.WebSecurity);
            this.SetParamSimple(map, prefix + "AccessControl", this.AccessControl);
            this.SetParamSimple(map, prefix + "CcProtection", this.CcProtection);
            this.SetParamSimple(map, prefix + "ApiProtection", this.ApiProtection);
            this.SetParamSimple(map, prefix + "ApiDetect", this.ApiDetect);
            this.SetParamSimple(map, prefix + "AntiTamper", this.AntiTamper);
            this.SetParamSimple(map, prefix + "AntiLeakage", this.AntiLeakage);
            this.SetParamSimple(map, prefix + "RateLimit", this.RateLimit);
            this.SetParamSimple(map, prefix + "GzipAnalysis", this.GzipAnalysis);
        }
    }
}

