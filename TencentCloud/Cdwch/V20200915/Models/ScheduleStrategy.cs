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

namespace TencentCloud.Cdwch.V20200915.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScheduleStrategy : AbstractModel
    {
        
        /// <summary>
        /// 备份桶名称
        /// </summary>
        [JsonProperty("CosBucketName")]
        public string CosBucketName{ get; set; }

        /// <summary>
        /// 备份保留天数
        /// </summary>
        [JsonProperty("RetainDays")]
        public long? RetainDays{ get; set; }

        /// <summary>
        /// 备份的天
        /// </summary>
        [JsonProperty("WeekDays")]
        public string WeekDays{ get; set; }

        /// <summary>
        /// 备份小时
        /// </summary>
        [JsonProperty("ExecuteHour")]
        public long? ExecuteHour{ get; set; }

        /// <summary>
        /// 策略id
        /// </summary>
        [JsonProperty("ScheduleId")]
        public long? ScheduleId{ get; set; }

        /// <summary>
        /// 下次备份时间
        /// </summary>
        [JsonProperty("NextBackupTime")]
        public string NextBackupTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CosBucketName", this.CosBucketName);
            this.SetParamSimple(map, prefix + "RetainDays", this.RetainDays);
            this.SetParamSimple(map, prefix + "WeekDays", this.WeekDays);
            this.SetParamSimple(map, prefix + "ExecuteHour", this.ExecuteHour);
            this.SetParamSimple(map, prefix + "ScheduleId", this.ScheduleId);
            this.SetParamSimple(map, prefix + "NextBackupTime", this.NextBackupTime);
        }
    }
}

