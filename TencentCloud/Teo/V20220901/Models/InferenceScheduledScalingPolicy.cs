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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InferenceScheduledScalingPolicy : AbstractModel
    {
        
        /// <summary>
        /// 定时伸缩动作列表。至少填写 1 个，最多支持 10 个。
        /// </summary>
        [JsonProperty("ScheduledActions")]
        public InferenceScheduledScalingAction[] ScheduledActions{ get; set; }

        /// <summary>
        /// 有效期范围，用于描述该定时伸缩策略长期有效或仅在指定日期范围内有效。
        /// </summary>
        [JsonProperty("EffectiveRange")]
        public InferenceScheduledScalingEffectiveRange EffectiveRange{ get; set; }

        /// <summary>
        /// 时区，使用 [IANA 时区](https://www.iana.org/time-zones) 标识 ScheduledActions 中的触发时间，例如 UTC、Asia/Shanghai、America/New_York、Europe/London、Asia/Kolkata。不传时默认使用 UTC。
        /// 
        /// 
        /// 
        /// 
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ScheduledActions.", this.ScheduledActions);
            this.SetParamObj(map, prefix + "EffectiveRange.", this.EffectiveRange);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
        }
    }
}

