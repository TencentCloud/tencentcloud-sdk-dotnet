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

    public class PermissionDetail : AbstractModel
    {
        
        /// <summary>
        /// 当前用户对该实体拥有的权限列表
        /// </summary>
        [JsonProperty("Permissions")]
        public string[] Permissions{ get; set; }

        /// <summary>
        /// catalog在工作空间上的权限信息（可选）。取值：WORKSPACE_READONLY（只读）或WORKSPACE_READWRITE（读写）
        /// </summary>
        [JsonProperty("CatalogWorkspacePrivilege")]
        public string CatalogWorkspacePrivilege{ get; set; }

        /// <summary>
        /// deny权限总列表（用户deny ∪ 角色deny ∪ 继承deny，已去重，已从Permissions中排除）
        /// </summary>
        [JsonProperty("DenyPrivilegeList")]
        public string[] DenyPrivilegeList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Permissions.", this.Permissions);
            this.SetParamSimple(map, prefix + "CatalogWorkspacePrivilege", this.CatalogWorkspacePrivilege);
            this.SetParamArraySimple(map, prefix + "DenyPrivilegeList.", this.DenyPrivilegeList);
        }
    }
}

