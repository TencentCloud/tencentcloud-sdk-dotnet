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

    public class DeleteBlockIgnoreRuleNewRequest : AbstractModel
    {
        
        /// <summary>
        /// 删除模式，必传且只接受整数 0 或 1。0 表示按 Rules 中的 RuleType 与 Ioc 删除匹配记录；1 表示按 ShowType 清空对应列表，其中 blocklist 删除全部 RuleType=1 记录，whitelist 删除全部 RuleType>=2 记录，风险极高。
        /// </summary>
        [JsonProperty("DeleteAll")]
        public long? DeleteAll{ get; set; }

        /// <summary>
        /// <p>AI操作来源</p><p>枚举值：</p><ul><li>console： 控制台来源值</li><li>wechat： 微信</li></ul>。
        /// </summary>
        [JsonProperty("CfwAiAgentOperationSource")]
        public string CfwAiAgentOperationSource{ get; set; }

        /// <summary>
        /// 可省略。当前处理逻辑不读取该顶层字段；传入值不参与精确删除或整表删除的目标选择。
        /// </summary>
        [JsonProperty("RuleType")]
        public long? RuleType{ get; set; }

        /// <summary>
        /// 待删除规则列表。DeleteAll=0 时必填，每项删除所有与 RuleType、Ioc 匹配的记录；DirectionList 不参与目标匹配，但 RuleType=1、2、3 时必须使用 DescribeBlockIgnoreList 返回的完整方向列表。同一请求混合 RuleType 时，引擎更新使用最后一项的 RuleType。DeleteAll=1 时省略。
        /// </summary>
        [JsonProperty("Rules")]
        public BanAndAllowRuleDel[] Rules{ get; set; }

        /// <summary>
        /// 列表类型，处理时必传且只接受 blocklist 或 whitelist。DeleteAll=1 时，blocklist 选择全部 RuleType=1 记录，whitelist 选择全部 RuleType>=2 记录；DeleteAll=0 时该字段仅校验取值，不限制 Rules 指定的删除目标。
        /// </summary>
        [JsonProperty("ShowType")]
        public string ShowType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeleteAll", this.DeleteAll);
            this.SetParamSimple(map, prefix + "CfwAiAgentOperationSource", this.CfwAiAgentOperationSource);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
            this.SetParamSimple(map, prefix + "ShowType", this.ShowType);
        }
    }
}

