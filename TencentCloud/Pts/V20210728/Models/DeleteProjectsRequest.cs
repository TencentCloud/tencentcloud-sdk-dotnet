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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteProjectsRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID数组
        /// </summary>
        [JsonProperty("ProjectIds")]
        public string[] ProjectIds{ get; set; }

        /// <summary>
        /// 是否删除项目相关的场景。默认为否。
        /// </summary>
        [JsonProperty("DeleteScenarios")]
        public bool? DeleteScenarios{ get; set; }

        /// <summary>
        /// 是否删除项目相关的任务。默认为否。
        /// </summary>
        [JsonProperty("DeleteJobs")]
        public bool? DeleteJobs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamSimple(map, prefix + "DeleteScenarios", this.DeleteScenarios);
            this.SetParamSimple(map, prefix + "DeleteJobs", this.DeleteJobs);
        }
    }
}

