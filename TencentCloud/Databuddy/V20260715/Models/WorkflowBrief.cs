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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkflowBrief : AbstractModel
    {
        
        /// <summary>
        /// <p>工作流名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }

        /// <summary>
        /// <p>工作流ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>创建人UIN</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateUserUin")]
        public string CreateUserUin{ get; set; }

        /// <summary>
        /// <p>工作流负责人用户名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerUserName")]
        public string OwnerUserName{ get; set; }

        /// <summary>
        /// <p>工作流负责人UIN</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerUserUin")]
        public string OwnerUserUin{ get; set; }

        /// <summary>
        /// <p>工作流负责人展示名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerDisplayName")]
        public string OwnerDisplayName{ get; set; }

        /// <summary>
        /// <p>创建时间，单位：毫秒时间戳</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间，单位：毫秒时间戳</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>标签列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LabelList")]
        public LabelBrief[] LabelList{ get; set; }

        /// <summary>
        /// <p>工作流调度配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Trigger")]
        public WorkflowTriggerConfiguration[] Trigger{ get; set; }

        /// <summary>
        /// <p>工作流运行人UIN</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunUserUin")]
        public string RunUserUin{ get; set; }

        /// <summary>
        /// <p>工作流运行人用户名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunUserName")]
        public string RunUserName{ get; set; }

        /// <summary>
        /// <p>工作流任务节点列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskList")]
        public WorkflowTaskNodeBrief[] TaskList{ get; set; }

        /// <summary>
        /// <p>工作流运行情况列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowRunList")]
        public WorkflowRunBrief[] WorkflowRunList{ get; set; }

        /// <summary>
        /// <p>资源组信息列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroupInfoList")]
        public ResourceGroupInfo[] ResourceGroupInfoList{ get; set; }

        /// <summary>
        /// <p>工作流权限信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Permission")]
        public string Permission{ get; set; }

        /// <summary>
        /// <p>工作流绑定的 Bundle 唯一标识，未绑定时为空</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// <p>Bundle信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BundleInfo")]
        public string BundleInfo{ get; set; }

        /// <summary>
        /// <p>Git配置ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GitConfigId")]
        public string GitConfigId{ get; set; }

        /// <summary>
        /// <p>Git分支信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GitBranch")]
        public string GitBranch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreateUserUin", this.CreateUserUin);
            this.SetParamSimple(map, prefix + "OwnerUserName", this.OwnerUserName);
            this.SetParamSimple(map, prefix + "OwnerUserUin", this.OwnerUserUin);
            this.SetParamSimple(map, prefix + "OwnerDisplayName", this.OwnerDisplayName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArrayObj(map, prefix + "LabelList.", this.LabelList);
            this.SetParamArrayObj(map, prefix + "Trigger.", this.Trigger);
            this.SetParamSimple(map, prefix + "RunUserUin", this.RunUserUin);
            this.SetParamSimple(map, prefix + "RunUserName", this.RunUserName);
            this.SetParamArrayObj(map, prefix + "TaskList.", this.TaskList);
            this.SetParamArrayObj(map, prefix + "WorkflowRunList.", this.WorkflowRunList);
            this.SetParamArrayObj(map, prefix + "ResourceGroupInfoList.", this.ResourceGroupInfoList);
            this.SetParamSimple(map, prefix + "Permission", this.Permission);
            this.SetParamSimple(map, prefix + "BundleId", this.BundleId);
            this.SetParamSimple(map, prefix + "BundleInfo", this.BundleInfo);
            this.SetParamSimple(map, prefix + "GitConfigId", this.GitConfigId);
            this.SetParamSimple(map, prefix + "GitBranch", this.GitBranch);
        }
    }
}

