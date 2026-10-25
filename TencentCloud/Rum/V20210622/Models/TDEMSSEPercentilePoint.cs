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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TDEMSSEPercentilePoint : AbstractModel
    {
        
        /// <summary>
        /// <p>时间桶起点，Unix 毫秒。</p>
        /// </summary>
        [JsonProperty("Time")]
        public long? Time{ get; set; }

        /// <summary>
        /// <p>该桶算术平均值。没有样本的桶不返回。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Average")]
        public float? Average{ get; set; }

        /// <summary>
        /// <p>50 分位。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("P50")]
        public float? P50{ get; set; }

        /// <summary>
        /// <p>75 分位。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("P75")]
        public float? P75{ get; set; }

        /// <summary>
        /// <p>95 分位。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("P95")]
        public float? P95{ get; set; }

        /// <summary>
        /// <p>99 分位。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("P99")]
        public float? P99{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "Average", this.Average);
            this.SetParamSimple(map, prefix + "P50", this.P50);
            this.SetParamSimple(map, prefix + "P75", this.P75);
            this.SetParamSimple(map, prefix + "P95", this.P95);
            this.SetParamSimple(map, prefix + "P99", this.P99);
        }
    }
}

