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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MetricAlarm : AbstractModel
    {
        
        /// <summary>
        /// <p>比较运算符，可选值：<br><li>GREATER_THAN：大于</li><li>GREATER_THAN_OR_EQUAL_TO：大于或等于</li><li>LESS_THAN：小于</li><li> LESS_THAN_OR_EQUAL_TO：小于或等于</li><li> EQUAL_TO：等于</li> <li>NOT_EQUAL_TO：不等于</li></p>
        /// </summary>
        [JsonProperty("ComparisonOperator")]
        public string ComparisonOperator{ get; set; }

        /// <summary>
        /// <p>指标名称，可选字段如下：<li>CPU_UTILIZATION：CPU利用率</li><li>MEM_UTILIZATION：内存利用率</li><li>LAN_TRAFFIC_OUT：内网出带宽</li><li>LAN_TRAFFIC_IN：内网入带宽</li><li>WAN_TRAFFIC_OUT：外网出带宽</li><li>WAN_TRAFFIC_IN：外网入带宽</li><li>TCP_CURR_ESTAB：TCP连接数</li></p><p>当前外网出入带宽属于 CLB 类指标，其他指标属于 CVM 类指标。修改指标名称时不允许跨类别修改。</p>
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// <p>告警阈值：<br><li>CPU_UTILIZATION：[1, 100]，单位：%</li><li>MEM_UTILIZATION：[1, 100]，单位：%</li><li>LAN_TRAFFIC_OUT：&gt;0，单位：Mbps </li><li>LAN_TRAFFIC_IN：&gt;0，单位：Mbps</li><li>WAN_TRAFFIC_OUT：&gt;0，单位：Mbps</li><li>WAN_TRAFFIC_IN：&gt;0，单位：Mbps</li><li>TCP_CURR_ESTAB：&gt;0, 单位：Count</li></p>
        /// </summary>
        [JsonProperty("Threshold")]
        public ulong? Threshold{ get; set; }

        /// <summary>
        /// <p>时间周期，单位：秒，取值枚举值为60、300。</p>
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// <p>重复次数。取值范围 [1, 10]</p>
        /// </summary>
        [JsonProperty("ContinuousTime")]
        public ulong? ContinuousTime{ get; set; }

        /// <summary>
        /// <p>统计类型，可选字段如下：<br><li>AVERAGE：平均值</li><li>MAXIMUM：最大值<li>MINIMUM：最小值</li><br> 默认取值：AVERAGE</p>
        /// </summary>
        [JsonProperty("Statistic")]
        public string Statistic{ get; set; }

        /// <summary>
        /// <p>精确告警阈值，本参数不作为入参输入，仅用作查询接口出参：<br><li>CPU_UTILIZATION：(0, 100]，单位：%</li><li>MEM_UTILIZATION：(0, 100]，单位：%</li><li>LAN_TRAFFIC_OUT：&gt;0，单位：Mbps </li><li>LAN_TRAFFIC_IN：&gt;0，单位：Mbps</li><li>WAN_TRAFFIC_OUT：&gt;0，单位：Mbps</li><li>WAN_TRAFFIC_IN：&gt;0，单位：Mbps</li><li>TCP_CURR_ESTAB：&gt;0, 单位：Count</li></p>
        /// </summary>
        [JsonProperty("PreciseThreshold")]
        public float? PreciseThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComparisonOperator", this.ComparisonOperator);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "ContinuousTime", this.ContinuousTime);
            this.SetParamSimple(map, prefix + "Statistic", this.Statistic);
            this.SetParamSimple(map, prefix + "PreciseThreshold", this.PreciseThreshold);
        }
    }
}

