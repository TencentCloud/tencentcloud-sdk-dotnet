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

    public class TaskOpsDto : AbstractModel
    {
        
        /// <summary>
        /// 任务ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 虚拟任务id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VirtualTaskId")]
        public string VirtualTaskId{ get; set; }

        /// <summary>
        /// 虚拟任务标记
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VirtualFlag")]
        public bool? VirtualFlag{ get; set; }

        /// <summary>
        /// 任务名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 工作流id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// 任务为虚拟任务时，任务所在的真实工作流Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealWorkflowId")]
        public string RealWorkflowId{ get; set; }

        /// <summary>
        /// 工作流名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }

        /// <summary>
        /// 文件夹id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FolderId")]
        public string FolderId{ get; set; }

        /// <summary>
        /// 文件夹名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FolderName")]
        public string FolderName{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 最近更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastUpdate")]
        public string LastUpdate{ get; set; }

        /// <summary>
        /// 任务状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 责任人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InCharge")]
        public string InCharge{ get; set; }

        /// <summary>
        /// 责任人用户id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InChargeId")]
        public string InChargeId{ get; set; }

        /// <summary>
        /// 调度生效日期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 调度结束日期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 执行时间左闭区间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutionStartTime")]
        public string ExecutionStartTime{ get; set; }

        /// <summary>
        /// 执行时间右闭区间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutionEndTime")]
        public string ExecutionEndTime{ get; set; }

        /// <summary>
        /// 周期类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

        /// <summary>
        /// 步长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CycleStep")]
        public ulong? CycleStep{ get; set; }

        /// <summary>
        /// 调度cron表达式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CrontabExpression")]
        public string CrontabExpression{ get; set; }

        /// <summary>
        /// 延时执行时间，unit=分钟
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DelayTime")]
        public ulong? DelayTime{ get; set; }

        /// <summary>
        /// 开始执行时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartupTime")]
        public ulong? StartupTime{ get; set; }

        /// <summary>
        /// 重试等待时间, unit=分钟
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RetryWait")]
        public ulong? RetryWait{ get; set; }

        /// <summary>
        /// 是否可重试，1 代表可以重试
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RetryAble")]
        public ulong? RetryAble{ get; set; }

        /// <summary>
        /// 调度配置-弹性周期配置，小时/周/月/年调度才有，小时任务指定每天的0点3点4点跑，则为'0,3,4'
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskAction")]
        public string TaskAction{ get; set; }

        /// <summary>
        /// 运行次数限制
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TryLimit")]
        public ulong? TryLimit{ get; set; }

        /// <summary>
        /// 运行优先级
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunPriority")]
        public ulong? RunPriority{ get; set; }

        /// <summary>
        /// 任务类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskType")]
        public TaskTypeOpsDto TaskType{ get; set; }

        /// <summary>
        /// 指定的运行节点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BrokerIp")]
        public string BrokerIp{ get; set; }

        /// <summary>
        /// 集群name
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 最小数据时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MinDateTime")]
        public string MinDateTime{ get; set; }

        /// <summary>
        /// 最大数据时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxDateTime")]
        public string MaxDateTime{ get; set; }

        /// <summary>
        /// 运行耗时超时时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutionTTL")]
        public long? ExecutionTTL{ get; set; }

        /// <summary>
        /// 自依赖类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SelfDepend")]
        public string SelfDepend{ get; set; }

        /// <summary>
        /// 左侧坐标
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LeftCoordinate")]
        public float? LeftCoordinate{ get; set; }

        /// <summary>
        /// 顶部坐标
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopCoordinate")]
        public float? TopCoordinate{ get; set; }

        /// <summary>
        /// 任务备注
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Notes")]
        public string Notes{ get; set; }

        /// <summary>
        /// 任务初始化策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceInitStrategy")]
        public string InstanceInitStrategy{ get; set; }

        /// <summary>
        /// 计算队列
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("YarnQueue")]
        public string YarnQueue{ get; set; }

        /// <summary>
        /// 最新调度提交时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastSchedulerCommitTime")]
        public string LastSchedulerCommitTime{ get; set; }

        /// <summary>
        /// 按cron表达式计算的任务开始执行时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NormalizedJobStartTime")]
        public string NormalizedJobStartTime{ get; set; }

        /// <summary>
        /// 调度计划描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchedulerDesc")]
        public string SchedulerDesc{ get; set; }

        /// <summary>
        /// 计算资源组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroup")]
        public string ResourceGroup{ get; set; }

        /// <summary>
        /// 任务创建人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// 任务依赖类型 and、or
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DependencyRel")]
        public string DependencyRel{ get; set; }

        /// <summary>
        /// 任务工作流依赖 yes、no
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DependencyWorkflow")]
        public string DependencyWorkflow{ get; set; }

        /// <summary>
        /// 事件监听配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventListenerConfig")]
        public string EventListenerConfig{ get; set; }

        /// <summary>
        /// 事件驱动配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventPublisherConfig")]
        public string EventPublisherConfig{ get; set; }

        /// <summary>
        /// 虚拟任务状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VirtualTaskStatus")]
        public string VirtualTaskStatus{ get; set; }

        /// <summary>
        /// 任务依赖边详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskLinkInfo")]
        public LinkOpsDto TaskLinkInfo{ get; set; }

        /// <summary>
        /// 任务产品类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

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
        /// 主账户userId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnId")]
        public string OwnId{ get; set; }

        /// <summary>
        /// 用户userId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 租户id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TenantId")]
        public string TenantId{ get; set; }

        /// <summary>
        /// 更新人昵称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateUser")]
        public string UpdateUser{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 更新人userId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateUserId")]
        public string UpdateUserId{ get; set; }

        /// <summary>
        /// 任务类型id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskTypeId")]
        public long? TaskTypeId{ get; set; }

        /// <summary>
        /// 任务类型描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskTypeDesc")]
        public string TaskTypeDesc{ get; set; }

        /// <summary>
        /// 是否展示工作流
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShowWorkflow")]
        public bool? ShowWorkflow{ get; set; }

        /// <summary>
        /// 首次提交时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FirstSubmitTime")]
        public string FirstSubmitTime{ get; set; }

        /// <summary>
        /// 首次运行时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FirstRunTime")]
        public string FirstRunTime{ get; set; }

        /// <summary>
        /// 调度描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScheduleDesc")]
        public string ScheduleDesc{ get; set; }

        /// <summary>
        /// 周期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CycleNum")]
        public long? CycleNum{ get; set; }

        /// <summary>
        /// 表达式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Crontab")]
        public string Crontab{ get; set; }

        /// <summary>
        /// 开始日期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// 结束日期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }

        /// <summary>
        /// 周期单位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CycleUnit")]
        public string CycleUnit{ get; set; }

        /// <summary>
        /// 初始化策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InitStrategy")]
        public string InitStrategy{ get; set; }

        /// <summary>
        /// 层级
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Layer")]
        public string Layer{ get; set; }

        /// <summary>
        /// 来源数据源ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceServiceId")]
        public string SourceServiceId{ get; set; }

        /// <summary>
        /// 来源数据源类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceServiceType")]
        public string SourceServiceType{ get; set; }

        /// <summary>
        /// 目标数据源ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetServiceId")]
        public string TargetServiceId{ get; set; }

        /// <summary>
        /// 目标数据源类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetServiceType")]
        public string TargetServiceType{ get; set; }

        /// <summary>
        /// 子任务列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TasksStr")]
        public string TasksStr{ get; set; }

        /// <summary>
        /// 任务版本是否已提交
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Submit")]
        public bool? Submit{ get; set; }

        /// <summary>
        /// 资源组id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorGroupId")]
        public string ExecutorGroupId{ get; set; }

        /// <summary>
        /// 资源组名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorGroupName")]
        public string ExecutorGroupName{ get; set; }

        /// <summary>
        /// 任务扩展信息(目前返沪离线同步的任务详情)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskExtInfo")]
        public string TaskExtInfo{ get; set; }

        /// <summary>
        /// 任务绑定的事件信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventListenerInfos")]
        public AiOpsEventListenerDTO[] EventListenerInfos{ get; set; }

        /// <summary>
        /// 脚本信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScriptInfo")]
        public AiopsScriptInfo ScriptInfo{ get; set; }

        /// <summary>
        /// DLC资源配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DLCResourceConfig")]
        public AiopsDLCResourceConfigDto DLCResourceConfig{ get; set; }

        /// <summary>
        /// 父任务simple信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentTaskInfos")]
        public AiopsSimpleTaskDto ParentTaskInfos{ get; set; }

        /// <summary>
        /// 资源获取标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtResourceFlag")]
        public ExtResourceFlagDto ExtResourceFlag{ get; set; }

        /// <summary>
        /// 父任务simple信息(新)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NewParentTaskInfos")]
        public AiopsSimpleTaskDto[] NewParentTaskInfos{ get; set; }

        /// <summary>
        /// 任务自依赖类型：
        /// yes： 任务需满足自依赖
        /// no：任务无需满足自依赖
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SelfWorkFlowDependType")]
        public string SelfWorkFlowDependType{ get; set; }

        /// <summary>
        /// 允许重跑类型，ALL 表示无论实例运行成功还是失败都允许重跑，NONE表示无论成功或者失败都不允许重跑，FAILURE 表示只有运行失败才能重跑
        /// </summary>
        [JsonProperty("AllowRedoType")]
        public string AllowRedoType{ get; set; }

        /// <summary>
        /// 负责人Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerId")]
        public string OwnerId{ get; set; }

        /// <summary>
        /// 当前用户对该任务的权限列表， 当前支持
        /// CAN_MANAGE : 有权限管理操作
        /// </summary>
        [JsonProperty("Privileges")]
        public string[] Privileges{ get; set; }

        /// <summary>
        /// bundle客户端唯一id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// bundle客户端信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BundleInfo")]
        public string BundleInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "VirtualTaskId", this.VirtualTaskId);
            this.SetParamSimple(map, prefix + "VirtualFlag", this.VirtualFlag);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "RealWorkflowId", this.RealWorkflowId);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamSimple(map, prefix + "FolderId", this.FolderId);
            this.SetParamSimple(map, prefix + "FolderName", this.FolderName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LastUpdate", this.LastUpdate);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "InCharge", this.InCharge);
            this.SetParamSimple(map, prefix + "InChargeId", this.InChargeId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ExecutionStartTime", this.ExecutionStartTime);
            this.SetParamSimple(map, prefix + "ExecutionEndTime", this.ExecutionEndTime);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "CycleStep", this.CycleStep);
            this.SetParamSimple(map, prefix + "CrontabExpression", this.CrontabExpression);
            this.SetParamSimple(map, prefix + "DelayTime", this.DelayTime);
            this.SetParamSimple(map, prefix + "StartupTime", this.StartupTime);
            this.SetParamSimple(map, prefix + "RetryWait", this.RetryWait);
            this.SetParamSimple(map, prefix + "RetryAble", this.RetryAble);
            this.SetParamSimple(map, prefix + "TaskAction", this.TaskAction);
            this.SetParamSimple(map, prefix + "TryLimit", this.TryLimit);
            this.SetParamSimple(map, prefix + "RunPriority", this.RunPriority);
            this.SetParamObj(map, prefix + "TaskType.", this.TaskType);
            this.SetParamSimple(map, prefix + "BrokerIp", this.BrokerIp);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "MinDateTime", this.MinDateTime);
            this.SetParamSimple(map, prefix + "MaxDateTime", this.MaxDateTime);
            this.SetParamSimple(map, prefix + "ExecutionTTL", this.ExecutionTTL);
            this.SetParamSimple(map, prefix + "SelfDepend", this.SelfDepend);
            this.SetParamSimple(map, prefix + "LeftCoordinate", this.LeftCoordinate);
            this.SetParamSimple(map, prefix + "TopCoordinate", this.TopCoordinate);
            this.SetParamSimple(map, prefix + "Notes", this.Notes);
            this.SetParamSimple(map, prefix + "InstanceInitStrategy", this.InstanceInitStrategy);
            this.SetParamSimple(map, prefix + "YarnQueue", this.YarnQueue);
            this.SetParamSimple(map, prefix + "LastSchedulerCommitTime", this.LastSchedulerCommitTime);
            this.SetParamSimple(map, prefix + "NormalizedJobStartTime", this.NormalizedJobStartTime);
            this.SetParamSimple(map, prefix + "SchedulerDesc", this.SchedulerDesc);
            this.SetParamSimple(map, prefix + "ResourceGroup", this.ResourceGroup);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "DependencyRel", this.DependencyRel);
            this.SetParamSimple(map, prefix + "DependencyWorkflow", this.DependencyWorkflow);
            this.SetParamSimple(map, prefix + "EventListenerConfig", this.EventListenerConfig);
            this.SetParamSimple(map, prefix + "EventPublisherConfig", this.EventPublisherConfig);
            this.SetParamSimple(map, prefix + "VirtualTaskStatus", this.VirtualTaskStatus);
            this.SetParamObj(map, prefix + "TaskLinkInfo.", this.TaskLinkInfo);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectIdent", this.ProjectIdent);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "OwnId", this.OwnId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "TenantId", this.TenantId);
            this.SetParamSimple(map, prefix + "UpdateUser", this.UpdateUser);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "UpdateUserId", this.UpdateUserId);
            this.SetParamSimple(map, prefix + "TaskTypeId", this.TaskTypeId);
            this.SetParamSimple(map, prefix + "TaskTypeDesc", this.TaskTypeDesc);
            this.SetParamSimple(map, prefix + "ShowWorkflow", this.ShowWorkflow);
            this.SetParamSimple(map, prefix + "FirstSubmitTime", this.FirstSubmitTime);
            this.SetParamSimple(map, prefix + "FirstRunTime", this.FirstRunTime);
            this.SetParamSimple(map, prefix + "ScheduleDesc", this.ScheduleDesc);
            this.SetParamSimple(map, prefix + "CycleNum", this.CycleNum);
            this.SetParamSimple(map, prefix + "Crontab", this.Crontab);
            this.SetParamSimple(map, prefix + "StartDate", this.StartDate);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
            this.SetParamSimple(map, prefix + "CycleUnit", this.CycleUnit);
            this.SetParamSimple(map, prefix + "InitStrategy", this.InitStrategy);
            this.SetParamSimple(map, prefix + "Layer", this.Layer);
            this.SetParamSimple(map, prefix + "SourceServiceId", this.SourceServiceId);
            this.SetParamSimple(map, prefix + "SourceServiceType", this.SourceServiceType);
            this.SetParamSimple(map, prefix + "TargetServiceId", this.TargetServiceId);
            this.SetParamSimple(map, prefix + "TargetServiceType", this.TargetServiceType);
            this.SetParamSimple(map, prefix + "TasksStr", this.TasksStr);
            this.SetParamSimple(map, prefix + "Submit", this.Submit);
            this.SetParamSimple(map, prefix + "ExecutorGroupId", this.ExecutorGroupId);
            this.SetParamSimple(map, prefix + "ExecutorGroupName", this.ExecutorGroupName);
            this.SetParamSimple(map, prefix + "TaskExtInfo", this.TaskExtInfo);
            this.SetParamArrayObj(map, prefix + "EventListenerInfos.", this.EventListenerInfos);
            this.SetParamObj(map, prefix + "ScriptInfo.", this.ScriptInfo);
            this.SetParamObj(map, prefix + "DLCResourceConfig.", this.DLCResourceConfig);
            this.SetParamObj(map, prefix + "ParentTaskInfos.", this.ParentTaskInfos);
            this.SetParamObj(map, prefix + "ExtResourceFlag.", this.ExtResourceFlag);
            this.SetParamArrayObj(map, prefix + "NewParentTaskInfos.", this.NewParentTaskInfos);
            this.SetParamSimple(map, prefix + "SelfWorkFlowDependType", this.SelfWorkFlowDependType);
            this.SetParamSimple(map, prefix + "AllowRedoType", this.AllowRedoType);
            this.SetParamSimple(map, prefix + "OwnerId", this.OwnerId);
            this.SetParamArraySimple(map, prefix + "Privileges.", this.Privileges);
            this.SetParamSimple(map, prefix + "BundleId", this.BundleId);
            this.SetParamSimple(map, prefix + "BundleInfo", this.BundleInfo);
        }
    }
}

