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

    public class ListInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// **项目ID**
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// **实例计划调度时间过滤条件**
        /// 过滤起始时间，时间格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("ScheduleTimeFrom")]
        public string ScheduleTimeFrom{ get; set; }

        /// <summary>
        /// **实例计划调度时间过滤条件**
        /// 过滤截止时间，时间格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("ScheduleTimeTo")]
        public string ScheduleTimeTo{ get; set; }

        /// <summary>
        /// **页码，整型**
        /// 配合pageSize使用且不能小于1， 默认值1
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// **每页数目，整型**
        /// 配合pageNumber使用且不能大于200, 默认值 10
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// **查询结果排序字段**
        /// 
        /// - SCHEDULE_DATE 表示 根据计划调度时间排序
        /// - START_TIME 表示 根据实例开始执行时间排序
        /// - END_TIME 表示 根据实例结束执行时间排序
        /// - COST_TIME 表示 根据实例执行时长排序
        /// </summary>
        [JsonProperty("SortColumn")]
        public string SortColumn{ get; set; }

        /// <summary>
        /// **实例排序方式**
        /// 
        /// - ASC 
        /// - DESC
        /// </summary>
        [JsonProperty("SortType")]
        public string SortType{ get; set; }

        /// <summary>
        /// **实例类型**
        /// 
        /// - 0 表示补录类型
        /// - 1 表示周期实例
        /// - 2 表示非周期实例
        /// </summary>
        [JsonProperty("InstanceType")]
        public ulong? InstanceType{ get; set; }

        /// <summary>
        /// **实例执行状态**
        /// 支持过滤多个，条件间为 或 的过滤关系
        /// 
        /// - [0] 表示 等待事件
        /// - [12] 表示 等待上游
        /// - [6, 7, 9, 10, 18] 表示 等待运行
        /// - [1, 19, 22] 表示 运行中
        /// - [21] 表示 跳过运行
        /// - [3] 表示 失败重试
        /// - [8, 4, 5, 13] 表示 失败
        /// - [2] 表示 成功
        /// </summary>
        [JsonProperty("InstanceStateList")]
        public ulong?[] InstanceStateList{ get; set; }

        /// <summary>
        /// **任务类型Id**
        /// 
        /// - 支持过滤多个，条件间为 或 的过滤关系
        /// - 可以通过接口 DescribeAllTaskType 获取项目支持的全部任务类型
        /// </summary>
        [JsonProperty("TaskTypeIdList")]
        public ulong?[] TaskTypeIdList{ get; set; }

        /// <summary>
        /// **任务周期类型**
        /// 支持过滤多个，条件间为 或 的过滤关系
        /// * O: ONEOFF_CYCLE
        /// * Y: YEAR_CYCLE
        /// * M: MONTH_CYCLE
        /// * W: WEEK_CYCLE
        /// * D: DAY_CYCLE
        /// * H: HOUR_CYCLE
        /// * I: MINUTE_CYCLE
        /// * C: CRONTAB_CYCLE
        /// </summary>
        [JsonProperty("TaskCycleList")]
        public string[] TaskCycleList{ get; set; }

        /// <summary>
        /// **任务名称 或 任务ID**
        /// 支持模糊搜索过滤, 多个用 英文逗号, 分割
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// **任务负责人**
        /// 支持过滤多个，条件间为 或 的过滤关系
        /// </summary>
        [JsonProperty("InChargeList")]
        public string[] InChargeList{ get; set; }

        /// <summary>
        /// **任务所属文件件**
        /// 支持过滤多个，条件间为 或 的过滤关系
        /// 可以通过接口 FindAllFolder 获取项目下的所有文件夹列表
        /// </summary>
        [JsonProperty("TaskFolderIdList")]
        public string[] TaskFolderIdList{ get; set; }

        /// <summary>
        /// **任务所属工作流**
        /// 支持过滤多个，条件间为 或 的过滤关系
        /// 可以通过接口 DescribeOpsWorkflows 获取项目下的所有工作流列表
        /// </summary>
        [JsonProperty("WorkflowIdList")]
        public string[] WorkflowIdList{ get; set; }

        /// <summary>
        /// **执行资源组Id**
        /// 支持过滤多个，条件间为 或 的过滤关系
        /// 可以通过接口 DescribeNormalSchedulerExecutorGroups 获取项目下的所有调度资源组列表
        /// 可以通过接口 DescribeNormalIntegrationExecutorGroups 获取项目下的所有集成资源组列表
        /// </summary>
        [JsonProperty("ExecutorGroupIdList")]
        public string[] ExecutorGroupIdList{ get; set; }

        /// <summary>
        /// **实例执行开始时间过滤条件**
        /// 过滤起始时间，时间格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("StartTimeFrom")]
        public string StartTimeFrom{ get; set; }

        /// <summary>
        /// **实例执行开始时间过滤条件**
        /// 过滤截止时间，时间格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("StartTimeTo")]
        public string StartTimeTo{ get; set; }

        /// <summary>
        /// **时区**
        /// timeZone, 默认UTC+8
        /// </summary>
        [JsonProperty("ScheduleTimeZone")]
        public string ScheduleTimeZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ScheduleTimeFrom", this.ScheduleTimeFrom);
            this.SetParamSimple(map, prefix + "ScheduleTimeTo", this.ScheduleTimeTo);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "SortColumn", this.SortColumn);
            this.SetParamSimple(map, prefix + "SortType", this.SortType);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamArraySimple(map, prefix + "InstanceStateList.", this.InstanceStateList);
            this.SetParamArraySimple(map, prefix + "TaskTypeIdList.", this.TaskTypeIdList);
            this.SetParamArraySimple(map, prefix + "TaskCycleList.", this.TaskCycleList);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamArraySimple(map, prefix + "InChargeList.", this.InChargeList);
            this.SetParamArraySimple(map, prefix + "TaskFolderIdList.", this.TaskFolderIdList);
            this.SetParamArraySimple(map, prefix + "WorkflowIdList.", this.WorkflowIdList);
            this.SetParamArraySimple(map, prefix + "ExecutorGroupIdList.", this.ExecutorGroupIdList);
            this.SetParamSimple(map, prefix + "StartTimeFrom", this.StartTimeFrom);
            this.SetParamSimple(map, prefix + "StartTimeTo", this.StartTimeTo);
            this.SetParamSimple(map, prefix + "ScheduleTimeZone", this.ScheduleTimeZone);
        }
    }
}

