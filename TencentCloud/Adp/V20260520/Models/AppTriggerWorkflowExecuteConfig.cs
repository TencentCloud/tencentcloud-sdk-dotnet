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

    public class AppTriggerWorkflowExecuteConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>工作流API参数绑定</p>
        /// </summary>
        [JsonProperty("ParamBindingsApi")]
        public AppTriggerParamBindingConfig ParamBindingsApi{ get; set; }

        /// <summary>
        /// <p>工作流参数绑定</p>
        /// </summary>
        [JsonProperty("ParamBindingsWorkflow")]
        public AppTriggerParamBindingConfig ParamBindingsWorkflow{ get; set; }

        /// <summary>
        /// <p>工作流ID</p>
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// <p>工作流名字</p>
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ParamBindingsApi.", this.ParamBindingsApi);
            this.SetParamObj(map, prefix + "ParamBindingsWorkflow.", this.ParamBindingsWorkflow);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
        }
    }
}

