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

    public class InferenceScalingPolicy : AbstractModel
    {
        
        /// <summary>
        /// 策略名称。长度限制为 1~30 个字符。同一服务内策略名称需唯一。
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// 策略类型，创建后不可修改。取值：<li>ScheduledScaling：定时伸缩。</li>
        /// </summary>
        [JsonProperty("PolicyType")]
        public string PolicyType{ get; set; }

        /// <summary>
        /// 定时伸缩配置。当 PolicyType 取值为 ScheduledScaling 时，该字段必填。
        /// </summary>
        [JsonProperty("ScheduledScalingPolicy")]
        public InferenceScheduledScalingPolicy ScheduledScalingPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamObj(map, prefix + "ScheduledScalingPolicy.", this.ScheduledScalingPolicy);
        }
    }
}

