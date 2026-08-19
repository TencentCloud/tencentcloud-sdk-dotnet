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

    public class ModifyAIScheduleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>AI 定时任务 ID。可通过 CreateAISchedule 接口获取。</p>
        /// </summary>
        [JsonProperty("ScheduleId")]
        public string ScheduleId{ get; set; }

        /// <summary>
        /// <p>任务名称。最大 128 字符。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>执行提示词。最大 2048 字符。</p>
        /// </summary>
        [JsonProperty("Prompts")]
        public string Prompts{ get; set; }

        /// <summary>
        /// <p>最大触发次数，0 表示无限制。</p>
        /// </summary>
        [JsonProperty("MaxFireCount")]
        public long? MaxFireCount{ get; set; }

        /// <summary>
        /// <p>生效开始时间，Unix 毫秒时间戳，0 表示立即生效。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// <p>生效结束时间，Unix 毫秒时间戳，0 表示永不过期。</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// <p>触发器列表，当 UpdateTriggers 为 true 时全量替换。</p>
        /// </summary>
        [JsonProperty("Triggers")]
        public AiScheduleTriggerInfo[] Triggers{ get; set; }

        /// <summary>
        /// <p>是否更新触发器列表。取值：true（使用 Triggers 字段全量替换）、false（不更新）。</p>
        /// </summary>
        [JsonProperty("UpdateTriggers")]
        public bool? UpdateTriggers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScheduleId", this.ScheduleId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Prompts", this.Prompts);
            this.SetParamSimple(map, prefix + "MaxFireCount", this.MaxFireCount);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArrayObj(map, prefix + "Triggers.", this.Triggers);
            this.SetParamSimple(map, prefix + "UpdateTriggers", this.UpdateTriggers);
        }
    }
}

