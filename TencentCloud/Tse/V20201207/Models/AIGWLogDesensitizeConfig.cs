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

    public class AIGWLogDesensitizeConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>日志脱敏开关</p>
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// <p>预定义规则类型</p><p>枚举值：</p><ul><li>Phone： 电话号码</li><li>IdCard： 身份证号</li><li>BankCard： 银行卡号</li><li>Email： 邮箱地址</li><li>IP： IP地址</li><li>Name： 姓名</li></ul>
        /// </summary>
        [JsonProperty("PredefinedRuleTypes")]
        public string[] PredefinedRuleTypes{ get; set; }

        /// <summary>
        /// <p>自定义脱敏规则</p>
        /// </summary>
        [JsonProperty("CustomRules")]
        public AIGWCustomDesensitizeRule[] CustomRules{ get; set; }

        /// <summary>
        /// <p>日志脱敏范围</p><p>枚举值：</p><ul><li>Request： 请求</li><li>Response： 响应</li></ul>
        /// </summary>
        [JsonProperty("Scope")]
        public string[] Scope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamArraySimple(map, prefix + "PredefinedRuleTypes.", this.PredefinedRuleTypes);
            this.SetParamArrayObj(map, prefix + "CustomRules.", this.CustomRules);
            this.SetParamArraySimple(map, prefix + "Scope.", this.Scope);
        }
    }
}

