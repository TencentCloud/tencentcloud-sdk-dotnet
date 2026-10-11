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

namespace TencentCloud.Goosefs.V20220519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExecutePeriodAttribute : AbstractModel
    {
        
        /// <summary>
        /// <p>选择的周期类型</p><p>枚举值：</p><ul><li>DAY： 每天执行 </li><li>WEEK： 每周执行</li><li>MONTH： 每月执行</li></ul>
        /// </summary>
        [JsonProperty("PeriodType")]
        public string PeriodType{ get; set; }

        /// <summary>
        /// <p>选择每周执行时必填，需要选择周几,0-6 分别是周日到周六</p><p>取值范围：[0, 6]</p><p>默认值：0</p>
        /// </summary>
        [JsonProperty("StartWeekday")]
        public ulong? StartWeekday{ get; set; }

        /// <summary>
        /// <p>选择每月执行时必填，1-28日选择一天</p><p>取值范围：[1, 28]</p><p>默认值：1</p>
        /// </summary>
        [JsonProperty("StartDate")]
        public ulong? StartDate{ get; set; }

        /// <summary>
        /// <p>周期中的时间点，取值0~59</p><p>取值范围：[0, 59]</p>
        /// </summary>
        [JsonProperty("StartMinute")]
        public ulong? StartMinute{ get; set; }

        /// <summary>
        /// <p>24小时周期开始的小时数，取值0~23</p><p>取值范围：[0, 23]</p><p>默认值：1</p>
        /// </summary>
        [JsonProperty("StartHour")]
        public ulong? StartHour{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PeriodType", this.PeriodType);
            this.SetParamSimple(map, prefix + "StartWeekday", this.StartWeekday);
            this.SetParamSimple(map, prefix + "StartDate", this.StartDate);
            this.SetParamSimple(map, prefix + "StartMinute", this.StartMinute);
            this.SetParamSimple(map, prefix + "StartHour", this.StartHour);
        }
    }
}

