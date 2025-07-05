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

    public class ModifyWorkflowScheduleRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 工作流id
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// 延迟时间，单位分钟
        /// </summary>
        [JsonProperty("DelayTime")]
        public long? DelayTime{ get; set; }

        /// <summary>
        /// 启动时间
        /// </summary>
        [JsonProperty("StartupTime")]
        public long? StartupTime{ get; set; }

        /// <summary>
        /// 自依赖类型  1:有序串行 一次一个 排队, 2: 无序串行 一次一个 不排队， 3:并行 一次多个
        /// </summary>
        [JsonProperty("SelfDepend")]
        public long? SelfDepend{ get; set; }

        /// <summary>
        /// "周期类型  0:crontab类型, 1:分钟，2:小时，3:天，4:周，5:月，6:一次性，7:用户驱动，10:弹性周期 周,11:弹性周期 月,12:年,13:即时触发Instant类型，与正常周期调度任务逻辑隔离
        /// </summary>
        [JsonProperty("CycleType")]
        public long? CycleType{ get; set; }

        /// <summary>
        /// 步长，间隔时间，最小1
        /// </summary>
        [JsonProperty("CycleStep")]
        public long? CycleStep{ get; set; }

        /// <summary>
        /// 生效开始时间，格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 生效结束时间，格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 调度配置-弹性周期配置，小时/周/月/年调度才有，小时任务指定每天的0点3点4点跑，则为'0,3,4'。
        /// </summary>
        [JsonProperty("TaskAction")]
        public string TaskAction{ get; set; }

        /// <summary>
        /// cron表达式  周期类型为crontab调度才需要
        /// </summary>
        [JsonProperty("CrontabExpression")]
        public string CrontabExpression{ get; set; }

        /// <summary>
        /// 执行时间左闭区间，格式：HH:mm  小时调度才有，例如小时任务, 每日固定区间生效
        /// </summary>
        [JsonProperty("ExecutionStartTime")]
        public string ExecutionStartTime{ get; set; }

        /// <summary>
        /// 执行时间右闭区间，格式：HH:mm  小时调度才有，例如小时任务, 每日固定区间生效
        /// </summary>
        [JsonProperty("ExecutionEndTime")]
        public string ExecutionEndTime{ get; set; }

        /// <summary>
        /// 工作流依赖 ,yes 或者no
        /// </summary>
        [JsonProperty("DependencyWorkflow")]
        public string DependencyWorkflow{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "DelayTime", this.DelayTime);
            this.SetParamSimple(map, prefix + "StartupTime", this.StartupTime);
            this.SetParamSimple(map, prefix + "SelfDepend", this.SelfDepend);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "CycleStep", this.CycleStep);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TaskAction", this.TaskAction);
            this.SetParamSimple(map, prefix + "CrontabExpression", this.CrontabExpression);
            this.SetParamSimple(map, prefix + "ExecutionStartTime", this.ExecutionStartTime);
            this.SetParamSimple(map, prefix + "ExecutionEndTime", this.ExecutionEndTime);
            this.SetParamSimple(map, prefix + "DependencyWorkflow", this.DependencyWorkflow);
        }
    }
}

