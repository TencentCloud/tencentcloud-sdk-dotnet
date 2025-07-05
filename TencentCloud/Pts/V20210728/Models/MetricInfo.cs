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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MetricInfo : AbstractModel
    {
        
        /// <summary>
        /// 后台指标
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// 前台展示指标名称
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// 指标描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 指标类型
        /// </summary>
        [JsonProperty("MetricType")]
        public string MetricType{ get; set; }

        /// <summary>
        /// 默认指标单位
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// 指标支持的聚合函数
        /// </summary>
        [JsonProperty("Aggregations")]
        public AggregationLegend[] Aggregations{ get; set; }

        /// <summary>
        /// 是否内部指标，内部指标不可在前台提供用户自由选择
        /// </summary>
        [JsonProperty("InnerMetric")]
        public bool? InnerMetric{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "MetricType", this.MetricType);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamArrayObj(map, prefix + "Aggregations.", this.Aggregations);
            this.SetParamSimple(map, prefix + "InnerMetric", this.InnerMetric);
        }
    }
}

