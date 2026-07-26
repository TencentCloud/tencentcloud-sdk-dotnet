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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TimerScheduleConfig : AbstractModel
    {
        
        /// <summary>
        /// cron配置
        /// </summary>
        [JsonProperty("Cron")]
        public CronSchedule Cron{ get; set; }

        /// <summary>
        /// 每日触发
        /// </summary>
        [JsonProperty("Daily")]
        public DailySchedule Daily{ get; set; }

        /// <summary>
        /// 固定间隔
        /// </summary>
        [JsonProperty("Interval")]
        public IntervalSchedule Interval{ get; set; }

        /// <summary>
        /// 仅手动
        /// </summary>
        [JsonProperty("ManualOnly")]
        public ManualOnlySchedule ManualOnly{ get; set; }

        /// <summary>
        /// 单次
        /// </summary>
        [JsonProperty("Once")]
        public OnceSchedule Once{ get; set; }

        /// <summary>
        /// 
        /// 枚举值:
        /// | uint | 描述 |
        /// | --- | --- |
        /// | 0 |  |
        /// | 1 | 仅手动 |
        /// | 2 | 每天 |
        /// | 3 | 每周 |
        /// | 4 | 按间隔 |
        /// | 5 | 一次性 |
        /// | 6 | Cron |
        /// </summary>
        [JsonProperty("ScheduleType")]
        public long? ScheduleType{ get; set; }

        /// <summary>
        /// 时区
        /// </summary>
        [JsonProperty("Timezone")]
        public string Timezone{ get; set; }

        /// <summary>
        /// 每周固定时间触发
        /// </summary>
        [JsonProperty("Weekly")]
        public WeeklySchedule Weekly{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Cron.", this.Cron);
            this.SetParamObj(map, prefix + "Daily.", this.Daily);
            this.SetParamObj(map, prefix + "Interval.", this.Interval);
            this.SetParamObj(map, prefix + "ManualOnly.", this.ManualOnly);
            this.SetParamObj(map, prefix + "Once.", this.Once);
            this.SetParamSimple(map, prefix + "ScheduleType", this.ScheduleType);
            this.SetParamSimple(map, prefix + "Timezone", this.Timezone);
            this.SetParamObj(map, prefix + "Weekly.", this.Weekly);
        }
    }
}

