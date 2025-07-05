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

    public class DescribeProjectResponse : AbstractModel
    {
        
        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 项目预算
        /// </summary>
        [JsonProperty("ProjectBudget")]
        public float? ProjectBudget{ get; set; }

        /// <summary>
        /// 项目机构
        /// </summary>
        [JsonProperty("ProjectOrg")]
        public string ProjectOrg{ get; set; }

        /// <summary>
        /// 项目简介
        /// </summary>
        [JsonProperty("ProjectIntroduction")]
        public string ProjectIntroduction{ get; set; }

        /// <summary>
        /// 子项目列表
        /// </summary>
        [JsonProperty("SubProjectList")]
        public SubProjectInfo[] SubProjectList{ get; set; }

        /// <summary>
        /// 项目状态
        /// </summary>
        [JsonProperty("ProjectStatus")]
        public string ProjectStatus{ get; set; }

        /// <summary>
        /// 项目机构Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectOrgId")]
        public string ProjectOrgId{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "ProjectBudget", this.ProjectBudget);
            this.SetParamSimple(map, prefix + "ProjectOrg", this.ProjectOrg);
            this.SetParamSimple(map, prefix + "ProjectIntroduction", this.ProjectIntroduction);
            this.SetParamArrayObj(map, prefix + "SubProjectList.", this.SubProjectList);
            this.SetParamSimple(map, prefix + "ProjectStatus", this.ProjectStatus);
            this.SetParamSimple(map, prefix + "ProjectOrgId", this.ProjectOrgId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

