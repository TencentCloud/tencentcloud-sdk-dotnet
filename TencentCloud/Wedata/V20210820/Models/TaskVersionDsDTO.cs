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

    public class TaskVersionDsDTO : AbstractModel
    {
        
        /// <summary>
        /// 版本ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }

        /// <summary>
        /// 任务id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 版本号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VersionNum")]
        public string VersionNum{ get; set; }

        /// <summary>
        /// 版本备注
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VersionRemark")]
        public string VersionRemark{ get; set; }

        /// <summary>
        /// 版本创建人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// 版本创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 版本更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 最新调度计划变更时间 生产态存储
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastSchedulerCommitTime")]
        public string LastSchedulerCommitTime{ get; set; }

        /// <summary>
        /// 版本是否正在使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsedVersion")]
        public long? UsedVersion{ get; set; }

        /// <summary>
        /// 任务信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskInfo")]
        public TaskDsDTO TaskInfo{ get; set; }

        /// <summary>
        /// 任务参数信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskParaInfo")]
        public ParameterTaskDsDto[] TaskParaInfo{ get; set; }

        /// <summary>
        /// TaskInputParam输入参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskInputParam")]
        public ParameterTaskInDsDto[] TaskInputParam{ get; set; }

        /// <summary>
        /// TaskOutputParam输出参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskOutputParam")]
        public ParameterTaskOutDsDto[] TaskOutputParam{ get; set; }

        /// <summary>
        /// 任务上游依赖信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskLinkInfo")]
        public TaskLinkDsDTO[] TaskLinkInfo{ get; set; }

        /// <summary>
        /// 审批状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApproveStatus")]
        public string ApproveStatus{ get; set; }

        /// <summary>
        /// 审批人名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApproveName")]
        public string ApproveName{ get; set; }

        /// <summary>
        /// 任务事件绑定
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskEventPublisher")]
        public EventPublisherDTO[] TaskEventPublisher{ get; set; }

        /// <summary>
        /// 任务产出登记信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskRegisterOutputTable")]
        public TaskDataRegistryDTO[] TaskRegisterOutputTable{ get; set; }

        /// <summary>
        /// 循环依赖信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskCycleLinkInfo")]
        public TaskCycleLinkDTO[] TaskCycleLinkInfo{ get; set; }

        /// <summary>
        /// 事件监听信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskEventListener")]
        public EventListenerDTO[] TaskEventListener{ get; set; }

        /// <summary>
        /// 审批时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApproveTime")]
        public string ApproveTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "VersionNum", this.VersionNum);
            this.SetParamSimple(map, prefix + "VersionRemark", this.VersionRemark);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "LastSchedulerCommitTime", this.LastSchedulerCommitTime);
            this.SetParamSimple(map, prefix + "UsedVersion", this.UsedVersion);
            this.SetParamObj(map, prefix + "TaskInfo.", this.TaskInfo);
            this.SetParamArrayObj(map, prefix + "TaskParaInfo.", this.TaskParaInfo);
            this.SetParamArrayObj(map, prefix + "TaskInputParam.", this.TaskInputParam);
            this.SetParamArrayObj(map, prefix + "TaskOutputParam.", this.TaskOutputParam);
            this.SetParamArrayObj(map, prefix + "TaskLinkInfo.", this.TaskLinkInfo);
            this.SetParamSimple(map, prefix + "ApproveStatus", this.ApproveStatus);
            this.SetParamSimple(map, prefix + "ApproveName", this.ApproveName);
            this.SetParamArrayObj(map, prefix + "TaskEventPublisher.", this.TaskEventPublisher);
            this.SetParamArrayObj(map, prefix + "TaskRegisterOutputTable.", this.TaskRegisterOutputTable);
            this.SetParamArrayObj(map, prefix + "TaskCycleLinkInfo.", this.TaskCycleLinkInfo);
            this.SetParamArrayObj(map, prefix + "TaskEventListener.", this.TaskEventListener);
            this.SetParamSimple(map, prefix + "ApproveTime", this.ApproveTime);
        }
    }
}

