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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateWorkflowInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 操作者名称
        /// </summary>
        [JsonProperty("OperatorName")]
        public string OperatorName{ get; set; }

        /// <summary>
        /// 工作流id
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// 责任人
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// 责任人id
        /// </summary>
        [JsonProperty("OwnerId")]
        public string OwnerId{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("WorkflowDesc")]
        public string WorkflowDesc{ get; set; }

        /// <summary>
        /// 工作流名称
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }

        /// <summary>
        /// 所属文件夹id
        /// </summary>
        [JsonProperty("FolderId")]
        public string FolderId{ get; set; }

        /// <summary>
        /// 工作流所属用户分组id  若有多个,分号隔开: a;b;c
        /// </summary>
        [JsonProperty("UserGroupId")]
        public string UserGroupId{ get; set; }

        /// <summary>
        /// 工作流所属用户分组名称  若有多个,分号隔开: a;b;c
        /// </summary>
        [JsonProperty("UserGroupName")]
        public string UserGroupName{ get; set; }

        /// <summary>
        /// 工作流参数列表
        /// </summary>
        [JsonProperty("WorkflowParams")]
        public ParamInfo[] WorkflowParams{ get; set; }

        /// <summary>
        /// 用于配置优化参数（线程、内存、CPU核数等），仅作用于Spark SQL节点。多个参数用英文分号分隔。
        /// </summary>
        [JsonProperty("GeneralTaskParams")]
        public GeneralTaskParam[] GeneralTaskParams{ get; set; }

        /// <summary>
        /// 工作流依赖，yes/no。开启后表示当前任务依赖本工作流上个周期的所有任务。仅支持当前任务所在工作流的任务全部为同周期的情况，如果非同周期则不生效，请在工作流-统一调度上进行配置。
        /// </summary>
        [JsonProperty("DependencyWorkflow")]
        public string DependencyWorkflow{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "OperatorName", this.OperatorName);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
            this.SetParamSimple(map, prefix + "OwnerId", this.OwnerId);
            this.SetParamSimple(map, prefix + "WorkflowDesc", this.WorkflowDesc);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamSimple(map, prefix + "FolderId", this.FolderId);
            this.SetParamSimple(map, prefix + "UserGroupId", this.UserGroupId);
            this.SetParamSimple(map, prefix + "UserGroupName", this.UserGroupName);
            this.SetParamArrayObj(map, prefix + "WorkflowParams.", this.WorkflowParams);
            this.SetParamArrayObj(map, prefix + "GeneralTaskParams.", this.GeneralTaskParams);
            this.SetParamSimple(map, prefix + "DependencyWorkflow", this.DependencyWorkflow);
        }
    }
}

