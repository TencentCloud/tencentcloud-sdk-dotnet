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

    public class RealtimeConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Realtime 模型路由策略。</p><p>入参限制：仅支持 SimpleShuffle（随机）、LeastBusy（最少繁忙）、CostBasedRouting（最低成本）。</p><p>默认值：SimpleShuffle</p><p>修改时未传保留旧策略；切换策略会清理旧策略的 RoutingStrategyArgs。不接受 null。</p>
        /// </summary>
        [JsonProperty("RoutingStrategy")]
        public string RoutingStrategy{ get; set; }

        /// <summary>
        /// <p>Realtime 路由重试次数。</p><p>取值范围：[0, 5]</p><p>默认值：2</p><p>仅接受整数，0 表示不重试。修改时未提供此字段则保留旧值，不接受 null。</p>
        /// </summary>
        [JsonProperty("NumRetries")]
        public ulong? NumRetries{ get; set; }

        /// <summary>
        /// <p>Realtime 路由策略的附加参数。</p><p>入参限制：LeastBusy 仅接受 LeastBusyBuffer；CostBasedRouting 仅接受 LowestCostBuffer；SimpleShuffle 仅接受空对象。</p><p>修改时未提供的参数保留旧值，切换策略时清理旧参数；适用的 Buffer 默认 0。不接受 null。</p>
        /// </summary>
        [JsonProperty("RoutingStrategyArgs")]
        public RealtimeRoutingStrategyArgs RoutingStrategyArgs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoutingStrategy", this.RoutingStrategy);
            this.SetParamSimple(map, prefix + "NumRetries", this.NumRetries);
            this.SetParamObj(map, prefix + "RoutingStrategyArgs.", this.RoutingStrategyArgs);
        }
    }
}

