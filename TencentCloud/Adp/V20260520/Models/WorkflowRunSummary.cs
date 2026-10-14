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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkflowRunSummary : AbstractModel
    {
        
        /// <summary>
        /// <p>运行环境。1:开发域，2:生产域</p>
        /// </summary>
        [JsonProperty("Domain")]
        public ulong? Domain{ get; set; }

        /// <summary>
        /// <p>工作流运行实例基本信息</p>
        /// </summary>
        [JsonProperty("WorkflowRunProfile")]
        public WorkflowRunProfile WorkflowRunProfile{ get; set; }

        /// <summary>
        /// <p>工作流运行实例结果</p>
        /// </summary>
        [JsonProperty("WorkflowRunResult")]
        public WorkflowRunResult WorkflowRunResult{ get; set; }

        /// <summary>
        /// <p>工作流运行实例时间信息</p>
        /// </summary>
        [JsonProperty("WorkflowRunTime")]
        public WorkflowRunTime WorkflowRunTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamObj(map, prefix + "WorkflowRunProfile.", this.WorkflowRunProfile);
            this.SetParamObj(map, prefix + "WorkflowRunResult.", this.WorkflowRunResult);
            this.SetParamObj(map, prefix + "WorkflowRunTime.", this.WorkflowRunTime);
        }
    }
}

