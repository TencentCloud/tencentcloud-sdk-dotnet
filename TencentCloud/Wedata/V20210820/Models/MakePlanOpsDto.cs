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

    public class MakePlanOpsDto : AbstractModel
    {
        
        /// <summary>
        /// <p>补录计划ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PlanId")]
        public string PlanId{ get; set; }

        /// <summary>
        /// <p>补录计划名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MakeName")]
        public string MakeName{ get; set; }

        /// <summary>
        /// <p>项目ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>补录是否检查父任务状态</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckParent")]
        public bool? CheckParent{ get; set; }

        /// <summary>
        /// <p>是否使用任务原有自依赖配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SameSelfDependType")]
        public bool? SameSelfDependType{ get; set; }

        /// <summary>
        /// <p>并行度，在SameSelfDependType为false时生效</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParallelNum")]
        public long? ParallelNum{ get; set; }

        /// <summary>
        /// <p>补录实例生成周期是否修改</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SameCycle")]
        public bool? SameCycle{ get; set; }

        /// <summary>
        /// <p>调度周期转换方式-原始周期类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceTaskCycle")]
        public string SourceTaskCycle{ get; set; }

        /// <summary>
        /// <p>调度周期转换方式-目标周期类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetTaskCycle")]
        public string TargetTaskCycle{ get; set; }

        /// <summary>
        /// <p>调度周期转换方式-目标周期类型指定时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetTaskAction")]
        public long? TargetTaskAction{ get; set; }

        /// <summary>
        /// <p>补录实例自定义参数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MapParamList")]
        public StrToStrMap[] MapParamList{ get; set; }

        /// <summary>
        /// <p>补录扩展属性</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MakeExtList")]
        public StrToStrMap[] MakeExtList{ get; set; }

        /// <summary>
        /// <p>创建人ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatorId")]
        public string CreatorId{ get; set; }

        /// <summary>
        /// <p>创建人</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>补录任务ID集合</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskIdList")]
        public string[] TaskIdList{ get; set; }

        /// <summary>
        /// <p>补录计划日期范围</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MakeDatetimeList")]
        public CreateMakeDatetimeInfo[] MakeDatetimeList{ get; set; }

        /// <summary>
        /// <p>补录计划说明</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>补录指定的调度资源组（ID）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchedulerResourceGroup")]
        public string SchedulerResourceGroup{ get; set; }

        /// <summary>
        /// <p>补录指定的调度资源组名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchedulerResourceGroupName")]
        public string SchedulerResourceGroupName{ get; set; }

        /// <summary>
        /// <p>补录指定的集成资源组（ID）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntegrationResourceGroup")]
        public string IntegrationResourceGroup{ get; set; }

        /// <summary>
        /// <p>补录指定的集成资源组名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntegrationResourceGroupName")]
        public string IntegrationResourceGroupName{ get; set; }

        /// <summary>
        /// <p>补录计划任务数量</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskCount")]
        public long? TaskCount{ get; set; }

        /// <summary>
        /// <p>补录计划实例完成百分数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompletePercent")]
        public long? CompletePercent{ get; set; }

        /// <summary>
        /// <p>补录计划实例成功百分数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SuccessPercent")]
        public long? SuccessPercent{ get; set; }

        /// <summary>
        /// <p>补录检查父任务类型。取值范围：</p><li> NONE: 全部不检查 </li><li> ALL: 检查全部上游父任务 </li><li> MAKE_SCOPE: 只在（当前补录计划）选中任务中检查 </li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckParentType")]
        public string CheckParentType{ get; set; }

        /// <summary>
        /// <p>是否和原任务保持相同工作流自依赖属性</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SameSelfWorkflowDependType")]
        public bool? SameSelfWorkflowDependType{ get; set; }

        /// <summary>
        /// <p>工作流自依赖类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SelfWorkflowDependency")]
        public string SelfWorkflowDependency{ get; set; }

        /// <summary>
        /// <p>补录时间顺序<br>NORMAL： 正常<br>ORDER ： 按照实例时间顺序执行<br>REVERSE： 实例数据时间逆序</p>
        /// </summary>
        [JsonProperty("MakeDataTimeOrder")]
        public string MakeDataTimeOrder{ get; set; }

        /// <summary>
        /// <p>补录时间范围的时区</p>
        /// </summary>
        [JsonProperty("ScheduleTimeZone")]
        public string ScheduleTimeZone{ get; set; }

        /// <summary>
        /// <p>执行应用参数</p>
        /// </summary>
        [JsonProperty("AppParam")]
        public string AppParam{ get; set; }

        /// <summary>
        /// <p>补录计划时间范围的类型：<br>DATA_TIME：实例数据时间；SCHEDULE_TIME 计划调度时间</p>
        /// </summary>
        [JsonProperty("TimeType")]
        public string TimeType{ get; set; }

        /// <summary>
        /// <p>开始时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>结束时间</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>失败百分比</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailurePercent")]
        public long? FailurePercent{ get; set; }

        /// <summary>
        /// <p>补录计划的告警规则</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlarmRule")]
        public MakePlanAlarmRule AlarmRule{ get; set; }

        /// <summary>
        /// <p>运行类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunType")]
        public long? RunType{ get; set; }

        /// <summary>
        /// <p>定时运行时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunDateTime")]
        public string RunDateTime{ get; set; }

        /// <summary>
        /// <p>定时补录计划 或者 指定时间段补录 执行时间点的时区</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunScheduleTimeZone")]
        public string RunScheduleTimeZone{ get; set; }

        /// <summary>
        /// <p>指定时间段补录开始时间</p><p>参数格式：00:00 - 23:59</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunScheduleRangeStartTime")]
        public string RunScheduleRangeStartTime{ get; set; }

        /// <summary>
        /// <p>指定时间段补录结束时间</p><p>参数格式：00:00 - 23:59</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunScheduleRangeEndTime")]
        public string RunScheduleRangeEndTime{ get; set; }

        /// <summary>
        /// <p>指定时间段补录生效日，星期一到星期日，1-7</p><p>枚举值：</p><ul><li>星期一： 1</li><li>星期二： 2</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunScheduleRangeWeekDays")]
        public long?[] RunScheduleRangeWeekDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlanId", this.PlanId);
            this.SetParamSimple(map, prefix + "MakeName", this.MakeName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "CheckParent", this.CheckParent);
            this.SetParamSimple(map, prefix + "SameSelfDependType", this.SameSelfDependType);
            this.SetParamSimple(map, prefix + "ParallelNum", this.ParallelNum);
            this.SetParamSimple(map, prefix + "SameCycle", this.SameCycle);
            this.SetParamSimple(map, prefix + "SourceTaskCycle", this.SourceTaskCycle);
            this.SetParamSimple(map, prefix + "TargetTaskCycle", this.TargetTaskCycle);
            this.SetParamSimple(map, prefix + "TargetTaskAction", this.TargetTaskAction);
            this.SetParamArrayObj(map, prefix + "MapParamList.", this.MapParamList);
            this.SetParamArrayObj(map, prefix + "MakeExtList.", this.MakeExtList);
            this.SetParamSimple(map, prefix + "CreatorId", this.CreatorId);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArraySimple(map, prefix + "TaskIdList.", this.TaskIdList);
            this.SetParamArrayObj(map, prefix + "MakeDatetimeList.", this.MakeDatetimeList);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "SchedulerResourceGroup", this.SchedulerResourceGroup);
            this.SetParamSimple(map, prefix + "SchedulerResourceGroupName", this.SchedulerResourceGroupName);
            this.SetParamSimple(map, prefix + "IntegrationResourceGroup", this.IntegrationResourceGroup);
            this.SetParamSimple(map, prefix + "IntegrationResourceGroupName", this.IntegrationResourceGroupName);
            this.SetParamSimple(map, prefix + "TaskCount", this.TaskCount);
            this.SetParamSimple(map, prefix + "CompletePercent", this.CompletePercent);
            this.SetParamSimple(map, prefix + "SuccessPercent", this.SuccessPercent);
            this.SetParamSimple(map, prefix + "CheckParentType", this.CheckParentType);
            this.SetParamSimple(map, prefix + "SameSelfWorkflowDependType", this.SameSelfWorkflowDependType);
            this.SetParamSimple(map, prefix + "SelfWorkflowDependency", this.SelfWorkflowDependency);
            this.SetParamSimple(map, prefix + "MakeDataTimeOrder", this.MakeDataTimeOrder);
            this.SetParamSimple(map, prefix + "ScheduleTimeZone", this.ScheduleTimeZone);
            this.SetParamSimple(map, prefix + "AppParam", this.AppParam);
            this.SetParamSimple(map, prefix + "TimeType", this.TimeType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "FailurePercent", this.FailurePercent);
            this.SetParamObj(map, prefix + "AlarmRule.", this.AlarmRule);
            this.SetParamSimple(map, prefix + "RunType", this.RunType);
            this.SetParamSimple(map, prefix + "RunDateTime", this.RunDateTime);
            this.SetParamSimple(map, prefix + "RunScheduleTimeZone", this.RunScheduleTimeZone);
            this.SetParamSimple(map, prefix + "RunScheduleRangeStartTime", this.RunScheduleRangeStartTime);
            this.SetParamSimple(map, prefix + "RunScheduleRangeEndTime", this.RunScheduleRangeEndTime);
            this.SetParamArraySimple(map, prefix + "RunScheduleRangeWeekDays.", this.RunScheduleRangeWeekDays);
        }
    }
}

