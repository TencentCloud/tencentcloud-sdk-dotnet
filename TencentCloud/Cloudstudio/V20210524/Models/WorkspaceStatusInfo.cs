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

    public class WorkspaceStatusInfo : AbstractModel
    {
        
        /// <summary>
        /// 空间ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 空间名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 所属人
        /// </summary>
        [JsonProperty("Owner")]
        public UserInfoRsp Owner{ get; set; }

        /// <summary>
        /// 空间标识
        /// </summary>
        [JsonProperty("SpaceKey")]
        public string SpaceKey{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 最后操作时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastOpsDate")]
        public string LastOpsDate{ get; set; }

        /// <summary>
        /// 描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 共享状态
        /// </summary>
        [JsonProperty("Share")]
        public WorkspaceShareInfo Share{ get; set; }

        /// <summary>
        /// 空间类型
        /// </summary>
        [JsonProperty("WorkspaceType")]
        public string WorkspaceType{ get; set; }

        /// <summary>
        /// 标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// 空间版本
        /// </summary>
        [JsonProperty("WorkspaceVersion")]
        public long? WorkspaceVersion{ get; set; }

        /// <summary>
        /// 图标地址
        /// </summary>
        [JsonProperty("ImageIcon")]
        public string ImageIcon{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateDate")]
        public string CreateDate{ get; set; }

        /// <summary>
        /// 版本控制地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VersionControlUrl")]
        public string VersionControlUrl{ get; set; }

        /// <summary>
        /// 版本控制描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VersionControlDesc")]
        public string VersionControlDesc{ get; set; }

        /// <summary>
        /// 版本控制引用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VersionControlRef")]
        public string VersionControlRef{ get; set; }

        /// <summary>
        /// 版本控制引用类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VersionControlRefType")]
        public string VersionControlRefType{ get; set; }

        /// <summary>
        /// 版本控制类型
        /// </summary>
        [JsonProperty("VersionControlType")]
        public string VersionControlType{ get; set; }

        /// <summary>
        /// 模板ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TemplateId")]
        public long? TemplateId{ get; set; }

        /// <summary>
        /// 快照ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SnapshotUid")]
        public string SnapshotUid{ get; set; }

        /// <summary>
        /// 类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpecDesc")]
        public string SpecDesc{ get; set; }

        /// <summary>
        /// CPU数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 内存
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "Owner.", this.Owner);
            this.SetParamSimple(map, prefix + "SpaceKey", this.SpaceKey);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "LastOpsDate", this.LastOpsDate);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamObj(map, prefix + "Share.", this.Share);
            this.SetParamSimple(map, prefix + "WorkspaceType", this.WorkspaceType);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "WorkspaceVersion", this.WorkspaceVersion);
            this.SetParamSimple(map, prefix + "ImageIcon", this.ImageIcon);
            this.SetParamSimple(map, prefix + "CreateDate", this.CreateDate);
            this.SetParamSimple(map, prefix + "VersionControlUrl", this.VersionControlUrl);
            this.SetParamSimple(map, prefix + "VersionControlDesc", this.VersionControlDesc);
            this.SetParamSimple(map, prefix + "VersionControlRef", this.VersionControlRef);
            this.SetParamSimple(map, prefix + "VersionControlRefType", this.VersionControlRefType);
            this.SetParamSimple(map, prefix + "VersionControlType", this.VersionControlType);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "SnapshotUid", this.SnapshotUid);
            this.SetParamSimple(map, prefix + "SpecDesc", this.SpecDesc);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
        }
    }
}

