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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySecurityRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 规则名：不得超过30个字符，超过部分会被截断。
        /// </summary>
        [JsonProperty("AliasName")]
        public string AliasName{ get; set; }

        /// <summary>
        /// 安全策略ID
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// 安全规则动作
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }

        /// <summary>
        /// 规则关联地址，格式需要满足CIDR网络地址规范
        /// </summary>
        [JsonProperty("SourceCidr")]
        public string SourceCidr{ get; set; }

        /// <summary>
        /// 协议类型
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 端口范围，支持以下格式
        /// 单个端口: 80
        /// 多个端口: 80,443
        /// 连续端口: 3306-20000
        /// 所有端口: ALL
        /// </summary>
        [JsonProperty("DestPortRange")]
        public string DestPortRange{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "AliasName", this.AliasName);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamSimple(map, prefix + "SourceCidr", this.SourceCidr);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "DestPortRange", this.DestPortRange);
        }
    }
}

