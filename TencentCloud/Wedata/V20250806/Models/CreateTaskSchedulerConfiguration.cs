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
        /// 调度类型: 0 正常调度 1 空跑调度，默认为 0
        /// </summary>
        [JsonProperty("ScheduleRunType")]
        public string ScheduleRunType{ get; set; }

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
        /// 任务调度优先级 运行优先级 4高 5中 6低 , 默认:6
        /// </summary>
        [JsonProperty("RunPriority")]
        public string RunPriority{ get; set; }

        /// <summary>
        /// 重试策略 重试等待时间,单位分钟: 默认: 5
        /// </summary>
        [JsonProperty("RetryWait")]
        public string RetryWait{ get; set; }

        /// <summary>
        /// 重试策略 最大尝试次数, 默认: 4
        /// </summary>
        [JsonProperty("MaxRetryAttempts")]
        public string MaxRetryAttempts{ get; set; }

        /// <summary>
        /// 超时处理策略 运行耗时超时（单位：分钟）默认为 -1
        /// </summary>
        [JsonProperty("ExecutionTTL")]
        public string ExecutionTTL{ get; set; }

        /// <summary>
        /// 超时处理策略 等待总时长耗时超时（单位：分钟）默认为 -1
        /// </summary>
        [JsonProperty("WaitExecutionTotalTTL")]
        public string WaitExecutionTotalTTL{ get; set; }

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
            this.SetParamSimple(map, prefix + "ScheduleRunType", this.ScheduleRunType);
            this.SetParamSimple(map, prefix + "CalendarOpen", this.CalendarOpen);
            this.SetParamSimple(map, prefix + "CalendarId", this.CalendarId);
            this.SetParamSimple(map, prefix + "SelfDepend", this.SelfDepend);
            this.SetParamArrayObj(map, prefix + "UpstreamDependencyConfigList.", this.UpstreamDependencyConfigList);
            this.SetParamArrayObj(map, prefix + "EventListenerList.", this.EventListenerList);
            this.SetParamSimple(map, prefix + "RunPriority", this.RunPriority);
            this.SetParamSimple(map, prefix + "RetryWait", this.RetryWait);
            this.SetParamSimple(map, prefix + "MaxRetryAttempts", this.MaxRetryAttempts);
            this.SetParamSimple(map, prefix + "ExecutionTTL", this.ExecutionTTL);
            this.SetParamSimple(map, prefix + "WaitExecutionTotalTTL", this.WaitExecutionTotalTTL);
            this.SetParamSimple(map, prefix + "AllowRedoType", this.AllowRedoType);
            this.SetParamArrayObj(map, prefix + "ParamTaskOutList.", this.ParamTaskOutList);
            this.SetParamArrayObj(map, prefix + "ParamTaskInList.", this.ParamTaskInList);
            this.SetParamArrayObj(map, prefix + "TaskOutputRegistryList.", this.TaskOutputRegistryList);
            this.SetParamSimple(map, prefix + "InitStrategy", this.InitStrategy);
        }
    }
}

