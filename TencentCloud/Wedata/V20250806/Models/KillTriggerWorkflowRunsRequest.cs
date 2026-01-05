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

    public class KillTriggerWorkflowRunsRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID	
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 工作流ID
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// 指定要停止的工作流执行ID
        /// </summary>
        [JsonProperty("WorkflowExecutionIdList")]
        public string[] WorkflowExecutionIdList{ get; set; }

        /// <summary>
        /// 当指定的工作流运行为空时，是否全部终止正在运行的工作流执行	
        /// </summary>
        [JsonProperty("All")]
        public bool? All{ get; set; }

        /// <summary>
        /// 当指定的工作流运行为空时，是否仅停止等待中的工作流运行
        /// </summary>
        [JsonProperty("Pending")]
        public bool? Pending{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamArraySimple(map, prefix + "WorkflowExecutionIdList.", this.WorkflowExecutionIdList);
            this.SetParamSimple(map, prefix + "All", this.All);
            this.SetParamSimple(map, prefix + "Pending", this.Pending);
        }
    }
}

