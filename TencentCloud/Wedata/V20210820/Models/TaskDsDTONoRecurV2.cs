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

    public class TaskDsDTONoRecurV2 : AbstractModel
    {
        
        /// <summary>
        /// 任务ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 虚拟任务标记
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
        /// 真实工作流id
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
        /// 更新时间
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
        /// 生效日期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束日期
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
        public long? CycleStep{ get; set; }

        /// <summary>
        /// 对于crontab类型调度配置其为用户输入 对于周期类型调度配置其为系统计算
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CrontabExpression")]
        public string CrontabExpression{ get; set; }

        /// <summary>
        /// 延时调度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DelayTime")]
        public long? DelayTime{ get; set; }

        /// <summary>
        /// 延时执行时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartupTime")]
        public long? StartupTime{ get; set; }

        /// <summary>
        /// 重试等待时间,单位分钟
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RetryWait")]
        public long? RetryWait{ get; set; }

        /// <summary>
        /// 是否可重试
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Retriable")]
        public long? Retriable{ get; set; }

        /// <summary>
        /// 调度扩展信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskAction")]
        public string TaskAction{ get; set; }

        /// <summary>
        /// 运行次数限制
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TryLimit")]
        public long? TryLimit{ get; set; }

        /// <summary>
        /// 运行优先级
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunPriority")]
        public long? RunPriority{ get; set; }

        /// <summary>
        /// 任务类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskType")]
        public TaskTypeDsVO TaskType{ get; set; }

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
        /// 是否自身依赖 是1 否2 并行3
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SelfDepend")]
        public long? SelfDepend{ get; set; }

        /// <summary>
        /// LeftCoordinate坐标
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LeftCoordinate")]
        public float? LeftCoordinate{ get; set; }

        /// <summary>
        /// TopCoordinate坐标
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopCoordinate")]
        public float? TopCoordinate{ get; set; }

        /// <summary>
        /// TaskExt信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskExt")]
        public TaskExtDsVO TaskExt{ get; set; }

        /// <summary>
        /// taskExt 导入导出json使用 private Map  properties;
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Properties")]
        public string Properties{ get; set; }

        /// <summary>
        /// 任务备注
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Notes")]
        public string Notes{ get; set; }

        /// <summary>
        /// 实例生成策略 T+1 表示当前周期生成上一周期数据时间任务实例 默认T+1 T+0 表示当前周期生成当前周期数据时间任务实例 T-1
        ///      * 表示当前周期生成下一周期数据时间任务实例
        ///      *
        ///      * service不做默认策略处理, 下沉到数据初始化默认T+1, service涉及到多个更新task的路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceInitStrategy")]
        public string InstanceInitStrategy{ get; set; }

        /// <summary>
        /// 资源池队列名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("YarnQueue")]
        public string YarnQueue{ get; set; }

        /// <summary>
        /// 任务告警信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Alarms")]
        public AlarmDsVO[] Alarms{ get; set; }

        /// <summary>
        /// alarmDTO 导入导出json使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Alarm")]
        public string Alarm{ get; set; }

        /// <summary>
        /// 任务脚本是否发生变化
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScriptChange")]
        public bool? ScriptChange{ get; set; }

        /// <summary>
        /// 任务版本是否已提交
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Submit")]
        public bool? Submit{ get; set; }

        /// <summary>
        /// 最新调度计划变更时间 仅生产态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastSchedulerCommitTime")]
        public string LastSchedulerCommitTime{ get; set; }

        /// <summary>
        /// 仅生产态存储于生产态序列化任务信息, 减少base CPU重复密集计算
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NormalizedJobStartTime")]
        public string NormalizedJobStartTime{ get; set; }

        /// <summary>
        /// 启动暂停的任务时，选择不补录中间实例，通过此字段来标识从哪个时间开始生成实例
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecoverFreezeStartTime")]
        public string RecoverFreezeStartTime{ get; set; }

        /// <summary>
        /// 源数据源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceServer")]
        public string SourceServer{ get; set; }

        /// <summary>
        /// 目标数据源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetServer")]
        public string TargetServer{ get; set; }

        /// <summary>
        /// 父子节点树
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tasks")]
        public string[] Tasks{ get; set; }

        /// <summary>
        /// 创建者
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Creater")]
        public string Creater{ get; set; }

        /// <summary>
        /// 分支，依赖关系，and/or, 默认and
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DependencyRel")]
        public string DependencyRel{ get; set; }

        /// <summary>
        /// 是否支持工作流依赖 yes / no 默认 no
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DependencyWorkflow")]
        public string DependencyWorkflow{ get; set; }

        /// <summary>
        /// 支持事件监听器配置导入导出
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventListenerConfig")]
        public string EventListenerConfig{ get; set; }

        /// <summary>
        /// 支持事件触发器配置导入导出
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventPublisherConfig")]
        public string EventPublisherConfig{ get; set; }

        /// <summary>
        /// 依赖配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DependencyConfigList")]
        public string[] DependencyConfigList{ get; set; }

        /// <summary>
        /// 虚拟任务状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VirtualTaskStatus")]
        public string VirtualTaskStatus{ get; set; }

        /// <summary>
        /// 回收站还原提示语
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecycleTips")]
        public string RecycleTips{ get; set; }

        /// <summary>
        /// 回收站所属用户
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecycleUser")]
        public string RecycleUser{ get; set; }

        /// <summary>
        /// 新增 或 修改
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NewOrUpdate")]
        public string NewOrUpdate{ get; set; }

        /// <summary>
        /// 任务上游依赖信息 用于发布管理导入导出
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Params")]
        public ParameterTaskDsDto[] Params{ get; set; }

        /// <summary>
        /// 任务上游依赖信息 用于发布管理导入导出
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskLinkInfo")]
        public TaskLinkDsDTO[] TaskLinkInfo{ get; set; }

        /// <summary>
        /// 导入结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImportResult")]
        public bool? ImportResult{ get; set; }

        /// <summary>
        /// 导入失败原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImportErrMsg")]
        public string ImportErrMsg{ get; set; }

        /// <summary>
        /// 任务内容 全部内容 配置内容 资源内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContentType")]
        public string ContentType{ get; set; }

        /// <summary>
        /// 是否导入提交运行
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskAutoSubmit")]
        public bool? TaskAutoSubmit{ get; set; }

        /// <summary>
        /// 上层产品 数据质量 / 数据开发 / ...
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 创建者帐号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnId")]
        public string OwnId{ get; set; }

        /// <summary>
        /// 子账号
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
        /// 最后修改的人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateUser")]
        public string UpdateUser{ get; set; }

        /// <summary>
        /// 最后修改时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 最后修改的人的ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateUserId")]
        public string UpdateUserId{ get; set; }

        /// <summary>
        /// 调度计划
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchedulerDesc")]
        public string SchedulerDesc{ get; set; }

        /// <summary>
        /// 资源组
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroup")]
        public string ResourceGroup{ get; set; }

        /// <summary>
        /// 版本提交说明
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VersionDesc")]
        public string VersionDesc{ get; set; }

        /// <summary>
        /// 编排-删除添加的链接
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LinkId")]
        public string LinkId{ get; set; }

        /// <summary>
        /// 脚本引用关系
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserFileId")]
        public string UserFileId{ get; set; }

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
        /// 去向数据源ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetServiceId")]
        public string TargetServiceId{ get; set; }

        /// <summary>
        /// 去向数据源类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetServiceType")]
        public string TargetServiceType{ get; set; }

        /// <summary>
        /// 输入参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParamInList")]
        public ParameterTaskInDsDto[] ParamInList{ get; set; }

        /// <summary>
        /// 输出参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParamOutList")]
        public ParameterTaskOutDsDto[] ParamOutList{ get; set; }


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
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectIdent", this.ProjectIdent);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "CycleStep", this.CycleStep);
            this.SetParamSimple(map, prefix + "CrontabExpression", this.CrontabExpression);
            this.SetParamSimple(map, prefix + "DelayTime", this.DelayTime);
            this.SetParamSimple(map, prefix + "StartupTime", this.StartupTime);
            this.SetParamSimple(map, prefix + "RetryWait", this.RetryWait);
            this.SetParamSimple(map, prefix + "Retriable", this.Retriable);
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
            this.SetParamObj(map, prefix + "TaskExt.", this.TaskExt);
            this.SetParamSimple(map, prefix + "Properties", this.Properties);
            this.SetParamSimple(map, prefix + "Notes", this.Notes);
            this.SetParamSimple(map, prefix + "InstanceInitStrategy", this.InstanceInitStrategy);
            this.SetParamSimple(map, prefix + "YarnQueue", this.YarnQueue);
            this.SetParamArrayObj(map, prefix + "Alarms.", this.Alarms);
            this.SetParamSimple(map, prefix + "Alarm", this.Alarm);
            this.SetParamSimple(map, prefix + "ScriptChange", this.ScriptChange);
            this.SetParamSimple(map, prefix + "Submit", this.Submit);
            this.SetParamSimple(map, prefix + "LastSchedulerCommitTime", this.LastSchedulerCommitTime);
            this.SetParamSimple(map, prefix + "NormalizedJobStartTime", this.NormalizedJobStartTime);
            this.SetParamSimple(map, prefix + "RecoverFreezeStartTime", this.RecoverFreezeStartTime);
            this.SetParamSimple(map, prefix + "SourceServer", this.SourceServer);
            this.SetParamSimple(map, prefix + "TargetServer", this.TargetServer);
            this.SetParamArraySimple(map, prefix + "Tasks.", this.Tasks);
            this.SetParamSimple(map, prefix + "Creater", this.Creater);
            this.SetParamSimple(map, prefix + "DependencyRel", this.DependencyRel);
            this.SetParamSimple(map, prefix + "DependencyWorkflow", this.DependencyWorkflow);
            this.SetParamSimple(map, prefix + "EventListenerConfig", this.EventListenerConfig);
            this.SetParamSimple(map, prefix + "EventPublisherConfig", this.EventPublisherConfig);
            this.SetParamArraySimple(map, prefix + "DependencyConfigList.", this.DependencyConfigList);
            this.SetParamSimple(map, prefix + "VirtualTaskStatus", this.VirtualTaskStatus);
            this.SetParamSimple(map, prefix + "RecycleTips", this.RecycleTips);
            this.SetParamSimple(map, prefix + "RecycleUser", this.RecycleUser);
            this.SetParamSimple(map, prefix + "NewOrUpdate", this.NewOrUpdate);
            this.SetParamArrayObj(map, prefix + "Params.", this.Params);
            this.SetParamArrayObj(map, prefix + "TaskLinkInfo.", this.TaskLinkInfo);
            this.SetParamSimple(map, prefix + "ImportResult", this.ImportResult);
            this.SetParamSimple(map, prefix + "ImportErrMsg", this.ImportErrMsg);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamSimple(map, prefix + "TaskAutoSubmit", this.TaskAutoSubmit);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "OwnId", this.OwnId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "TenantId", this.TenantId);
            this.SetParamSimple(map, prefix + "UpdateUser", this.UpdateUser);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "UpdateUserId", this.UpdateUserId);
            this.SetParamSimple(map, prefix + "SchedulerDesc", this.SchedulerDesc);
            this.SetParamSimple(map, prefix + "ResourceGroup", this.ResourceGroup);
            this.SetParamSimple(map, prefix + "VersionDesc", this.VersionDesc);
            this.SetParamSimple(map, prefix + "LinkId", this.LinkId);
            this.SetParamSimple(map, prefix + "UserFileId", this.UserFileId);
            this.SetParamSimple(map, prefix + "SourceServiceId", this.SourceServiceId);
            this.SetParamSimple(map, prefix + "SourceServiceType", this.SourceServiceType);
            this.SetParamSimple(map, prefix + "TargetServiceId", this.TargetServiceId);
            this.SetParamSimple(map, prefix + "TargetServiceType", this.TargetServiceType);
            this.SetParamArrayObj(map, prefix + "ParamInList.", this.ParamInList);
            this.SetParamArrayObj(map, prefix + "ParamOutList.", this.ParamOutList);
        }
    }
}

