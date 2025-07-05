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

namespace TencentCloud.Eiam.V20210420.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateOrgNodeRequest : AbstractModel
    {
        
        /// <summary>
        /// 机构节点名称，长度限制：64个字符。
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// 父机构节点ID，如果为空则默认创建在机构根节点下。
        /// </summary>
        [JsonProperty("ParentOrgNodeId")]
        public string ParentOrgNodeId{ get; set; }

        /// <summary>
        /// 机构节点描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 机构代码。如果为空，则默认生成机构代码。如果为非空，则校验机构代码的唯一性。
        /// </summary>
        [JsonProperty("CustomizedOrgNodeId")]
        public string CustomizedOrgNodeId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "ParentOrgNodeId", this.ParentOrgNodeId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CustomizedOrgNodeId", this.CustomizedOrgNodeId);
        }
    }
}

