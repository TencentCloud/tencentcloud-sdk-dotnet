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

    public class ModifyDspmRiskStrategyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>风险策略类型</p>
        /// </summary>
        [JsonProperty("StrategyType")]
        public string StrategyType{ get; set; }

        /// <summary>
        /// <p>是否启用</p>
        /// </summary>
        [JsonProperty("IsEnabled")]
        public long? IsEnabled{ get; set; }

        /// <summary>
        /// <p>策略内容，如：{     ThresholdValue: &quot;100&quot; }</p>
        /// </summary>
        [JsonProperty("Rule")]
        public string Rule{ get; set; }

        /// <summary>
        /// <p>可选值：Info/Low/Medium/High</p>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// <p>策略id</p>
        /// </summary>
        [JsonProperty("StrategyId")]
        public ulong?[] StrategyId{ get; set; }

        /// <summary>
        /// <p>策略名</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>策略描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>支持的数据库类型</p>
        /// </summary>
        [JsonProperty("DbTypes")]
        public string DbTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "StrategyType", this.StrategyType);
            this.SetParamSimple(map, prefix + "IsEnabled", this.IsEnabled);
            this.SetParamSimple(map, prefix + "Rule", this.Rule);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamArraySimple(map, prefix + "StrategyId.", this.StrategyId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DbTypes", this.DbTypes);
        }
    }
}

