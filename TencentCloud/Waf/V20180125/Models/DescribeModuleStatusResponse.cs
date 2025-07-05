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

    public class DescribeModuleStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// WEB安全规则是否开启
        /// </summary>
        [JsonProperty("WebSecurity")]
        public ulong? WebSecurity{ get; set; }

        /// <summary>
        /// 访问控制规则是否开启
        /// </summary>
        [JsonProperty("AccessControl")]
        public long? AccessControl{ get; set; }

        /// <summary>
        /// CC防护是否开启
        /// </summary>
        [JsonProperty("CcProtection")]
        public ulong? CcProtection{ get; set; }

        /// <summary>
        /// 网页防篡改是否开启
        /// </summary>
        [JsonProperty("AntiTamper")]
        public ulong? AntiTamper{ get; set; }

        /// <summary>
        /// 信息防泄漏是否开启
        /// </summary>
        [JsonProperty("AntiLeakage")]
        public ulong? AntiLeakage{ get; set; }

        /// <summary>
        /// API安全是否开启
        /// </summary>
        [JsonProperty("ApiProtection")]
        public ulong? ApiProtection{ get; set; }

        /// <summary>
        /// 限流模块开关
        /// </summary>
        [JsonProperty("RateLimit")]
        public ulong? RateLimit{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WebSecurity", this.WebSecurity);
            this.SetParamSimple(map, prefix + "AccessControl", this.AccessControl);
            this.SetParamSimple(map, prefix + "CcProtection", this.CcProtection);
            this.SetParamSimple(map, prefix + "AntiTamper", this.AntiTamper);
            this.SetParamSimple(map, prefix + "AntiLeakage", this.AntiLeakage);
            this.SetParamSimple(map, prefix + "ApiProtection", this.ApiProtection);
            this.SetParamSimple(map, prefix + "RateLimit", this.RateLimit);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

