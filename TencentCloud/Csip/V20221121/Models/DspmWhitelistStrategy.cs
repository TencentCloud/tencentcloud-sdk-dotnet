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

    public class DspmWhitelistStrategy : AbstractModel
    {
        
        /// <summary>
        /// <p>白名单策略id</p>
        /// </summary>
        [JsonProperty("WhitelistStrategyId")]
        public string WhitelistStrategyId{ get; set; }

        /// <summary>
        /// <p>策略类型</p>
        /// </summary>
        [JsonProperty("StrategyType")]
        public string StrategyType{ get; set; }

        /// <summary>
        /// <p>白名单策略名</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>策略类型</p>
        /// </summary>
        [JsonProperty("StrategyCategory")]
        public string StrategyCategory{ get; set; }

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
        /// <p>修改时间</p>
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

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
        /// <p>策略规则内容描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>白名单类型。risk-风险白名单；alarm-告警白名单。</p>
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
        /// <p>白名单类型</p>
        /// </summary>
        [JsonProperty("WhitelistType")]
        public string WhitelistType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WhitelistStrategyId", this.WhitelistStrategyId);
            this.SetParamSimple(map, prefix + "StrategyType", this.StrategyType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "StrategyCategory", this.StrategyCategory);
            this.SetParamSimple(map, prefix + "Rule", this.Rule);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "Account", this.Account);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "RiskType", this.RiskType);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "WhitelistType", this.WhitelistType);
        }
    }
}

