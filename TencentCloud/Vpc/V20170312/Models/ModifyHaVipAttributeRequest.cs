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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyHaVipAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><code>HAVIP</code>唯一<code>ID</code>，形如：<code>havip-9o233uri</code>。</p>
        /// </summary>
        [JsonProperty("HaVipId")]
        public string HaVipId{ get; set; }

        /// <summary>
        /// <p><code>HAVIP</code>名称，可任意命名，但不得超过60个字符。</p>
        /// </summary>
        [JsonProperty("HaVipName")]
        public string HaVipName{ get; set; }

        /// <summary>
        /// <p>删除保护。</p>
        /// </summary>
        [JsonProperty("TerminationProtection")]
        public bool? TerminationProtection{ get; set; }

        /// <summary>
        /// <p>流量保护。</p>
        /// </summary>
        [JsonProperty("TrafficProtection")]
        public bool? TrafficProtection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HaVipId", this.HaVipId);
            this.SetParamSimple(map, prefix + "HaVipName", this.HaVipName);
            this.SetParamSimple(map, prefix + "TerminationProtection", this.TerminationProtection);
            this.SetParamSimple(map, prefix + "TrafficProtection", this.TrafficProtection);
        }
    }
}

