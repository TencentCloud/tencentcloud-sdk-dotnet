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

    public class ModifyModelRouterGuardrailsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>待修改的 Guardrail 防护配置列表。</p><p>当前最多支持 1 个元素。每个元素必须填写 GuardrailId；当 Type 为 WAF 或未传按 WAF 处理时，InstanceId 和 ServiceId 必填；InputCheckDepth 为选填，不传时沿用当前已关联 Guardrail 的取值。</p>
        /// </summary>
        [JsonProperty("Guardrails")]
        public GuardrailConfig[] Guardrails{ get; set; }

        /// <summary>
        /// <p>模型路由实例 ID。</p>
        /// </summary>
        [JsonProperty("ModelRouterId")]
        public string ModelRouterId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Guardrails.", this.Guardrails);
            this.SetParamSimple(map, prefix + "ModelRouterId", this.ModelRouterId);
        }
    }
}

