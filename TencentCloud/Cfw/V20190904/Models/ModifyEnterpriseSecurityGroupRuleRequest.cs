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

    public class ModifyEnterpriseSecurityGroupRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 修改类型，仅接受 0、1、2。0：用 Data 完整替换 RuleUuid 指定规则的可写内容；1：修改 RuleUuid 指定规则的启停状态；2：修改当前账号全部可操作规则的启停状态。
        /// </summary>
        [JsonProperty("ModifyType")]
        public ulong? ModifyType{ get; set; }

        /// <summary>
        /// 规则数值 ID。ModifyType=0 或 1 时，调用 DescribeCfwRules，传 RuleType=enterprise_sg、RuleId=<数值 RuleUuid>、ExpandNames=false，并使用返回的 rules[].uuid；ModifyType=2 时传 0。
        /// </summary>
        [JsonProperty("RuleUuid")]
        public ulong? RuleUuid{ get; set; }

        /// <summary>
        /// <p>AI操作来源</p><p>枚举值：</p><ul><li>console： 控制台来源值</li><li>wechat： 微信</li></ul>。
        /// </summary>
        [JsonProperty("CfwAiAgentOperationSource")]
        public string CfwAiAgentOperationSource{ get; set; }

        /// <summary>
        /// ModifyType=0 时必填的完整规则内容对象，不是局部更新。调用 DescribeCfwRules，传 RuleType=enterprise_sg、RuleId=<数值 RuleUuid>、ExpandNames=false 获取原规则：src_content、dst_content 分别写入 SourceContent、DestContent；src_type 和 dst_type 的 0、1/2/3/4/5/6/16/24/25、7、8、9/10、100 分别对应 net、instance、template、tag、region、resourcegroup，DestType 的 20 对应 dnsparse；未列出的数值类型不能转换。再调用 DescribeEnterpriseSecurityGroupRule，使用同一 RuleUuid 获取 OrderIndex、Protocol、Port、RuleAction、Description、Scope 和 ServiceTemplateId。缺失字段按空值处理，仅 Scope 省略时保留原值。ModifyType=1 或 2 时不传 Data。
        /// </summary>
        [JsonProperty("Data")]
        public SecurityGroupRule Data{ get; set; }

        /// <summary>
        /// 规则状态，JSON 整数：0 表示关闭，1 表示开启。ModifyType=1 时修改 RuleUuid 指定规则，ModifyType=2 时修改当前账号的全部可操作规则；这两种模式下应显式填写。ModifyType=0 时忽略该字段。
        /// </summary>
        [JsonProperty("Enable")]
        public ulong? Enable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModifyType", this.ModifyType);
            this.SetParamSimple(map, prefix + "RuleUuid", this.RuleUuid);
            this.SetParamSimple(map, prefix + "CfwAiAgentOperationSource", this.CfwAiAgentOperationSource);
            this.SetParamObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
        }
    }
}

