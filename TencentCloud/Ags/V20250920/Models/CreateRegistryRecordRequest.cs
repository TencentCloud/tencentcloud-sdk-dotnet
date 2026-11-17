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
        /// <p>资产类型。取值包括 MCP、A2A、AGUI、CUSTOM、AGENT_SKILLS 和 PLUGIN。Record 创建后不可修改。PLUGIN 按通用文件资产保存，由运行端解析和加载。</p>
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
        /// <p>Plugin 通用文件来源。DescriptorType=PLUGIN 时必填，其他类型禁止。</p><p>入参限制：Create 仅支持 Type=FILE；声明 SizeBytes 为 1..54525952 字节，可选 SHA256 为 64 位小写十六进制摘要。</p><p>Registry 保存原始文件，不校验插件内容格式或语义；由运行端解析和加载。Skill 继续使用原 SkillSource。</p>
        /// </summary>
        [JsonProperty("FileSource")]
        public CloudFileSourceInput FileSource{ get; set; }

        /// <summary>
        /// <p>本版本支持的 HarnessVersionReference 对象列表；每项包含 HarnessEngine 和 HarnessEngineVersion，原样使用 DescribeHarnessEngineList 返回的选项。</p><p>入参限制：两个字段均必填，各为 1 至 128 字符的精确值，区分大小写，不含空白、通配符或版本范围；最多 128 项，按引擎与版本二元组去重。不接受旧字符串数组、null、缺少字段或额外字段。</p><p>省略或空数组表示未声明，不继承前一版本，不代表支持所有 Harness。兼容性按同一对象的引擎与版本共同判断。修改兼容声明需创建新 Version，文件资产可通过 FileSource.Type=VERSION 复用制品。</p>
        /// </summary>
        [JsonProperty("SupportedHarnessVersions")]
        public HarnessVersionReference[] SupportedHarnessVersions{ get; set; }

        /// <summary>
        /// <p>版本元数据的 Name/Value 对象数组。</p><p>参数格式：每项仅包含必填的 Name、Value 两个字符串字段。Name 非空、小写且数组内唯一，不自动转换；重复 Name 即使 Value 相同也返回 InvalidParameter。Value 允许空字符串，保留大小写；不接受嵌套对象、数组或非字符串值。</p><p>默认值：空数组 []。创建新版本时省略或 [] 均为空，不继承；null、JSON 字符串和原生对象非法。响应按 Name 升序返回，旧 SQL NULL 归一为 []。服务内部使用 map[string]string，数据库 JSON 列保存对象。publisher 表示发布者展示名称；metadata.&lt;key&gt; 按完整小写名称精确筛选，规则不变。</p>
        /// </summary>
        [JsonProperty("Metadata")]
        public MetadataEntry[] Metadata{ get; set; }


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
            this.SetParamObj(map, prefix + "FileSource.", this.FileSource);
            this.SetParamArrayObj(map, prefix + "SupportedHarnessVersions.", this.SupportedHarnessVersions);
            this.SetParamArrayObj(map, prefix + "Metadata.", this.Metadata);
        }
    }
}

