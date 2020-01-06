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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MetricAlarm : AbstractModel
    {
        
        /// <summary>
        /// 比较运算符，可选值：<br><li>GREATER_THAN：大于</li><li>GREATER_THAN_OR_EQUAL_TO：大于或等于</li><li>LESS_THAN：小于</li><li> LESS_THAN_OR_EQUAL_TO：小于或等于</li><li> EQUAL_TO：等于</li> <li>NOT_EQUAL_TO：不等于</li>
        /// </summary>
        [JsonProperty("ComparisonOperator")]
        public string ComparisonOperator{ get; set; }

        /// <summary>
        /// 指标名称，可选字段如下：<br><li>CPU_UTILIZATION：CPU利用率</li><li>MEM_UTILIZATION：内存利用率</li><li>LAN_TRAFFIC_OUT：内网出带宽</li><li>LAN_TRAFFIC_IN：内网入带宽</li><li>WAN_TRAFFIC_OUT：外网出带宽</li><li>WAN_TRAFFIC_IN：外网入带宽</li>
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 告警阈值：<br><li>CPU_UTILIZATION：[1, 100]，单位：%</li><li>MEM_UTILIZATION：[1, 100]，单位：%</li><li>LAN_TRAFFIC_OUT：>0，单位：Mbps </li><li>LAN_TRAFFIC_IN：>0，单位：Mbps</li><li>WAN_TRAFFIC_OUT：>0，单位：Mbps</li><li>WAN_TRAFFIC_IN：>0，单位：Mbps</li>
        /// </summary>
        [JsonProperty("Threshold")]
        public ulong? Threshold{ get; set; }

        /// <summary>
        /// 时间周期，单位：秒，取值枚举值为60、300。
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// 重复次数。取值范围 [1, 10]
        /// </summary>
        [JsonProperty("ContinuousTime")]
        public ulong? ContinuousTime{ get; set; }

        /// <summary>
        /// 统计类型，可选字段如下：<br><li>AVERAGE：平均值</li><li>MAXIMUM：最大值<li>MINIMUM：最小值</li><br> 默认取值：AVERAGE
        /// </summary>
        [JsonProperty("Statistic")]
        public string Statistic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComparisonOperator", this.ComparisonOperator);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "ContinuousTime", this.ContinuousTime);
            this.SetParamSimple(map, prefix + "Statistic", this.Statistic);
        }
    }
}

