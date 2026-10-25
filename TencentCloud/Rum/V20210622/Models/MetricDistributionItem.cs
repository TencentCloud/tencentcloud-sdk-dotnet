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

    public class MetricDistributionItem : AbstractModel
    {
        
        /// <summary>
        /// <p>维度值</p>
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// <p>次数</p>
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// <p>影响用户数</p>
        /// </summary>
        [JsonProperty("AffectedUser")]
        public long? AffectedUser{ get; set; }

        /// <summary>
        /// <p>率，分母为 0 时省略</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Rate")]
        public float? Rate{ get; set; }

        /// <summary>
        /// <p>影响用户率，缺省省略</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AffectedUserRate")]
        public float? AffectedUserRate{ get; set; }

        /// <summary>
        /// <p>均值，缺省省略</p>
        /// </summary>
        [JsonProperty("Avg")]
        public float? Avg{ get; set; }

        /// <summary>
        /// <p>P50，缺省省略</p>
        /// </summary>
        [JsonProperty("P50")]
        public float? P50{ get; set; }

        /// <summary>
        /// <p>P75，缺省省略</p>
        /// </summary>
        [JsonProperty("P75")]
        public float? P75{ get; set; }

        /// <summary>
        /// <p>P95，缺省省略</p>
        /// </summary>
        [JsonProperty("P95")]
        public float? P95{ get; set; }

        /// <summary>
        /// <p>P99，缺省省略</p>
        /// </summary>
        [JsonProperty("P99")]
        public float? P99{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "AffectedUser", this.AffectedUser);
            this.SetParamSimple(map, prefix + "Rate", this.Rate);
            this.SetParamSimple(map, prefix + "AffectedUserRate", this.AffectedUserRate);
            this.SetParamSimple(map, prefix + "Avg", this.Avg);
            this.SetParamSimple(map, prefix + "P50", this.P50);
            this.SetParamSimple(map, prefix + "P75", this.P75);
            this.SetParamSimple(map, prefix + "P95", this.P95);
            this.SetParamSimple(map, prefix + "P99", this.P99);
        }
    }
}

