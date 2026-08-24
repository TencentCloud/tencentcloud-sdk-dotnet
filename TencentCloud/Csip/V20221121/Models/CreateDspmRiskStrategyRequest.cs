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

    public class CreateDspmRiskStrategyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>策略名</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>策略规则，JSON 字符串</p>
        /// </summary>
        [JsonProperty("Rule")]
        public string Rule{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>英文策略名</p>
        /// </summary>
        [JsonProperty("EnName")]
        public string EnName{ get; set; }

        /// <summary>
        /// <p>策略描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>英文策略描述</p>
        /// </summary>
        [JsonProperty("EnDescription")]
        public string EnDescription{ get; set; }

        /// <summary>
        /// <p>风险等级，可选值：Info/Low/Medium/High。不传默认 Medium</p>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// <p>是否启用。0-禁用，1-启用，不传默认启用</p>
        /// </summary>
        [JsonProperty("IsEnabled")]
        public long? IsEnabled{ get; set; }

        /// <summary>
        /// <p>风险类型。当前仅支持 alarm，不传默认 alarm</p>
        /// </summary>
        [JsonProperty("RiskType")]
        public string RiskType{ get; set; }

        /// <summary>
        /// <p>策略类别。当前仅支持 SQLOperationAnomaly，不传默认 SQLOperationAnomaly</p>
        /// </summary>
        [JsonProperty("StrategyCategory")]
        public string StrategyCategory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Rule", this.Rule);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "EnName", this.EnName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "EnDescription", this.EnDescription);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "IsEnabled", this.IsEnabled);
            this.SetParamSimple(map, prefix + "RiskType", this.RiskType);
            this.SetParamSimple(map, prefix + "StrategyCategory", this.StrategyCategory);
        }
    }
}

