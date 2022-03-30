/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Cat.V20180409.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeProbeMetricDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 分析任务类型
        /// </summary>
        [JsonProperty("AnalyzeTaskType")]
        public string AnalyzeTaskType{ get; set; }

        /// <summary>
        /// 指标类型，counter 或者 gauge
        /// </summary>
        [JsonProperty("MetricType")]
        public string MetricType{ get; set; }

        /// <summary>
        /// 指标详细字段
        /// </summary>
        [JsonProperty("Field")]
        public string Field{ get; set; }

        /// <summary>
        /// 过滤条件
        /// </summary>
        [JsonProperty("Filter")]
        public string Filter{ get; set; }

        /// <summary>
        /// 聚合时间, 1m、1d、100d 等等
        /// </summary>
        [JsonProperty("GroupBy")]
        public string GroupBy{ get; set; }

        /// <summary>
        /// 过滤条件数组
        /// </summary>
        [JsonProperty("Filters")]
        public string[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AnalyzeTaskType", this.AnalyzeTaskType);
            this.SetParamSimple(map, prefix + "MetricType", this.MetricType);
            this.SetParamSimple(map, prefix + "Field", this.Field);
            this.SetParamSimple(map, prefix + "Filter", this.Filter);
            this.SetParamSimple(map, prefix + "GroupBy", this.GroupBy);
            this.SetParamArraySimple(map, prefix + "Filters.", this.Filters);
        }
    }
}

