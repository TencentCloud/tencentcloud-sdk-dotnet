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

namespace TencentCloud.Cvd.V20201104.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceMonitorDataRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例维度组合数组</p>
        /// </summary>
        [JsonProperty("Instances")]
        public Instance[] Instances{ get; set; }

        /// <summary>
        /// <p>命名空间。如QCE/CVM、QCE/BLOCK_STORAGE等</p>
        /// </summary>
        [JsonProperty("NameSpace")]
        public string NameSpace{ get; set; }

        /// <summary>
        /// <p>指标名</p>
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// <p>统计周期(时间粒度), 单位s。</p>
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// <p>开始时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>结束时间</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>多种统计方式数据。avg, max, min (1,2,4)可以自由组合</p>
        /// </summary>
        [JsonProperty("SpecifyStatistics")]
        public long? SpecifyStatistics{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Instances.", this.Instances);
            this.SetParamSimple(map, prefix + "NameSpace", this.NameSpace);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SpecifyStatistics", this.SpecifyStatistics);
        }
    }
}

