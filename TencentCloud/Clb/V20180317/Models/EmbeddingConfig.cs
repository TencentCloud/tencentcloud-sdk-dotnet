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

    public class EmbeddingConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>模型内路由策略</p><p>枚举值：</p><ul><li>SimpleShuffle： 简单随机路由</li><li>LeastBusy： 最低繁忙路由</li><li>LatencyBasedRouting： 最低延迟路由</li><li>UsageBasedRouting： 用量均衡路由</li><li>CostBasedRouting： 最低积分路由</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RoutingStrategy")]
        public string RoutingStrategy{ get; set; }

        /// <summary>
        /// <p>路由参数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RoutingStrategyArgs")]
        public RoutingStrategyArgs RoutingStrategyArgs{ get; set; }

        /// <summary>
        /// <p>CMR实例级别模型组内请求重试次数</p><p>取值范围：[0, 5]</p><p>默认值：2</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NumRetries")]
        public ulong? NumRetries{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoutingStrategy", this.RoutingStrategy);
            this.SetParamObj(map, prefix + "RoutingStrategyArgs.", this.RoutingStrategyArgs);
            this.SetParamSimple(map, prefix + "NumRetries", this.NumRetries);
        }
    }
}

