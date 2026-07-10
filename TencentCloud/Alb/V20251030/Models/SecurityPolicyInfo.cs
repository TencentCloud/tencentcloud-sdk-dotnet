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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecurityPolicyInfo : AbstractModel
    {
        
        /// <summary>
        /// 支持的加密套件列表。
        /// 支持的加密套件，具体依赖 TLSVersions 的取值。
        /// Cipher 只要被任何一个传入的 TLSVersions 支持即可。
        /// 
        /// 说明：若选择了 TLSv1.3，那么 Cipher 列表必须包含 TLSv1.3 支持的 Cipher。
        /// 
        /// 请调用 DescribeSecurityPolicyCapabilities 接口获取支持的加密套件列表。
        /// </summary>
        [JsonProperty("Ciphers")]
        public string[] Ciphers{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 安全策略 ID，格式为 tls- 后接 8 位字母数字。
        /// </summary>
        [JsonProperty("SecurityPolicyId")]
        public string SecurityPolicyId{ get; set; }

        /// <summary>
        /// 安全策略名称。长度为2~128个英文或中文字符，必须以字母或中文开头，可包含数字、半角句号（.）、下划线（_）和短划线（-）。
        /// </summary>
        [JsonProperty("SecurityPolicyName")]
        public string SecurityPolicyName{ get; set; }

        /// <summary>
        /// 安全策略状态。当前接口最常返回 Active，表示安全策略处于可用状态。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 支持的 TLS 协议版本列表。可选值包括：TLSv1.0、TLSv1.1、TLSv1.2、TLSv1.3。
        /// </summary>
        [JsonProperty("TLSVersions")]
        public string[] TLSVersions{ get; set; }

        /// <summary>
        /// 标签信息。
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Ciphers.", this.Ciphers);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "SecurityPolicyId", this.SecurityPolicyId);
            this.SetParamSimple(map, prefix + "SecurityPolicyName", this.SecurityPolicyName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "TLSVersions.", this.TLSVersions);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

