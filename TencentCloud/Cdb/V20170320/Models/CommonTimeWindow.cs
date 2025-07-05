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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CommonTimeWindow : AbstractModel
    {
        
        /// <summary>
        /// 周一的时间窗，格式如： 02:00-06:00
        /// </summary>
        [JsonProperty("Monday")]
        public string Monday{ get; set; }

        /// <summary>
        /// 周二的时间窗，格式如： 02:00-06:00
        /// </summary>
        [JsonProperty("Tuesday")]
        public string Tuesday{ get; set; }

        /// <summary>
        /// 周三的时间窗，格式如： 02:00-06:00
        /// </summary>
        [JsonProperty("Wednesday")]
        public string Wednesday{ get; set; }

        /// <summary>
        /// 周四的时间窗，格式如： 02:00-06:00
        /// </summary>
        [JsonProperty("Thursday")]
        public string Thursday{ get; set; }

        /// <summary>
        /// 周五的时间窗，格式如： 02:00-06:00
        /// </summary>
        [JsonProperty("Friday")]
        public string Friday{ get; set; }

        /// <summary>
        /// 周六的时间窗，格式如： 02:00-06:00
        /// </summary>
        [JsonProperty("Saturday")]
        public string Saturday{ get; set; }

        /// <summary>
        /// 周日的时间窗，格式如： 02:00-06:00
        /// </summary>
        [JsonProperty("Sunday")]
        public string Sunday{ get; set; }

        /// <summary>
        /// 常规备份保留策略，weekly-按周备份，monthly-按月备份，默认为weekly
        /// </summary>
        [JsonProperty("BackupPeriodStrategy")]
        public string BackupPeriodStrategy{ get; set; }

        /// <summary>
        /// 如果设置为按月备份，需填入每月具体备份日期，相邻备份天数不得超过两天。例[1,4,7,9,11,14,17,19,22,25,28,30,31]
        /// </summary>
        [JsonProperty("Days")]
        public long?[] Days{ get; set; }

        /// <summary>
        /// 月度备份时间窗，BackupPeriodStrategy为monthly时必填。格式如： 02:00-06:00
        /// </summary>
        [JsonProperty("BackupPeriodTime")]
        public string BackupPeriodTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Monday", this.Monday);
            this.SetParamSimple(map, prefix + "Tuesday", this.Tuesday);
            this.SetParamSimple(map, prefix + "Wednesday", this.Wednesday);
            this.SetParamSimple(map, prefix + "Thursday", this.Thursday);
            this.SetParamSimple(map, prefix + "Friday", this.Friday);
            this.SetParamSimple(map, prefix + "Saturday", this.Saturday);
            this.SetParamSimple(map, prefix + "Sunday", this.Sunday);
            this.SetParamSimple(map, prefix + "BackupPeriodStrategy", this.BackupPeriodStrategy);
            this.SetParamArraySimple(map, prefix + "Days.", this.Days);
            this.SetParamSimple(map, prefix + "BackupPeriodTime", this.BackupPeriodTime);
        }
    }
}

