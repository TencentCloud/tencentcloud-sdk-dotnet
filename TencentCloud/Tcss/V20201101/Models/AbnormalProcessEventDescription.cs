/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AbnormalProcessEventDescription : AbstractModel
    {
        
        /// <summary>
        /// 事件规则
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 解决方案
        /// </summary>
        [JsonProperty("Solution")]
        public string Solution{ get; set; }

        /// <summary>
        /// 事件备注信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 命中规则详细信息
        /// </summary>
        [JsonProperty("MatchRule")]
        public AbnormalProcessChildRuleInfo MatchRule{ get; set; }

        /// <summary>
        /// 命中规则名称，PROXY_TOOL：代理软件，TRANSFER_CONTROL：横向渗透，ATTACK_CMD：恶意命令，REVERSE_SHELL：反弹shell，FILELESS：无文件程序执行，RISK_CMD：高危命令，ABNORMAL_CHILD_PROC：敏感服务异常子进程启动，USER_DEFINED_RULE：用户自定义规则
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 命中规则的id
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 事件最后一次处理的时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperationTime")]
        public string OperationTime{ get; set; }

        /// <summary>
        /// 命中策略名称：SYSTEM_DEFINED_RULE （系统策略）或  用户自定义的策略名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Solution", this.Solution);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamObj(map, prefix + "MatchRule.", this.MatchRule);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "OperationTime", this.OperationTime);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
        }
    }
}

