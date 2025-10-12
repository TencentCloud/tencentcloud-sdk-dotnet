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

    public class CreateProjectRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目基本信息
        /// </summary>
        [JsonProperty("Project")]
        public ProjectRequest Project{ get; set; }

        /// <summary>
        /// DLC绑定集群信息
        /// </summary>
        [JsonProperty("DLCInfo")]
        public DLCClusterInfo DLCInfo{ get; set; }

        /// <summary>
        /// 绑定资源组的id列表
        /// </summary>
        [JsonProperty("ResourceIds")]
        public string[] ResourceIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Project.", this.Project);
            this.SetParamObj(map, prefix + "DLCInfo.", this.DLCInfo);
            this.SetParamArraySimple(map, prefix + "ResourceIds.", this.ResourceIds);
        }
    }
}

