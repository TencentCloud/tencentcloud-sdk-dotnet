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

    public class VideoConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>模型内路由策略</p>
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
        /// <p>同一模型请求重试次数</p>
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

