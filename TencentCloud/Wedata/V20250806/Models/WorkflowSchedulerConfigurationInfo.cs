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
        /// <p>时区</p>
        /// </summary>
        [JsonProperty("ScheduleTimeZone")]
        public string ScheduleTimeZone{ get; set; }

        /// <summary>
        /// <p>周期类型：支持的类型为<br>ONEOFF_CYCLE: 一次性<br>YEAR_CYCLE: 年<br>MONTH_CYCLE: 月<br>WEEK_CYCLE: 周<br>DAY_CYCLE: 天<br>HOUR_CYCLE: 小时<br>MINUTE_CYCLE: 分钟<br>CRONTAB_CYCLE: crontab表达式类型</p>
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

        /// <summary>
        /// <p>自依赖, 默认值 serial, 取值为：parallel(并行), serial(串行), orderly(有序)</p>
        /// </summary>
        [JsonProperty("SelfDepend")]
        public string SelfDepend{ get; set; }

        /// <summary>
        /// <p>生效开始时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>生效结束时间</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>cron表达式</p>
        /// </summary>
        [JsonProperty("CrontabExpression")]
        public string CrontabExpression{ get; set; }

        /// <summary>
        /// <p>工作流依赖，yes or no</p>
        /// </summary>
        [JsonProperty("DependencyWorkflow")]
        public string DependencyWorkflow{ get; set; }

        /// <summary>
        /// <p>0：不修改 1：将任务的上游依赖配置改为默认值</p>
        /// </summary>
        [JsonProperty("ModifyCycleValue")]
        public string ModifyCycleValue{ get; set; }

        /// <summary>
        /// <p>工作流存在跨工作流依赖且使用cron表达式调度。如果保存统一调度，会断开不支持的依赖关系</p>
        /// </summary>
        [JsonProperty("ClearLink")]
        public bool? ClearLink{ get; set; }

        /// <summary>
        /// <p>ModifyCycleValue为1的时候生效，表示默认修改的上游依赖-时间维度，取值为：</p><ul><li>CRONTAB</li><li>DAY</li><li>HOUR</li><li>LIST_DAY</li><li>LIST_HOUR</li><li>LIST_MINUTE</li><li>MINUTE</li><li>MONTH</li><li>RANGE_DAY</li><li>RANGE_HOUR</li><li>RANGE_MINUTE</li><li>WEEK</li><li>YEAR</li></ul><p>https://capi.woa.com/object/detail?product=wedata&amp;env=api_dev&amp;version=2025-08-06&amp;name=WorkflowSchedulerConfigurationInfo</p>
        /// </summary>
        [JsonProperty("MainCyclicConfig")]
        public string MainCyclicConfig{ get; set; }

        /// <summary>
        /// <p>ModifyCycleValue为1的时候生效，表示默认修改的上游依赖-实例范围<br>取值为：</p><ul><li>ALL_DAY_OF_YEAR</li><li>ALL_MONTH_OF_YEAR</li><li>CURRENT</li><li>CURRENT_DAY</li><li>CURRENT_HOUR</li><li>CURRENT_MINUTE</li><li>CURRENT_MONTH</li><li>CURRENT_WEEK</li><li>CURRENT_YEAR</li><li>PREVIOUS_BEGIN_OF_MONTH</li><li>PREVIOUS_DAY</li><li>PREVIOUS_DAY_LATER_OFFSET_HOUR</li><li>PREVIOUS_DAY_LATER_OFFSET_MINUTE</li><li>PREVIOUS_END_OF_MONTH</li><li>PREVIOUS_FRIDAY</li><li>PREVIOUS_HOUR</li><li>PREVIOUS_HOUR_CYCLE</li><li>PREVIOUS_HOUR_LATER_OFFSET_MINUTE</li><li>PREVIOUS_MINUTE_CYCLE</li><li>PREVIOUS_MONTH</li><li>PREVIOUS_WEEK</li><li>PREVIOUS_WEEKEND</li><li>RECENT_DATE</li></ul><p>https://capi.woa.com/object/detail?product=wedata&amp;env=api_dev&amp;version=2025-08-06&amp;name=WorkflowSchedulerConfigurationInfo</p>
        /// </summary>
        [JsonProperty("SubordinateCyclicConfig")]
        public string SubordinateCyclicConfig{ get; set; }

        /// <summary>
        /// <p>执行时间左闭区间，示例：00:00，只有周期类型为MINUTE_CYCLE才需要填入</p>
        /// </summary>
        [JsonProperty("ExecutionStartTime")]
        public string ExecutionStartTime{ get; set; }

        /// <summary>
        /// <p>执行时间右闭区间，示例：23:59，只有周期类型为MINUTE_CYCLE才需要填入</p>
        /// </summary>
        [JsonProperty("ExecutionEndTime")]
        public string ExecutionEndTime{ get; set; }

        /// <summary>
        /// <p>是否开启日历调度 1 开启 0关闭</p>
        /// </summary>
        [JsonProperty("CalendarOpen")]
        public string CalendarOpen{ get; set; }

        /// <summary>
        /// <p>日历id</p>
        /// </summary>
        [JsonProperty("CalendarId")]
        public string CalendarId{ get; set; }

        /// <summary>
        /// <p>分钟任务相位偏移</p>
        /// </summary>
        [JsonProperty("MinuteOffset")]
        public ulong? MinuteOffset{ get; set; }


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
            this.SetParamSimple(map, prefix + "MinuteOffset", this.MinuteOffset);
        }
    }
}

