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

    public class DependencyWorkflowDTO : AbstractModel
    {
        
        /// <summary>
        /// 已选工作流id
        /// </summary>
        [JsonProperty("SelectedWorkflowId")]
        public string SelectedWorkflowId{ get; set; }

        /// <summary>
        /// 已选工作流名称
        /// </summary>
        [JsonProperty("SelectedWorkflowName")]
        public string SelectedWorkflowName{ get; set; }

        /// <summary>
        /// 依赖工作流id
        /// </summary>
        [JsonProperty("DependencyWorkflowId")]
        public string DependencyWorkflowId{ get; set; }

        /// <summary>
        /// 依赖工作流名称
        /// </summary>
        [JsonProperty("DependencyWorkflowName")]
        public string DependencyWorkflowName{ get; set; }

        /// <summary>
        /// 依赖工作流是否跨项目
        /// </summary>
        [JsonProperty("CrossProject")]
        public bool? CrossProject{ get; set; }

        /// <summary>
        /// 依赖工作流对应项目id
        /// </summary>
        [JsonProperty("DependencyProjectId")]
        public string DependencyProjectId{ get; set; }

        /// <summary>
        /// 依赖工作流对应项目名称
        /// </summary>
        [JsonProperty("DependencyProjectName")]
        public string DependencyProjectName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SelectedWorkflowId", this.SelectedWorkflowId);
            this.SetParamSimple(map, prefix + "SelectedWorkflowName", this.SelectedWorkflowName);
            this.SetParamSimple(map, prefix + "DependencyWorkflowId", this.DependencyWorkflowId);
            this.SetParamSimple(map, prefix + "DependencyWorkflowName", this.DependencyWorkflowName);
            this.SetParamSimple(map, prefix + "CrossProject", this.CrossProject);
            this.SetParamSimple(map, prefix + "DependencyProjectId", this.DependencyProjectId);
            this.SetParamSimple(map, prefix + "DependencyProjectName", this.DependencyProjectName);
        }
    }
}

