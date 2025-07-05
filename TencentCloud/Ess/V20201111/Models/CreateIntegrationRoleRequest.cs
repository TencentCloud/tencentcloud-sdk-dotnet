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

    public class CreateIntegrationRoleRequest : AbstractModel
    {
        
        /// <summary>
        /// 角色名称，最大长度为20个字符，仅限中文、字母、数字和下划线组成。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 执行本接口操作的员工信息。使用此接口时，必须填写userId。
        /// 支持填入集团子公司经办人 userId 代发合同。
        /// 
        /// 注: 在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 角色描述，最大长度为50个字符
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 角色类型，0:saas角色，1:集团角色
        /// 默认0，saas角色
        /// </summary>
        [JsonProperty("IsGroupRole")]
        public long? IsGroupRole{ get; set; }

        /// <summary>
        /// 权限树
        /// </summary>
        [JsonProperty("PermissionGroups")]
        public PermissionGroup[] PermissionGroups{ get; set; }

        /// <summary>
        /// 集团角色的话，需要传递集团子企业列表，如果是全选，则传1
        /// </summary>
        [JsonProperty("SubOrganizationIds")]
        public string SubOrganizationIds{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。
        /// 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "IsGroupRole", this.IsGroupRole);
            this.SetParamArrayObj(map, prefix + "PermissionGroups.", this.PermissionGroups);
            this.SetParamSimple(map, prefix + "SubOrganizationIds", this.SubOrganizationIds);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
        }
    }
}

