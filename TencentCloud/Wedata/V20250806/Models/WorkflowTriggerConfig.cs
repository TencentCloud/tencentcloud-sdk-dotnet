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

    public class WorkflowTriggerConfig : AbstractModel
    {
        
        /// <summary>
        /// 触发方式，
        /// - 定时触发：TIME_TRIGGER
        /// - 持续运行：CONTINUE_RUN
        /// - 文件到达：FILE_ARRIVAL
        /// 
        /// 注意：
        /// - TIME_TRIGGER 和 CONTINUE_RUN 模式下，SchedulerStatus、SchedulerTimeZone、StartTime、EndTime、ConfigMode、CycleType、CrontabExpression 必填；
        /// - FILE_ARRIVAL 模式下，FileArrivalPath、TriggerMinimumIntervalSecond、TriggerWaitTimeSecond 必填；
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerMode")]
        public string TriggerMode{ get; set; }

        /// <summary>
        /// WorkflowTriggerConfig转换成Json格式，对账使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtraInfo")]
        public string ExtraInfo{ get; set; }

        /// <summary>
        /// 调度时区
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScheduleTimeZone")]
        public string ScheduleTimeZone{ get; set; }

        /// <summary>
        /// 调度生效时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 调度结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 配置方式，常规：COMMON，CRON表达式：CRON_EXPRESSION
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigMode")]
        public string ConfigMode{ get; set; }

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
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

        /// <summary>
        /// cron表达式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CrontabExpression")]
        public string CrontabExpression{ get; set; }

        /// <summary>
        /// triggerId, uuid
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerId")]
        public string TriggerId{ get; set; }

        /// <summary>
        /// 文件到达模式下	存储系统中的监听路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileArrivalPath")]
        public string FileArrivalPath{ get; set; }

        /// <summary>
        /// 文件到达模式下	触发最短间隔时间（单位：秒）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerMinimumIntervalSecond")]
        public ulong? TriggerMinimumIntervalSecond{ get; set; }

        /// <summary>
        /// 文件到达模式下	触发等待时间（单位：秒）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerWaitTimeSecond")]
        public ulong? TriggerWaitTimeSecond{ get; set; }

        /// <summary>
        /// Trigger 状态 启动ACTIVE，暂停PAUSED
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchedulerStatus")]
        public string SchedulerStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TriggerMode", this.TriggerMode);
            this.SetParamSimple(map, prefix + "ExtraInfo", this.ExtraInfo);
            this.SetParamSimple(map, prefix + "ScheduleTimeZone", this.ScheduleTimeZone);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ConfigMode", this.ConfigMode);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "CrontabExpression", this.CrontabExpression);
            this.SetParamSimple(map, prefix + "TriggerId", this.TriggerId);
            this.SetParamSimple(map, prefix + "FileArrivalPath", this.FileArrivalPath);
            this.SetParamSimple(map, prefix + "TriggerMinimumIntervalSecond", this.TriggerMinimumIntervalSecond);
            this.SetParamSimple(map, prefix + "TriggerWaitTimeSecond", this.TriggerWaitTimeSecond);
            this.SetParamSimple(map, prefix + "SchedulerStatus", this.SchedulerStatus);
        }
    }
}

