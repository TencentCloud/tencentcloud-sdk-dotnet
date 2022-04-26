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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StatisticItem : AbstractModel
    {
        
        /// <summary>
        /// 封顶类型，累计用量total，瞬时用量moment
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 自动解封时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnBlockTime")]
        public ulong? UnBlockTime{ get; set; }

        /// <summary>
        /// 带宽、流量阈值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BpsThreshold")]
        public ulong? BpsThreshold{ get; set; }

        /// <summary>
        /// 关闭方式 返回404:RETURN_404, dns回源：RESOLVE_DNS_TO_ORIGIN
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CounterMeasure")]
        public string CounterMeasure{ get; set; }

        /// <summary>
        /// 触发提醒阈值百分比
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlertPercentage")]
        public ulong? AlertPercentage{ get; set; }

        /// <summary>
        /// 提醒开关 on/off
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlertSwitch")]
        public string AlertSwitch{ get; set; }

        /// <summary>
        /// 指标类型，流量flux或带宽bandwidth
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// 检测周期，单位分钟，60或1440
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cycle")]
        public ulong? Cycle{ get; set; }

        /// <summary>
        /// 是否开启该选项，on/off
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "UnBlockTime", this.UnBlockTime);
            this.SetParamSimple(map, prefix + "BpsThreshold", this.BpsThreshold);
            this.SetParamSimple(map, prefix + "CounterMeasure", this.CounterMeasure);
            this.SetParamSimple(map, prefix + "AlertPercentage", this.AlertPercentage);
            this.SetParamSimple(map, prefix + "AlertSwitch", this.AlertSwitch);
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamSimple(map, prefix + "Cycle", this.Cycle);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
        }
    }
}

