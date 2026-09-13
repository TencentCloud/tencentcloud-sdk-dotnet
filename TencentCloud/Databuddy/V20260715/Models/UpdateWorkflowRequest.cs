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

    public class UpdateWorkflowRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>工作空间ID，可通过 ListWorkspaces 获取。必填</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>待更新的工作流ID，可通过 ListWorkflows 获取。必填</p>
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// <p>需要清空的字段名列表，用于将指定字段重置为空</p>
        /// </summary>
        [JsonProperty("FieldToRemoveList")]
        public string[] FieldToRemoveList{ get; set; }

        /// <summary>
        /// <p>更新后的工作流配置，仅传入需要变更的部分即可</p>
        /// </summary>
        [JsonProperty("NewSetting")]
        public Workflow NewSetting{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamArraySimple(map, prefix + "FieldToRemoveList.", this.FieldToRemoveList);
            this.SetParamObj(map, prefix + "NewSetting.", this.NewSetting);
        }
    }
}

