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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RealtimeRoutingStrategyArgs : AbstractModel
    {
        
        /// <summary>
        /// <p>LeastBusy 路由策略的缓冲参数，仅 RoutingStrategy=LeastBusy 时允许设置。</p><p>取值范围：[0, 1000]</p><p>默认值：0</p><p>最多支持两位小数；不接受字符串、布尔值或 null。修改时未传保留旧值，显式 0 生效。</p>
        /// </summary>
        [JsonProperty("LeastBusyBuffer")]
        public float? LeastBusyBuffer{ get; set; }

        /// <summary>
        /// <p>CostBasedRouting 路由策略的缓冲参数，仅 RoutingStrategy=CostBasedRouting 时允许设置。</p><p>取值范围：[0, 1000]</p><p>默认值：0</p><p>最多支持两位小数；不接受字符串、布尔值或 null。修改时未传保留旧值，显式 0 生效。</p>
        /// </summary>
        [JsonProperty("LowestCostBuffer")]
        public float? LowestCostBuffer{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LeastBusyBuffer", this.LeastBusyBuffer);
            this.SetParamSimple(map, prefix + "LowestCostBuffer", this.LowestCostBuffer);
        }
    }
}

