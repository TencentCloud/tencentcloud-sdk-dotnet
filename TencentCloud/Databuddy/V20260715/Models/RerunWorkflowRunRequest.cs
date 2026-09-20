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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RerunWorkflowRunRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>工作空间ID，可通过 ListWorkspaces 获取。必填</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>工作流ID，可通过 ListWorkflows 获取。必填</p>
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// <p>工作流运行ID，可通过 ListWorkflowRuns 获取。必填</p>
        /// </summary>
        [JsonProperty("WorkflowRunId")]
        public string WorkflowRunId{ get; set; }

        /// <summary>
        /// <p>运行类型。必填。取值：1 普通运行，2 高级运行</p>
        /// </summary>
        [JsonProperty("RunType")]
        public long? RunType{ get; set; }

        /// <summary>
        /// <p>运行类型为高级运行时填写的自定义运行参数</p>
        /// </summary>
        [JsonProperty("AdvancedParams")]
        public TaskSchedulingParameterBrief[] AdvancedParams{ get; set; }

        /// <summary>
        /// <p>本次需要重跑指定的任务ID集合，可通过 ListWorkflowTasks 获取，不传默认重跑该工作流下所有任务</p>
        /// </summary>
        [JsonProperty("TaskIds")]
        public string[] TaskIds{ get; set; }

        /// <summary>
        /// <p>计划调度时间列表配置</p>
        /// </summary>
        [JsonProperty("ScheduledTimeConfig")]
        public ScheduledTimeConfig ScheduledTimeConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "WorkflowRunId", this.WorkflowRunId);
            this.SetParamSimple(map, prefix + "RunType", this.RunType);
            this.SetParamArrayObj(map, prefix + "AdvancedParams.", this.AdvancedParams);
            this.SetParamArraySimple(map, prefix + "TaskIds.", this.TaskIds);
            this.SetParamObj(map, prefix + "ScheduledTimeConfig.", this.ScheduledTimeConfig);
        }
    }
}

