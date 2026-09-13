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

    public class GetWorkflowTaskRunRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>工作空间ID，可通过 ListWorkspaces 获取。必填</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>任务运行ID，可通过 ListWorkflowTaskRuns 获取。必填</p>
        /// </summary>
        [JsonProperty("WorkflowTaskRunId")]
        public string WorkflowTaskRunId{ get; set; }

        /// <summary>
        /// <p>内嵌工作流任务运行列表选项（仅限 FOR_EACH 任务使用）。非必填</p>
        /// </summary>
        [JsonProperty("InnerWorkflowTaskRunListOption")]
        public InnerWorkflowTaskRunListOption InnerWorkflowTaskRunListOption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "WorkflowTaskRunId", this.WorkflowTaskRunId);
            this.SetParamObj(map, prefix + "InnerWorkflowTaskRunListOption.", this.InnerWorkflowTaskRunListOption);
        }
    }
}

