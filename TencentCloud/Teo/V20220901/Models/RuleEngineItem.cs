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

    public class RuleEngineItem : AbstractModel
    {
        
        /// <summary>
        /// <p>规则状态。取值有：<li> enable: 启用； </li><li> disable: 未启用。</li></p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>规则 ID。规则的唯一性标识，当调用 ModifyL7AccRule 时，该参数必填。</p>
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// <p>规则名称。名称长度限制不超过 255 个字符。</p>
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// <p>规则注释。可以填写多个注释。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string[] Description{ get; set; }

        /// <summary>
        /// <p>规则级自定义变量列表。CustomVariable.Name 需要使用 user.rule. 作为前缀。变量按照数组顺序依次初始化，InitialValue 支持引用站点级自定义变量，以及位于当前变量之前的规则级自定义变量，不支持引用当前变量自身或位于其后的规则级自定义变量。站点级自定义变量可通过 DescribeZoneCustomVariables 接口查询。当 Branches 为空时 CustomVariable 不允许填写，填写无效。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomVariables")]
        public CustomVariable[] CustomVariables{ get; set; }

        /// <summary>
        /// <p>规则级自定义变量运算详情。运算中支持引用站点级自定义变量和当前规则已定义的规则级自定义变量。站点级自定义变量可通过 DescribeZoneCustomVariables 接口查询。此列表当前只支持填写一项规则，多填无效。当 Branches 为空时 CustomVariableOperations 不允许填写，填写无效。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomVariableOperations")]
        public CustomVariableOperation[] CustomVariableOperations{ get; set; }

        /// <summary>
        /// <p>子规则分支。此列表当前只支持填写一项规则，多填无效。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Branches")]
        public RuleBranch[] Branches{ get; set; }

        /// <summary>
        /// <p>规则优先级。仅作为出参使用。</p>
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
            this.SetParamArrayObj(map, prefix + "CustomVariables.", this.CustomVariables);
            this.SetParamArrayObj(map, prefix + "CustomVariableOperations.", this.CustomVariableOperations);
            this.SetParamArrayObj(map, prefix + "Branches.", this.Branches);
            this.SetParamSimple(map, prefix + "RulePriority", this.RulePriority);
        }
    }
}

