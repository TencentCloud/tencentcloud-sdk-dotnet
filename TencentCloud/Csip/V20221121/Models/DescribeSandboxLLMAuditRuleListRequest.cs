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

    public class DescribeSandboxLLMAuditRuleListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>偏移量，默认 0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>每页数量，默认 10，上限 200</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>过滤条件<br>支持的过滤项：<br>RuleID：规则 ID，用于查询单条规则<br>RuleName：按规则名称搜索<br>Status：规则状态，可选值：ON（启用） / OFF（禁用）<br>Level：规则级别，可选值：INFO（提示） / LOW（低危） / MEDIUM（中危） / HIGH（高危） / CRITICAL（严重）<br>RuleAction：规则动作，可选值：PASS（加白） / BLOCK（拦截并告警） / MONITOR（告警）<br>BelongAssetType：归属资产类型，可选值：HOST（主机） / CONTAINER（容器）</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
        }
    }
}

