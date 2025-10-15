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

    public class RemoveMemberProjectRoleRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("UserUin")]
        public string UserUin{ get; set; }

        /// <summary>
        /// 角色id列表，目前支持的项目角色有
        /// - 308335260274237440 (项目管理员)
        /// - 308335260676890624 (数据工程师)
        /// - 308335260844662784 (运维工程师)
        /// - 308335260945326080 (普通成员)
        /// </summary>
        [JsonProperty("RoleIds")]
        public string[] RoleIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "UserUin", this.UserUin);
            this.SetParamArraySimple(map, prefix + "RoleIds.", this.RoleIds);
        }
    }
}

