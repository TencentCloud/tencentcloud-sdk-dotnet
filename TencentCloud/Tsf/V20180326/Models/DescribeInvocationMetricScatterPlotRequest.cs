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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInvocationMetricScatterPlotRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 查询结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 查询时间粒度，单位秒。可选值：60、3600、86400。
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// 查询指标维度
        /// </summary>
        [JsonProperty("MetricDimensions")]
        public MetricDimension[] MetricDimensions{ get; set; }

        /// <summary>
        /// 查询指标名
        /// </summary>
        [JsonProperty("Metrics")]
        public Metric[] Metrics{ get; set; }

        /// <summary>
        /// 视图视角。可选值：SERVER, CLIENT。默认为SERVER
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamArrayObj(map, prefix + "MetricDimensions.", this.MetricDimensions);
            this.SetParamArrayObj(map, prefix + "Metrics.", this.Metrics);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
        }
    }
}

