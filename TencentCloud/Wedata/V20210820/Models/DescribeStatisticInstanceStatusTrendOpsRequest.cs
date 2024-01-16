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

    public class DescribeStatisticInstanceStatusTrendOpsRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 任务类型Id
        /// </summary>
        [JsonProperty("TaskTypeId")]
        public string TaskTypeId{ get; set; }

        /// <summary>
        /// 时间类型
        /// </summary>
        [JsonProperty("TimeType")]
        public string TimeType{ get; set; }

        /// <summary>
        /// 任务类型名称
        /// </summary>
        [JsonProperty("TypeName")]
        public string TypeName{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 资源组ID
        /// </summary>
        [JsonProperty("ExecutionGroupId")]
        public string ExecutionGroupId{ get; set; }

        /// <summary>
        /// 资源组名称
        /// </summary>
        [JsonProperty("ExecutionGroupName")]
        public string ExecutionGroupName{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("InCharge")]
        public string InCharge{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("StateList")]
        public long?[] StateList{ get; set; }

        /// <summary>
        /// D代表天，H代表小时
        /// </summary>
        [JsonProperty("AggregationUnit")]
        public string AggregationUnit{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("AverageWindowSize")]
        public long? AverageWindowSize{ get; set; }

        /// <summary>
        /// 工作流ID
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "TaskTypeId", this.TaskTypeId);
            this.SetParamSimple(map, prefix + "TimeType", this.TimeType);
            this.SetParamSimple(map, prefix + "TypeName", this.TypeName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ExecutionGroupId", this.ExecutionGroupId);
            this.SetParamSimple(map, prefix + "ExecutionGroupName", this.ExecutionGroupName);
            this.SetParamSimple(map, prefix + "InCharge", this.InCharge);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamArraySimple(map, prefix + "StateList.", this.StateList);
            this.SetParamSimple(map, prefix + "AggregationUnit", this.AggregationUnit);
            this.SetParamSimple(map, prefix + "AverageWindowSize", this.AverageWindowSize);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
        }
    }
}

