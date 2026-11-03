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

    public class CustomGuardrailPolicy : AbstractModel
    {
        
        /// <summary>
        /// <p>策略 ID</p>
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// <p>策略名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>策略描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>策略期望启用状态；实际生效还需检查 EffectiveEnabled 和 SyncStatus。</p>
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// <p>当前控制面计算值：Enabled=true 且 SyncStatus=synced 时为 true。不代表一次真实业务请求已通过审核，也不替代 DP 同步/链路验证。</p>
        /// </summary>
        [JsonProperty("EffectiveEnabled")]
        public bool? EffectiveEnabled{ get; set; }

        /// <summary>
        /// <p>审核服务配置</p>
        /// </summary>
        [JsonProperty("ServiceConfig")]
        public CustomGuardrailServiceConfig ServiceConfig{ get; set; }

        /// <summary>
        /// <p>审核引擎鉴权的脱敏视图，仅返回鉴权类型、Header 名和密钥存在状态，不返回 ApiKey。</p>
        /// </summary>
        [JsonProperty("AuthConfig")]
        public CustomGuardrailAuthConfig AuthConfig{ get; set; }

        /// <summary>
        /// <p>审核响应判定配置</p>
        /// </summary>
        [JsonProperty("DecisionConfig")]
        public CustomGuardrailDecisionConfig DecisionConfig{ get; set; }

        /// <summary>
        /// <p>处理行为配置</p>
        /// </summary>
        [JsonProperty("BehaviorConfig")]
        public CustomGuardrailBehaviorConfig BehaviorConfig{ get; set; }

        /// <summary>
        /// <p>过滤与采样配置</p>
        /// </summary>
        [JsonProperty("FilterConfig")]
        public CustomGuardrailFilterConfig FilterConfig{ get; set; }

        /// <summary>
        /// <p>生效范围</p>
        /// </summary>
        [JsonProperty("Scope")]
        public CustomGuardrailScope Scope{ get; set; }

        /// <summary>
        /// <p>业务资源到 Kong Route 的绑定及插件投影信息，一个业务资源可能对应多个 Route。</p>
        /// </summary>
        [JsonProperty("Bindings")]
        public CustomGuardrailPolicyBinding[] Bindings{ get; set; }

        /// <summary>
        /// <p>同步状态：pending 待同步，synced 已完成本次配置同步，partial 部分失败，failed 失败。需结合 FailedResources/SyncError；synced 不等于已完成所有数据面实例的业务端到端验证。</p>
        /// </summary>
        [JsonProperty("SyncStatus")]
        public string SyncStatus{ get; set; }

        /// <summary>
        /// <p>配置同步错误摘要，无错误时可能省略。</p>
        /// </summary>
        [JsonProperty("SyncError")]
        public string SyncError{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>最后修改时间</p>
        /// </summary>
        [JsonProperty("ModificationTime")]
        public string ModificationTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "EffectiveEnabled", this.EffectiveEnabled);
            this.SetParamObj(map, prefix + "ServiceConfig.", this.ServiceConfig);
            this.SetParamObj(map, prefix + "AuthConfig.", this.AuthConfig);
            this.SetParamObj(map, prefix + "DecisionConfig.", this.DecisionConfig);
            this.SetParamObj(map, prefix + "BehaviorConfig.", this.BehaviorConfig);
            this.SetParamObj(map, prefix + "FilterConfig.", this.FilterConfig);
            this.SetParamObj(map, prefix + "Scope.", this.Scope);
            this.SetParamArrayObj(map, prefix + "Bindings.", this.Bindings);
            this.SetParamSimple(map, prefix + "SyncStatus", this.SyncStatus);
            this.SetParamSimple(map, prefix + "SyncError", this.SyncError);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModificationTime", this.ModificationTime);
        }
    }
}

