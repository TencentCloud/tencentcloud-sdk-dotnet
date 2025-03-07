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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RedisInstanceEvent : AbstractModel
    {
        
        /// <summary>
        /// 事件 ID。
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// 实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 事件类型，当前仅支持配置实例迁移、资源腾挪、机房裁撤相关的运维操作。该参数仅支持配置为 **InstanceMigration**。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 事件等级根据其影响严重程度和紧急程度进行分级，由重至轻依次为关键、重要、中等、一般。
        /// - Critical：关键
        /// - High：重要
        /// - Middle：中等
        /// - Low：一般
        /// </summary>
        [JsonProperty("Grade")]
        public string Grade{ get; set; }

        /// <summary>
        /// 事件计划执行日期。
        /// </summary>
        [JsonProperty("ExecutionDate")]
        public string ExecutionDate{ get; set; }

        /// <summary>
        /// 事件计划执行开始时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 事件计划执行结束时间。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 运维事件最迟执行的日期，即该事件必须在该日期之前完成，否则可能会对业务产生影响。
        /// </summary>
        [JsonProperty("LatestExecutionDate")]
        public string LatestExecutionDate{ get; set; }

        /// <summary>
        /// 事件当前状态。
        /// - Waiting：未到达执行日期或不在维护时间窗内的事件。
        /// - Running：在维护时间窗内，正在执行维护的事件。
        /// - Finished：已全部完成维护的事件。
        /// - Canceled：已取消执行的事件。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 事件执行任务完成时间。
        /// </summary>
        [JsonProperty("TaskEndTime")]
        public string TaskEndTime{ get; set; }

        /// <summary>
        /// 事件影响信息。
        /// </summary>
        [JsonProperty("EffectInfo")]
        public string EffectInfo{ get; set; }

        /// <summary>
        /// 事件最初计划执行日期。
        /// </summary>
        [JsonProperty("InitialExecutionDate")]
        public string InitialExecutionDate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Grade", this.Grade);
            this.SetParamSimple(map, prefix + "ExecutionDate", this.ExecutionDate);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "LatestExecutionDate", this.LatestExecutionDate);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TaskEndTime", this.TaskEndTime);
            this.SetParamSimple(map, prefix + "EffectInfo", this.EffectInfo);
            this.SetParamSimple(map, prefix + "InitialExecutionDate", this.InitialExecutionDate);
        }
    }
}

