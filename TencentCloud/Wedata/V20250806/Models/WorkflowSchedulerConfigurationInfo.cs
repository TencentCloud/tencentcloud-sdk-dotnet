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

    public class WorkflowSchedulerConfigurationInfo : AbstractModel
    {
        
        /// <summary>
        /// 时区
        /// </summary>
        [JsonProperty("ScheduleTimeZone")]
        public string ScheduleTimeZone{ get; set; }

        /// <summary>
        /// 周期类型：支持的类型为
        /// ONEOFF_CYCLE: 一次性
        /// YEAR_CYCLE: 年
        /// MONTH_CYCLE: 月
        /// WEEK_CYCLE: 周
        /// DAY_CYCLE: 天
        /// HOUR_CYCLE: 小时
        /// MINUTE_CYCLE: 分钟
        /// CRONTAB_CYCLE: crontab表达式类型
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

        /// <summary>
        /// 自依赖, 默认值 serial, 取值为：parallel(并行), serial(串行), orderly(有序)
        /// </summary>
        [JsonProperty("SelfDepend")]
        public string SelfDepend{ get; set; }

        /// <summary>
        /// 生效开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 生效结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// cron表达式
        /// </summary>
        [JsonProperty("CrontabExpression")]
        public string CrontabExpression{ get; set; }

        /// <summary>
        /// 工作流依赖，yes or no
        /// </summary>
        [JsonProperty("DependencyWorkflow")]
        public string DependencyWorkflow{ get; set; }

        /// <summary>
        /// 0：不修改 1：将任务的上游依赖配置改为默认值
        /// </summary>
        [JsonProperty("ModifyCycleValue")]
        public string ModifyCycleValue{ get; set; }

        /// <summary>
        /// 工作流存在跨工作流依赖且使用cron表达式调度。如果保存统一调度，会断开不支持的依赖关系
        /// </summary>
        [JsonProperty("ClearLink")]
        public bool? ClearLink{ get; set; }

        /// <summary>
        /// ModifyCycleValue为1的时候生效，表示默认修改的上游依赖-时间维度，取值为：
        /// * CRONTAB
        /// * DAY
        /// * HOUR
        /// * LIST_DAY
        /// * LIST_HOUR
        /// * LIST_MINUTE
        /// * MINUTE
        /// * MONTH
        /// * RANGE_DAY
        /// * RANGE_HOUR
        /// * RANGE_MINUTE
        /// * WEEK
        /// * YEAR
        /// 
        /// https://capi.woa.com/object/detail?product=wedata&env=api_dev&version=2025-08-06&name=WorkflowSchedulerConfigurationInfo
        /// </summary>
        [JsonProperty("MainCyclicConfig")]
        public string MainCyclicConfig{ get; set; }

        /// <summary>
        /// ModifyCycleValue为1的时候生效，表示默认修改的上游依赖-实例范围
        /// 取值为：
        /// * ALL_DAY_OF_YEAR
        /// * ALL_MONTH_OF_YEAR
        /// * CURRENT
        /// * CURRENT_DAY
        /// * CURRENT_HOUR
        /// * CURRENT_MINUTE
        /// * CURRENT_MONTH
        /// * CURRENT_WEEK
        /// * CURRENT_YEAR
        /// * PREVIOUS_BEGIN_OF_MONTH
        /// * PREVIOUS_DAY
        /// * PREVIOUS_DAY_LATER_OFFSET_HOUR
        /// * PREVIOUS_DAY_LATER_OFFSET_MINUTE
        /// * PREVIOUS_END_OF_MONTH
        /// * PREVIOUS_FRIDAY
        /// * PREVIOUS_HOUR
        /// * PREVIOUS_HOUR_CYCLE
        /// * PREVIOUS_HOUR_LATER_OFFSET_MINUTE
        /// * PREVIOUS_MINUTE_CYCLE
        /// * PREVIOUS_MONTH
        /// * PREVIOUS_WEEK
        /// * PREVIOUS_WEEKEND
        /// * RECENT_DATE
        /// 
        /// https://capi.woa.com/object/detail?product=wedata&env=api_dev&version=2025-08-06&name=WorkflowSchedulerConfigurationInfo
        /// </summary>
        [JsonProperty("SubordinateCyclicConfig")]
        public string SubordinateCyclicConfig{ get; set; }

        /// <summary>
        /// 执行时间左闭区间，示例：00:00，只有周期类型为MINUTE_CYCLE才需要填入
        /// </summary>
        [JsonProperty("ExecutionStartTime")]
        public string ExecutionStartTime{ get; set; }

        /// <summary>
        /// 执行时间右闭区间，示例：23:59，只有周期类型为MINUTE_CYCLE才需要填入
        /// </summary>
        [JsonProperty("ExecutionEndTime")]
        public string ExecutionEndTime{ get; set; }

        /// <summary>
        /// 是否开启日历调度 1 开启 0关闭
        /// </summary>
        [JsonProperty("CalendarOpen")]
        public string CalendarOpen{ get; set; }

        /// <summary>
        /// 日历id
        /// </summary>
        [JsonProperty("CalendarId")]
        public string CalendarId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScheduleTimeZone", this.ScheduleTimeZone);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "SelfDepend", this.SelfDepend);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CrontabExpression", this.CrontabExpression);
            this.SetParamSimple(map, prefix + "DependencyWorkflow", this.DependencyWorkflow);
            this.SetParamSimple(map, prefix + "ModifyCycleValue", this.ModifyCycleValue);
            this.SetParamSimple(map, prefix + "ClearLink", this.ClearLink);
            this.SetParamSimple(map, prefix + "MainCyclicConfig", this.MainCyclicConfig);
            this.SetParamSimple(map, prefix + "SubordinateCyclicConfig", this.SubordinateCyclicConfig);
            this.SetParamSimple(map, prefix + "ExecutionStartTime", this.ExecutionStartTime);
            this.SetParamSimple(map, prefix + "ExecutionEndTime", this.ExecutionEndTime);
            this.SetParamSimple(map, prefix + "CalendarOpen", this.CalendarOpen);
            this.SetParamSimple(map, prefix + "CalendarId", this.CalendarId);
        }
    }
}

