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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageScanScheduleConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>周期类型</p><p>枚举值：</p><ul><li>DAILY： 每天</li><li>WEEKLY： 每周</li><li>MONTHLY： 每月</li></ul>
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

        /// <summary>
        /// <p>具体日期。周类型时: 1-7 (周一到周日); 月类型时: 1-31; 日类型时不生效。</p>
        /// </summary>
        [JsonProperty("CycleDays")]
        public ulong?[] CycleDays{ get; set; }

        /// <summary>
        /// <p>扫描开始时间</p><p>参数格式：hh:mm</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>时区</p>
        /// </summary>
        [JsonProperty("Timezone")]
        public string Timezone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamArraySimple(map, prefix + "CycleDays.", this.CycleDays);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Timezone", this.Timezone);
        }
    }
}

