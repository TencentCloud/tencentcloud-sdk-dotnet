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

    public class RuleEngineItem : AbstractModel
    {
        
        /// <summary>
        /// 规则状态。取值有：<li> enable: 启用； </li><li> disable: 未启用。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 规则 ID。规则的唯一性标识，当调用 ModifyL7AccRules 时，该参数必填。
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 规则名称。名称长度限制不超过 255 个字符。
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 规则注释。可以填写多个注释。
        /// </summary>
        [JsonProperty("Description")]
        public string[] Description{ get; set; }

        /// <summary>
        /// 子规则分支。此列表当前只支持填写一项规则，多填无效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Branches")]
        public RuleBranch[] Branches{ get; set; }

        /// <summary>
        /// 规则优先级。仅作为出参使用。
        /// </summary>
        [JsonProperty("RulePriority")]
        public long? RulePriority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamArraySimple(map, prefix + "Description.", this.Description);
            this.SetParamArrayObj(map, prefix + "Branches.", this.Branches);
            this.SetParamSimple(map, prefix + "RulePriority", this.RulePriority);
        }
    }
}

