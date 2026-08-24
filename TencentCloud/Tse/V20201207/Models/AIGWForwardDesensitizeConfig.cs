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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIGWForwardDesensitizeConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>转发脱敏配置总开关</p>
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// <p>内置规则类型：Phone、IdCard、BankCard、Email、IP、Name</p>
        /// </summary>
        [JsonProperty("PredefinedRuleTypes")]
        public string[] PredefinedRuleTypes{ get; set; }

        /// <summary>
        /// <p>自定义规则，最多 20 条</p>
        /// </summary>
        [JsonProperty("CustomRules")]
        public AIGWCustomDesensitizeRule[] CustomRules{ get; set; }

        /// <summary>
        /// <p>内置规则占位符格式，最长 32；为空时默认 [{type}]</p>
        /// </summary>
        [JsonProperty("PlaceholderFormat")]
        public string PlaceholderFormat{ get; set; }

        /// <summary>
        /// <p>脱敏失败处理：Reject（拒绝请求）或 Skip（跳过脱敏并转发）</p>
        /// </summary>
        [JsonProperty("OnFailure")]
        public string OnFailure{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamArraySimple(map, prefix + "PredefinedRuleTypes.", this.PredefinedRuleTypes);
            this.SetParamArrayObj(map, prefix + "CustomRules.", this.CustomRules);
            this.SetParamSimple(map, prefix + "PlaceholderFormat", this.PlaceholderFormat);
            this.SetParamSimple(map, prefix + "OnFailure", this.OnFailure);
        }
    }
}

