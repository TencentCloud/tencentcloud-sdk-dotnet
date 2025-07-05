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

    public class DeleteWorkflowByIdRequest : AbstractModel
    {
        
        /// <summary>
        /// 工作流id
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 删除后下游任务的处理方式，true:下游任务均正常运行 false:下游任务均运行失败
        /// </summary>
        [JsonProperty("DeleteMode")]
        public bool? DeleteMode{ get; set; }

        /// <summary>
        /// 删除任务后是否通知下游任务责任人, true:通知 false:不通知
        /// </summary>
        [JsonProperty("EnableNotify")]
        public bool? EnableNotify{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "DeleteMode", this.DeleteMode);
            this.SetParamSimple(map, prefix + "EnableNotify", this.EnableNotify);
        }
    }
}

