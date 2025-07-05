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

namespace TencentCloud.Solar.V20181011.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateProjectRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 项目机构
        /// </summary>
        [JsonProperty("ProjectOrg")]
        public string ProjectOrg{ get; set; }

        /// <summary>
        /// 项目预算
        /// </summary>
        [JsonProperty("ProjectBudget")]
        public string ProjectBudget{ get; set; }

        /// <summary>
        /// 项目简介
        /// </summary>
        [JsonProperty("ProjectIntroduction")]
        public string ProjectIntroduction{ get; set; }

        /// <summary>
        /// 所属部门ID
        /// </summary>
        [JsonProperty("ProjectOrgId")]
        public string ProjectOrgId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "ProjectOrg", this.ProjectOrg);
            this.SetParamSimple(map, prefix + "ProjectBudget", this.ProjectBudget);
            this.SetParamSimple(map, prefix + "ProjectIntroduction", this.ProjectIntroduction);
            this.SetParamSimple(map, prefix + "ProjectOrgId", this.ProjectOrgId);
        }
    }
}

