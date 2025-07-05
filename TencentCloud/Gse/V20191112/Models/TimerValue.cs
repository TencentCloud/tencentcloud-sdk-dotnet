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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TimerValue : AbstractModel
    {
        
        /// <summary>
        /// 每X天，执行一次(重复周期-按天/单次)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Day")]
        public long? Day{ get; set; }

        /// <summary>
        /// 每月从第x天，执行一次(重复周期-按月)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FromDay")]
        public long? FromDay{ get; set; }

        /// <summary>
        /// 每月到第x天，执行一次(重复周期-按月)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ToDay")]
        public long? ToDay{ get; set; }

        /// <summary>
        /// 重复周期-按周，周几（多个值,取值周一(1,2,3,4,5,6,7)周日）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WeekDays")]
        public long?[] WeekDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Day", this.Day);
            this.SetParamSimple(map, prefix + "FromDay", this.FromDay);
            this.SetParamSimple(map, prefix + "ToDay", this.ToDay);
            this.SetParamArraySimple(map, prefix + "WeekDays.", this.WeekDays);
        }
    }
}

