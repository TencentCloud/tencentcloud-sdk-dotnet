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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AvailableTimeConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>日期类型，默认为每天</p><p>枚举值：</p><ul><li>EveryDay： 每天</li><li>BusinessDay： 法定工作日</li><li>Holiday： 法定休息日</li><li>Custom： 自定义</li></ul>
        /// </summary>
        [JsonProperty("DayType")]
        public string DayType{ get; set; }

        /// <summary>
        /// <p>仅在 DayType 为 Custom 时生效，指定适用的星期几</p><p>枚举值：</p><ul><li>Monday： 星期一</li><li>Tuesday： 星期二</li><li>Wednesday： 星期三</li><li>Thursday： 星期四</li><li>Friday： 星期五</li><li>Saturday： 星期六</li><li>Sunday： 星期日</li></ul>
        /// </summary>
        [JsonProperty("DaysOfWeek")]
        public string[] DaysOfWeek{ get; set; }

        /// <summary>
        /// <p>该日期类型下的时间段列表</p>
        /// </summary>
        [JsonProperty("TimeRanges")]
        public TimeRange[] TimeRanges{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DayType", this.DayType);
            this.SetParamArraySimple(map, prefix + "DaysOfWeek.", this.DaysOfWeek);
            this.SetParamArrayObj(map, prefix + "TimeRanges.", this.TimeRanges);
        }
    }
}

