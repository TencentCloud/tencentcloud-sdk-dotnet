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

    public class RemoveVpcAcRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>待删除规则 ID 列表。具体规则 ID 通过 DescribeCfwRules 查询 RuleType=vpc 和目标 RuleUuid，并使用返回的 rules[].uuid。数组恰为 [-1] 时删除当前账号中 IpVersion 指定版本的全部可操作规则，风险极高；其它数组按 ID 批量删除。具体 ID 删除忽略 IpVersion；至少匹配一条即成功，全部未找到时返回 ResourceNotFound。成功响应回显请求中的 ID 列表。</p>
        /// </summary>
        [JsonProperty("RuleUuids")]
        public long?[] RuleUuids{ get; set; }

        /// <summary>
        /// <p>AI操作来源</p><p>枚举值：</p><ul><li>console： 控制台来源值</li><li>wechat： 微信</li></ul>。
        /// </summary>
        [JsonProperty("CfwAiAgentOperationSource")]
        public string CfwAiAgentOperationSource{ get; set; }

        /// <summary>
        /// <p>IP 版本，仅 RuleUuids 恰为 [-1] 时生效：1 表示 IPv6，0、省略或其它整数表示 IPv4。按具体规则 ID 删除时忽略。</p>
        /// </summary>
        [JsonProperty("IpVersion")]
        public ulong? IpVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "RuleUuids.", this.RuleUuids);
            this.SetParamSimple(map, prefix + "CfwAiAgentOperationSource", this.CfwAiAgentOperationSource);
            this.SetParamSimple(map, prefix + "IpVersion", this.IpVersion);
        }
    }
}

