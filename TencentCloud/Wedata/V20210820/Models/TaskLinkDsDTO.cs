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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskLinkDsDTO : AbstractModel
    {
        
        /// <summary>
        /// TaskTo信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskTo")]
        public string TaskTo{ get; set; }

        /// <summary>
        /// TaskFrom信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskFrom")]
        public string TaskFrom{ get; set; }

        /// <summary>
        /// LinkType信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LinkType")]
        public string LinkType{ get; set; }

        /// <summary>
        /// key
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LinkKey")]
        public string LinkKey{ get; set; }

        /// <summary>
        /// LinkId信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 责任人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InCharge")]
        public string InCharge{ get; set; }

        /// <summary>
        /// 父子任务之间的依赖关系
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LinkDependencyType")]
        public string LinkDependencyType{ get; set; }

        /// <summary>
        /// 父子任务之间依赖偏移量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 工作流id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// 实体任务id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealFromTaskId")]
        public string RealFromTaskId{ get; set; }

        /// <summary>
        /// 实体任务名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealFromTaskName")]
        public string RealFromTaskName{ get; set; }

        /// <summary>
        /// 实体任务所属工作流
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealFromWorkflowId")]
        public string RealFromWorkflowId{ get; set; }

        /// <summary>
        /// 实体任务所属工作流名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealFromWorkflowName")]
        public string RealFromWorkflowName{ get; set; }

        /// <summary>
        /// 实体任务所属项目id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealProjectId")]
        public string RealProjectId{ get; set; }

        /// <summary>
        /// 实体任务所属项目标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealProjectIdent")]
        public string RealProjectIdent{ get; set; }

        /// <summary>
        /// 实体任务所属项目名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealProjectName")]
        public string RealProjectName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskTo", this.TaskTo);
            this.SetParamSimple(map, prefix + "TaskFrom", this.TaskFrom);
            this.SetParamSimple(map, prefix + "LinkType", this.LinkType);
            this.SetParamSimple(map, prefix + "LinkKey", this.LinkKey);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "InCharge", this.InCharge);
            this.SetParamSimple(map, prefix + "LinkDependencyType", this.LinkDependencyType);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "RealFromTaskId", this.RealFromTaskId);
            this.SetParamSimple(map, prefix + "RealFromTaskName", this.RealFromTaskName);
            this.SetParamSimple(map, prefix + "RealFromWorkflowId", this.RealFromWorkflowId);
            this.SetParamSimple(map, prefix + "RealFromWorkflowName", this.RealFromWorkflowName);
            this.SetParamSimple(map, prefix + "RealProjectId", this.RealProjectId);
            this.SetParamSimple(map, prefix + "RealProjectIdent", this.RealProjectIdent);
            this.SetParamSimple(map, prefix + "RealProjectName", this.RealProjectName);
        }
    }
}

