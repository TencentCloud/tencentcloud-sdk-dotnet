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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GuardrailConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Guardrail 防护配置 ID。</p><p>DescribeModelRouterGuardrails 会返回该字段；DisassociateModelRouterGuardrails 和 ModifyModelRouterGuardrails 需要使用该字段定位要操作的防护配置。</p>
        /// </summary>
        [JsonProperty("GuardrailId")]
        public string GuardrailId{ get; set; }

        /// <summary>
        /// <p>Guardrail 防护类型。</p><p>枚举值：</p><ul><li>WAF：使用腾讯云 WAF LLM SDK 接入配置对模型路由请求进行安全防护。</li></ul><p>当前仅支持 WAF；AssociateModelRouterGuardrails 不传时默认为 WAF，ModifyModelRouterGuardrails 不传时沿用当前已关联 Guardrail 的 Type。</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>关联的腾讯云 WAF 实例 ID。</p><p>ModifyModelRouterGuardrails 在 Type 为 WAF 时必填。DescribeModelRouterGuardrails 返回。接口会校验该 WAF 实例存在且属于当前账号。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>WAF LLM SDK 接入服务 ID。</p><p>该字段对应 WAF LLM SDK 接入配置中的服务标识，用于指定模型路由请求要绑定的 WAF 防护配置。ModifyModelRouterGuardrails 在 Type 为 WAF 时必填。DescribeModelRouterGuardrails 返回。接口会校验该服务配置存在于指定的 WAF 实例下。</p>
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// <p>最大检测对话轮数。</p><p>ModifyModelRouterGuardrails 选填；未传时沿用当前已关联 Guardrail 的 InputCheckDepth。DescribeModelRouterGuardrails 返回。若传入，取值必须为正整数。</p>
        /// </summary>
        [JsonProperty("InputCheckDepth")]
        public ulong? InputCheckDepth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GuardrailId", this.GuardrailId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "InputCheckDepth", this.InputCheckDepth);
        }
    }
}

