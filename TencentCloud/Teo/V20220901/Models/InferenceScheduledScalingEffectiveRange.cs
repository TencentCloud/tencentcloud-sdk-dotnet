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

    public class InferenceScheduledScalingEffectiveRange : AbstractModel
    {
        
        /// <summary>
        /// <p>有效期类型。取值有：<li>LongTerm：长期有效；</li><li>Custom：自定义起止日期。</li></p>
        /// </summary>
        [JsonProperty("EffectiveType")]
        public string EffectiveType{ get; set; }

        /// <summary>
        /// <p>有效期起始日期。当 EffectiveType 为 Custom 时必填；当 EffectiveType 为 LongTerm 时不传该字段。</p>
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// <p>有效期终止日期。当 EffectiveType 为 Custom 时必填，且不得早于 StartDate；当 EffectiveType 为 LongTerm 时不传该字段。</p>
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EffectiveType", this.EffectiveType);
            this.SetParamSimple(map, prefix + "StartDate", this.StartDate);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
        }
    }
}

