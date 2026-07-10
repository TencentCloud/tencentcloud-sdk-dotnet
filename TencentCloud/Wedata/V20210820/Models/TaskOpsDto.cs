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
        /// <p>任务ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>虚拟任务id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VirtualTaskId")]
        public string VirtualTaskId{ get; set; }

        /// <summary>
        /// <p>虚拟任务标记</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VirtualFlag")]
        public bool? VirtualFlag{ get; set; }

        /// <summary>
        /// <p>任务名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>工作流id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// <p>任务为虚拟任务时，任务所在的真实工作流Id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealWorkflowId")]
        public string RealWorkflowId{ get; set; }

        /// <summary>
        /// <p>工作流名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }

        /// <summary>
        /// <p>文件夹id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FolderId")]
        public string FolderId{ get; set; }

        /// <summary>
        /// <p>文件夹名字</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FolderName")]
        public string FolderName{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>最近更新时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastUpdate")]
        public string LastUpdate{ get; set; }

        /// <summary>
        /// <p>任务状态</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>责任人</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InCharge")]
        public string InCharge{ get; set; }

        /// <summary>
        /// <p>责任人用户id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InChargeId")]
        public string InChargeId{ get; set; }

        /// <summary>
        /// <p>调度生效日期</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>调度结束日期</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>执行时间左闭区间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutionStartTime")]
        public string ExecutionStartTime{ get; set; }

        /// <summary>
        /// <p>执行时间右闭区间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutionEndTime")]
        public string ExecutionEndTime{ get; set; }

        /// <summary>
        /// <p>周期类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

        /// <summary>
        /// <p>步长</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CycleStep")]
        public ulong? CycleStep{ get; set; }

        /// <summary>
        /// <p>调度cron表达式</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CrontabExpression")]
        public string CrontabExpression{ get; set; }

        /// <summary>
        /// <p>延时执行时间，unit=分钟</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DelayTime")]
        public ulong? DelayTime{ get; set; }

        /// <summary>
        /// <p>开始执行时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartupTime")]
        public ulong? StartupTime{ get; set; }

        /// <summary>
        /// <p>重试等待时间, unit=分钟</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RetryWait")]
        public ulong? RetryWait{ get; set; }

        /// <summary>
        /// <p>是否可重试，1 代表可以重试</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RetryAble")]
        public ulong? RetryAble{ get; set; }

        /// <summary>
        /// <p>调度配置-弹性周期配置，小时/周/月/年调度才有，小时任务指定每天的0点3点4点跑，则为&#39;0,3,4&#39;</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskAction")]
        public string TaskAction{ get; set; }

        /// <summary>
        /// <p>运行次数限制</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TryLimit")]
        public ulong? TryLimit{ get; set; }

        /// <summary>
        /// <p>运行优先级</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunPriority")]
        public ulong? RunPriority{ get; set; }

        /// <summary>
        /// <p>任务类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskType")]
        public TaskTypeOpsDto TaskType{ get; set; }

        /// <summary>
        /// <p>指定的运行节点</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BrokerIp")]
        public string BrokerIp{ get; set; }

        /// <summary>
        /// <p>集群name</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>最小数据时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MinDateTime")]
        public string MinDateTime{ get; set; }

        /// <summary>
        /// <p>最大数据时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxDateTime")]
        public string MaxDateTime{ get; set; }

        /// <summary>
        /// <p>运行耗时超时时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutionTTL")]
        public long? ExecutionTTL{ get; set; }

        /// <summary>
        /// <p>自依赖类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SelfDepend")]
        public string SelfDepend{ get; set; }

        /// <summary>
        /// <p>左侧坐标</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LeftCoordinate")]
        public float? LeftCoordinate{ get; set; }

        /// <summary>
        /// <p>顶部坐标</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopCoordinate")]
        public float? TopCoordinate{ get; set; }

        /// <summary>
        /// <p>任务备注</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Notes")]
        public string Notes{ get; set; }

        /// <summary>
        /// <p>任务初始化策略</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceInitStrategy")]
        public string InstanceInitStrategy{ get; set; }

        /// <summary>
        /// <p>计算队列</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("YarnQueue")]
        public string YarnQueue{ get; set; }

        /// <summary>
        /// <p>最新调度提交时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastSchedulerCommitTime")]
        public string LastSchedulerCommitTime{ get; set; }

        /// <summary>
        /// <p>按cron表达式计算的任务开始执行时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NormalizedJobStartTime")]
        public string NormalizedJobStartTime{ get; set; }

        /// <summary>
        /// <p>调度计划描述</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchedulerDesc")]
        public string SchedulerDesc{ get; set; }

        /// <summary>
        /// <p>计算资源组</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroup")]
        public string ResourceGroup{ get; set; }

        /// <summary>
        /// <p>任务创建人</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// <p>任务依赖类型 and、or</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DependencyRel")]
        public string DependencyRel{ get; set; }

        /// <summary>
        /// <p>任务工作流依赖 yes、no</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DependencyWorkflow")]
        public string DependencyWorkflow{ get; set; }

        /// <summary>
        /// <p>事件监听配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventListenerConfig")]
        public string EventListenerConfig{ get; set; }

        /// <summary>
        /// <p>事件驱动配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventPublisherConfig")]
        public string EventPublisherConfig{ get; set; }

        /// <summary>
        /// <p>虚拟任务状态</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VirtualTaskStatus")]
        public string VirtualTaskStatus{ get; set; }

        /// <summary>
        /// <p>任务依赖边详情</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskLinkInfo")]
        public LinkOpsDto TaskLinkInfo{ get; set; }

        /// <summary>
        /// <p>任务产品类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// <p>项目id</p>
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
        /// <p>主账户userId</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnId")]
        public string OwnId{ get; set; }

        /// <summary>
        /// <p>用户userId</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// <p>租户id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TenantId")]
        public string TenantId{ get; set; }

        /// <summary>
        /// <p>更新人昵称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateUser")]
        public string UpdateUser{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>更新人userId</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateUserId")]
        public string UpdateUserId{ get; set; }

        /// <summary>
        /// <p>任务类型id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskTypeId")]
        public long? TaskTypeId{ get; set; }

        /// <summary>
        /// <p>任务类型描述</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskTypeDesc")]
        public string TaskTypeDesc{ get; set; }

        /// <summary>
        /// <p>是否展示工作流</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShowWorkflow")]
        public bool? ShowWorkflow{ get; set; }

        /// <summary>
        /// <p>首次提交时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FirstSubmitTime")]
        public string FirstSubmitTime{ get; set; }

        /// <summary>
        /// <p>首次运行时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FirstRunTime")]
        public string FirstRunTime{ get; set; }

        /// <summary>
        /// <p>调度描述</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScheduleDesc")]
        public string ScheduleDesc{ get; set; }

        /// <summary>
        /// <p>周期</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CycleNum")]
        public long? CycleNum{ get; set; }

        /// <summary>
        /// <p>表达式</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Crontab")]
        public string Crontab{ get; set; }

        /// <summary>
        /// <p>开始日期</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// <p>结束日期</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }

        /// <summary>
        /// <p>周期单位</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CycleUnit")]
        public string CycleUnit{ get; set; }

        /// <summary>
        /// <p>初始化策略</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InitStrategy")]
        public string InitStrategy{ get; set; }

        /// <summary>
        /// <p>层级</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Layer")]
        public string Layer{ get; set; }

        /// <summary>
        /// <p>来源数据源ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceServiceId")]
        public string SourceServiceId{ get; set; }

        /// <summary>
        /// <p>来源数据源类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceServiceType")]
        public string SourceServiceType{ get; set; }

        /// <summary>
        /// <p>目标数据源ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetServiceId")]
        public string TargetServiceId{ get; set; }

        /// <summary>
        /// <p>目标数据源类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetServiceType")]
        public string TargetServiceType{ get; set; }

        /// <summary>
        /// <p>子任务列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TasksStr")]
        public string TasksStr{ get; set; }

        /// <summary>
        /// <p>任务版本是否已提交</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Submit")]
        public bool? Submit{ get; set; }

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
        /// <p>任务扩展信息(目前返沪离线同步的任务详情)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskExtInfo")]
        public string TaskExtInfo{ get; set; }

        /// <summary>
        /// <p>任务绑定的事件信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventListenerInfos")]
        public AiOpsEventListenerDTO[] EventListenerInfos{ get; set; }

        /// <summary>
        /// <p>脚本信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScriptInfo")]
        public AiopsScriptInfo ScriptInfo{ get; set; }

        /// <summary>
        /// <p>DLC资源配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DLCResourceConfig")]
        public AiopsDLCResourceConfigDto DLCResourceConfig{ get; set; }

        /// <summary>
        /// <p>父任务simple信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentTaskInfos")]
        public AiopsSimpleTaskDto ParentTaskInfos{ get; set; }

        /// <summary>
        /// <p>资源获取标识</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtResourceFlag")]
        public ExtResourceFlagDto ExtResourceFlag{ get; set; }

        /// <summary>
        /// <p>父任务simple信息(新)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NewParentTaskInfos")]
        public AiopsSimpleTaskDto[] NewParentTaskInfos{ get; set; }

        /// <summary>
        /// <p>任务自依赖类型：<br>yes： 任务需满足自依赖<br>no：任务无需满足自依赖</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SelfWorkFlowDependType")]
        public string SelfWorkFlowDependType{ get; set; }

        /// <summary>
        /// <p>允许重跑类型，ALL 表示无论实例运行成功还是失败都允许重跑，NONE表示无论成功或者失败都不允许重跑，FAILURE 表示只有运行失败才能重跑</p>
        /// </summary>
        [JsonProperty("AllowRedoType")]
        public string AllowRedoType{ get; set; }

        /// <summary>
        /// <p>负责人Id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerId")]
        public string OwnerId{ get; set; }

        /// <summary>
        /// <p>当前用户对该任务的权限列表， 当前支持<br>CAN_MANAGE : 有权限管理操作</p>
        /// </summary>
        [JsonProperty("Privileges")]
        public string[] Privileges{ get; set; }

        /// <summary>
        /// <p>bundle客户端唯一id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// <p>bundle客户端信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BundleInfo")]
        public string BundleInfo{ get; set; }

        /// <summary>
        /// <p>工作流类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowType")]
        public string WorkflowType{ get; set; }

        /// <summary>
        /// <p>任务扩展信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskExtDTO")]
        public TaskExtOpsDto TaskExtDTO{ get; set; }

        /// <summary>
        /// <p>任务时区</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScheduleTimeZone")]
        public string ScheduleTimeZone{ get; set; }

        /// <summary>
        /// <p>代理任务ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyTaskId")]
        public string ProxyTaskId{ get; set; }

        /// <summary>
        /// <p>代理任务类型ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyTaskTypeId")]
        public long? ProxyTaskTypeId{ get; set; }


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
            this.SetParamSimple(map, prefix + "WorkflowType", this.WorkflowType);
            this.SetParamObj(map, prefix + "TaskExtDTO.", this.TaskExtDTO);
            this.SetParamSimple(map, prefix + "ScheduleTimeZone", this.ScheduleTimeZone);
            this.SetParamSimple(map, prefix + "ProxyTaskId", this.ProxyTaskId);
            this.SetParamSimple(map, prefix + "ProxyTaskTypeId", this.ProxyTaskTypeId);
        }
    }
}

