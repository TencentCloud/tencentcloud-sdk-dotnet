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

    public class CreateUserRequest : AbstractModel
    {
        
        /// <summary>
        /// 用户名，长度限制：64个字符。
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 用户密码， 需要符合密码策略的配置。
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 昵称，长度限制：64个字符。 默认与用户名相同。
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// 用户备注，长度限制：512个字符。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 用户所属用户组ID列表。
        /// </summary>
        [JsonProperty("UserGroupIds")]
        public string[] UserGroupIds{ get; set; }

        /// <summary>
        /// 用户手机号。例如：+86-1xxxxxxxxxx。
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// 用户所属的主组织机构唯一ID。如果为空，默认为在根节点下创建用户。
        /// </summary>
        [JsonProperty("OrgNodeId")]
        public string OrgNodeId{ get; set; }

        /// <summary>
        /// 用户过期时间，遵循 ISO 8601 标准。
        /// </summary>
        [JsonProperty("ExpirationTime")]
        public string ExpirationTime{ get; set; }

        /// <summary>
        /// 用户邮箱。
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 密码是否需要重置，为空默认为false不需要重置密码。
        /// </summary>
        [JsonProperty("PwdNeedReset")]
        public bool? PwdNeedReset{ get; set; }

        /// <summary>
        /// 用户所属的次要组织机构ID列表。
        /// </summary>
        [JsonProperty("SecondaryOrgNodeIdList")]
        public string[] SecondaryOrgNodeIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "UserGroupIds.", this.UserGroupIds);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "OrgNodeId", this.OrgNodeId);
            this.SetParamSimple(map, prefix + "ExpirationTime", this.ExpirationTime);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "PwdNeedReset", this.PwdNeedReset);
            this.SetParamArraySimple(map, prefix + "SecondaryOrgNodeIdList.", this.SecondaryOrgNodeIdList);
        }
    }
}

