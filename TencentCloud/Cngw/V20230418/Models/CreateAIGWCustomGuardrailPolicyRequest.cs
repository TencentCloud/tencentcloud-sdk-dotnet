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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAIGWCustomGuardrailPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>网关实例 ID</p>
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// <p>策略名称，同一网关内唯一，长度 1～64</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>审核服务配置</p>
        /// </summary>
        [JsonProperty("ServiceConfig")]
        public CustomGuardrailServiceConfigInput ServiceConfig{ get; set; }

        /// <summary>
        /// <p>审核响应判定配置</p>
        /// </summary>
        [JsonProperty("DecisionConfig")]
        public CustomGuardrailDecisionConfigInput DecisionConfig{ get; set; }

        /// <summary>
        /// <p>资源绑定范围，global 或 resource。修改时传入的是新的完整范围，不是增量追加。</p>
        /// </summary>
        [JsonProperty("Scope")]
        public CustomGuardrailScopeInput Scope{ get; set; }

        /// <summary>
        /// <p>必填，必须显式选择鉴权类型；无鉴权填写 {"AuthType":"none"}。</p>
        /// </summary>
        [JsonProperty("AuthConfig")]
        public CustomGuardrailAuthConfigInput AuthConfig{ get; set; }

        /// <summary>
        /// <p>必填，Direction、HandleAction、TimeoutMs、FailureMode 四项均须显式填写。</p>
        /// </summary>
        [JsonProperty("BehaviorConfig")]
        public CustomGuardrailBehaviorConfigInput BehaviorConfig{ get; set; }

        /// <summary>
        /// <p>策略描述，最长 200</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>是否启用策略，默认 true</p>
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// <p>过滤与采样配置</p>
        /// </summary>
        [JsonProperty("FilterConfig")]
        public CustomGuardrailFilterConfigInput FilterConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "ServiceConfig.", this.ServiceConfig);
            this.SetParamObj(map, prefix + "DecisionConfig.", this.DecisionConfig);
            this.SetParamObj(map, prefix + "Scope.", this.Scope);
            this.SetParamObj(map, prefix + "AuthConfig.", this.AuthConfig);
            this.SetParamObj(map, prefix + "BehaviorConfig.", this.BehaviorConfig);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamObj(map, prefix + "FilterConfig.", this.FilterConfig);
        }
    }
}

