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

    public class CloudRegistry : AbstractModel
    {
        
        /// <summary>
        /// <p>Registry ID；格式 <code>reg-</code> + 8 位小写字母/数字。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegistryId")]
        public string RegistryId{ get; set; }

        /// <summary>
        /// <p>Registry 同一 AppId + Region 唯一名称。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>描述。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>审批模式；AUTO 自动通过，MANUAL 需人工审批；创建时确定，不可修改。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApprovalMode")]
        public string ApprovalMode{ get; set; }

        /// <summary>
        /// <p>Registry 所在腾讯云地域，如 <code>ap-guangzhou</code>。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>Registry 状态。ACTIVE / ARCHIVED。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>创建时间，ISO 8601 UTC，如 <code>2026-08-11T10:00:00Z</code>。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>最近一次更新时间，ISO 8601 UTC。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>Registry 下 Record 总数。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecordCount")]
        public long? RecordCount{ get; set; }

        /// <summary>
        /// <p>权威读取的腾讯云自定义标签，按 Key、Value 稳定排序；无标签时固定返回空数组，不返回 null。</p>
        /// </summary>
        [JsonProperty("Tags")]
        public CloudTag[] Tags{ get; set; }

        /// <summary>
        /// <p>Stable Label 已绑定的 Record 数量。Approved Version 数量和可对外消费的 Record 数量已不再等价。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublishedRecordCount")]
        public long? PublishedRecordCount{ get; set; }

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
        /// <p>创建者子账号 UIN；主账号直接创建时为空字符串。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatorSubAccountUin")]
        public string CreatorSubAccountUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegistryId", this.RegistryId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ApprovalMode", this.ApprovalMode);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "RecordCount", this.RecordCount);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "PublishedRecordCount", this.PublishedRecordCount);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "CreatorUin", this.CreatorUin);
            this.SetParamSimple(map, prefix + "CreatorSubAccountUin", this.CreatorSubAccountUin);
        }
    }
}

