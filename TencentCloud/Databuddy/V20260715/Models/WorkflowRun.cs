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

    public class WorkflowRun : AbstractModel
    {
        
        /// <summary>
        /// <p>主账号ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

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
        /// <p>工作流运行ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowRunId")]
        public string WorkflowRunId{ get; set; }

        /// <summary>
        /// <p>工作空间ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>触发方式，Scheduler、ManualTrigger、Event (参考SchedulerTriggerType)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerType")]
        public string TriggerType{ get; set; }

        /// <summary>
        /// <p>运行开始时间，单位：毫秒时间戳</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunStartTime")]
        public string RunStartTime{ get; set; }

        /// <summary>
        /// <p>pending 状态开始时间，单位：毫秒时间戳</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PendingStartTime")]
        public string PendingStartTime{ get; set; }

        /// <summary>
        /// <p>queue 状态开始时间，单位：毫秒时间戳</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueueStartTime")]
        public string QueueStartTime{ get; set; }

        /// <summary>
        /// <p>运行结束时间，单位：毫秒时间戳</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunEndTime")]
        public string RunEndTime{ get; set; }

        /// <summary>
        /// <p>终态时间，运行进入终态时都有值，单位：毫秒时间戳</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>运行时长，单位：秒</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunCostTime")]
        public string RunCostTime{ get; set; }

        /// <summary>
        /// <p>并发排队花费时间，单位：秒</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueueCostTime")]
        public string QueueCostTime{ get; set; }

        /// <summary>
        /// <p>等待资源花费时间，单位：秒</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PendingCostTime")]
        public string PendingCostTime{ get; set; }

        /// <summary>
        /// <p>运行状态。取值参考工作流运行状态枚举，如 Pending / Running / Succeeded / Failed / Killed</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunState")]
        public string RunState{ get; set; }

        /// <summary>
        /// <p>计算资源（任务的资源组ID集合）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroupIds")]
        public string[] ResourceGroupIds{ get; set; }

        /// <summary>
        /// <p>运行用户UIN</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunUserUin")]
        public string RunUserUin{ get; set; }

        /// <summary>
        /// <p>运行用户名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunUserName")]
        public string RunUserName{ get; set; }

        /// <summary>
        /// <p>错误码</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorCodeString")]
        public string ErrorCodeString{ get; set; }

        /// <summary>
        /// <p>运行参数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowParams")]
        public string WorkflowParams{ get; set; }

        /// <summary>
        /// <p>工作流版本ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowVersionId")]
        public string WorkflowVersionId{ get; set; }

        /// <summary>
        /// <p>当前工作流是否支持重跑</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportRerun")]
        public bool? SupportRerun{ get; set; }

        /// <summary>
        /// <p>工作流运行创建时间，单位：毫秒时间戳</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>重跑次数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RerunTimes")]
        public long? RerunTimes{ get; set; }

        /// <summary>
        /// <p>运行的任务范围，任务ID列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SelectedTaskIds")]
        public string[] SelectedTaskIds{ get; set; }

        /// <summary>
        /// <p>资源组信息列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroupInfoList")]
        public ResourceGroupInfo[] ResourceGroupInfoList{ get; set; }

        /// <summary>
        /// <p>标签列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LabelList")]
        public LabelBrief[] LabelList{ get; set; }

        /// <summary>
        /// <p>父工作流运行ID 【由嵌套工作流触发独有】</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentWorkflowRunId")]
        public string ParentWorkflowRunId{ get; set; }

        /// <summary>
        /// <p>父工作流任务运行ID 【由嵌套工作流触发独有】</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentWorkflowTaskRunId")]
        public string ParentWorkflowTaskRunId{ get; set; }

        /// <summary>
        /// <p>父工作流任务运行名称 【由嵌套工作流触发独有】</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentWorkflowTaskRunName")]
        public string ParentWorkflowTaskRunName{ get; set; }

        /// <summary>
        /// <p>授权权限类型<br>PERMISSION_TYPE_UNSPECIFIED：未指定权限<br>MANAGE : 管理权限：包含所有操作权限<br>RUN : 运行权限：可执行实体<br>VIEW : 查看权限：可查看实体内容</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Permission")]
        public string Permission{ get; set; }

        /// <summary>
        /// <p>工作流高级运行时用户填入的参数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdvancedParameters")]
        public AdvancedParameter[] AdvancedParameters{ get; set; }

        /// <summary>
        /// <p>计划调度时间</p><p>参数格式：毫秒时间戳（UTC）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScheduledTime")]
        public string ScheduledTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "WorkflowRunId", this.WorkflowRunId);
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "RunStartTime", this.RunStartTime);
            this.SetParamSimple(map, prefix + "PendingStartTime", this.PendingStartTime);
            this.SetParamSimple(map, prefix + "QueueStartTime", this.QueueStartTime);
            this.SetParamSimple(map, prefix + "RunEndTime", this.RunEndTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "RunCostTime", this.RunCostTime);
            this.SetParamSimple(map, prefix + "QueueCostTime", this.QueueCostTime);
            this.SetParamSimple(map, prefix + "PendingCostTime", this.PendingCostTime);
            this.SetParamSimple(map, prefix + "RunState", this.RunState);
            this.SetParamArraySimple(map, prefix + "ResourceGroupIds.", this.ResourceGroupIds);
            this.SetParamSimple(map, prefix + "RunUserUin", this.RunUserUin);
            this.SetParamSimple(map, prefix + "RunUserName", this.RunUserName);
            this.SetParamSimple(map, prefix + "ErrorCodeString", this.ErrorCodeString);
            this.SetParamSimple(map, prefix + "WorkflowParams", this.WorkflowParams);
            this.SetParamSimple(map, prefix + "WorkflowVersionId", this.WorkflowVersionId);
            this.SetParamSimple(map, prefix + "SupportRerun", this.SupportRerun);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "RerunTimes", this.RerunTimes);
            this.SetParamArraySimple(map, prefix + "SelectedTaskIds.", this.SelectedTaskIds);
            this.SetParamArrayObj(map, prefix + "ResourceGroupInfoList.", this.ResourceGroupInfoList);
            this.SetParamArrayObj(map, prefix + "LabelList.", this.LabelList);
            this.SetParamSimple(map, prefix + "ParentWorkflowRunId", this.ParentWorkflowRunId);
            this.SetParamSimple(map, prefix + "ParentWorkflowTaskRunId", this.ParentWorkflowTaskRunId);
            this.SetParamSimple(map, prefix + "ParentWorkflowTaskRunName", this.ParentWorkflowTaskRunName);
            this.SetParamSimple(map, prefix + "Permission", this.Permission);
            this.SetParamArrayObj(map, prefix + "AdvancedParameters.", this.AdvancedParameters);
            this.SetParamSimple(map, prefix + "ScheduledTime", this.ScheduledTime);
        }
    }
}

