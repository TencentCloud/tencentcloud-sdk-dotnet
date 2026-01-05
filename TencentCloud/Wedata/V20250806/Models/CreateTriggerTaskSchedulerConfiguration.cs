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

    public class CreateTriggerTaskSchedulerConfiguration : AbstractModel
    {
        
        /// <summary>
        /// 上游依赖的任务数组
        /// </summary>
        [JsonProperty("UpstreamDependencyConfigList")]
        public DependencyTriggerTaskBrief[] UpstreamDependencyConfigList{ get; set; }

        /// <summary>
        /// 任务调度优先级 运行优先级 4高 5中 6低 , 默认:6
        /// </summary>
        [JsonProperty("RunPriorityType")]
        public long? RunPriorityType{ get; set; }

        /// <summary>
        /// 重试策略 重试等待时间,单位分钟: 默认: 5
        /// </summary>
        [JsonProperty("RetryWaitMinute")]
        public long? RetryWaitMinute{ get; set; }

        /// <summary>
        /// 重试策略 最大尝试次数, 默认: 4
        /// </summary>
        [JsonProperty("MaxRetryNumber")]
        public long? MaxRetryNumber{ get; set; }

        /// <summary>
        /// 超时处理策略 运行耗时超时（单位：分钟）默认为 -1
        /// </summary>
        [JsonProperty("ExecutionTTLMinute")]
        public long? ExecutionTTLMinute{ get; set; }

        /// <summary>
        /// 超时处理策略 等待总时长耗时超时（单位：分钟）默认为 -1
        /// </summary>
        [JsonProperty("WaitExecutionTotalTTLMinute")]
        public long? WaitExecutionTotalTTLMinute{ get; set; }

        /// <summary>
        /// 重跑&补录配置, 默认为 ALL; , ALL 运行成功或失败后皆可重跑或补录, FAILURE 运行成功后不可重跑或补录，运行失败后可重跑或补录, NONE 运行成功或失败后皆不可重跑或补录;
        /// </summary>
        [JsonProperty("AllowRedoType")]
        public string AllowRedoType{ get; set; }

        /// <summary>
        /// 输出参数数组
        /// </summary>
        [JsonProperty("ParamTaskOutList")]
        public OutTaskParameter[] ParamTaskOutList{ get; set; }

        /// <summary>
        /// 输入参数数组
        /// </summary>
        [JsonProperty("ParamTaskInList")]
        public InTaskParameter[] ParamTaskInList{ get; set; }

        /// <summary>
        /// 产出登记
        /// </summary>
        [JsonProperty("TaskOutputRegistryList")]
        public TaskDataRegistry[] TaskOutputRegistryList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "UpstreamDependencyConfigList.", this.UpstreamDependencyConfigList);
            this.SetParamSimple(map, prefix + "RunPriorityType", this.RunPriorityType);
            this.SetParamSimple(map, prefix + "RetryWaitMinute", this.RetryWaitMinute);
            this.SetParamSimple(map, prefix + "MaxRetryNumber", this.MaxRetryNumber);
            this.SetParamSimple(map, prefix + "ExecutionTTLMinute", this.ExecutionTTLMinute);
            this.SetParamSimple(map, prefix + "WaitExecutionTotalTTLMinute", this.WaitExecutionTotalTTLMinute);
            this.SetParamSimple(map, prefix + "AllowRedoType", this.AllowRedoType);
            this.SetParamArrayObj(map, prefix + "ParamTaskOutList.", this.ParamTaskOutList);
            this.SetParamArrayObj(map, prefix + "ParamTaskInList.", this.ParamTaskInList);
            this.SetParamArrayObj(map, prefix + "TaskOutputRegistryList.", this.TaskOutputRegistryList);
        }
    }
}

