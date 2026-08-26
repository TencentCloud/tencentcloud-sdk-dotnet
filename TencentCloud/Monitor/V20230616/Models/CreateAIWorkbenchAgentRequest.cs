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

namespace TencentCloud.Monitor.V20230616.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAIWorkbenchAgentRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Agent 名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Agent 描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Agent 分类</p>
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// <p>Agent 标签</p>
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// <p>Agent 提示词</p>
        /// </summary>
        [JsonProperty("Instruction")]
        public InstructionConfig Instruction{ get; set; }

        /// <summary>
        /// <p>关联技能 ID 列表</p>
        /// </summary>
        [JsonProperty("SkillIds")]
        public string[] SkillIds{ get; set; }

        /// <summary>
        /// <p>来源: builtin / custom</p>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// <p>关联的资源地图 ID</p>
        /// </summary>
        [JsonProperty("ResourceMapId")]
        public string ResourceMapId{ get; set; }

        /// <summary>
        /// <p>关联的mcp工具</p>
        /// </summary>
        [JsonProperty("MCPIds")]
        public string[] MCPIds{ get; set; }

        /// <summary>
        /// <p>资源标签</p>
        /// </summary>
        [JsonProperty("CamTags")]
        public Tag[] CamTags{ get; set; }

        /// <summary>
        /// <p>agent运行时环境变量</p>
        /// </summary>
        [JsonProperty("EnvVars")]
        public EnvVar[] EnvVars{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "Instruction.", this.Instruction);
            this.SetParamArraySimple(map, prefix + "SkillIds.", this.SkillIds);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "ResourceMapId", this.ResourceMapId);
            this.SetParamArraySimple(map, prefix + "MCPIds.", this.MCPIds);
            this.SetParamArrayObj(map, prefix + "CamTags.", this.CamTags);
            this.SetParamArrayObj(map, prefix + "EnvVars.", this.EnvVars);
        }
    }
}

