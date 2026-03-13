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

    public class CreateTriggerWorkflowRunRequest : AbstractModel
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
        /// 自定义运行参数，如果为空或者null则使用工作流最新配置
        /// </summary>
        [JsonProperty("AdvancedParams")]
        public SchedulingParameter[] AdvancedParams{ get; set; }

        /// <summary>
        /// 本次需要运行指定的任务ID集合，如果为null或为空则运行全部
        /// </summary>
        [JsonProperty("TaskIds")]
        public string[] TaskIds{ get; set; }

        /// <summary>
        /// 指定的调度资源组id，为空默认原资源组
        /// </summary>
        [JsonProperty("SchedulingResourceGroupId")]
        public string SchedulingResourceGroupId{ get; set; }

        /// <summary>
        /// 指定的集成资源组id，为空默认原资源组
        /// </summary>
        [JsonProperty("IntegrationResourceGroupId")]
        public string IntegrationResourceGroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamArrayObj(map, prefix + "AdvancedParams.", this.AdvancedParams);
            this.SetParamArraySimple(map, prefix + "TaskIds.", this.TaskIds);
            this.SetParamSimple(map, prefix + "SchedulingResourceGroupId", this.SchedulingResourceGroupId);
            this.SetParamSimple(map, prefix + "IntegrationResourceGroupId", this.IntegrationResourceGroupId);
        }
    }
}

