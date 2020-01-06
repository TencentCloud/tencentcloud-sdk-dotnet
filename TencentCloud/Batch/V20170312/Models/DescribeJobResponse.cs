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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeJobResponse : AbstractModel
    {
        
        /// <summary>
        /// 作业ID
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 作业名称
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// 可用区信息
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 作业优先级
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// 作业状态
        /// </summary>
        [JsonProperty("JobState")]
        public string JobState{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 任务视图信息
        /// </summary>
        [JsonProperty("TaskSet")]
        public TaskView[] TaskSet{ get; set; }

        /// <summary>
        /// 任务间依赖信息
        /// </summary>
        [JsonProperty("DependenceSet")]
        public Dependence[] DependenceSet{ get; set; }

        /// <summary>
        /// 任务统计指标
        /// </summary>
        [JsonProperty("TaskMetrics")]
        public TaskMetrics TaskMetrics{ get; set; }

        /// <summary>
        /// 任务实例统计指标
        /// </summary>
        [JsonProperty("TaskInstanceMetrics")]
        public TaskInstanceView TaskInstanceMetrics{ get; set; }

        /// <summary>
        /// 作业失败原因
        /// </summary>
        [JsonProperty("StateReason")]
        public string StateReason{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "JobState", this.JobState);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArrayObj(map, prefix + "TaskSet.", this.TaskSet);
            this.SetParamArrayObj(map, prefix + "DependenceSet.", this.DependenceSet);
            this.SetParamObj(map, prefix + "TaskMetrics.", this.TaskMetrics);
            this.SetParamObj(map, prefix + "TaskInstanceMetrics.", this.TaskInstanceMetrics);
            this.SetParamSimple(map, prefix + "StateReason", this.StateReason);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

