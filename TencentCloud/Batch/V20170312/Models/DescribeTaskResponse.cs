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

    public class DescribeTaskResponse : AbstractModel
    {
        
        /// <summary>
        /// 作业ID
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [JsonProperty("TaskState")]
        public string TaskState{ get; set; }

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
        /// 任务实例总数
        /// </summary>
        [JsonProperty("TaskInstanceTotalCount")]
        public long? TaskInstanceTotalCount{ get; set; }

        /// <summary>
        /// 任务实例信息
        /// </summary>
        [JsonProperty("TaskInstanceSet")]
        public TaskInstanceView[] TaskInstanceSet{ get; set; }

        /// <summary>
        /// 任务实例统计指标
        /// </summary>
        [JsonProperty("TaskInstanceMetrics")]
        public TaskInstanceMetrics TaskInstanceMetrics{ get; set; }

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
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskState", this.TaskState);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TaskInstanceTotalCount", this.TaskInstanceTotalCount);
            this.SetParamArrayObj(map, prefix + "TaskInstanceSet.", this.TaskInstanceSet);
            this.SetParamObj(map, prefix + "TaskInstanceMetrics.", this.TaskInstanceMetrics);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

