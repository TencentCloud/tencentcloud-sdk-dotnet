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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TriggerWorkflowRunBrief : AbstractModel
    {
        
        /// <summary>
        /// 用户AppId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 项目ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 工作流名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }

        /// <summary>
        /// 工作流ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// 工作流运行ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutionId")]
        public string ExecutionId{ get; set; }

        /// <summary>
        /// 触发器ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerId")]
        public string TriggerId{ get; set; }

        /// <summary>
        /// 触发方式:调度触发Scheduler、手动触发ManualTrigger、事件触发Event
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerType")]
        public string TriggerType{ get; set; }

        /// <summary>
        /// 工作流触发时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 计划调度时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScheduleTime")]
        public string ScheduleTime{ get; set; }

        /// <summary>
        /// 执行开始时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutionStartTime")]
        public string ExecutionStartTime{ get; set; }

        /// <summary>
        /// 执行结束时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutionEndTime")]
        public string ExecutionEndTime{ get; set; }

        /// <summary>
        /// 运行时长，单位秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutionCostTime")]
        public string ExecutionCostTime{ get; set; }

        /// <summary>
        /// 并发排队花费时间，单位秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueueCostTime")]
        public string QueueCostTime{ get; set; }

        /// <summary>
        /// 等待资源花费时间，单位秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PendingCostTime")]
        public string PendingCostTime{ get; set; }

        /// <summary>
        /// 执行状态，运行失败:FAILED、运行成功:SUCCESS、等待中:PENDING、跳过运行:SKIPED、运行中:RUNNING
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutionState")]
        public string ExecutionState{ get; set; }

        /// <summary>
        /// 运行用户UIN
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecuteUserUin")]
        public string ExecuteUserUin{ get; set; }

        /// <summary>
        /// 运行用户名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecuteUserName")]
        public string ExecuteUserName{ get; set; }

        /// <summary>
        /// 错误码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorCodeStr")]
        public string ErrorCodeStr{ get; set; }

        /// <summary>
        /// 运行参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowParams")]
        public string WorkflowParams{ get; set; }

        /// <summary>
        /// 工作流版本信息ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowVersionId")]
        public string WorkflowVersionId{ get; set; }

        /// <summary>
        /// 是否支持重跑
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportRerun")]
        public bool? SupportRerun{ get; set; }

        /// <summary>
        /// 重跑次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RerunTimes")]
        public ulong? RerunTimes{ get; set; }

        /// <summary>
        /// 运行的任务范围,逗号分隔的任务ID列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SelectedTaskIds")]
        public string[] SelectedTaskIds{ get; set; }

        /// <summary>
        /// 等待并发开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PendingStartTime")]
        public string PendingStartTime{ get; set; }

        /// <summary>
        /// 排队等待开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueueStartTime")]
        public string QueueStartTime{ get; set; }

        /// <summary>
        /// 运行结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 文件夹ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FolderId")]
        public string FolderId{ get; set; }

        /// <summary>
        /// 文件夹名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FolderName")]
        public string FolderName{ get; set; }

        /// <summary>
        /// 计划调度时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PlannedSchedulingTime")]
        public string PlannedSchedulingTime{ get; set; }

        /// <summary>
        /// 周期类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

        /// <summary>
        /// 责任人名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserNameInCharge")]
        public string UserNameInCharge{ get; set; }

        /// <summary>
        /// 责任人ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserUinInCharge")]
        public string UserUinInCharge{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "ExecutionId", this.ExecutionId);
            this.SetParamSimple(map, prefix + "TriggerId", this.TriggerId);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ScheduleTime", this.ScheduleTime);
            this.SetParamSimple(map, prefix + "ExecutionStartTime", this.ExecutionStartTime);
            this.SetParamSimple(map, prefix + "ExecutionEndTime", this.ExecutionEndTime);
            this.SetParamSimple(map, prefix + "ExecutionCostTime", this.ExecutionCostTime);
            this.SetParamSimple(map, prefix + "QueueCostTime", this.QueueCostTime);
            this.SetParamSimple(map, prefix + "PendingCostTime", this.PendingCostTime);
            this.SetParamSimple(map, prefix + "ExecutionState", this.ExecutionState);
            this.SetParamSimple(map, prefix + "ExecuteUserUin", this.ExecuteUserUin);
            this.SetParamSimple(map, prefix + "ExecuteUserName", this.ExecuteUserName);
            this.SetParamSimple(map, prefix + "ErrorCodeStr", this.ErrorCodeStr);
            this.SetParamSimple(map, prefix + "WorkflowParams", this.WorkflowParams);
            this.SetParamSimple(map, prefix + "WorkflowVersionId", this.WorkflowVersionId);
            this.SetParamSimple(map, prefix + "SupportRerun", this.SupportRerun);
            this.SetParamSimple(map, prefix + "RerunTimes", this.RerunTimes);
            this.SetParamArraySimple(map, prefix + "SelectedTaskIds.", this.SelectedTaskIds);
            this.SetParamSimple(map, prefix + "PendingStartTime", this.PendingStartTime);
            this.SetParamSimple(map, prefix + "QueueStartTime", this.QueueStartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "FolderId", this.FolderId);
            this.SetParamSimple(map, prefix + "FolderName", this.FolderName);
            this.SetParamSimple(map, prefix + "PlannedSchedulingTime", this.PlannedSchedulingTime);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "UserNameInCharge", this.UserNameInCharge);
            this.SetParamSimple(map, prefix + "UserUinInCharge", this.UserUinInCharge);
        }
    }
}

