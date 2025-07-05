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

    public class ExceptUserRule : AbstractModel
    {
        
        /// <summary>
        /// 规则名称，不可使用中文。
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 规则的处置方式，当前仅支持skip：跳过全部托管规则。
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 规则生效状态，取值有：
        /// <li>on：生效；</li>
        /// <li>off：失效。</li>
        /// </summary>
        [JsonProperty("RuleStatus")]
        public string RuleStatus{ get; set; }

        /// <summary>
        /// 规则ID。仅出参使用。默认由底层生成。
        /// </summary>
        [JsonProperty("RuleID")]
        public long? RuleID{ get; set; }

        /// <summary>
        /// 更新时间，如果为null，默认由底层按当前时间生成。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 匹配条件。
        /// </summary>
        [JsonProperty("ExceptUserRuleConditions")]
        public ExceptUserRuleCondition[] ExceptUserRuleConditions{ get; set; }

        /// <summary>
        /// 规则生效的范围。
        /// </summary>
        [JsonProperty("ExceptUserRuleScope")]
        public ExceptUserRuleScope ExceptUserRuleScope{ get; set; }

        /// <summary>
        /// 优先级，取值范围0-100。如果为null，默认由底层设置为0。
        /// </summary>
        [JsonProperty("RulePriority")]
        public long? RulePriority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "RuleStatus", this.RuleStatus);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArrayObj(map, prefix + "ExceptUserRuleConditions.", this.ExceptUserRuleConditions);
            this.SetParamObj(map, prefix + "ExceptUserRuleScope.", this.ExceptUserRuleScope);
            this.SetParamSimple(map, prefix + "RulePriority", this.RulePriority);
        }
    }
}

