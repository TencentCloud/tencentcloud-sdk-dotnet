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

    public class CloudRecordVersion : AbstractModel
    {
        
        /// <summary>
        /// <p>Version ID；格式 <code>rv-</code> + 8 位小写字母/数字。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }

        /// <summary>
        /// <p>所属 Record ID。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// <p>Version 递增序号（1 起）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Revision")]
        public long? Revision{ get; set; }

        /// <summary>
        /// <p>Version 状态。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>审批模式；创建时锁定，后续变更 Registry 审批模式不影响本 Version。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApprovalMode")]
        public string ApprovalMode{ get; set; }

        /// <summary>
        /// <p>所属租户 AppId。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>创建者主账号 UIN。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatorUin")]
        public string CreatorUin{ get; set; }

        /// <summary>
        /// <p>创建时间。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>最近一次更新时间。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>Version 别名（可选）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }

        /// <summary>
        /// <p>协议描述符对象。（JSON 字符串形式）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Descriptors")]
        public string Descriptors{ get; set; }

        /// <summary>
        /// <p>内容来源。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// <p>规范化来源配置对象。（JSON 字符串形式）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceConfig")]
        public string SourceConfig{ get; set; }

        /// <summary>
        /// <p>内容状态。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContentStatus")]
        public string ContentStatus{ get; set; }

        /// <summary>
        /// <p>READY 内容 SHA-256。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContentSHA256")]
        public string ContentSHA256{ get; set; }

        /// <summary>
        /// <p>READY 内容字节数。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContentSizeBytes")]
        public long? ContentSizeBytes{ get; set; }

        /// <summary>
        /// <p>配置内容规范化后的 SHA-256（用于幂等去重）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigSHA256")]
        public string ConfigSHA256{ get; set; }

        /// <summary>
        /// <p>创建者子账号 UIN。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatorSubAccountUin")]
        public string CreatorSubAccountUin{ get; set; }

        /// <summary>
        /// <p>Version 历次审批动作。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApprovalActions")]
        public CloudVersionApprovalAction[] ApprovalActions{ get; set; }

        /// <summary>
        /// <p>文件内容就绪时间，UTC RFC3339 格式。</p><p>仅 TAR_PACKAGE 或 FILE 来源且 ContentStatus=READY 的版本返回；其他来源或未就绪文件为空。Skill 沿用现有 TAR 内容校验机制，Plugin 仅确认文件大小和完整性。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContentReadyTime")]
        public string ContentReadyTime{ get; set; }

        /// <summary>
        /// <p>本次 Version 的变更原因，最大 4096 字符；不可修改。Revision 1 或未填写时返回空字符串。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChangeLog")]
        public string ChangeLog{ get; set; }

        /// <summary>
        /// <p>当前绑定该 Version 的 Label Name 列表（例如 stable / latest 或自定义 Label 名称）。未绑定 Label 不在此返回。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LabelSet")]
        public string[] LabelSet{ get; set; }

        /// <summary>
        /// <p>该资产版本支持的 Harness 引擎与具体版本对象列表。</p><p>参数格式：元素为 HarnessVersionReference，包含必填的 HarnessEngine 和 HarnessEngineVersion，原样使用 DescribeHarnessEngineList 返回值；每个字段 1 至 128 字符，最多 128 项，按二元组区分大小写去重。不使用拼接标识、通配符或版本范围。</p><p>默认值：[]</p><p>随版本创建，不继承。省略或空列表表示未声明，不代表支持所有 Harness。旧字符串快照按未声明返回 []，不推断引擎，不匹配兼容筛选。supported_harness_engine 和 supported_harness_version 必须同时传入并精确匹配同一个对象；Managed Harness 按目标引擎与版本二元组校验。</p>
        /// </summary>
        [JsonProperty("SupportedHarnessVersions")]
        public HarnessVersionReference[] SupportedHarnessVersions{ get; set; }

        /// <summary>
        /// <p>版本元数据的 Name/Value 对象数组。</p><p>参数格式：每项仅包含必填的 Name、Value 两个字符串字段。Name 非空、小写且数组内唯一，不自动转换；重复 Name 即使 Value 相同也返回 InvalidParameter。Value 允许空字符串，保留大小写；不接受嵌套对象、数组或非字符串值。</p><p>默认值：空数组 []。创建新版本时省略或 [] 均为空，不继承；null、JSON 字符串和原生对象非法。响应按 Name 升序返回，旧 SQL NULL 归一为 []。服务内部使用 map[string]string，数据库 JSON 列保存对象。publisher 表示发布者展示名称；metadata.&lt;key&gt; 按完整小写名称精确筛选，规则不变。</p>
        /// </summary>
        [JsonProperty("Metadata")]
        public MetadataEntry[] Metadata{ get; set; }

        /// <summary>
        /// <p>所属 Record 当前的名称。仅 DescribeRegistryRecordVersionList 在普通模式和市场模式中返回，用于卡片展示。</p><p>展示投影不保存到不可变版本快照；其他返回版本信息的接口可不包含此字段。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>所属 Record 当前的描述。仅 DescribeRegistryRecordVersionList 在普通模式和市场模式中返回，允许为空字符串。</p><p>Record 描述更新后，列表查询同步反映新值，包括空字符串；固定 VersionId、Descriptors 和其他版本内容不变。其他返回版本信息的接口可不包含此字段。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>所属 Record 的底层资产类型。仅 DescribeRegistryRecordVersionList 在普通模式和市场模式中返回，用于卡片展示及 descriptor_type 筛选。</p><p>取值包括 MCP、A2A、AGUI、CUSTOM、AGENT_SKILLS 和 PLUGIN。不新增 Kind 或 TOOL 类型；此展示投影不保存到版本快照，其他返回版本信息的接口可不包含此字段。</p>
        /// </summary>
        [JsonProperty("DescriptorType")]
        public string DescriptorType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "Revision", this.Revision);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ApprovalMode", this.ApprovalMode);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "CreatorUin", this.CreatorUin);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
            this.SetParamSimple(map, prefix + "Descriptors", this.Descriptors);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "SourceConfig", this.SourceConfig);
            this.SetParamSimple(map, prefix + "ContentStatus", this.ContentStatus);
            this.SetParamSimple(map, prefix + "ContentSHA256", this.ContentSHA256);
            this.SetParamSimple(map, prefix + "ContentSizeBytes", this.ContentSizeBytes);
            this.SetParamSimple(map, prefix + "ConfigSHA256", this.ConfigSHA256);
            this.SetParamSimple(map, prefix + "CreatorSubAccountUin", this.CreatorSubAccountUin);
            this.SetParamArrayObj(map, prefix + "ApprovalActions.", this.ApprovalActions);
            this.SetParamSimple(map, prefix + "ContentReadyTime", this.ContentReadyTime);
            this.SetParamSimple(map, prefix + "ChangeLog", this.ChangeLog);
            this.SetParamArraySimple(map, prefix + "LabelSet.", this.LabelSet);
            this.SetParamArrayObj(map, prefix + "SupportedHarnessVersions.", this.SupportedHarnessVersions);
            this.SetParamArrayObj(map, prefix + "Metadata.", this.Metadata);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DescriptorType", this.DescriptorType);
        }
    }
}

