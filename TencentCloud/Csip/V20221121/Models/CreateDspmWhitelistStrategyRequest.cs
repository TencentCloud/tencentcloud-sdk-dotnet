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

    public class CreateDspmWhitelistStrategyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>策略类型</p>
        /// </summary>
        [JsonProperty("StrategyType")]
        public string StrategyType{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>白名单</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>规则</p>
        /// </summary>
        [JsonProperty("Rule")]
        public string Rule{ get; set; }

        /// <summary>
        /// <p>资产id</p>
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// <p>账号</p>
        /// </summary>
        [JsonProperty("Account")]
        public string Account{ get; set; }

        /// <summary>
        /// <p>主机</p>
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// <p>风险id</p>
        /// </summary>
        [JsonProperty("RiskId")]
        public string RiskId{ get; set; }

        /// <summary>
        /// <p>备注</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>白名单的类型</p><p>枚举值：</p><ul><li>static_risk： 静态配置扫描的白名单规则</li><li>audit： 审计白名单规则</li><li>ueba： ueba相关的白名单规则</li></ul>
        /// </summary>
        [JsonProperty("WhitelistType")]
        public string WhitelistType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StrategyType", this.StrategyType);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Rule", this.Rule);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "Account", this.Account);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "RiskId", this.RiskId);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "WhitelistType", this.WhitelistType);
        }
    }
}

