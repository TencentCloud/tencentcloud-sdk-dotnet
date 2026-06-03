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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FrequencyConfig : AbstractModel
    {
        
        /// <summary>
        /// 周期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Frequency")]
        public string Frequency{ get; set; }

        /// <summary>
        /// 日期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Dates")]
        public long?[] Dates{ get; set; }

        /// <summary>
        /// 时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 间隔时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntervalTime")]
        public ulong? IntervalTime{ get; set; }

        /// <summary>
        /// 1:SECOND,2:MINUTE,3:HOUR,4:DAY
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntervalTimeUnit")]
        public ulong? IntervalTimeUnit{ get; set; }

        /// <summary>
        /// 小时列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Hours")]
        public long?[] Hours{ get; set; }

        /// <summary>
        /// 分钟列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Minute")]
        public long?[] Minute{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Frequency", this.Frequency);
            this.SetParamArraySimple(map, prefix + "Dates.", this.Dates);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "IntervalTime", this.IntervalTime);
            this.SetParamSimple(map, prefix + "IntervalTimeUnit", this.IntervalTimeUnit);
            this.SetParamArraySimple(map, prefix + "Hours.", this.Hours);
            this.SetParamArraySimple(map, prefix + "Minute.", this.Minute);
        }
    }
}

