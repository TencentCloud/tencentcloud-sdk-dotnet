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

    public class ModifyAIGWCustomGuardrailPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>网关实例 ID</p>
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// <p>策略 ID</p>
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// <p>策略名称，长度 1～64</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>策略描述，最长 200；传空字符串可清空</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>是否启用策略</p>
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// <p>审核服务局部更新配置</p>
        /// </summary>
        [JsonProperty("ServiceConfig")]
        public CustomGuardrailServiceConfigPatch ServiceConfig{ get; set; }

        /// <summary>
        /// <p>审核服务鉴权局部更新配置</p>
        /// </summary>
        [JsonProperty("AuthConfig")]
        public CustomGuardrailAuthConfigPatch AuthConfig{ get; set; }

        /// <summary>
        /// <p>审核响应判定局部更新配置</p>
        /// </summary>
        [JsonProperty("DecisionConfig")]
        public CustomGuardrailDecisionConfigPatch DecisionConfig{ get; set; }

        /// <summary>
        /// <p>处理行为局部更新配置</p>
        /// </summary>
        [JsonProperty("BehaviorConfig")]
        public CustomGuardrailBehaviorConfigPatch BehaviorConfig{ get; set; }

        /// <summary>
        /// <p>过滤与采样局部更新配置</p>
        /// </summary>
        [JsonProperty("FilterConfig")]
        public CustomGuardrailFilterConfigPatch FilterConfig{ get; set; }

        /// <summary>
        /// <p>资源绑定范围，global 或 resource。修改时传入的是新的完整范围，不是增量追加。</p>
        /// </summary>
        [JsonProperty("Scope")]
        public CustomGuardrailScopeInput Scope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamObj(map, prefix + "ServiceConfig.", this.ServiceConfig);
            this.SetParamObj(map, prefix + "AuthConfig.", this.AuthConfig);
            this.SetParamObj(map, prefix + "DecisionConfig.", this.DecisionConfig);
            this.SetParamObj(map, prefix + "BehaviorConfig.", this.BehaviorConfig);
            this.SetParamObj(map, prefix + "FilterConfig.", this.FilterConfig);
            this.SetParamObj(map, prefix + "Scope.", this.Scope);
        }
    }
}

