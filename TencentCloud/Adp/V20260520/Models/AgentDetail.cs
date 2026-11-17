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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>Agent ID</p>
        /// </summary>
        [JsonProperty("AgentId")]
        public string AgentId{ get; set; }

        /// <summary>
        /// <p>Agent基本配置</p>
        /// </summary>
        [JsonProperty("Profile")]
        public AgentProfile Profile{ get; set; }

        /// <summary>
        /// <p>系统提示词</p>
        /// </summary>
        [JsonProperty("Instructions")]
        public string Instructions{ get; set; }

        /// <summary>
        /// <p>模型信息</p>
        /// </summary>
        [JsonProperty("Model")]
        public AgentModelConfig Model{ get; set; }

        /// <summary>
        /// <p>工具详情</p>
        /// </summary>
        [JsonProperty("ToolList")]
        public AgentTool[] ToolList{ get; set; }

        /// <summary>
        /// <p>插件配置</p>
        /// </summary>
        [JsonProperty("PluginList")]
        public AgentPlugin[] PluginList{ get; set; }

        /// <summary>
        /// <p>技能详情</p>
        /// </summary>
        [JsonProperty("SkillList")]
        public AgentSkill[] SkillList{ get; set; }

        /// <summary>
        /// <p>高级配置</p>
        /// </summary>
        [JsonProperty("AdvancedConfig")]
        public AgentAdvancedConfig AdvancedConfig{ get; set; }

        /// <summary>
        /// <p>调用方执行的 Function Tool 列表</p><p>入参限制：仅在 C 端用户态 Agent 场景可用，B 端配置态 Agent 忽略该字段与</p>
        /// </summary>
        [JsonProperty("ExternalToolList")]
        public AgentExternalToolConfig[] ExternalToolList{ get; set; }

        /// <summary>
        /// <p>子 Agent 执行来源</p><p>枚举值：</p><ul><li>0： 应用内子 Agent</li><li>1： 引用已发布的应用</li></ul>
        /// </summary>
        [JsonProperty("ProviderType")]
        public long? ProviderType{ get; set; }

        /// <summary>
        /// <p>引用应用的ID</p>
        /// </summary>
        [JsonProperty("ReferenceAppId")]
        public string ReferenceAppId{ get; set; }

        /// <summary>
        /// <p>引用应用状态，ProviderType=1 时有效</p><p>枚举值：</p><ul><li>0： 来源应用可用</li><li>1： 来源应用不可用</li><li>2： 无权限</li><li>3： 嵌套引用: 来源应用线上生效配置中已含应用类子 Agent</li></ul>
        /// </summary>
        [JsonProperty("ReferenceAppStatus")]
        public long? ReferenceAppStatus{ get; set; }

        /// <summary>
        /// <p>引用应用详情，ProviderType=1 时返回</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReferenceApp")]
        public ReferenceAppDetail ReferenceApp{ get; set; }

        /// <summary>
        /// <p>内置工具列表</p>
        /// </summary>
        [JsonProperty("BuiltinToolList")]
        public AgentBuiltinTool[] BuiltinToolList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AgentId", this.AgentId);
            this.SetParamObj(map, prefix + "Profile.", this.Profile);
            this.SetParamSimple(map, prefix + "Instructions", this.Instructions);
            this.SetParamObj(map, prefix + "Model.", this.Model);
            this.SetParamArrayObj(map, prefix + "ToolList.", this.ToolList);
            this.SetParamArrayObj(map, prefix + "PluginList.", this.PluginList);
            this.SetParamArrayObj(map, prefix + "SkillList.", this.SkillList);
            this.SetParamObj(map, prefix + "AdvancedConfig.", this.AdvancedConfig);
            this.SetParamArrayObj(map, prefix + "ExternalToolList.", this.ExternalToolList);
            this.SetParamSimple(map, prefix + "ProviderType", this.ProviderType);
            this.SetParamSimple(map, prefix + "ReferenceAppId", this.ReferenceAppId);
            this.SetParamSimple(map, prefix + "ReferenceAppStatus", this.ReferenceAppStatus);
            this.SetParamObj(map, prefix + "ReferenceApp.", this.ReferenceApp);
            this.SetParamArrayObj(map, prefix + "BuiltinToolList.", this.BuiltinToolList);
        }
    }
}

