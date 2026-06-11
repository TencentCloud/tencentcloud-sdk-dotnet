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

    public class InstanceOpsDto : AbstractModel
    {
        
        /// <summary>
        /// <p>任务ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>任务名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>工作流ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// <p>工作流名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }

        /// <summary>
        /// <p>负责人</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InCharge")]
        public string InCharge{ get; set; }

        /// <summary>
        /// <p>周期类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

        /// <summary>
        /// <p>数据时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurRunDate")]
        public string CurRunDate{ get; set; }

        /// <summary>
        /// <p>下一个数据时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NextCurDate")]
        public string NextCurDate{ get; set; }

        /// <summary>
        /// <p>运行优先级</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunPriority")]
        public ulong? RunPriority{ get; set; }

        /// <summary>
        /// <p>尝试运行次数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TryLimit")]
        public ulong? TryLimit{ get; set; }

        /// <summary>
        /// <p>当前运行次数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tries")]
        public ulong? Tries{ get; set; }

        /// <summary>
        /// <p>重跑总次数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalRunNum")]
        public ulong? TotalRunNum{ get; set; }

        /// <summary>
        /// <p>是否补录</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DoFlag")]
        public ulong? DoFlag{ get; set; }

        /// <summary>
        /// <p>是否是重跑</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RedoFlag")]
        public ulong? RedoFlag{ get; set; }

        /// <summary>
        /// <p>实例状态</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// <p>运行节点</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuntimeBroker")]
        public string RuntimeBroker{ get; set; }

        /// <summary>
        /// <p>失败的原因</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorDesc")]
        public string ErrorDesc{ get; set; }

        /// <summary>
        /// <p>任务类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskType")]
        public TaskTypeOpsDto TaskType{ get; set; }

        /// <summary>
        /// <p>依赖判断完成时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DependenceFulfillTime")]
        public string DependenceFulfillTime{ get; set; }

        /// <summary>
        /// <p>首次依赖判断通过时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FirstDependenceFulfillTime")]
        public string FirstDependenceFulfillTime{ get; set; }

        /// <summary>
        /// <p>首次启动时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FirstStartTime")]
        public string FirstStartTime{ get; set; }

        /// <summary>
        /// <p>开始启动时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>运行完成时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>耗费时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CostTime")]
        public string CostTime{ get; set; }

        /// <summary>
        /// <p>耗费时间(ms)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CostMillisecond")]
        public ulong? CostMillisecond{ get; set; }

        /// <summary>
        /// <p>最大运行耗时</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxCostTime")]
        public ulong? MaxCostTime{ get; set; }

        /// <summary>
        /// <p>最小运行耗时</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MinCostTime")]
        public ulong? MinCostTime{ get; set; }

        /// <summary>
        /// <p>平均运行耗时</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AvgCostTime")]
        public float? AvgCostTime{ get; set; }

        /// <summary>
        /// <p>最近日志</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastLog")]
        public string LastLog{ get; set; }

        /// <summary>
        /// <p>调度时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchedulerDateTime")]
        public string SchedulerDateTime{ get; set; }

        /// <summary>
        /// <p>上次调度时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastSchedulerDateTime")]
        public string LastSchedulerDateTime{ get; set; }

        /// <summary>
        /// <p>最后更新事件</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastUpdate")]
        public string LastUpdate{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>分支，依赖关系 and、or</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DependencyRel")]
        public string DependencyRel{ get; set; }

        /// <summary>
        /// <p>执行空间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutionSpace")]
        public string ExecutionSpace{ get; set; }

        /// <summary>
        /// <p>忽略事件</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IgnoreEvent")]
        public bool? IgnoreEvent{ get; set; }

        /// <summary>
        /// <p>虚拟任务实例</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VirtualFlag")]
        public bool? VirtualFlag{ get; set; }

        /// <summary>
        /// <p>文件夹ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FolderId")]
        public string FolderId{ get; set; }

        /// <summary>
        /// <p>文件夹名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FolderName")]
        public string FolderName{ get; set; }

        /// <summary>
        /// <p>递归实例信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SonList")]
        public string SonList{ get; set; }

        /// <summary>
        /// <p>产品业务名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// <p>资源组</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroup")]
        public string ResourceGroup{ get; set; }

        /// <summary>
        /// <p>资源组指定执行节点</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceInstanceId")]
        public string ResourceInstanceId{ get; set; }

        /// <summary>
        /// <p>资源队列</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("YarnQueue")]
        public string YarnQueue{ get; set; }

        /// <summary>
        /// <p>调度计划</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchedulerDesc")]
        public string SchedulerDesc{ get; set; }

        /// <summary>
        /// <p>最近提交时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FirstSubmitTime")]
        public string FirstSubmitTime{ get; set; }

        /// <summary>
        /// <p>首次执行时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FirstRunTime")]
        public string FirstRunTime{ get; set; }

        /// <summary>
        /// <p>项目ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>项目标识</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectIdent")]
        public string ProjectIdent{ get; set; }

        /// <summary>
        /// <p>项目名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// <p>租户id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TenantId")]
        public string TenantId{ get; set; }

        /// <summary>
        /// <p>实例标识</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceKey")]
        public string InstanceKey{ get; set; }

        /// <summary>
        /// <p>资源组id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorGroupId")]
        public string ExecutorGroupId{ get; set; }

        /// <summary>
        /// <p>资源组名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorGroupName")]
        public string ExecutorGroupName{ get; set; }

        /// <summary>
        /// <p>关联实例信息。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelatedInstanceList")]
        public InstanceOpsDto[] RelatedInstanceList{ get; set; }

        /// <summary>
        /// <p>关联实例信息数量，不和RelatedInstanceList强关联。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelatedInstanceSize")]
        public long? RelatedInstanceSize{ get; set; }

        /// <summary>
        /// <p>ownerId</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerId")]
        public string OwnerId{ get; set; }

        /// <summary>
        /// <p>用户id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// <p>实例生命周期</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceLifeCycleOpsDto")]
        public InstanceLifeCycleOpsDto InstanceLifeCycleOpsDto{ get; set; }

        /// <summary>
        /// <p>自动重试次数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RetryAttempts")]
        public ulong? RetryAttempts{ get; set; }

        /// <summary>
        /// <p>紧急去除的依赖父实例列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeletedFatherList")]
        public string[] DeletedFatherList{ get; set; }

        /// <summary>
        /// <p>循环依赖关联的实例</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CirculateInstanceList")]
        public InstanceOpsDto[] CirculateInstanceList{ get; set; }

        /// <summary>
        /// <p>并发策略, 0: 等待并发, 1: kill自身</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConcurrentStrategy")]
        public ulong? ConcurrentStrategy{ get; set; }

        /// <summary>
        /// <p>调度运行方式, 0: 周期调度, 1: 空跑调度</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScheduleRunType")]
        public ulong? ScheduleRunType{ get; set; }

        /// <summary>
        /// <p>允许重跑类型，ALL 表示无论实例运行成功还是失败都允许重跑，NONE表示无论成功或者失败都不允许重跑，FAILURE 表示只有运行失败才能重跑</p>
        /// </summary>
        [JsonProperty("AllowRedoType")]
        public string AllowRedoType{ get; set; }

        /// <summary>
        /// <p>实例生命周期</p>
        /// </summary>
        [JsonProperty("InstanceCycleType")]
        public string InstanceCycleType{ get; set; }

        /// <summary>
        /// <p>实例执行计划描述</p>
        /// </summary>
        [JsonProperty("InstanceSchedulerDesc")]
        public string InstanceSchedulerDesc{ get; set; }

        /// <summary>
        /// <p>当前用户对该实例的权限列表</p>
        /// </summary>
        [JsonProperty("Privileges")]
        public string[] Privileges{ get; set; }

        /// <summary>
        /// <p>任务执行id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskExecutionId")]
        public string TaskExecutionId{ get; set; }

        /// <summary>
        /// <p>dlc taskid</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DlcTaskId")]
        public string DlcTaskId{ get; set; }

        /// <summary>
        /// <p>dlc jobid</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DlcSparkJobId")]
        public string DlcSparkJobId{ get; set; }

        /// <summary>
        /// <p>扩展属性</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Ext")]
        public StrToStrMap Ext{ get; set; }

        /// <summary>
        /// <p>事件列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelatedEventList")]
        public EventCaseAuditLogOptDto[] RelatedEventList{ get; set; }

        /// <summary>
        /// <p>代理任务ID（仅 嵌套场景使用，非 嵌套 场景为 null）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyTaskId")]
        public string ProxyTaskId{ get; set; }

        /// <summary>
        /// <p>嵌套工作流名称（仅 嵌套场景使用，非 嵌套 场景为 null）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowRunName")]
        public string WorkflowRunName{ get; set; }

        /// <summary>
        /// <p>代理任务类型（仅 嵌套场景使用，非 嵌套 场景为 null）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyTaskType")]
        public TaskTypeOpsDto ProxyTaskType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamSimple(map, prefix + "InCharge", this.InCharge);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "CurRunDate", this.CurRunDate);
            this.SetParamSimple(map, prefix + "NextCurDate", this.NextCurDate);
            this.SetParamSimple(map, prefix + "RunPriority", this.RunPriority);
            this.SetParamSimple(map, prefix + "TryLimit", this.TryLimit);
            this.SetParamSimple(map, prefix + "Tries", this.Tries);
            this.SetParamSimple(map, prefix + "TotalRunNum", this.TotalRunNum);
            this.SetParamSimple(map, prefix + "DoFlag", this.DoFlag);
            this.SetParamSimple(map, prefix + "RedoFlag", this.RedoFlag);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "RuntimeBroker", this.RuntimeBroker);
            this.SetParamSimple(map, prefix + "ErrorDesc", this.ErrorDesc);
            this.SetParamObj(map, prefix + "TaskType.", this.TaskType);
            this.SetParamSimple(map, prefix + "DependenceFulfillTime", this.DependenceFulfillTime);
            this.SetParamSimple(map, prefix + "FirstDependenceFulfillTime", this.FirstDependenceFulfillTime);
            this.SetParamSimple(map, prefix + "FirstStartTime", this.FirstStartTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CostTime", this.CostTime);
            this.SetParamSimple(map, prefix + "CostMillisecond", this.CostMillisecond);
            this.SetParamSimple(map, prefix + "MaxCostTime", this.MaxCostTime);
            this.SetParamSimple(map, prefix + "MinCostTime", this.MinCostTime);
            this.SetParamSimple(map, prefix + "AvgCostTime", this.AvgCostTime);
            this.SetParamSimple(map, prefix + "LastLog", this.LastLog);
            this.SetParamSimple(map, prefix + "SchedulerDateTime", this.SchedulerDateTime);
            this.SetParamSimple(map, prefix + "LastSchedulerDateTime", this.LastSchedulerDateTime);
            this.SetParamSimple(map, prefix + "LastUpdate", this.LastUpdate);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DependencyRel", this.DependencyRel);
            this.SetParamSimple(map, prefix + "ExecutionSpace", this.ExecutionSpace);
            this.SetParamSimple(map, prefix + "IgnoreEvent", this.IgnoreEvent);
            this.SetParamSimple(map, prefix + "VirtualFlag", this.VirtualFlag);
            this.SetParamSimple(map, prefix + "FolderId", this.FolderId);
            this.SetParamSimple(map, prefix + "FolderName", this.FolderName);
            this.SetParamSimple(map, prefix + "SonList", this.SonList);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "ResourceGroup", this.ResourceGroup);
            this.SetParamSimple(map, prefix + "ResourceInstanceId", this.ResourceInstanceId);
            this.SetParamSimple(map, prefix + "YarnQueue", this.YarnQueue);
            this.SetParamSimple(map, prefix + "SchedulerDesc", this.SchedulerDesc);
            this.SetParamSimple(map, prefix + "FirstSubmitTime", this.FirstSubmitTime);
            this.SetParamSimple(map, prefix + "FirstRunTime", this.FirstRunTime);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectIdent", this.ProjectIdent);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "TenantId", this.TenantId);
            this.SetParamSimple(map, prefix + "InstanceKey", this.InstanceKey);
            this.SetParamSimple(map, prefix + "ExecutorGroupId", this.ExecutorGroupId);
            this.SetParamSimple(map, prefix + "ExecutorGroupName", this.ExecutorGroupName);
            this.SetParamArrayObj(map, prefix + "RelatedInstanceList.", this.RelatedInstanceList);
            this.SetParamSimple(map, prefix + "RelatedInstanceSize", this.RelatedInstanceSize);
            this.SetParamSimple(map, prefix + "OwnerId", this.OwnerId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamObj(map, prefix + "InstanceLifeCycleOpsDto.", this.InstanceLifeCycleOpsDto);
            this.SetParamSimple(map, prefix + "RetryAttempts", this.RetryAttempts);
            this.SetParamArraySimple(map, prefix + "DeletedFatherList.", this.DeletedFatherList);
            this.SetParamArrayObj(map, prefix + "CirculateInstanceList.", this.CirculateInstanceList);
            this.SetParamSimple(map, prefix + "ConcurrentStrategy", this.ConcurrentStrategy);
            this.SetParamSimple(map, prefix + "ScheduleRunType", this.ScheduleRunType);
            this.SetParamSimple(map, prefix + "AllowRedoType", this.AllowRedoType);
            this.SetParamSimple(map, prefix + "InstanceCycleType", this.InstanceCycleType);
            this.SetParamSimple(map, prefix + "InstanceSchedulerDesc", this.InstanceSchedulerDesc);
            this.SetParamArraySimple(map, prefix + "Privileges.", this.Privileges);
            this.SetParamSimple(map, prefix + "TaskExecutionId", this.TaskExecutionId);
            this.SetParamSimple(map, prefix + "DlcTaskId", this.DlcTaskId);
            this.SetParamSimple(map, prefix + "DlcSparkJobId", this.DlcSparkJobId);
            this.SetParamObj(map, prefix + "Ext.", this.Ext);
            this.SetParamArrayObj(map, prefix + "RelatedEventList.", this.RelatedEventList);
            this.SetParamSimple(map, prefix + "ProxyTaskId", this.ProxyTaskId);
            this.SetParamSimple(map, prefix + "WorkflowRunName", this.WorkflowRunName);
            this.SetParamObj(map, prefix + "ProxyTaskType.", this.ProxyTaskType);
        }
    }
}

