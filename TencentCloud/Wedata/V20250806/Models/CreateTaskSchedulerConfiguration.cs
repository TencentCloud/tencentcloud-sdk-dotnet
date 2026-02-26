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

    public class CreateTaskSchedulerConfiguration : AbstractModel
    {
        
        /// <summary>
        /// 周期类型：默认为 DAY_CYCLE
        /// 
        /// 支持的类型为 
        /// 
        /// * ONEOFF_CYCLE: 一次性
        /// * YEAR_CYCLE: 年
        /// * MONTH_CYCLE: 月
        /// * WEEK_CYCLE: 周
        /// * DAY_CYCLE: 天
        /// * HOUR_CYCLE: 小时
        /// * MINUTE_CYCLE: 分钟
        /// * CRONTAB_CYCLE: crontab表达式类型
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

        /// <summary>
        /// 时区，默认为 UTC+8
        /// </summary>
        [JsonProperty("ScheduleTimeZone")]
        public string ScheduleTimeZone{ get; set; }

        /// <summary>
        /// Cron表达式，默认为 0 0 0 * * ? * 
        /// </summary>
        [JsonProperty("CrontabExpression")]
        public string CrontabExpression{ get; set; }

        /// <summary>
        /// 生效日期，默认为当前日期的 00:00:00
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束日期，默认为 2099-12-31 23:59:59
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 执行时间 左闭区间，默认 00:00
        /// </summary>
        [JsonProperty("ExecutionStartTime")]
        public string ExecutionStartTime{ get; set; }

        /// <summary>
        /// 执行时间 右闭区间，默认 23:59
        /// </summary>
        [JsonProperty("ExecutionEndTime")]
        public string ExecutionEndTime{ get; set; }

        /// <summary>
        /// 日历调度 取值为 0 和 1， 1为打开，0为关闭，默认为0
        /// </summary>
        [JsonProperty("CalendarOpen")]
        public string CalendarOpen{ get; set; }

        /// <summary>
        /// 日历调度 日历 ID
        /// </summary>
        [JsonProperty("CalendarId")]
        public string CalendarId{ get; set; }

        /// <summary>
        /// 自依赖, 默认值 serial, 取值为：parallel(并行), serial(串行), orderly(有序)
        /// </summary>
        [JsonProperty("SelfDepend")]
        public string SelfDepend{ get; set; }

        /// <summary>
        /// 上游依赖数组
        /// </summary>
        [JsonProperty("UpstreamDependencyConfigList")]
        public DependencyTaskBrief[] UpstreamDependencyConfigList{ get; set; }

        /// <summary>
        /// 事件数组
        /// </summary>
        [JsonProperty("EventListenerList")]
        public EventListener[] EventListenerList{ get; set; }

        /// <summary>
        /// 重跑&补录配置, 默认为 ALL; , ALL 运行成功或失败后皆可重跑或补录, FAILURE 运行成功后不可重跑或补录，运行失败后可重跑或补录, NONE 运行成功或失败后皆不可重跑或补录;
        /// </summary>
        [JsonProperty("AllowRedoType")]
        public string AllowRedoType{ get; set; }

        /// <summary>
        /// 输出参数数组
        /// </summary>
        [JsonProperty("ParamTaskOutList")]
        public OutTaskParameter[] ParamTaskOutList{ get; set; }

        /// <summary>
        /// 输入参数数组
        /// </summary>
        [JsonProperty("ParamTaskInList")]
        public InTaskParameter[] ParamTaskInList{ get; set; }

        /// <summary>
        /// 产出登记
        /// </summary>
        [JsonProperty("TaskOutputRegistryList")]
        public TaskDataRegistry[] TaskOutputRegistryList{ get; set; }

        /// <summary>
        /// **实例生成策略**
        /// * T_PLUS_0: T+0生成,默认策略
        /// * T_PLUS_1: T+1生成
        /// </summary>
        [JsonProperty("InitStrategy")]
        public string InitStrategy{ get; set; }

        /// <summary>
        /// 调度类型: 0 正常调度 1 空跑调度，默认为 0
        /// </summary>
        [JsonProperty("ScheduleRunType")]
        [System.Obsolete]
        public string ScheduleRunType{ get; set; }

        /// <summary>
        /// 任务调度优先级 运行优先级 4高 5中 6低 , 默认:6
        /// </summary>
        [JsonProperty("RunPriority")]
        [System.Obsolete]
        public string RunPriority{ get; set; }

        /// <summary>
        /// 重试策略 重试等待时间,单位分钟: 默认: 5
        /// </summary>
        [JsonProperty("RetryWait")]
        [System.Obsolete]
        public string RetryWait{ get; set; }

        /// <summary>
        /// 重试策略 最大尝试次数, 默认: 4
        /// </summary>
        [JsonProperty("MaxRetryAttempts")]
        [System.Obsolete]
        public string MaxRetryAttempts{ get; set; }

        /// <summary>
        /// 超时处理策略 运行耗时超时（单位：分钟）默认为 -1
        /// </summary>
        [JsonProperty("ExecutionTTL")]
        [System.Obsolete]
        public string ExecutionTTL{ get; set; }

        /// <summary>
        /// 超时处理策略 等待总时长耗时超时（单位：分钟）默认为 -1
        /// </summary>
        [JsonProperty("WaitExecutionTotalTTL")]
        [System.Obsolete]
        public string WaitExecutionTotalTTL{ get; set; }

        /// <summary>
        /// 调度类型: 0 正常调度 1 空跑调度，默认为 0
        /// </summary>
        [JsonProperty("ScheduleType")]
        public long? ScheduleType{ get; set; }

        /// <summary>
        /// 任务调度优先级 运行优先级 4高 5中 6低 , 默认:6
        /// </summary>
        [JsonProperty("RunPriorityType")]
        public long? RunPriorityType{ get; set; }

        /// <summary>
        /// 重试策略 重试等待时间,单位分钟: 默认: 5
        /// </summary>
        [JsonProperty("RetryWaitMinute")]
        public long? RetryWaitMinute{ get; set; }

        /// <summary>
        /// 重试策略 最大尝试次数, 默认: 4
        /// </summary>
        [JsonProperty("MaxRetryNumber")]
        public long? MaxRetryNumber{ get; set; }

        /// <summary>
        /// 超时处理策略 运行耗时超时（单位：分钟）默认为 -1
        /// </summary>
        [JsonProperty("ExecutionTTLMinute")]
        public long? ExecutionTTLMinute{ get; set; }

        /// <summary>
        /// 超时处理策略 等待总时长耗时超时（单位：分钟）默认为 -1
        /// </summary>
        [JsonProperty("WaitExecutionTotalTTLMinute")]
        public long? WaitExecutionTotalTTLMinute{ get; set; }

        /// <summary>
        /// - 任务依赖运行条件，默认为ALL_SUCCESS，暂时只支持工作流调度项目下配置
        /// - ALL_SUCCESS： 全部成功：所有上游依赖任务都达到终态时，进行依赖判断，如果上游全部都成功，则依赖判断成功，否则如果上游有一个跳过运行，则标记为跳过运行，其余情况标记为上游失败
        /// - ALL_FAILED：全部失败：所有上游依赖任务都达到终态时，进行依赖判断，如果上游状态都是失败或者上游失败，则依赖判断成功，否则就标记为跳过运行
        /// - ALL_DONE：全部完成：所有上游依赖任务都达到终态时，进行依赖判断，直接是依赖判断成功
        /// - ALL_DONE_AT_LEAST_ONE_SUCCESS：上游全部完成至少一个成功: 所有上游依赖任务都达到终态时，进行依赖判断，至少有一个成功，则依赖判断成功，否则就是跳过运行
        /// - ALL_SKIPPED：上游全部都跳过: 所有上游依赖任务都达到终态时，进行依赖判断，所有的上游都是跳过状态才算依赖判断成功，否则当前节点就是跳过运行
        /// - ONE_FAILED：至少一个失败: 上游只要有一个失败了，就进行依赖判断，且依赖判断成功，如果上游全部完成但是没有失败，则跳过运行
        /// - ONE_SUCCESS：至少一个成功：上游只要有一个成功，就进行依赖判断，且依赖判断成功，如果上游全部完成但是没有成功，则跳过运行
        /// - ONE_DONE：至少一个完成：上游只要有一个完成了，就进行依赖判断，且依赖判断成功，否则还是等待上游
        /// - NONE_FAILED：上游全部完成，没有失败: 所有上游依赖任务都达到终态时，进行依赖判断，如果上游都是成功或者跳过运行，则依赖判断成功，否则标记为上游失败
        /// - ALL_DONE_NONE_FAILED_AT_LEAST_ONE_SUCCESS：上游全部完成，没有失败，至少有一个成功: 所有上游依赖任务都达到终态时，进行依赖判断，上游没有一个失败且至少有一个成功的情况下，依赖判断成功，否则就是跳过运行
        /// - NONE_SKIPPED：上游全部完成，没有跳过运行: 所有上游依赖任务都达到终态时，进行依赖判断, 如果上游状态全部都是成功、失败、上游失败状态，则依赖判断成功，否则为跳过运行
        /// - ALL_DONE_AT_LEAST_ONE_FAILED：上游全部完成至少一个失败: 所有上游依赖任务都达到终态时，进行依赖判断，至少有一个失败，则依赖判断成功，否则就是跳过运行
        /// </summary>
        [JsonProperty("DependencyTriggerPolicy")]
        public string DependencyTriggerPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "ScheduleTimeZone", this.ScheduleTimeZone);
            this.SetParamSimple(map, prefix + "CrontabExpression", this.CrontabExpression);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ExecutionStartTime", this.ExecutionStartTime);
            this.SetParamSimple(map, prefix + "ExecutionEndTime", this.ExecutionEndTime);
            this.SetParamSimple(map, prefix + "CalendarOpen", this.CalendarOpen);
            this.SetParamSimple(map, prefix + "CalendarId", this.CalendarId);
            this.SetParamSimple(map, prefix + "SelfDepend", this.SelfDepend);
            this.SetParamArrayObj(map, prefix + "UpstreamDependencyConfigList.", this.UpstreamDependencyConfigList);
            this.SetParamArrayObj(map, prefix + "EventListenerList.", this.EventListenerList);
            this.SetParamSimple(map, prefix + "AllowRedoType", this.AllowRedoType);
            this.SetParamArrayObj(map, prefix + "ParamTaskOutList.", this.ParamTaskOutList);
            this.SetParamArrayObj(map, prefix + "ParamTaskInList.", this.ParamTaskInList);
            this.SetParamArrayObj(map, prefix + "TaskOutputRegistryList.", this.TaskOutputRegistryList);
            this.SetParamSimple(map, prefix + "InitStrategy", this.InitStrategy);
            this.SetParamSimple(map, prefix + "ScheduleRunType", this.ScheduleRunType);
            this.SetParamSimple(map, prefix + "RunPriority", this.RunPriority);
            this.SetParamSimple(map, prefix + "RetryWait", this.RetryWait);
            this.SetParamSimple(map, prefix + "MaxRetryAttempts", this.MaxRetryAttempts);
            this.SetParamSimple(map, prefix + "ExecutionTTL", this.ExecutionTTL);
            this.SetParamSimple(map, prefix + "WaitExecutionTotalTTL", this.WaitExecutionTotalTTL);
            this.SetParamSimple(map, prefix + "ScheduleType", this.ScheduleType);
            this.SetParamSimple(map, prefix + "RunPriorityType", this.RunPriorityType);
            this.SetParamSimple(map, prefix + "RetryWaitMinute", this.RetryWaitMinute);
            this.SetParamSimple(map, prefix + "MaxRetryNumber", this.MaxRetryNumber);
            this.SetParamSimple(map, prefix + "ExecutionTTLMinute", this.ExecutionTTLMinute);
            this.SetParamSimple(map, prefix + "WaitExecutionTotalTTLMinute", this.WaitExecutionTotalTTLMinute);
            this.SetParamSimple(map, prefix + "DependencyTriggerPolicy", this.DependencyTriggerPolicy);
        }
    }
}

