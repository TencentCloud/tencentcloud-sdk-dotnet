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

    public class RerunTriggerWorkflowRunAsyncRequest : AbstractModel
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
        /// 工作流运行ID
        /// </summary>
        [JsonProperty("WorkflowExecutionId")]
        public string WorkflowExecutionId{ get; set; }

        /// <summary>
        /// 运行方式：普通运行默认所有参数：1，高级运行可选任务范围和运行参数：2
        /// </summary>
        [JsonProperty("ExecuteType")]
        public string ExecuteType{ get; set; }

        /// <summary>
        /// 运行类型为高级运行时填写的自定义运行参数
        /// </summary>
        [JsonProperty("AdvancedParams")]
        public SchedulingParameter[] AdvancedParams{ get; set; }

        /// <summary>
        /// 高级运行模式下本次需要运行指定的任务ID集合
        /// </summary>
        [JsonProperty("TaskIds")]
        public string[] TaskIds{ get; set; }

        /// <summary>
        /// 指定调度资源组,为空时默认使用配置的原调度资源组
        /// </summary>
        [JsonProperty("SchedulingResourceGroup")]
        public string SchedulingResourceGroup{ get; set; }

        /// <summary>
        /// 指定集成资源组,为空时默认使用配置的原集成资源组
        /// </summary>
        [JsonProperty("IntegrationResourceGroup")]
        public string IntegrationResourceGroup{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "WorkflowExecutionId", this.WorkflowExecutionId);
            this.SetParamSimple(map, prefix + "ExecuteType", this.ExecuteType);
            this.SetParamArrayObj(map, prefix + "AdvancedParams.", this.AdvancedParams);
            this.SetParamArraySimple(map, prefix + "TaskIds.", this.TaskIds);
            this.SetParamSimple(map, prefix + "SchedulingResourceGroup", this.SchedulingResourceGroup);
            this.SetParamSimple(map, prefix + "IntegrationResourceGroup", this.IntegrationResourceGroup);
        }
    }
}

