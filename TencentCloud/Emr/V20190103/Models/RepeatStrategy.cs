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

    public class RepeatStrategy : AbstractModel
    {
        
        /// <summary>
        /// 取值范围"DAY","DOW","DOM","NONE"，分别表示按天重复、按周重复、按月重复和一次执行。必须填写
        /// </summary>
        [JsonProperty("RepeatType")]
        public string RepeatType{ get; set; }

        /// <summary>
        /// 按天重复规则，当RepeatType为"DAY"时有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DayRepeat")]
        public DayRepeatStrategy DayRepeat{ get; set; }

        /// <summary>
        /// 按周重复规则，当RepeatType为"DOW"时有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WeekRepeat")]
        public WeekRepeatStrategy WeekRepeat{ get; set; }

        /// <summary>
        /// 按月重复规则，当RepeatType为"DOM"时有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MonthRepeat")]
        public MonthRepeatStrategy MonthRepeat{ get; set; }

        /// <summary>
        /// 一次执行规则，当RepeatType为"NONE"时有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NotRepeat")]
        public NotRepeatStrategy NotRepeat{ get; set; }

        /// <summary>
        /// 规则过期时间，超过该时间后，规则将自动置为暂停状态，形式为"2020-07-23 00:00:00"。必须填写
        /// </summary>
        [JsonProperty("Expire")]
        public string Expire{ get; set; }

        /// <summary>
        /// 周期性规则开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RepeatType", this.RepeatType);
            this.SetParamObj(map, prefix + "DayRepeat.", this.DayRepeat);
            this.SetParamObj(map, prefix + "WeekRepeat.", this.WeekRepeat);
            this.SetParamObj(map, prefix + "MonthRepeat.", this.MonthRepeat);
            this.SetParamObj(map, prefix + "NotRepeat.", this.NotRepeat);
            this.SetParamSimple(map, prefix + "Expire", this.Expire);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
        }
    }
}

