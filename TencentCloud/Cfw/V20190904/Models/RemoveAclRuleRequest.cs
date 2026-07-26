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

    public class RemoveAclRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>必填的规则 ID 列表。具体规则 ID 通过 DescribeCfwRules 查询 RuleType=border 和目标 RuleUuid，并使用返回的 rules[].uuid。列表恰为 [-1] 时删除 Direction 指定方向下当前账号的全部可操作规则，风险极高；其它列表按 ID 删除匹配规则。空列表返回 InternalError，不删除规则。成功响应回显请求中的 ID 列表。</p>
        /// </summary>
        [JsonProperty("RuleUuid")]
        public long?[] RuleUuid{ get; set; }

        /// <summary>
        /// <p>AI操作来源</p><p>枚举值：</p><ul><li>console： 控制台来源值</li><li>wechat： 微信</li></ul>。
        /// </summary>
        [JsonProperty("CfwAiAgentOperationSource")]
        public string CfwAiAgentOperationSource{ get; set; }

        /// <summary>
        /// <p>规则方向，JSON 整数：1 表示入站，0 表示出站。</p><p>RuleUuid 恰为 [-1] 时，本字段决定全量删除的方向；RuleUuid 为具体 ID 列表时，仅按 ID 匹配，不使用 Direction 筛选。字段省略时取值为 -1，不会按出站处理。</p>
        /// </summary>
        [JsonProperty("Direction")]
        public ulong? Direction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "RuleUuid.", this.RuleUuid);
            this.SetParamSimple(map, prefix + "CfwAiAgentOperationSource", this.CfwAiAgentOperationSource);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
        }
    }
}

