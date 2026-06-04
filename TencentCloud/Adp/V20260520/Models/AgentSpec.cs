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

    public class AgentSpec : AbstractModel
    {
        
        /// <summary>
        /// <p>Agent基本配置</p>
        /// </summary>
        [JsonProperty("Profile")]
        public AgentProfile Profile{ get; set; }

        /// <summary>
        /// 系统提示词
        /// </summary>
        [JsonProperty("Instructions")]
        public string Instructions{ get; set; }

        /// <summary>
        /// 主模型配置
        /// </summary>
        [JsonProperty("Model")]
        public AgentModelConfig Model{ get; set; }

        /// <summary>
        /// <p>工具信息</p>
        /// </summary>
        [JsonProperty("ToolList")]
        public AgentToolConfig[] ToolList{ get; set; }

        /// <summary>
        /// <p>插件信息</p>
        /// </summary>
        [JsonProperty("PluginList")]
        public AgentPluginConfig[] PluginList{ get; set; }

        /// <summary>
        /// <p>技能信息</p>
        /// </summary>
        [JsonProperty("SkillList")]
        public AgentSkillConfig[] SkillList{ get; set; }

        /// <summary>
        /// 高级设置
        /// </summary>
        [JsonProperty("AdvancedConfig")]
        public AgentAdvancedConfig AdvancedConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Profile.", this.Profile);
            this.SetParamSimple(map, prefix + "Instructions", this.Instructions);
            this.SetParamObj(map, prefix + "Model.", this.Model);
            this.SetParamArrayObj(map, prefix + "ToolList.", this.ToolList);
            this.SetParamArrayObj(map, prefix + "PluginList.", this.PluginList);
            this.SetParamArrayObj(map, prefix + "SkillList.", this.SkillList);
            this.SetParamObj(map, prefix + "AdvancedConfig.", this.AdvancedConfig);
        }
    }
}

