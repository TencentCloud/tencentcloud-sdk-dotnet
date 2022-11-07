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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecRuleRelatedInfo : AbstractModel
    {
        
        /// <summary>
        /// 规则ID。
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }

        /// <summary>
        /// 执行动作（处置方式），取值有：
        /// <li>trans ：通过 ；</li>
        /// <li>alg ：算法挑战 ；</li>
        /// <li>drop ：丢弃 ；</li>
        /// <li>ban ：封禁源ip ；</li>
        /// <li>redirect ：重定向 ；</li>
        /// <li>page ：返回指定页面 ；</li>
        /// <li>monitor ：观察 。</li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 风险等级（waf日志中独有），取值有：
        /// <li>high risk ：高危 ；</li>
        /// <li>middle risk ：中危 ；</li>
        /// <li>low risk ：低危 ；</li>
        /// <li>unkonw ：未知 。</li>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// 规则等级，取值有：
        /// <li>normal  ：正常 。</li>
        /// </summary>
        [JsonProperty("RuleLevel")]
        public string RuleLevel{ get; set; }

        /// <summary>
        /// 规则描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 规则类型名称。
        /// </summary>
        [JsonProperty("RuleTypeName")]
        public string RuleTypeName{ get; set; }

        /// <summary>
        /// 攻击内容。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttackContent")]
        public string AttackContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "RuleLevel", this.RuleLevel);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "RuleTypeName", this.RuleTypeName);
            this.SetParamSimple(map, prefix + "AttackContent", this.AttackContent);
        }
    }
}

