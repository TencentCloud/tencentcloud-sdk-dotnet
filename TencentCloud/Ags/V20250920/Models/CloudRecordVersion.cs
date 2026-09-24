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
        /// <p>TAR 内容成功校验、完成物化并进入 READY 的时间；MANUAL / URL_IMPORT 或尚未 READY 的 TAR_PACKAGE 均为空。</p>
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
        }
    }
}

