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

namespace TencentCloud.Ags.V20250920.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateRegistryRecordRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Registry ID。</p>
        /// </summary>
        [JsonProperty("RegistryId")]
        public string RegistryId{ get; set; }

        /// <summary>
        /// <p>Record ID。</p>
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// <p>Record 描述，可选。Record 更新模式下允许，允许空字符串清空；Version 创建模式禁止。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>新 Version 的展示名，可选。仅 Version 创建模式允许。</p>
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }

        /// <summary>
        /// <p>新 Version 的变更原因，最大 4096 字符，可选。仅 Version 创建模式允许。</p>
        /// </summary>
        [JsonProperty("ChangeLog")]
        public string ChangeLog{ get; set; }

        /// <summary>
        /// <p>Version 创建模式：现有 Record 的 DescriptorType=MCP 时可提交。</p>
        /// </summary>
        [JsonProperty("MCPSource")]
        public CloudMCPSourceInput MCPSource{ get; set; }

        /// <summary>
        /// <p>Version 创建模式：现有 Record 的 DescriptorType=A2A 或 AGUI 时可提交。</p>
        /// </summary>
        [JsonProperty("AgentSource")]
        public CloudAgentSourceInput AgentSource{ get; set; }

        /// <summary>
        /// <p>Version 创建模式：现有 Record 的 DescriptorType=AGENT_SKILLS 时可提交。</p>
        /// </summary>
        [JsonProperty("SkillSource")]
        public CloudSkillSourceInput SkillSource{ get; set; }

        /// <summary>
        /// <p>Version 创建模式：现有 Record 的 DescriptorType=CUSTOM 时可提交，必须是 JSON object 字符串。</p>
        /// </summary>
        [JsonProperty("CustomDescriptors")]
        public string CustomDescriptors{ get; set; }

        /// <summary>
        /// <p>Record 更新模式：Label 变更列表，最多 32 条，同一次请求中 Label Name 不可重复。</p>
        /// </summary>
        [JsonProperty("LabelMutations")]
        public CloudRecordLabelMutation[] LabelMutations{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegistryId", this.RegistryId);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
            this.SetParamSimple(map, prefix + "ChangeLog", this.ChangeLog);
            this.SetParamObj(map, prefix + "MCPSource.", this.MCPSource);
            this.SetParamObj(map, prefix + "AgentSource.", this.AgentSource);
            this.SetParamObj(map, prefix + "SkillSource.", this.SkillSource);
            this.SetParamSimple(map, prefix + "CustomDescriptors", this.CustomDescriptors);
            this.SetParamArrayObj(map, prefix + "LabelMutations.", this.LabelMutations);
        }
    }
}

