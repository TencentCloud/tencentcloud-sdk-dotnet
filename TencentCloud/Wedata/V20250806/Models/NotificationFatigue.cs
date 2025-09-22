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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NotificationFatigue : AbstractModel
    {
        
        /// <summary>
        /// 告警次数
        /// </summary>
        [JsonProperty("NotifyCount")]
        public ulong? NotifyCount{ get; set; }

        /// <summary>
        /// 告警间隔，分钟
        /// </summary>
        [JsonProperty("NotifyInterval")]
        public ulong? NotifyInterval{ get; set; }

        /// <summary>
        /// 免打扰时间，例如示例值
        /// [{DaysOfWeek: [1, 2], StartTime: "00:00:00", EndTime: "09:00:00"}]	
        /// 每周一、周二的00:00到09:00免打扰
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QuietIntervals")]
        public AlarmQuietInterval[] QuietIntervals{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NotifyCount", this.NotifyCount);
            this.SetParamSimple(map, prefix + "NotifyInterval", this.NotifyInterval);
            this.SetParamArrayObj(map, prefix + "QuietIntervals.", this.QuietIntervals);
        }
    }
}

