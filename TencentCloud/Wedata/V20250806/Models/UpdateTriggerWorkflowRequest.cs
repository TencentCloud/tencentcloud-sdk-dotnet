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

    public class UpdateTriggerWorkflowRequest : AbstractModel
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
        /// 工作流名称
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }

        /// <summary>
        /// 责任人ID
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("WorkflowDesc")]
        public string WorkflowDesc{ get; set; }

        /// <summary>
        /// 工作流参数列表
        /// </summary>
        [JsonProperty("WorkflowParams")]
        public ParamInfo[] WorkflowParams{ get; set; }

        /// <summary>
        /// 统一调度参数
        /// </summary>
        [JsonProperty("TriggerWorkflowSchedulerConfigurations")]
        public WorkflowTriggerConfig[] TriggerWorkflowSchedulerConfigurations{ get; set; }

        /// <summary>
        /// BundleId项
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// Bundle信息
        /// </summary>
        [JsonProperty("BundleInfo")]
        public string BundleInfo{ get; set; }

        /// <summary>
        /// 通用参数配置
        /// </summary>
        [JsonProperty("GeneralTaskParams")]
        public WorkflowGeneralTaskParam[] GeneralTaskParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "WorkflowDesc", this.WorkflowDesc);
            this.SetParamArrayObj(map, prefix + "WorkflowParams.", this.WorkflowParams);
            this.SetParamArrayObj(map, prefix + "TriggerWorkflowSchedulerConfigurations.", this.TriggerWorkflowSchedulerConfigurations);
            this.SetParamSimple(map, prefix + "BundleId", this.BundleId);
            this.SetParamSimple(map, prefix + "BundleInfo", this.BundleInfo);
            this.SetParamArrayObj(map, prefix + "GeneralTaskParams.", this.GeneralTaskParams);
        }
    }
}

