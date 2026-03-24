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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CompliancePackRule : AbstractModel
    {
        
        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [JsonProperty("RiskLevel")]
        public ulong? RiskLevel{ get; set; }

        /// <summary>
        /// 入参
        /// </summary>
        [JsonProperty("InputParameter")]
        public InputParameter[] InputParameter{ get; set; }

        /// <summary>
        /// 规则身份标识
        /// </summary>
        [JsonProperty("Identifier")]
        public string Identifier{ get; set; }

        /// <summary>
        /// 描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 预设规则身份标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ManagedRuleIdentifier")]
        public string ManagedRuleIdentifier{ get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("ConfigRuleId")]
        public string ConfigRuleId{ get; set; }

        /// <summary>
        /// 合规包ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompliancePackId")]
        public string CompliancePackId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamArrayObj(map, prefix + "InputParameter.", this.InputParameter);
            this.SetParamSimple(map, prefix + "Identifier", this.Identifier);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ManagedRuleIdentifier", this.ManagedRuleIdentifier);
            this.SetParamSimple(map, prefix + "ConfigRuleId", this.ConfigRuleId);
            this.SetParamSimple(map, prefix + "CompliancePackId", this.CompliancePackId);
        }
    }
}

