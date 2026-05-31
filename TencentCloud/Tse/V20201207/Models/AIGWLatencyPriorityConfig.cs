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

    public class AIGWLatencyPriorityConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>路由规则列表</p>
        /// </summary>
        [JsonProperty("Rules")]
        public AIGWLatencyPriorityRouteRule[] Rules{ get; set; }

        /// <summary>
        /// <p>延迟指标</p><p>枚举值：</p><ul><li>LLMLatency： LLM 延迟</li><li>NetworkLatency： 网络延迟</li></ul>
        /// </summary>
        [JsonProperty("LatencyMetric")]
        public string LatencyMetric{ get; set; }

        /// <summary>
        /// <p>路由策略</p><p>枚举值：</p><ul><li>FastMode： 快速模式</li><li>BalanceMode： 均衡模式</li></ul>
        /// </summary>
        [JsonProperty("RouteMode")]
        public string RouteMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
            this.SetParamSimple(map, prefix + "LatencyMetric", this.LatencyMetric);
            this.SetParamSimple(map, prefix + "RouteMode", this.RouteMode);
        }
    }
}

