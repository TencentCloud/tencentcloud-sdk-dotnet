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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OverviewVpcRuleQuotaDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>允许使用的规则总数。</p>
        /// </summary>
        [JsonProperty("AllowedNum")]
        public long? AllowedNum{ get; set; }

        /// <summary>
        /// <p>已使用规则数量。</p>
        /// </summary>
        [JsonProperty("UsedNum")]
        public long? UsedNum{ get; set; }

        /// <summary>
        /// <p>剩余规则配额数量。</p>
        /// </summary>
        [JsonProperty("RemainQuota")]
        public long? RemainQuota{ get; set; }

        /// <summary>
        /// <p>剩余扩容规则数量。</p>
        /// </summary>
        [JsonProperty("RemainExtensionNum")]
        public long? RemainExtensionNum{ get; set; }

        /// <summary>
        /// <p>全局规则总数。</p>
        /// </summary>
        [JsonProperty("GlobalRuleNum")]
        public long? GlobalRuleNum{ get; set; }

        /// <summary>
        /// <p>当前已启用的全局规则条目。</p>
        /// </summary>
        [JsonProperty("GlobalEnableRuleNum")]
        public long? GlobalEnableRuleNum{ get; set; }

        /// <summary>
        /// <p>边界规则总数。</p>
        /// </summary>
        [JsonProperty("EdgeRuleNum")]
        public long? EdgeRuleNum{ get; set; }

        /// <summary>
        /// <p>边界启用规则数。</p>
        /// </summary>
        [JsonProperty("EdgeEnableRuleNum")]
        public long? EdgeEnableRuleNum{ get; set; }

        /// <summary>
        /// <p>IPv4 规则总数。</p>
        /// </summary>
        [JsonProperty("V4RuleTotal")]
        public long? V4RuleTotal{ get; set; }

        /// <summary>
        /// <p>当前已启用的 IPv4 规则条目。</p>
        /// </summary>
        [JsonProperty("V4EnableRuleTotal")]
        public long? V4EnableRuleTotal{ get; set; }

        /// <summary>
        /// <p>IPv6 规则总数。</p>
        /// </summary>
        [JsonProperty("V6RuleTotal")]
        public long? V6RuleTotal{ get; set; }

        /// <summary>
        /// <p>当前已启用的 IPv6 规则条目。</p>
        /// </summary>
        [JsonProperty("V6EnableRuleTotal")]
        public long? V6EnableRuleTotal{ get; set; }

        /// <summary>
        /// <p>VPC 防火墙开关状态标识。</p>
        /// </summary>
        [JsonProperty("IsSwitchEnable")]
        public long? IsSwitchEnable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AllowedNum", this.AllowedNum);
            this.SetParamSimple(map, prefix + "UsedNum", this.UsedNum);
            this.SetParamSimple(map, prefix + "RemainQuota", this.RemainQuota);
            this.SetParamSimple(map, prefix + "RemainExtensionNum", this.RemainExtensionNum);
            this.SetParamSimple(map, prefix + "GlobalRuleNum", this.GlobalRuleNum);
            this.SetParamSimple(map, prefix + "GlobalEnableRuleNum", this.GlobalEnableRuleNum);
            this.SetParamSimple(map, prefix + "EdgeRuleNum", this.EdgeRuleNum);
            this.SetParamSimple(map, prefix + "EdgeEnableRuleNum", this.EdgeEnableRuleNum);
            this.SetParamSimple(map, prefix + "V4RuleTotal", this.V4RuleTotal);
            this.SetParamSimple(map, prefix + "V4EnableRuleTotal", this.V4EnableRuleTotal);
            this.SetParamSimple(map, prefix + "V6RuleTotal", this.V6RuleTotal);
            this.SetParamSimple(map, prefix + "V6EnableRuleTotal", this.V6EnableRuleTotal);
            this.SetParamSimple(map, prefix + "IsSwitchEnable", this.IsSwitchEnable);
        }
    }
}

