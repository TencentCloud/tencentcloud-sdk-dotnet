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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IntegrateRole : AbstractModel
    {
        
        /// <summary>
        /// 角色id
        /// </summary>
        [JsonProperty("RoleId")]
        public string RoleId{ get; set; }

        /// <summary>
        /// 角色名
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }

        /// <summary>
        /// 角色状态，1-启用，2-禁用
        /// </summary>
        [JsonProperty("RoleStatus")]
        public ulong? RoleStatus{ get; set; }

        /// <summary>
        /// 是否是集团角色，true-是，false-否
        /// </summary>
        [JsonProperty("IsGroupRole")]
        public bool? IsGroupRole{ get; set; }

        /// <summary>
        /// 管辖的子企业列表
        /// </summary>
        [JsonProperty("SubOrgIdList")]
        public string[] SubOrgIdList{ get; set; }

        /// <summary>
        /// 权限树
        /// </summary>
        [JsonProperty("PermissionGroups")]
        public PermissionGroup[] PermissionGroups{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoleId", this.RoleId);
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
            this.SetParamSimple(map, prefix + "RoleStatus", this.RoleStatus);
            this.SetParamSimple(map, prefix + "IsGroupRole", this.IsGroupRole);
            this.SetParamArraySimple(map, prefix + "SubOrgIdList.", this.SubOrgIdList);
            this.SetParamArrayObj(map, prefix + "PermissionGroups.", this.PermissionGroups);
        }
    }
}

