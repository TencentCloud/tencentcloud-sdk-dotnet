/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Cloudstudio.V20210524.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkspaceTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 模板分类
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 模板描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 中文描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DescriptionEN")]
        public string DescriptionEN{ get; set; }

        /// <summary>
        /// 模板标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public string Tags{ get; set; }

        /// <summary>
        /// 模板图标地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Icon")]
        public string Icon{ get; set; }

        /// <summary>
        /// 默认仓库类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VersionControlType")]
        public string VersionControlType{ get; set; }

        /// <summary>
        /// 默认仓库地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VersionControlUrl")]
        public string VersionControlUrl{ get; set; }

        /// <summary>
        /// 默认仓库描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VersionControlDesc")]
        public string VersionControlDesc{ get; set; }

        /// <summary>
        /// 默认仓库所属人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VersionControlOwner")]
        public string VersionControlOwner{ get; set; }

        /// <summary>
        /// 默认仓库引用地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VersionControlRef")]
        public string VersionControlRef{ get; set; }

        /// <summary>
        /// 默认仓库引用类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VersionControlRefType")]
        public string VersionControlRefType{ get; set; }

        /// <summary>
        /// 用户自定义仓库地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserVersionControlUrl")]
        public string UserVersionControlUrl{ get; set; }

        /// <summary>
        /// 用户自定义仓库类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserVersionControlType")]
        public string UserVersionControlType{ get; set; }

        /// <summary>
        /// 用户自定义仓库引用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserVersionControlRef")]
        public string UserVersionControlRef{ get; set; }

        /// <summary>
        /// 用户自定义仓库引用类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserVersionControlRefType")]
        public string UserVersionControlRefType{ get; set; }

        /// <summary>
        /// xxx
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DevFile")]
        public string DevFile{ get; set; }

        /// <summary>
        /// xxx
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PluginFile")]
        public string PluginFile{ get; set; }

        /// <summary>
        /// 是否标记
        /// </summary>
        [JsonProperty("Marked")]
        public bool? Marked{ get; set; }

        /// <summary>
        /// 标记状态
        /// </summary>
        [JsonProperty("MarkAt")]
        public long? MarkAt{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateDate")]
        public string CreateDate{ get; set; }

        /// <summary>
        /// 最后修改时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastModified")]
        public string LastModified{ get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [JsonProperty("Sort")]
        public long? Sort{ get; set; }

        /// <summary>
        /// xxx
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SnapshotUid")]
        public string SnapshotUid{ get; set; }

        /// <summary>
        /// 用户ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserId")]
        public long? UserId{ get; set; }

        /// <summary>
        /// 用户名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Author")]
        public string Author{ get; set; }

        /// <summary>
        /// 是否属于当前用户
        /// </summary>
        [JsonProperty("Me")]
        public bool? Me{ get; set; }

        /// <summary>
        /// xxx
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthorAvatar")]
        public string AuthorAvatar{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DescriptionEN", this.DescriptionEN);
            this.SetParamSimple(map, prefix + "Tags", this.Tags);
            this.SetParamSimple(map, prefix + "Icon", this.Icon);
            this.SetParamSimple(map, prefix + "VersionControlType", this.VersionControlType);
            this.SetParamSimple(map, prefix + "VersionControlUrl", this.VersionControlUrl);
            this.SetParamSimple(map, prefix + "VersionControlDesc", this.VersionControlDesc);
            this.SetParamSimple(map, prefix + "VersionControlOwner", this.VersionControlOwner);
            this.SetParamSimple(map, prefix + "VersionControlRef", this.VersionControlRef);
            this.SetParamSimple(map, prefix + "VersionControlRefType", this.VersionControlRefType);
            this.SetParamSimple(map, prefix + "UserVersionControlUrl", this.UserVersionControlUrl);
            this.SetParamSimple(map, prefix + "UserVersionControlType", this.UserVersionControlType);
            this.SetParamSimple(map, prefix + "UserVersionControlRef", this.UserVersionControlRef);
            this.SetParamSimple(map, prefix + "UserVersionControlRefType", this.UserVersionControlRefType);
            this.SetParamSimple(map, prefix + "DevFile", this.DevFile);
            this.SetParamSimple(map, prefix + "PluginFile", this.PluginFile);
            this.SetParamSimple(map, prefix + "Marked", this.Marked);
            this.SetParamSimple(map, prefix + "MarkAt", this.MarkAt);
            this.SetParamSimple(map, prefix + "CreateDate", this.CreateDate);
            this.SetParamSimple(map, prefix + "LastModified", this.LastModified);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamSimple(map, prefix + "SnapshotUid", this.SnapshotUid);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Author", this.Author);
            this.SetParamSimple(map, prefix + "Me", this.Me);
            this.SetParamSimple(map, prefix + "AuthorAvatar", this.AuthorAvatar);
        }
    }
}

