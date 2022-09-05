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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExceptUserRule : AbstractModel
    {
        
        /// <summary>
        /// 规则ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleID")]
        public long? RuleID{ get; set; }

        /// <summary>
        /// 规则名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 规则的处置方式。
        /// 1. skip 跳过
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 规则生效状态。
        /// 1. on 生效
        /// 2. off 失效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleStatus")]
        public string RuleStatus{ get; set; }

        /// <summary>
        /// 更新时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 匹配条件。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Conditions")]
        public ExceptUserRuleCondition[] Conditions{ get; set; }

        /// <summary>
        /// 规则生效的范围。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Scope")]
        public ExceptUserRuleScope Scope{ get; set; }

        /// <summary>
        /// 优先级。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RulePriority")]
        public long? RulePriority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "RuleStatus", this.RuleStatus);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArrayObj(map, prefix + "Conditions.", this.Conditions);
            this.SetParamObj(map, prefix + "Scope.", this.Scope);
            this.SetParamSimple(map, prefix + "RulePriority", this.RulePriority);
        }
    }
}

