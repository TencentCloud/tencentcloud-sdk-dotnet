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

    public class AddAclRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 待添加的互联网边界规则列表，不能为空。每条规则都解析并校验方向、源目的、动作、范围、协议端口和模板；整个请求还会校验规则配额及可下发规则数量。批量覆盖的删除方向例外地只取首条规则。
        /// </summary>
        [JsonProperty("Rules")]
        public CreateRuleItem[] Rules{ get; set; }

        /// <summary>
        /// <p>AI操作来源</p><p>枚举值：</p><ul><li>console： 控制台来源值</li><li>wechat： 微信</li></ul>。
        /// </summary>
        [JsonProperty("CfwAiAgentOperationSource")]
        public string CfwAiAgentOperationSource{ get; set; }

        /// <summary>
        /// 添加方式。省略或空字符串执行普通新增；insert_rule 标记为指定位置新增；batch_import 标记为批量导入；batch_import_cover 执行覆盖导入，在独立事务中先删除首条规则 Direction 对应的当前账号可操作分区旧规则，再插入 Rules；删除提交后，插入失败不会恢复旧规则。覆盖导入不会校验 Rules 的 Direction 全部相同，删除范围仍只由首条规则决定。其它字符串未由入口统一拒绝，但不属于本接口定义的支持合同，调用方不得依赖其行为。
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
            this.SetParamSimple(map, prefix + "CfwAiAgentOperationSource", this.CfwAiAgentOperationSource);
            this.SetParamSimple(map, prefix + "From", this.From);
        }
    }
}

