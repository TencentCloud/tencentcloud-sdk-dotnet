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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HealthScoreTimeSeriesData : AbstractModel
    {
        
        /// <summary>
        /// 平均得分
        /// </summary>
        [JsonProperty("Avg")]
        public float? Avg{ get; set; }

        /// <summary>
        /// 健康状态
        /// 1-health
        /// 2-warning
        /// 3-critical
        /// </summary>
        [JsonProperty("HealthStatus")]
        public ulong? HealthStatus{ get; set; }

        /// <summary>
        /// 指标名称
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// 得分序列
        /// </summary>
        [JsonProperty("Series")]
        public ulong?[] Series{ get; set; }

        /// <summary>
        /// 时间序列，单位：毫秒数
        /// </summary>
        [JsonProperty("Timestamp")]
        public ulong?[] Timestamp{ get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Avg", this.Avg);
            this.SetParamSimple(map, prefix + "HealthStatus", this.HealthStatus);
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamArraySimple(map, prefix + "Series.", this.Series);
            this.SetParamArraySimple(map, prefix + "Timestamp.", this.Timestamp);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
        }
    }
}

