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

    public class DescribeTDEMSSEPercentileResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>时间桶宽度，单位秒，与趋势查询使用同一套分桶。</p>
        /// </summary>
        [JsonProperty("IntervalSec")]
        public long? IntervalSec{ get; set; }

        /// <summary>
        /// <p>整个时间窗的算术平均。没有有效样本时为 null。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Average")]
        public float? Average{ get; set; }

        /// <summary>
        /// <p>整个时间窗的 50 分位。没有有效样本时为 null。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("P50")]
        public float? P50{ get; set; }

        /// <summary>
        /// <p>整个时间窗的 75 分位。没有有效样本时为 null。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("P75")]
        public float? P75{ get; set; }

        /// <summary>
        /// <p>整个时间窗的 95 分位。没有有效样本时为 null。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("P95")]
        public float? P95{ get; set; }

        /// <summary>
        /// <p>整个时间窗的 99 分位。没有有效样本时为 null。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("P99")]
        public float? P99{ get; set; }

        /// <summary>
        /// <p>各时间桶的平均值和分位。没有样本的桶不返回，全部没有样本时为空数组。</p>
        /// </summary>
        [JsonProperty("Points")]
        public TDEMSSEPercentilePoint[] Points{ get; set; }

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
            this.SetParamSimple(map, prefix + "IntervalSec", this.IntervalSec);
            this.SetParamSimple(map, prefix + "Average", this.Average);
            this.SetParamSimple(map, prefix + "P50", this.P50);
            this.SetParamSimple(map, prefix + "P75", this.P75);
            this.SetParamSimple(map, prefix + "P95", this.P95);
            this.SetParamSimple(map, prefix + "P99", this.P99);
            this.SetParamArrayObj(map, prefix + "Points.", this.Points);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

