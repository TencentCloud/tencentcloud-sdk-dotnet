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

namespace TencentCloud.Apis.V20240801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InvokeLimitConfigDTO : AbstractModel
    {
        
        /// <summary>
        /// Type类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 令牌桶最大容量
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TokenBucketMaxNum")]
        public long? TokenBucketMaxNum{ get; set; }

        /// <summary>
        /// 令牌生成速率
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TokenBucketRate")]
        public long? TokenBucketRate{ get; set; }

        /// <summary>
        /// 漏斗容量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FunnelMaxNum")]
        public long? FunnelMaxNum{ get; set; }

        /// <summary>
        /// 漏嘴流速
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FunnelRate")]
        public long? FunnelRate{ get; set; }

        /// <summary>
        /// 滑动窗口最大请求数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SlidingWindowMaxNum")]
        public long? SlidingWindowMaxNum{ get; set; }

        /// <summary>
        /// 滑动窗口长度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SlidingWindowSize")]
        public long? SlidingWindowSize{ get; set; }

        /// <summary>
        /// 时间窗口最大请求数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeWindow")]
        public long? TimeWindow{ get; set; }

        /// <summary>
        /// 时间窗口长度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeWindowInterval")]
        public long? TimeWindowInterval{ get; set; }

        /// <summary>
        /// 请求的超时时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "TokenBucketMaxNum", this.TokenBucketMaxNum);
            this.SetParamSimple(map, prefix + "TokenBucketRate", this.TokenBucketRate);
            this.SetParamSimple(map, prefix + "FunnelMaxNum", this.FunnelMaxNum);
            this.SetParamSimple(map, prefix + "FunnelRate", this.FunnelRate);
            this.SetParamSimple(map, prefix + "SlidingWindowMaxNum", this.SlidingWindowMaxNum);
            this.SetParamSimple(map, prefix + "SlidingWindowSize", this.SlidingWindowSize);
            this.SetParamSimple(map, prefix + "TimeWindow", this.TimeWindow);
            this.SetParamSimple(map, prefix + "TimeWindowInterval", this.TimeWindowInterval);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
        }
    }
}

