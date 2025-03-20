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

    public class TriggerManualTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 触发运行名称
        /// </summary>
        [JsonProperty("TriggerName")]
        public string TriggerName{ get; set; }

        /// <summary>
        /// 运行范围 ENTIRE_WORKFLOW or SPECIFIED_TASK
        /// </summary>
        [JsonProperty("TriggerScope")]
        public string TriggerScope{ get; set; }

        /// <summary>
        /// 运行数据时间列表
        /// </summary>
        [JsonProperty("DataTimeList")]
        public string[] DataTimeList{ get; set; }

        /// <summary>
        /// 工作流ID
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 需要运行的任务列表
        /// TriggerScope=ENTIRE_WORKFLOW 时无需传此参数，TriggerScope=SPECIFIED_TASK此参数必传
        /// </summary>
        [JsonProperty("TaskIds")]
        public string[] TaskIds{ get; set; }

        /// <summary>
        /// 用户提交运行时指定的调度资源组，未指定时使用任务配置的调度资源组
        /// </summary>
        [JsonProperty("SchedulerResourceGroup")]
        public string SchedulerResourceGroup{ get; set; }

        /// <summary>
        /// 用户提交运行时指定的集成资源组，未指定时使用任务配置的集成资源组
        /// </summary>
        [JsonProperty("IntegrationResourceGroup")]
        public string IntegrationResourceGroup{ get; set; }

        /// <summary>
        /// 执行顺序 ASC、RAND、DESC
        /// </summary>
        [JsonProperty("ExecOrder")]
        public string ExecOrder{ get; set; }

        /// <summary>
        /// 自定义参数，最高优先级
        /// </summary>
        [JsonProperty("CustomParams")]
        public KVPair[] CustomParams{ get; set; }

        /// <summary>
        /// 页面反显使用，无业务含义
        /// </summary>
        [JsonProperty("ExtraParams")]
        public string ExtraParams{ get; set; }

        /// <summary>
        /// 实例时间的时区
        /// </summary>
        [JsonProperty("ScheduleTimeZone")]
        public string ScheduleTimeZone{ get; set; }

        /// <summary>
        /// 时间类型，DATA_TIME：数据时间、SCHEDULE_TIME：计划调度时间, 为空时会被当成DATA_TIME处理
        /// </summary>
        [JsonProperty("TimeType")]
        public string TimeType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "TriggerName", this.TriggerName);
            this.SetParamSimple(map, prefix + "TriggerScope", this.TriggerScope);
            this.SetParamArraySimple(map, prefix + "DataTimeList.", this.DataTimeList);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArraySimple(map, prefix + "TaskIds.", this.TaskIds);
            this.SetParamSimple(map, prefix + "SchedulerResourceGroup", this.SchedulerResourceGroup);
            this.SetParamSimple(map, prefix + "IntegrationResourceGroup", this.IntegrationResourceGroup);
            this.SetParamSimple(map, prefix + "ExecOrder", this.ExecOrder);
            this.SetParamArrayObj(map, prefix + "CustomParams.", this.CustomParams);
            this.SetParamSimple(map, prefix + "ExtraParams", this.ExtraParams);
            this.SetParamSimple(map, prefix + "ScheduleTimeZone", this.ScheduleTimeZone);
            this.SetParamSimple(map, prefix + "TimeType", this.TimeType);
        }
    }
}

