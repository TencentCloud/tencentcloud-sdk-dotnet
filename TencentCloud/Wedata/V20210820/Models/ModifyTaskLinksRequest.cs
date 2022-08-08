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

    public class ModifyTaskLinksRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 父任务ID
        /// </summary>
        [JsonProperty("TaskFrom")]
        public string TaskFrom{ get; set; }

        /// <summary>
        /// 子任务ID
        /// </summary>
        [JsonProperty("TaskTo")]
        public string TaskTo{ get; set; }

        /// <summary>
        /// 子任务工作流
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// 父任务工作流
        /// </summary>
        [JsonProperty("RealFromWorkflowId")]
        public string RealFromWorkflowId{ get; set; }

        /// <summary>
        /// 父子任务之间的依赖关系
        /// </summary>
        [JsonProperty("LinkDependencyType")]
        public string LinkDependencyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "TaskFrom", this.TaskFrom);
            this.SetParamSimple(map, prefix + "TaskTo", this.TaskTo);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "RealFromWorkflowId", this.RealFromWorkflowId);
            this.SetParamSimple(map, prefix + "LinkDependencyType", this.LinkDependencyType);
        }
    }
}

