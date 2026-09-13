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

    public class GetWorkflowTaskRunRsp : AbstractModel
    {
        
        /// <summary>
        /// 任务名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 任务运行ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowTaskRunId")]
        public string WorkflowTaskRunId{ get; set; }

        /// <summary>
        /// 运行状态。取值参考工作流任务运行状态枚举，如 Pending / Running / Succeeded / Failed / Killed
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunState")]
        public string RunState{ get; set; }

        /// <summary>
        /// 工作空间ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

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
        [JsonProperty("WorkflowRunId")]
        public string WorkflowRunId{ get; set; }

        /// <summary>
        /// 任务ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 任务类型名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskTypeName")]
        public string TaskTypeName{ get; set; }

        /// <summary>
        /// 任务版本ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskVersionId")]
        public string TaskVersionId{ get; set; }

        /// <summary>
        /// 触发类型 (参考SchedulerTriggerType枚举)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerType")]
        public string TriggerType{ get; set; }

        /// <summary>
        /// 所属资源组ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// 错误码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorCodeString")]
        public string ErrorCodeString{ get; set; }

        /// <summary>
        /// 运行用户UIN
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunUserUin")]
        public string RunUserUin{ get; set; }

        /// <summary>
        /// 运行用户名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunUserName")]
        public string RunUserName{ get; set; }

        /// <summary>
        /// 创建人UIN
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateUserUin")]
        public string CreateUserUin{ get; set; }

        /// <summary>
        /// 执行平台执行ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 创建时间，单位：毫秒时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间，单位：毫秒时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 依赖任务完成时间，单位：毫秒时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DependenceFinishedTime")]
        public string DependenceFinishedTime{ get; set; }

        /// <summary>
        /// 运行开始时间，单位：毫秒时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunStartTime")]
        public string RunStartTime{ get; set; }

        /// <summary>
        /// 运行结束时间，单位：毫秒时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunEndTime")]
        public string RunEndTime{ get; set; }

        /// <summary>
        /// 运行时长，单位：秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunCostTime")]
        public string RunCostTime{ get; set; }

        /// <summary>
        /// 等待时长（依赖就绪到开始运行的等待耗时），单位：秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WaitTime")]
        public string WaitTime{ get; set; }

        /// <summary>
        /// 下发执行平台时间，单位：毫秒时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IssueTime")]
        public string IssueTime{ get; set; }

        /// <summary>
        /// 时区
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }

        /// <summary>
        /// 依赖上游任务ID列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DependOnList")]
        public string[] DependOnList{ get; set; }

        /// <summary>
        /// 运行参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunParams")]
        public string RunParams{ get; set; }

        /// <summary>
        /// 任务扩展信息，包含脚本路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskTypeExtensions")]
        public string TaskTypeExtensions{ get; set; }

        /// <summary>
        /// 任务X坐标
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LeftCoordinate")]
        public float? LeftCoordinate{ get; set; }

        /// <summary>
        /// 任务Y坐标
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopCoordinate")]
        public float? TopCoordinate{ get; set; }

        /// <summary>
        /// 重试次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RetryTimes")]
        public long? RetryTimes{ get; set; }

        /// <summary>
        /// 工作流名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }

        /// <summary>
        /// 重跑次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RerunTimes")]
        public long? RerunTimes{ get; set; }

        /// <summary>
        /// 是否最新一次运行
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsLatestRun")]
        public bool? IsLatestRun{ get; set; }

        /// <summary>
        /// 资源组信息列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroupInfoList")]
        public ResourceGroupInfo[] ResourceGroupInfoList{ get; set; }

        /// <summary>
        /// 错误消息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

        /// <summary>
        /// 运行结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunResult")]
        public string RunResult{ get; set; }

        /// <summary>
        /// 内嵌工作流任务运行详情（仅限 FOR_EACH 任务，其他任务类型不返回该字段）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InnerWorkflowTaskRun")]
        public InnerWorkflowTaskRun InnerWorkflowTaskRun{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "WorkflowTaskRunId", this.WorkflowTaskRunId);
            this.SetParamSimple(map, prefix + "RunState", this.RunState);
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "WorkflowRunId", this.WorkflowRunId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskTypeName", this.TaskTypeName);
            this.SetParamSimple(map, prefix + "TaskVersionId", this.TaskVersionId);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamSimple(map, prefix + "ErrorCodeString", this.ErrorCodeString);
            this.SetParamSimple(map, prefix + "RunUserUin", this.RunUserUin);
            this.SetParamSimple(map, prefix + "RunUserName", this.RunUserName);
            this.SetParamSimple(map, prefix + "CreateUserUin", this.CreateUserUin);
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "DependenceFinishedTime", this.DependenceFinishedTime);
            this.SetParamSimple(map, prefix + "RunStartTime", this.RunStartTime);
            this.SetParamSimple(map, prefix + "RunEndTime", this.RunEndTime);
            this.SetParamSimple(map, prefix + "RunCostTime", this.RunCostTime);
            this.SetParamSimple(map, prefix + "WaitTime", this.WaitTime);
            this.SetParamSimple(map, prefix + "IssueTime", this.IssueTime);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
            this.SetParamArraySimple(map, prefix + "DependOnList.", this.DependOnList);
            this.SetParamSimple(map, prefix + "RunParams", this.RunParams);
            this.SetParamSimple(map, prefix + "TaskTypeExtensions", this.TaskTypeExtensions);
            this.SetParamSimple(map, prefix + "LeftCoordinate", this.LeftCoordinate);
            this.SetParamSimple(map, prefix + "TopCoordinate", this.TopCoordinate);
            this.SetParamSimple(map, prefix + "RetryTimes", this.RetryTimes);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamSimple(map, prefix + "RerunTimes", this.RerunTimes);
            this.SetParamSimple(map, prefix + "IsLatestRun", this.IsLatestRun);
            this.SetParamArrayObj(map, prefix + "ResourceGroupInfoList.", this.ResourceGroupInfoList);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamSimple(map, prefix + "RunResult", this.RunResult);
            this.SetParamObj(map, prefix + "InnerWorkflowTaskRun.", this.InnerWorkflowTaskRun);
        }
    }
}

