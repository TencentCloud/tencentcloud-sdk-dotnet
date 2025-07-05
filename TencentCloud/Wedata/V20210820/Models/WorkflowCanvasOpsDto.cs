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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkflowCanvasOpsDto : AbstractModel
    {
        
        /// <summary>
        /// 工作流id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// 工作流详情描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowDesc")]
        public string WorkflowDesc{ get; set; }

        /// <summary>
        /// 工作流名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }

        /// <summary>
        /// 所属文件夹id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FolderId")]
        public string FolderId{ get; set; }

        /// <summary>
        /// 所属文件夹ids
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FolderIds")]
        public string[] FolderIds{ get; set; }

        /// <summary>
        /// 任务列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tasks")]
        public TaskOpsDto[] Tasks{ get; set; }

        /// <summary>
        /// 任务依赖边列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Links")]
        public LinkOpsDto[] Links{ get; set; }

        /// <summary>
        /// 工作流所属用户分组id,若有多个分号隔开: a;b;c
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserGroupId")]
        public string UserGroupId{ get; set; }

        /// <summary>
        /// 工作流所属用户分组名称,若有多个分号隔开: a;b;c
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserGroupName")]
        public string UserGroupName{ get; set; }

        /// <summary>
        /// 项目id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 项目标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectIdent")]
        public string ProjectIdent{ get; set; }

        /// <summary>
        /// 项目名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 责任人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// 责任人UserId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerId")]
        public string OwnerId{ get; set; }

        /// <summary>
        /// 工作流类型，周期cycle，手动manual
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowType")]
        public string WorkflowType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "WorkflowDesc", this.WorkflowDesc);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamSimple(map, prefix + "FolderId", this.FolderId);
            this.SetParamArraySimple(map, prefix + "FolderIds.", this.FolderIds);
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamArrayObj(map, prefix + "Links.", this.Links);
            this.SetParamSimple(map, prefix + "UserGroupId", this.UserGroupId);
            this.SetParamSimple(map, prefix + "UserGroupName", this.UserGroupName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectIdent", this.ProjectIdent);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
            this.SetParamSimple(map, prefix + "OwnerId", this.OwnerId);
            this.SetParamSimple(map, prefix + "WorkflowType", this.WorkflowType);
        }
    }
}

