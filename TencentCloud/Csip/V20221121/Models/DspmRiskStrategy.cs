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

    public class DspmRiskStrategy : AbstractModel
    {
        
        /// <summary>
        /// <p>策略类型</p>
        /// </summary>
        [JsonProperty("StrategyType")]
        public string StrategyType{ get; set; }

        /// <summary>
        /// <p>策略名</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>策略类型</p>
        /// </summary>
        [JsonProperty("StrategyCategory")]
        public string StrategyCategory{ get; set; }

        /// <summary>
        /// <p>是否启用。0-禁用 1-启用</p>
        /// </summary>
        [JsonProperty("IsEnabled")]
        public long? IsEnabled{ get; set; }

        /// <summary>
        /// <p>风险等级。</p>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// <p>策略规则</p>
        /// </summary>
        [JsonProperty("Rule")]
        public string Rule{ get; set; }

        /// <summary>
        /// <p>备注</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>策略内容</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>命中次数</p>
        /// </summary>
        [JsonProperty("HitCount")]
        public long? HitCount{ get; set; }

        /// <summary>
        /// <p>风险类型。risk-风险；alarm-告警。</p>
        /// </summary>
        [JsonProperty("RiskType")]
        public string RiskType{ get; set; }

        /// <summary>
        /// <p>资产所属账号app id</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>账号昵称</p>
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// <p>资产所属账号uin</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>策略id</p>
        /// </summary>
        [JsonProperty("StrategyId")]
        public ulong? StrategyId{ get; set; }

        /// <summary>
        /// <p>规则来源</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleSource")]
        public string RuleSource{ get; set; }

        /// <summary>
        /// <p>支持的资产类型</p>
        /// </summary>
        [JsonProperty("AssetTypes")]
        public string[] AssetTypes{ get; set; }

        /// <summary>
        /// <p>风险描述</p>
        /// </summary>
        [JsonProperty("RiskDescription")]
        public string RiskDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StrategyType", this.StrategyType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "StrategyCategory", this.StrategyCategory);
            this.SetParamSimple(map, prefix + "IsEnabled", this.IsEnabled);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "Rule", this.Rule);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "HitCount", this.HitCount);
            this.SetParamSimple(map, prefix + "RiskType", this.RiskType);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "StrategyId", this.StrategyId);
            this.SetParamSimple(map, prefix + "RuleSource", this.RuleSource);
            this.SetParamArraySimple(map, prefix + "AssetTypes.", this.AssetTypes);
            this.SetParamSimple(map, prefix + "RiskDescription", this.RiskDescription);
        }
    }
}

