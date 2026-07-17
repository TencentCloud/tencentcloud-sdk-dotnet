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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInferenceServiceMonitorDataRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>站点 ID。</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>推理服务 ID。最多传入10个推理服务 ID。</p>
        /// </summary>
        [JsonProperty("ServiceIds")]
        public string[] ServiceIds{ get; set; }

        /// <summary>
        /// <p>指标列表，最多支持 10 个指标。取值有：<li>cpu_usage_average: CPU 平均使用率，单位：%，指标类型：Float；</li><li>cpu_usage_max: CPU 最大使用率，单位：%，指标类型：Float；</li><li>gpu_usage_average: GPU 平均使用率，单位：%，指标类型：Float；</li><li>gpu_usage_max: GPU 最大使用率，单位：%，指标类型：Float；</li><li>instance_num_average: 实例平均数量，单位：个，指标类型：Float；</li><li>instance_num_max: 实例最大数量，单位：个，指标类型：Float；</li><li>gpu_memory_usage_max: 显存最大使用率，单位：%，指标类型：Float；</li><li>memory_usage_average: 内存平均使用率，单位：%，指标类型：Float；</li><li>memory_usage_max: 内存最大使用率，单位：%，指标类型：Float；</li></p>
        /// </summary>
        [JsonProperty("MetricNames")]
        public string[] MetricNames{ get; set; }

        /// <summary>
        /// <p>开始时间。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>结束时间。查询时间范围（<code>EndTime - StartTime</code>）需小于等于 30 天。</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>查询时间粒度，取值有：</p><li>min: 1分钟，支持1天范围内的查询；</li><li>5min: 5分钟，支持7天范围内的查询；</li><li>hour: 1小时，支持30天范围内的查询；</li><li>day: 1天，支持30天范围内的查询；</li>不填将根据开始时间跟结束时间的间距自动推算粒度，具体为：2小时范围内以 min 粒度查询，2天范围内以 5min 粒度查询，7天范围内以 hour 粒度查询，超过7天以 day 粒度查询。
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArraySimple(map, prefix + "ServiceIds.", this.ServiceIds);
            this.SetParamArraySimple(map, prefix + "MetricNames.", this.MetricNames);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
        }
    }
}

