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

    public class ModifyScheduledActionRequest : AbstractModel
    {
        
        /// <summary>
        /// 待修改的定时任务ID
        /// </summary>
        [JsonProperty("ScheduledActionId")]
        public string ScheduledActionId{ get; set; }

        /// <summary>
        /// 定时任务名称。名称仅支持中文、英文、数字、下划线、分隔符"-"、小数点，最大长度不能超60个字节。同一伸缩组下必须唯一。
        /// </summary>
        [JsonProperty("ScheduledActionName")]
        public string ScheduledActionName{ get; set; }

        /// <summary>
        /// 当定时任务触发时，设置的伸缩组最大实例数。
        /// </summary>
        [JsonProperty("MaxSize")]
        public ulong? MaxSize{ get; set; }

        /// <summary>
        /// 当定时任务触发时，设置的伸缩组最小实例数。
        /// </summary>
        [JsonProperty("MinSize")]
        public ulong? MinSize{ get; set; }

        /// <summary>
        /// 当定时任务触发时，设置的伸缩组期望实例数。
        /// </summary>
        [JsonProperty("DesiredCapacity")]
        public ulong? DesiredCapacity{ get; set; }

        /// <summary>
        /// 定时任务的首次触发时间，取值为`北京时间`（UTC+8），按照`ISO8601`标准，格式：`YYYY-MM-DDThh:mm:ss+08:00`。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 定时任务的结束时间，取值为`北京时间`（UTC+8），按照`ISO8601`标准，格式：`YYYY-MM-DDThh:mm:ss+08:00`。<br>此参数与`Recurrence`需要同时指定，到达结束时间之后，定时任务将不再生效。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 定时任务的重复方式。为标准 Cron 格式<br>此参数与`EndTime`需要同时指定。
        /// </summary>
        [JsonProperty("Recurrence")]
        public string Recurrence{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScheduledActionId", this.ScheduledActionId);
            this.SetParamSimple(map, prefix + "ScheduledActionName", this.ScheduledActionName);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
            this.SetParamSimple(map, prefix + "MinSize", this.MinSize);
            this.SetParamSimple(map, prefix + "DesiredCapacity", this.DesiredCapacity);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Recurrence", this.Recurrence);
        }
    }
}

