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

    public class AggregateEvaluationResult : AbstractModel
    {
        
        /// <summary>
        /// 资源id
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 资源地域
        /// </summary>
        [JsonProperty("ResourceRegion")]
        public string ResourceRegion{ get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [JsonProperty("ConfigRuleId")]
        public string ConfigRuleId{ get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("ConfigRuleName")]
        public string ConfigRuleName{ get; set; }

        /// <summary>
        /// 合规包id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompliancePackId")]
        public string CompliancePackId{ get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [JsonProperty("RiskLevel")]
        public long? RiskLevel{ get; set; }

        /// <summary>
        /// 评估结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Annotation")]
        public Annotation Annotation{ get; set; }

        /// <summary>
        /// 合规类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComplianceType")]
        public string ComplianceType{ get; set; }

        /// <summary>
        /// 规则发起类型
        /// </summary>
        [JsonProperty("InvokingEventMessageType")]
        public string InvokingEventMessageType{ get; set; }

        /// <summary>
        /// 评估发起时间
        /// </summary>
        [JsonProperty("ConfigRuleInvokedTime")]
        public string ConfigRuleInvokedTime{ get; set; }

        /// <summary>
        /// 评估实际时间
        /// </summary>
        [JsonProperty("ResultRecordedTime")]
        public string ResultRecordedTime{ get; set; }

        /// <summary>
        /// 资源所属用户ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceOwnerId")]
        public ulong? ResourceOwnerId{ get; set; }

        /// <summary>
        /// 资源所属用户名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceOwnerName")]
        public string ResourceOwnerName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ResourceRegion", this.ResourceRegion);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "ConfigRuleId", this.ConfigRuleId);
            this.SetParamSimple(map, prefix + "ConfigRuleName", this.ConfigRuleName);
            this.SetParamSimple(map, prefix + "CompliancePackId", this.CompliancePackId);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamObj(map, prefix + "Annotation.", this.Annotation);
            this.SetParamSimple(map, prefix + "ComplianceType", this.ComplianceType);
            this.SetParamSimple(map, prefix + "InvokingEventMessageType", this.InvokingEventMessageType);
            this.SetParamSimple(map, prefix + "ConfigRuleInvokedTime", this.ConfigRuleInvokedTime);
            this.SetParamSimple(map, prefix + "ResultRecordedTime", this.ResultRecordedTime);
            this.SetParamSimple(map, prefix + "ResourceOwnerId", this.ResourceOwnerId);
            this.SetParamSimple(map, prefix + "ResourceOwnerName", this.ResourceOwnerName);
        }
    }
}

