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

    public class AuthorizePrivilegesRequest : AbstractModel
    {
        
        /// <summary>
        /// 资源数组
        /// ResourceType：来源于TCCATALOG模块的GetGrantPrivilegesSTD接口中返回的ResourceType，并改为首字母大写，例如METALAKE对应Metalake
        /// ResourceUri，取决于 ResourceType，Metalake时固定为default，其他类别采用catalog的三段式结构，例如
        /// - Metalake，固定为default
        /// - Catalog，取catalogName
        /// - Schema，取catalogName.SchemaName
        /// - Table,，取catalogName.SchemaName.TableName
        /// </summary>
        [JsonProperty("Resources")]
        public PrivilegeResource[] Resources{ get; set; }

        /// <summary>
        /// 授权主体数组，SubjectType及对应SubjectValue取值规则
        /// - User 用户
        ///     - 取自DescribeTenantUserList中的UserId
        /// - Project 项目
        ///     - 取自DescribeUserProjects中的ProjectId
        /// - Role 角色（项目级角色）
        ///     - 先调用DescribeUserProjects获取项目ID（ProjectId），再调用DescribeRoleList中的角色ID（RoleId），拼装为$ProjectId.$ProjectId. RoleId，例如"3085649716411588608.308335260274237440"
        /// - GlobalRole （平台级角色）
        ///     - AllAccountUsers 全部用户
        ///     - 其他ID，取自DescribeTenantRole中的RoleId
        /// </summary>
        [JsonProperty("Subjects")]
        public Subject[] Subjects{ get; set; }

        /// <summary>
        /// 权限点，来源于TCCATALOG模块的GetGrantPrivilegesSTD接口中返回的各类Privileges中的NAME
        /// </summary>
        [JsonProperty("Privileges")]
        public PrivilegeInfo[] Privileges{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Resources.", this.Resources);
            this.SetParamArrayObj(map, prefix + "Subjects.", this.Subjects);
            this.SetParamArrayObj(map, prefix + "Privileges.", this.Privileges);
        }
    }
}

