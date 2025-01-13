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

    public class MonthRepeatStrategy : AbstractModel
    {
        
        /// <summary>
        /// 重复任务执行的具体时刻，例如"01:02:00"
        /// </summary>
        [JsonProperty("ExecuteAtTimeOfDay")]
        public string ExecuteAtTimeOfDay{ get; set; }

        /// <summary>
        /// 每月中的天数时间段描述，长度只能为2，例如[2,10]表示每月2-10号。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DaysOfMonthRange")]
        public ulong?[] DaysOfMonthRange{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExecuteAtTimeOfDay", this.ExecuteAtTimeOfDay);
            this.SetParamArraySimple(map, prefix + "DaysOfMonthRange.", this.DaysOfMonthRange);
        }
    }
}

