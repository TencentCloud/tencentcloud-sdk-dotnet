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
        /// <p>Skill 或 Plugin 后续版本的文件来源。PLUGIN 可使用 FILE 上传新文件，或使用 VERSION 复用同一 Record 的 READY 制品；Skill 仅通过 VERSION 复用现有文件。与其他内容来源互斥。</p><p>VERSION 只提交 Type、SourceVersionId；Metadata 和 SupportedHarnessVersions 由本次请求单独声明，不继承来源版本。</p>
        /// </summary>
        [JsonProperty("FileSource")]
        public CloudFileSourceInput FileSource{ get; set; }

        /// <summary>
        /// <p>资产版本支持的 Harness 引擎与具体版本列表。每个元素同时包含 HarnessEngine 和 HarnessEngineVersion，取值原样使用 DescribeHarnessEngineList 返回的选项。</p><p>入参限制：最多 128 个元素；两个字段均必填，长度 1～128，区分大小写，不允许空白、通配符或版本范围。按完整配对去重；不接受字符串数组或 null。</p><p>省略或空数组表示未声明兼容性，不表示兼容全部。仅随新 Version 写入，后续修改需创建新 Version。筛选时 supported_harness_engine 与 supported_harness_version 必须同时传入，并在同一元素中精确匹配。</p>
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
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
            this.SetParamSimple(map, prefix + "ChangeLog", this.ChangeLog);
            this.SetParamObj(map, prefix + "MCPSource.", this.MCPSource);
            this.SetParamObj(map, prefix + "AgentSource.", this.AgentSource);
            this.SetParamObj(map, prefix + "SkillSource.", this.SkillSource);
            this.SetParamSimple(map, prefix + "CustomDescriptors", this.CustomDescriptors);
            this.SetParamArrayObj(map, prefix + "LabelMutations.", this.LabelMutations);
            this.SetParamObj(map, prefix + "FileSource.", this.FileSource);
            this.SetParamArrayObj(map, prefix + "SupportedHarnessVersions.", this.SupportedHarnessVersions);
            this.SetParamArrayObj(map, prefix + "Metadata.", this.Metadata);
        }
    }
}

