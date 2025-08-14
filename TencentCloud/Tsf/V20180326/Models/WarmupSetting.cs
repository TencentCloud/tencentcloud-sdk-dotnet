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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WarmupSetting : AbstractModel
    {
        
        /// <summary>
        /// 是否开启预热
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// 预热时间，单位秒
        /// </summary>
        [JsonProperty("WarmupTime")]
        public ulong? WarmupTime{ get; set; }

        /// <summary>
        /// 预热曲率，取值 1~5
        /// </summary>
        [JsonProperty("Curvature")]
        public ulong? Curvature{ get; set; }

        /// <summary>
        /// 是否开启预热保护，在开启保护的情况下，超过 50% 的节点处于预热中，则会中止预热
        /// </summary>
        [JsonProperty("EnabledProtection")]
        public bool? EnabledProtection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "WarmupTime", this.WarmupTime);
            this.SetParamSimple(map, prefix + "Curvature", this.Curvature);
            this.SetParamSimple(map, prefix + "EnabledProtection", this.EnabledProtection);
        }
    }
}

