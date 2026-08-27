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
        /// <p>触发方式，非必填，外部结构的TriggerMode字段优先级比当前字段高</p><ul><li>定时触发：TIME_TRIGGER</li><li>文件到达：FILE_ARRIVAL</li><li>持续运行：CONTINUE_RUN（暂不支持）</li></ul><p>注意：</p><ul><li>TIME_TRIGGER 和 CONTINUE_RUN 模式下，SchedulerStatus、SchedulerTimeZone、StartTime、EndTime、ConfigMode、CycleType、CrontabExpression 必填；</li><li>FILE_ARRIVAL 模式下，FileArrivalPath、TriggerMinimumIntervalSecond、TriggerWaitTimeSecond 必填；</li></ul><p>枚举值：</p><ul><li>TIME_TRIGGER： 定时触发</li><li>FILE_ARRIVAL： 文件到达</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerMode")]
        public string TriggerMode{ get; set; }

        /// <summary>
        /// <p>WorkflowTriggerConfig转换成Json格式，对账使用</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtraInfo")]
        public string ExtraInfo{ get; set; }

        /// <summary>
        /// <p>调度时区</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScheduleTimeZone")]
        public string ScheduleTimeZone{ get; set; }

        /// <summary>
        /// <p>调度生效时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>调度结束时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>配置方式，常规：COMMON，CRON表达式：CRON_EXPRESSION</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigMode")]
        public string ConfigMode{ get; set; }

        /// <summary>
        /// <p>周期类型：支持的类型为<br>ONEOFF_CYCLE: 一次性<br>YEAR_CYCLE: 年<br>MONTH_CYCLE: 月<br>WEEK_CYCLE: 周<br>DAY_CYCLE: 天<br>HOUR_CYCLE: 小时<br>MINUTE_CYCLE: 分钟<br>CRONTAB_CYCLE: crontab表达式类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CycleType")]
        public string CycleType{ get; set; }

        /// <summary>
        /// <p>cron表达式</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CrontabExpression")]
        public string CrontabExpression{ get; set; }

        /// <summary>
        /// <p>triggerId, uuid</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerId")]
        public string TriggerId{ get; set; }

        /// <summary>
        /// <p>文件到达模式下    存储系统中的监听路径</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileArrivalPath")]
        public string FileArrivalPath{ get; set; }

        /// <summary>
        /// <p>Trigger 状态 启动ACTIVE，暂停PAUSED。外部的TriggerStatus优先级大于当前值</p><p>枚举值：</p><ul><li>ACTIVE： 启动</li><li>PAUSED： 暂停</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchedulerStatus")]
        public string SchedulerStatus{ get; set; }

        /// <summary>
        /// <p>文件到达模式下 文件匹配规则</p><p>入参限制：文件名匹配仅支持文件名和 *，不能包含路径分隔符 /</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileNamePattern")]
        public string FileNamePattern{ get; set; }

        /// <summary>
        /// <p>文件到达模式下 是否递归检测子目录</p><p>取值范围：[0, 1]</p><p>默认值：1</p><p>默认 1（开启） 0 （关闭）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Recursive")]
        public long? Recursive{ get; set; }

        /// <summary>
        /// <p>文件到达模式下 最小触发间隔</p><p>取值范围：[1, 1440]</p><p>单位：分钟</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerMinimumInterval")]
        public long? TriggerMinimumInterval{ get; set; }

        /// <summary>
        /// <p>文件到达模式下 文件批次等待时间</p><p>取值范围：[1, 60]</p><p>单位：分钟</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerWaitTime")]
        public long? TriggerWaitTime{ get; set; }

        /// <summary>
        /// <p>文件到达模式下    触发最短间隔时间</p><p>单位：秒</p><p>后续废弃 勿用</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerMinimumIntervalSecond")]
        public long? TriggerMinimumIntervalSecond{ get; set; }

        /// <summary>
        /// <p>文件到达模式下    触发等待时间</p><p>单位：秒</p><p>后续废弃 勿用</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerWaitTimeSecond")]
        public long? TriggerWaitTimeSecond{ get; set; }


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
            this.SetParamSimple(map, prefix + "SchedulerStatus", this.SchedulerStatus);
            this.SetParamSimple(map, prefix + "FileNamePattern", this.FileNamePattern);
            this.SetParamSimple(map, prefix + "Recursive", this.Recursive);
            this.SetParamSimple(map, prefix + "TriggerMinimumInterval", this.TriggerMinimumInterval);
            this.SetParamSimple(map, prefix + "TriggerWaitTime", this.TriggerWaitTime);
            this.SetParamSimple(map, prefix + "TriggerMinimumIntervalSecond", this.TriggerMinimumIntervalSecond);
            this.SetParamSimple(map, prefix + "TriggerWaitTimeSecond", this.TriggerWaitTimeSecond);
        }
    }
}

