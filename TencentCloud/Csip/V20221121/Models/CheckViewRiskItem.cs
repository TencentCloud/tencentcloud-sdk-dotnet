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

    public class CheckViewRiskItem : AbstractModel
    {
        
        /// <summary>
        /// 检查项规则ID
        /// </summary>
        [JsonProperty("RiskRuleId")]
        public string RiskRuleId{ get; set; }

        /// <summary>
        /// 风险名称
        /// </summary>
        [JsonProperty("RiskTitle")]
        public string RiskTitle{ get; set; }

        /// <summary>
        /// 检查类型
        /// </summary>
        [JsonProperty("CheckType")]
        public string CheckType{ get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [JsonProperty("Severity")]
        public string Severity{ get; set; }

        /// <summary>
        /// 存在1个风险项
        /// </summary>
        [JsonProperty("RiskDesc")]
        public string RiskDesc{ get; set; }

        /// <summary>
        /// 首次发现时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 风险更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 云厂商
        /// </summary>
        [JsonProperty("Provider")]
        public string Provider{ get; set; }

        /// <summary>
        /// 风险状态
        /// </summary>
        [JsonProperty("RiskStatus")]
        public ulong? RiskStatus{ get; set; }

        /// <summary>
        /// 受影响资产数量
        /// </summary>
        [JsonProperty("AssetCount")]
        public ulong? AssetCount{ get; set; }

        /// <summary>
        /// 风险数量
        /// </summary>
        [JsonProperty("RiskCount")]
        public ulong? RiskCount{ get; set; }

        /// <summary>
        /// 资产类型
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// 处置分类
        /// </summary>
        [JsonProperty("Classify")]
        public string Classify{ get; set; }

        /// <summary>
        /// cspm规范条款
        /// </summary>
        [JsonProperty("StandardTerms")]
        public StandardTerm[] StandardTerms{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RiskRuleId", this.RiskRuleId);
            this.SetParamSimple(map, prefix + "RiskTitle", this.RiskTitle);
            this.SetParamSimple(map, prefix + "CheckType", this.CheckType);
            this.SetParamSimple(map, prefix + "Severity", this.Severity);
            this.SetParamSimple(map, prefix + "RiskDesc", this.RiskDesc);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
            this.SetParamSimple(map, prefix + "RiskStatus", this.RiskStatus);
            this.SetParamSimple(map, prefix + "AssetCount", this.AssetCount);
            this.SetParamSimple(map, prefix + "RiskCount", this.RiskCount);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "Classify", this.Classify);
            this.SetParamArrayObj(map, prefix + "StandardTerms.", this.StandardTerms);
        }
    }
}

