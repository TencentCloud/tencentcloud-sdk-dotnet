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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CCFrequencyRule : AbstractModel
    {
        
        /// <summary>
        /// CC的访问频率控制规则ID
        /// </summary>
        [JsonProperty("CCFrequencyRuleId")]
        public string CCFrequencyRuleId{ get; set; }

        /// <summary>
        /// URI字符串，必须以/开头，例如/abc/a.php，长度不超过31；当URI=/时，匹配模式只能选择前缀匹配；
        /// </summary>
        [JsonProperty("Uri")]
        public string Uri{ get; set; }

        /// <summary>
        /// User-Agent字符串，长度不超过80
        /// </summary>
        [JsonProperty("UserAgent")]
        public string UserAgent{ get; set; }

        /// <summary>
        /// Cookie字符串，长度不超过40
        /// </summary>
        [JsonProperty("Cookie")]
        public string Cookie{ get; set; }

        /// <summary>
        /// 匹配规则，取值["include"(前缀匹配)，"equal"(完全匹配)]
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 统计周期，单位秒，取值[10, 30, 60]
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// 访问次数，取值[1-10000]
        /// </summary>
        [JsonProperty("ReqNumber")]
        public ulong? ReqNumber{ get; set; }

        /// <summary>
        /// 执行动作，取值["alg"（人机识别）, "drop"（拦截）]
        /// </summary>
        [JsonProperty("Act")]
        public string Act{ get; set; }

        /// <summary>
        /// 执行时间，单位秒，取值[1-900]
        /// </summary>
        [JsonProperty("ExeDuration")]
        public ulong? ExeDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CCFrequencyRuleId", this.CCFrequencyRuleId);
            this.SetParamSimple(map, prefix + "Uri", this.Uri);
            this.SetParamSimple(map, prefix + "UserAgent", this.UserAgent);
            this.SetParamSimple(map, prefix + "Cookie", this.Cookie);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "ReqNumber", this.ReqNumber);
            this.SetParamSimple(map, prefix + "Act", this.Act);
            this.SetParamSimple(map, prefix + "ExeDuration", this.ExeDuration);
        }
    }
}

