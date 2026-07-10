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

    public class ModifySecurityPolicyAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>安全策略 ID，格式为 tls- 后接 8 位字母数字。</p>
        /// </summary>
        [JsonProperty("SecurityPolicyId")]
        public string SecurityPolicyId{ get; set; }

        /// <summary>
        /// <p>修改后的加密套件列表。加密套件用于协商客户端与服务端之间的加密算法。</p><p><strong>配置说明：</strong></p><ul><li>加密套件的可选范围取决于所选的 TLS 协议版本（TLSVersions 参数）。</li><li>只要加密套件被任意一个已选 TLS 版本支持，即可添加到列表中。</li><li>若 TLSVersions 包含 TLSv1.3：可不指定 TLSv1.3 专属加密套件（系统将自动补全全部 TLSv1.3 套件）；若指定，则必须包含全部 TLSv1.3 专属加密套件，不支持仅指定部分。</li></ul><p><strong>获取可用加密套件：</strong><br>请调用 <a href="https://cloud.tencent.com/document/api/1822/133718">DescribeSecurityPolicyCapabilities</a> 接口查询各 TLS 版本支持的加密套件列表。</p><p><strong>注意：</strong> 若不传此参数，则保持原有配置不变。</p>
        /// </summary>
        [JsonProperty("Ciphers")]
        public string[] Ciphers{ get; set; }

        /// <summary>
        /// <p>是否仅执行预检请求。取值：</p><ul><li><strong>true</strong>：仅执行预检请求，不实际修改资源。预检请求将验证参数格式、权限及配置有效性等，帮助您在正式操作前发现潜在问题。</li><li><strong>false</strong>（默认）：执行正常请求，通过预检后将直接修改安全策略。</li></ul>
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// <p>修改后的安全策略名称。用于标识和区分不同的安全策略。</p><p><strong>命名规则：</strong></p><ul><li>长度为 2~128 个字符。</li><li>必须以英文字母或中文开头。</li><li>可包含英文字母、中文、数字、半角句号（.）、下划线（_）和短划线（-）。</li></ul><p><strong>注意：</strong> 若不传此参数，则保持原有名称不变。</p>
        /// </summary>
        [JsonProperty("SecurityPolicyName")]
        public string SecurityPolicyName{ get; set; }

        /// <summary>
        /// <p>修改后的 TLS 协议版本列表。TLS（Transport Layer Security）协议用于保障客户端与负载均衡之间的通信安全。</p><p><strong>可选值：</strong></p><ul><li><strong>TLSv1.0</strong>：兼容性最好，但安全性较低，不推荐在生产环境使用。</li><li><strong>TLSv1.1</strong>：安全性略优于 TLSv1.0，但仍不推荐。</li><li><strong>TLSv1.2</strong>：目前主流的安全协议版本，兼顾安全性与兼容性。</li><li><strong>TLSv1.3</strong>：最新版本，安全性最高，性能更优，推荐优先使用。</li></ul><p><strong>注意：</strong> </p><ul><li>若不传此参数，则保持原有配置不变。</li><li>修改 TLS 版本时，请同步检查 Ciphers 参数的配置是否兼容。</li></ul>
        /// </summary>
        [JsonProperty("TLSVersions")]
        public string[] TLSVersions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecurityPolicyId", this.SecurityPolicyId);
            this.SetParamArraySimple(map, prefix + "Ciphers.", this.Ciphers);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamSimple(map, prefix + "SecurityPolicyName", this.SecurityPolicyName);
            this.SetParamArraySimple(map, prefix + "TLSVersions.", this.TLSVersions);
        }
    }
}

