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

namespace TencentCloud.Fwm.V20250611.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PolicyRisk : AbstractModel
    {
        
        /// <summary>
        /// 问题对应的唯一uuid
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 风险大类
        /// </summary>
        [JsonProperty("RiskCategory")]
        public string RiskCategory{ get; set; }

        /// <summary>
        /// 风险子类
        /// </summary>
        [JsonProperty("RiskSubCategory")]
        public string RiskSubCategory{ get; set; }

        /// <summary>
        /// 规则分类
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// 风险等级，0：低风险
        /// 1：中风险
        /// 2：高风险
        /// </summary>
        [JsonProperty("RiskLevel")]
        public long? RiskLevel{ get; set; }

        /// <summary>
        /// 安全组
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// 风险包含的企业安全组规则ID
        /// </summary>
        [JsonProperty("SgRuleId")]
        public string[] SgRuleId{ get; set; }

        /// <summary>
        /// 风险包含安全组ID内的问题规则数
        /// </summary>
        [JsonProperty("RuleCount")]
        public long? RuleCount{ get; set; }

        /// <summary>
        /// 风险包含的安全组ID
        /// </summary>
        [JsonProperty("SgId")]
        public string[] SgId{ get; set; }

        /// <summary>
        /// 风险特征
        /// </summary>
        [JsonProperty("RiskFeature")]
        public string RiskFeature{ get; set; }

        /// <summary>
        /// 处置建议
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// 处置状态，0：未处理，1：已处理，2：忽略
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 发现时间
        /// </summary>
        [JsonProperty("FoundTime")]
        public string FoundTime{ get; set; }

        /// <summary>
        /// 处置时间
        /// </summary>
        [JsonProperty("DisposalTime")]
        public string DisposalTime{ get; set; }

        /// <summary>
        /// 安全组地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Ingress入站，Egress出站
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }

        /// <summary>
        /// 风险原因
        /// </summary>
        [JsonProperty("RiskReason")]
        public string RiskReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "RiskCategory", this.RiskCategory);
            this.SetParamSimple(map, prefix + "RiskSubCategory", this.RiskSubCategory);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamArraySimple(map, prefix + "SgRuleId.", this.SgRuleId);
            this.SetParamSimple(map, prefix + "RuleCount", this.RuleCount);
            this.SetParamArraySimple(map, prefix + "SgId.", this.SgId);
            this.SetParamSimple(map, prefix + "RiskFeature", this.RiskFeature);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FoundTime", this.FoundTime);
            this.SetParamSimple(map, prefix + "DisposalTime", this.DisposalTime);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "RiskReason", this.RiskReason);
        }
    }
}

