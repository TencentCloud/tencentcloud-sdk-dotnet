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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomRiskRuleItem : AbstractModel
    {
        
        /// <summary>
        /// <p>风险规则ID</p>
        /// </summary>
        [JsonProperty("RuleID")]
        public string RuleID{ get; set; }

        /// <summary>
        /// <p>腾讯云</p>
        /// </summary>
        [JsonProperty("Provider")]
        public string Provider{ get; set; }

        /// <summary>
        /// <p>风险标题</p>
        /// </summary>
        [JsonProperty("RiskTitle")]
        public string RiskTitle{ get; set; }

        /// <summary>
        /// <p>风险分类</p>
        /// </summary>
        [JsonProperty("Classify")]
        public string Classify{ get; set; }

        /// <summary>
        /// <p>风险等级</p>
        /// </summary>
        [JsonProperty("Severity")]
        public string Severity{ get; set; }

        /// <summary>
        /// <p>风险规则开启状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>关联的账号数量</p>
        /// </summary>
        [JsonProperty("RelatedUinCount")]
        public ulong? RelatedUinCount{ get; set; }

        /// <summary>
        /// <p>策略启用的账号数量</p>
        /// </summary>
        [JsonProperty("PolicyEnableCount")]
        public ulong? PolicyEnableCount{ get; set; }

        /// <summary>
        /// <p>资产类型</p>
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// <p>规则是否免费</p>
        /// </summary>
        [JsonProperty("IsFree")]
        public ulong? IsFree{ get; set; }

        /// <summary>
        /// <p>检查类型</p>
        /// </summary>
        [JsonProperty("CheckType")]
        public string CheckType{ get; set; }

        /// <summary>
        /// <p>安全条款规范</p>
        /// </summary>
        [JsonProperty("StandardTerms")]
        public StandardTerm[] StandardTerms{ get; set; }

        /// <summary>
        /// <p>资产类型图标</p>
        /// </summary>
        [JsonProperty("AssetTypeIconURL")]
        public string AssetTypeIconURL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
            this.SetParamSimple(map, prefix + "RiskTitle", this.RiskTitle);
            this.SetParamSimple(map, prefix + "Classify", this.Classify);
            this.SetParamSimple(map, prefix + "Severity", this.Severity);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RelatedUinCount", this.RelatedUinCount);
            this.SetParamSimple(map, prefix + "PolicyEnableCount", this.PolicyEnableCount);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "IsFree", this.IsFree);
            this.SetParamSimple(map, prefix + "CheckType", this.CheckType);
            this.SetParamArrayObj(map, prefix + "StandardTerms.", this.StandardTerms);
            this.SetParamSimple(map, prefix + "AssetTypeIconURL", this.AssetTypeIconURL);
        }
    }
}

