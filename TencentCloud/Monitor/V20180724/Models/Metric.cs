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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Metric : AbstractModel
    {
        
        /// <summary>
        /// <p>告警策略类型</p>
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// <p>指标名</p>
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// <p>指标展示名</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>最小值</p>
        /// </summary>
        [JsonProperty("Min")]
        public float? Min{ get; set; }

        /// <summary>
        /// <p>最大值</p>
        /// </summary>
        [JsonProperty("Max")]
        public float? Max{ get; set; }

        /// <summary>
        /// <p>维度列表</p>
        /// </summary>
        [JsonProperty("Dimensions")]
        public string[] Dimensions{ get; set; }

        /// <summary>
        /// <p>单位</p>
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// <p>指标配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetricConfig")]
        public MetricConfig MetricConfig{ get; set; }

        /// <summary>
        /// <p>是否为高级指标。1是 0否</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsAdvanced")]
        public long? IsAdvanced{ get; set; }

        /// <summary>
        /// <p>高级指标是否开通。1是 0否</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsOpen")]
        public long? IsOpen{ get; set; }

        /// <summary>
        /// <p>集成中心产品ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductId")]
        public long? ProductId{ get; set; }

        /// <summary>
        /// <p>匹配运算符</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Operators")]
        public Operator[] Operators{ get; set; }

        /// <summary>
        /// <p>指标触发</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Periods")]
        public long?[] Periods{ get; set; }

        /// <summary>
        /// <p>是否延迟指标</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsLatenessMetric")]
        public long? IsLatenessMetric{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Min", this.Min);
            this.SetParamSimple(map, prefix + "Max", this.Max);
            this.SetParamArraySimple(map, prefix + "Dimensions.", this.Dimensions);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamObj(map, prefix + "MetricConfig.", this.MetricConfig);
            this.SetParamSimple(map, prefix + "IsAdvanced", this.IsAdvanced);
            this.SetParamSimple(map, prefix + "IsOpen", this.IsOpen);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamArrayObj(map, prefix + "Operators.", this.Operators);
            this.SetParamArraySimple(map, prefix + "Periods.", this.Periods);
            this.SetParamSimple(map, prefix + "IsLatenessMetric", this.IsLatenessMetric);
        }
    }
}

