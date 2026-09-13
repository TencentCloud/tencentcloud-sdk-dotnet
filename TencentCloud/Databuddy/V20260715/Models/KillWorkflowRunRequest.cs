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

    public class KillWorkflowRunRequest : AbstractModel
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
        /// <p>待终止的工作流运行ID列表，可通过 ListWorkflowRuns 获取</p>
        /// </summary>
        [JsonProperty("WorkflowRunIds")]
        public string[] WorkflowRunIds{ get; set; }

        /// <summary>
        /// <p>是否终止该工作流下所有未进入终态的运行。非必填，默认 false</p>
        /// </summary>
        [JsonProperty("KillAllRuns")]
        public bool? KillAllRuns{ get; set; }

        /// <summary>
        /// <p>是否只终止处于等待中（Pending）状态的运行。非必填，默认 false</p>
        /// </summary>
        [JsonProperty("OnlyKillPendingRuns")]
        public bool? OnlyKillPendingRuns{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamArraySimple(map, prefix + "WorkflowRunIds.", this.WorkflowRunIds);
            this.SetParamSimple(map, prefix + "KillAllRuns", this.KillAllRuns);
            this.SetParamSimple(map, prefix + "OnlyKillPendingRuns", this.OnlyKillPendingRuns);
        }
    }
}

