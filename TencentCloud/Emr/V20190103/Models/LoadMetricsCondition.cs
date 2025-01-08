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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LoadMetricsCondition : AbstractModel
    {
        
        /// <summary>
        /// 规则统计周期，提供1min,3min,5min。
        /// </summary>
        [JsonProperty("StatisticPeriod")]
        public long? StatisticPeriod{ get; set; }

        /// <summary>
        /// 触发次数，当连续触发超过TriggerThreshold次后才开始扩缩容。
        /// </summary>
        [JsonProperty("TriggerThreshold")]
        public long? TriggerThreshold{ get; set; }

        /// <summary>
        /// 扩缩容负载指标。
        /// </summary>
        [JsonProperty("LoadMetrics")]
        public string LoadMetrics{ get; set; }

        /// <summary>
        /// 规则元数据记录ID。
        /// </summary>
        [JsonProperty("MetricId")]
        public long? MetricId{ get; set; }

        /// <summary>
        /// 触发条件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Conditions")]
        public TriggerCondition[] Conditions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StatisticPeriod", this.StatisticPeriod);
            this.SetParamSimple(map, prefix + "TriggerThreshold", this.TriggerThreshold);
            this.SetParamSimple(map, prefix + "LoadMetrics", this.LoadMetrics);
            this.SetParamSimple(map, prefix + "MetricId", this.MetricId);
            this.SetParamArrayObj(map, prefix + "Conditions.", this.Conditions);
        }
    }
}

