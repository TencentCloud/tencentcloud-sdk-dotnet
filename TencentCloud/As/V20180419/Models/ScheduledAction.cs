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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScheduledAction : AbstractModel
    {
        
        /// <summary>
        /// 定时任务ID。
        /// </summary>
        [JsonProperty("ScheduledActionId")]
        public string ScheduledActionId{ get; set; }

        /// <summary>
        /// 定时任务名称。
        /// </summary>
        [JsonProperty("ScheduledActionName")]
        public string ScheduledActionName{ get; set; }

        /// <summary>
        /// 定时任务所在伸缩组ID。
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// 定时任务的开始时间。取值为`北京时间`（UTC+8），按照`ISO8601`标准，格式：`YYYY-MM-DDThh:mm:ss+08:00`。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 定时任务的重复方式。定时任务中的[Recurrence参数限制](https://cloud.tencent.com/document/product/377/88119)为5个字段，由空格分开，结构为：分，小时，日期，月份，星期。
        /// </summary>
        [JsonProperty("Recurrence")]
        public string Recurrence{ get; set; }

        /// <summary>
        /// 定时任务的结束时间。取值为`北京时间`（UTC+8），按照`ISO8601`标准，格式：`YYYY-MM-DDThh:mm:ss+08:00`。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 定时任务设置的最大实例数。
        /// </summary>
        [JsonProperty("MaxSize")]
        public ulong? MaxSize{ get; set; }

        /// <summary>
        /// 定时任务设置的期望实例数。
        /// </summary>
        [JsonProperty("DesiredCapacity")]
        public ulong? DesiredCapacity{ get; set; }

        /// <summary>
        /// 定时任务设置的最小实例数。
        /// </summary>
        [JsonProperty("MinSize")]
        public ulong? MinSize{ get; set; }

        /// <summary>
        /// 定时任务的创建时间。取值为标准`UTC`时间，按照`ISO8601`标准，格式：`YYYY-MM-DDThh:mm:ssZ`。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 定时任务的执行类型。取值范围：
        /// <li>CRONTAB：代表定时任务为重复执行。</li>
        /// <li>ONCE：代表定时任务为单次执行。</li>
        /// </summary>
        [JsonProperty("ScheduledType")]
        public string ScheduledType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScheduledActionId", this.ScheduledActionId);
            this.SetParamSimple(map, prefix + "ScheduledActionName", this.ScheduledActionName);
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Recurrence", this.Recurrence);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
            this.SetParamSimple(map, prefix + "DesiredCapacity", this.DesiredCapacity);
            this.SetParamSimple(map, prefix + "MinSize", this.MinSize);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ScheduledType", this.ScheduledType);
        }
    }
}

