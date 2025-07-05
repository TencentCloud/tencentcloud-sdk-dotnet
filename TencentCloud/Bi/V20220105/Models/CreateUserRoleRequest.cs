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

    public class CreateUserRoleRequest : AbstractModel
    {
        
        /// <summary>
        /// 角色ID列表
        /// </summary>
        [JsonProperty("RoleIdList")]
        public long?[] RoleIdList{ get; set; }

        /// <summary>
        /// 用户列表（废弃）
        /// </summary>
        [JsonProperty("UserList")]
        [System.Obsolete]
        public UserIdAndUserName[] UserList{ get; set; }

        /// <summary>
        /// 用户列表（新）
        /// </summary>
        [JsonProperty("UserInfoList")]
        public UserInfo[] UserInfoList{ get; set; }

        /// <summary>
        /// 用户组id列表
        /// </summary>
        [JsonProperty("UserGroups")]
        public ulong?[] UserGroups{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "RoleIdList.", this.RoleIdList);
            this.SetParamArrayObj(map, prefix + "UserList.", this.UserList);
            this.SetParamArrayObj(map, prefix + "UserInfoList.", this.UserInfoList);
            this.SetParamArraySimple(map, prefix + "UserGroups.", this.UserGroups);
        }
    }
}

