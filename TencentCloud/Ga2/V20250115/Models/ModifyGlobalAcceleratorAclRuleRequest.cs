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

namespace TencentCloud.Ga2.V20250115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyGlobalAcceleratorAclRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>全球加速实例ID。</p>
        /// </summary>
        [JsonProperty("GlobalAcceleratorId")]
        public string GlobalAcceleratorId{ get; set; }

        /// <summary>
        /// <p>安全策略ID</p>
        /// </summary>
        [JsonProperty("GlobalAcceleratorAclPolicyId")]
        public string GlobalAcceleratorAclPolicyId{ get; set; }

        /// <summary>
        /// <p>Acl规则ID。</p>
        /// </summary>
        [JsonProperty("GlobalAcceleratorAclRuleId")]
        public string GlobalAcceleratorAclRuleId{ get; set; }

        /// <summary>
        /// <p>协议。</p><p>入参限制：支持选择&#39;TCP&#39;, &#39;UDP&#39;, &#39;ALL&#39;。</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>端口。</p>
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// <p>网段。</p>
        /// </summary>
        [JsonProperty("SourceCidrBlock")]
        public string SourceCidrBlock{ get; set; }

        /// <summary>
        /// <p>动作。</p><p>入参限制：支持选择&#39;ACCEPT&#39;, &#39;DROP&#39;。</p><p>枚举值：</p><ul><li>ACCEPT： 允许。</li><li>DROP： 拒绝。</li></ul>
        /// </summary>
        [JsonProperty("Policy")]
        public string Policy{ get; set; }

        /// <summary>
        /// <p>描述信息，最大长度不能超过100个字节。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GlobalAcceleratorId", this.GlobalAcceleratorId);
            this.SetParamSimple(map, prefix + "GlobalAcceleratorAclPolicyId", this.GlobalAcceleratorAclPolicyId);
            this.SetParamSimple(map, prefix + "GlobalAcceleratorAclRuleId", this.GlobalAcceleratorAclRuleId);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "SourceCidrBlock", this.SourceCidrBlock);
            this.SetParamSimple(map, prefix + "Policy", this.Policy);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

