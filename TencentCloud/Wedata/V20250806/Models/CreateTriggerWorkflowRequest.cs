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

    public class CreateTriggerWorkflowRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>项目ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>工作流名称</p>
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }

        /// <summary>
        /// <p>所属文件夹路径</p>
        /// </summary>
        [JsonProperty("ParentFolderPath")]
        public string ParentFolderPath{ get; set; }

        /// <summary>
        /// <p>工作流描述</p>
        /// </summary>
        [JsonProperty("WorkflowDesc")]
        public string WorkflowDesc{ get; set; }

        /// <summary>
        /// <p>工作流负责人ID</p>
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// <p>工作流参数</p>
        /// </summary>
        [JsonProperty("WorkflowParams")]
        public ParamInfo[] WorkflowParams{ get; set; }

        /// <summary>
        /// <p>统一调度信息</p>
        /// </summary>
        [JsonProperty("TriggerWorkflowSchedulerConfigurations")]
        public WorkflowTriggerConfig[] TriggerWorkflowSchedulerConfigurations{ get; set; }

        /// <summary>
        /// <p>BundleId项</p>
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// <p>Bundle信息</p>
        /// </summary>
        [JsonProperty("BundleInfo")]
        public string BundleInfo{ get; set; }

        /// <summary>
        /// <p>通用参数配置</p>
        /// </summary>
        [JsonProperty("GeneralTaskParams")]
        public WorkflowGeneralTaskParam[] GeneralTaskParams{ get; set; }

        /// <summary>
        /// <p>工作流调度运行配置</p>
        /// </summary>
        [JsonProperty("TriggerWorkflowRunConfiguration")]
        public WorkflowRunConfig TriggerWorkflowRunConfiguration{ get; set; }

        /// <summary>
        /// <p>Trigger 状态 启动ACTIVE，暂停PAUSED。配置完之后，内部的Trigger状态可不配置，如果配置，内容会被该值覆盖</p><p>枚举值：</p><ul><li>ACTIVE： 启动</li><li>PAUSED： 暂停</li></ul>
        /// </summary>
        [JsonProperty("SchedulerStatus")]
        public string SchedulerStatus{ get; set; }

        /// <summary>
        /// <p>触发方式：定时触发：TIME_TRIGGER 。配置完之后，内部的TriggerMode状态可不配置，如果配置，内容会被该值覆盖。</p><p>枚举值：</p><ul><li>TIME_TRIGGER： 定时触发</li></ul>
        /// </summary>
        [JsonProperty("TriggerMode")]
        public string TriggerMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamSimple(map, prefix + "ParentFolderPath", this.ParentFolderPath);
            this.SetParamSimple(map, prefix + "WorkflowDesc", this.WorkflowDesc);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamArrayObj(map, prefix + "WorkflowParams.", this.WorkflowParams);
            this.SetParamArrayObj(map, prefix + "TriggerWorkflowSchedulerConfigurations.", this.TriggerWorkflowSchedulerConfigurations);
            this.SetParamSimple(map, prefix + "BundleId", this.BundleId);
            this.SetParamSimple(map, prefix + "BundleInfo", this.BundleInfo);
            this.SetParamArrayObj(map, prefix + "GeneralTaskParams.", this.GeneralTaskParams);
            this.SetParamObj(map, prefix + "TriggerWorkflowRunConfiguration.", this.TriggerWorkflowRunConfiguration);
            this.SetParamSimple(map, prefix + "SchedulerStatus", this.SchedulerStatus);
            this.SetParamSimple(map, prefix + "TriggerMode", this.TriggerMode);
        }
    }
}

