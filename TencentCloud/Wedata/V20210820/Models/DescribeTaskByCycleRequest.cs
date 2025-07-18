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

    public class DescribeTaskByCycleRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("InCharge")]
        public string InCharge{ get; set; }

        /// <summary>
        /// 工作流ID
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// 项目ID列表筛选
        /// </summary>
        [JsonProperty("ProjectIds")]
        public string[] ProjectIds{ get; set; }

        /// <summary>
        /// 资源组ID列表筛选
        /// </summary>
        [JsonProperty("ResourceGroupIds")]
        public string[] ResourceGroupIds{ get; set; }

        /// <summary>
        /// 任务类型ID筛选
        /// </summary>
        [JsonProperty("TaskTypeIdList")]
        public string[] TaskTypeIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "InCharge", this.InCharge);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamArraySimple(map, prefix + "ResourceGroupIds.", this.ResourceGroupIds);
            this.SetParamArraySimple(map, prefix + "TaskTypeIdList.", this.TaskTypeIdList);
        }
    }
}

