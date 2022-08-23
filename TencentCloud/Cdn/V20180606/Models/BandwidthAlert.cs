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

    public class BandwidthAlert : AbstractModel
    {
        
        /// <summary>
        /// 用量封顶配置开关
        /// on：开启
        /// off：关闭
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 用量封顶阈值，带宽单位为bps，流量单位byte
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BpsThreshold")]
        public long? BpsThreshold{ get; set; }

        /// <summary>
        /// 达到阈值后的操作
        /// RETURN_404：全部请求返回 404
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CounterMeasure")]
        public string CounterMeasure{ get; set; }

        /// <summary>
        /// 境内区域上次触发用量封顶阈值的时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastTriggerTime")]
        public string LastTriggerTime{ get; set; }

        /// <summary>
        /// 用量封顶提醒开关
        /// on：开启
        /// off：关闭
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlertSwitch")]
        public string AlertSwitch{ get; set; }

        /// <summary>
        /// 用量封顶阈值提醒百分比
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlertPercentage")]
        public long? AlertPercentage{ get; set; }

        /// <summary>
        /// 海外区域上次触发用量封顶阈值的时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastTriggerTimeOverseas")]
        public string LastTriggerTimeOverseas{ get; set; }

        /// <summary>
        /// 用量阈值触发的维度
        /// 带宽：bandwidth
        /// 流量：flux
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// 累计用量配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatisticItems")]
        public StatisticItem[] StatisticItems{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "BpsThreshold", this.BpsThreshold);
            this.SetParamSimple(map, prefix + "CounterMeasure", this.CounterMeasure);
            this.SetParamSimple(map, prefix + "LastTriggerTime", this.LastTriggerTime);
            this.SetParamSimple(map, prefix + "AlertSwitch", this.AlertSwitch);
            this.SetParamSimple(map, prefix + "AlertPercentage", this.AlertPercentage);
            this.SetParamSimple(map, prefix + "LastTriggerTimeOverseas", this.LastTriggerTimeOverseas);
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamArrayObj(map, prefix + "StatisticItems.", this.StatisticItems);
        }
    }
}

