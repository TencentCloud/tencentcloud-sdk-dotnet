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

    public class SystemCompliancePack : AbstractModel
    {
        
        /// <summary>
        /// 合规包ID
        /// </summary>
        [JsonProperty("CompliancePackId")]
        public string CompliancePackId{ get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("CompliancePackName")]
        public string CompliancePackName{ get; set; }

        /// <summary>
        /// 描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 合规包风险等级1：高风险。
        /// 2：中风险。
        /// 3：低风险。
        /// </summary>
        [JsonProperty("RiskLevel")]
        public ulong? RiskLevel{ get; set; }

        /// <summary>
        /// 合规包规则信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigRules")]
        public CompliancePackRuleForManage[] ConfigRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompliancePackId", this.CompliancePackId);
            this.SetParamSimple(map, prefix + "CompliancePackName", this.CompliancePackName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamArrayObj(map, prefix + "ConfigRules.", this.ConfigRules);
        }
    }
}

