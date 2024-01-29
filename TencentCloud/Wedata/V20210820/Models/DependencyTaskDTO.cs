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

    public class DependencyTaskDTO : AbstractModel
    {
        
        /// <summary>
        /// 已选任务id
        /// </summary>
        [JsonProperty("SelectedTaskId")]
        public string SelectedTaskId{ get; set; }

        /// <summary>
        /// 已选任务名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SelectedTaskName")]
        public string SelectedTaskName{ get; set; }

        /// <summary>
        /// 依赖任务id
        /// </summary>
        [JsonProperty("DependencyTaskId")]
        public string DependencyTaskId{ get; set; }

        /// <summary>
        /// 依赖任务名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DependencyTaskName")]
        public string DependencyTaskName{ get; set; }

        /// <summary>
        /// 依赖任务是否跨项目
        /// </summary>
        [JsonProperty("CrossProject")]
        public bool? CrossProject{ get; set; }

        /// <summary>
        /// 依赖任务对应项目id
        /// </summary>
        [JsonProperty("DependencyProjectId")]
        public string DependencyProjectId{ get; set; }

        /// <summary>
        /// 依赖任务对应项目名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DependencyProjectName")]
        public string DependencyProjectName{ get; set; }

        /// <summary>
        /// 依赖任务虚拟标识
        /// </summary>
        [JsonProperty("DependencyTaskVirtualFlag")]
        public bool? DependencyTaskVirtualFlag{ get; set; }

        /// <summary>
        /// 边依赖标识
        /// </summary>
        [JsonProperty("LinkDependency")]
        public bool? LinkDependency{ get; set; }

        /// <summary>
        /// 已选任务虚拟标识
        /// </summary>
        [JsonProperty("SelectedTaskVirtualFlag")]
        public bool? SelectedTaskVirtualFlag{ get; set; }

        /// <summary>
        /// 依赖任务工作流名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DependencyTaskWorkflowName")]
        public string DependencyTaskWorkflowName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SelectedTaskId", this.SelectedTaskId);
            this.SetParamSimple(map, prefix + "SelectedTaskName", this.SelectedTaskName);
            this.SetParamSimple(map, prefix + "DependencyTaskId", this.DependencyTaskId);
            this.SetParamSimple(map, prefix + "DependencyTaskName", this.DependencyTaskName);
            this.SetParamSimple(map, prefix + "CrossProject", this.CrossProject);
            this.SetParamSimple(map, prefix + "DependencyProjectId", this.DependencyProjectId);
            this.SetParamSimple(map, prefix + "DependencyProjectName", this.DependencyProjectName);
            this.SetParamSimple(map, prefix + "DependencyTaskVirtualFlag", this.DependencyTaskVirtualFlag);
            this.SetParamSimple(map, prefix + "LinkDependency", this.LinkDependency);
            this.SetParamSimple(map, prefix + "SelectedTaskVirtualFlag", this.SelectedTaskVirtualFlag);
            this.SetParamSimple(map, prefix + "DependencyTaskWorkflowName", this.DependencyTaskWorkflowName);
        }
    }
}

