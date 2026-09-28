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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateWorkspaceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>工作空间ID</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>工作空间名称，max_len=128</p>
        /// </summary>
        [JsonProperty("WorkspaceName")]
        public string WorkspaceName{ get; set; }

        /// <summary>
        /// <p>工作空间描述，max_len=300</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "WorkspaceName", this.WorkspaceName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

