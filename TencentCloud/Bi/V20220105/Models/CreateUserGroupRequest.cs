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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateUserGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>组管理员</p>
        /// </summary>
        [JsonProperty("AdminUserId")]
        public string AdminUserId{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>用户组名称</p>
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// <p>位置</p>
        /// </summary>
        [JsonProperty("Location")]
        public long? Location{ get; set; }

        /// <summary>
        /// <p>父用户组id</p>
        /// </summary>
        [JsonProperty("ParentId")]
        public long? ParentId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AdminUserId", this.AdminUserId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "ParentId", this.ParentId);
        }
    }
}

