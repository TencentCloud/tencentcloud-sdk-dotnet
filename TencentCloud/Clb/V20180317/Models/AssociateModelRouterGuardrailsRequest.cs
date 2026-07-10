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

    public class AssociateModelRouterGuardrailsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>待关联的 Guardrail 防护配置列表。</p><p>当前最多支持 1 个元素。每个元素必须填写 InstanceId、ServiceId；Type 和 InputCheckDepth 为选填，不传时分别使用默认值 WAF 和 5。本结构不包含 GuardrailId，关联成功后由系统生成。</p>
        /// </summary>
        [JsonProperty("Guardrails")]
        public AssociateGuardrailConfig[] Guardrails{ get; set; }

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

