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

    public class ModifyProjectRequest : AbstractModel
    {
        
        /// <summary>
        /// 目标修改的项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// true/false则修改，不带该参数不修改。
        /// </summary>
        [JsonProperty("TaskSubmitApproval")]
        public bool? TaskSubmitApproval{ get; set; }

        /// <summary>
        /// 资源池信息
        /// </summary>
        [JsonProperty("ResourcePoolInfo")]
        public ResourcePoolInfo ResourcePoolInfo{ get; set; }

        /// <summary>
        /// 项目管理员
        /// </summary>
        [JsonProperty("ProjectManagers")]
        public string[] ProjectManagers{ get; set; }

        /// <summary>
        /// 调度任务严格模式
        /// </summary>
        [JsonProperty("TaskStrictMode")]
        public bool? TaskStrictMode{ get; set; }

        /// <summary>
        /// 以后新增选项可以直接通过前端的json格式写入去实现
        /// </summary>
        [JsonProperty("ExtraOptions")]
        public string ExtraOptions{ get; set; }

        /// <summary>
        /// 项目类型，SIMPLE：简单模式 STANDARD：标准模式
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// 项目负责人
        /// </summary>
        [JsonProperty("ProjectOwner")]
        public string[] ProjectOwner{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "TaskSubmitApproval", this.TaskSubmitApproval);
            this.SetParamObj(map, prefix + "ResourcePoolInfo.", this.ResourcePoolInfo);
            this.SetParamArraySimple(map, prefix + "ProjectManagers.", this.ProjectManagers);
            this.SetParamSimple(map, prefix + "TaskStrictMode", this.TaskStrictMode);
            this.SetParamSimple(map, prefix + "ExtraOptions", this.ExtraOptions);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamArraySimple(map, prefix + "ProjectOwner.", this.ProjectOwner);
        }
    }
}

