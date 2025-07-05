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

    public class DescribeTasksForCodeTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 页码，最小1
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 单页大小，最小10，最大200
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 工作流id列表
        /// </summary>
        [JsonProperty("WorkflowIdList")]
        public string[] WorkflowIdList{ get; set; }

        /// <summary>
        /// 责任人名列表
        /// </summary>
        [JsonProperty("OwnerIdList")]
        public string[] OwnerIdList{ get; set; }

        /// <summary>
        /// 任务名
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 排序提交，目前只支持workflowName
        /// </summary>
        [JsonProperty("OrderCondition")]
        public OrderCondition OrderCondition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamArraySimple(map, prefix + "WorkflowIdList.", this.WorkflowIdList);
            this.SetParamArraySimple(map, prefix + "OwnerIdList.", this.OwnerIdList);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamObj(map, prefix + "OrderCondition.", this.OrderCondition);
        }
    }
}

