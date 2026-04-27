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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SparsePeriodTime : AbstractModel
    {
        
        /// <summary>
        /// 按周：星期几列表，1-7，1=周一，7=周日（仅 weekly 周期使用，最多7个）
        /// </summary>
        [JsonProperty("WeekDays")]
        public long?[] WeekDays{ get; set; }

        /// <summary>
        /// 按月：日期列表，1-31（仅 monthly 周期使用，最多7个）
        /// </summary>
        [JsonProperty("Days")]
        public long?[] Days{ get; set; }

        /// <summary>
        /// 按年：月日组合列表（仅 yearly 周期使用，最多7个）
        /// </summary>
        [JsonProperty("MonthDays")]
        public MonthDay[] MonthDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "WeekDays.", this.WeekDays);
            this.SetParamArraySimple(map, prefix + "Days.", this.Days);
            this.SetParamArrayObj(map, prefix + "MonthDays.", this.MonthDays);
        }
    }
}

