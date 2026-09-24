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

    public class CreateRegistryRecordRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>所属 Registry ID。</p>
        /// </summary>
        [JsonProperty("RegistryId")]
        public string RegistryId{ get; set; }

        /// <summary>
        /// <p>Record 名称，长度 1..255，同一租户、Registry 内按规范化 Name 唯一（大小写不敏感）；软删除后允许复用。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>协议描述符类型。MCP / A2A / AGUI / CUSTOM / AGENT_SKILLS。Record 创建后不可修改。</p>
        /// </summary>
        [JsonProperty("DescriptorType")]
        public string DescriptorType{ get; set; }

        /// <summary>
        /// <p>Record 描述，最大 4096 字符，可选，默认空。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Revision 1 的展示名称，可选。</p>
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }

        /// <summary>
        /// <p>DescriptorType=MCP 时必填，其他类型禁止。</p>
        /// </summary>
        [JsonProperty("MCPSource")]
        public CloudMCPSourceInput MCPSource{ get; set; }

        /// <summary>
        /// <p>DescriptorType=A2A 或 AGUI 时必填，其他类型禁止。</p>
        /// </summary>
        [JsonProperty("AgentSource")]
        public CloudAgentSourceInput AgentSource{ get; set; }

        /// <summary>
        /// <p>DescriptorType=AGENT_SKILLS 时必填，其他类型禁止。</p>
        /// </summary>
        [JsonProperty("SkillSource")]
        public CloudSkillSourceInput SkillSource{ get; set; }

        /// <summary>
        /// <p>DescriptorType=CUSTOM 时必填，其他类型禁止。内容必须是 JSON object 字符串；服务端解析后写入 CloudRecordVersion.Descriptors，Version 的 SourceType 固定为 MANUAL、SourceConfig 固定为空对象。</p>
        /// </summary>
        [JsonProperty("CustomDescriptors")]
        public string CustomDescriptors{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegistryId", this.RegistryId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DescriptorType", this.DescriptorType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
            this.SetParamObj(map, prefix + "MCPSource.", this.MCPSource);
            this.SetParamObj(map, prefix + "AgentSource.", this.AgentSource);
            this.SetParamObj(map, prefix + "SkillSource.", this.SkillSource);
            this.SetParamSimple(map, prefix + "CustomDescriptors", this.CustomDescriptors);
        }
    }
}

