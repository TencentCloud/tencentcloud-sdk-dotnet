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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OrgMemberAuthAccount : AbstractModel
    {
        
        /// <summary>
        /// 组织子账号Uin。
        /// </summary>
        [JsonProperty("OrgSubAccountUin")]
        public long? OrgSubAccountUin{ get; set; }

        /// <summary>
        /// 策略ID。
        /// </summary>
        [JsonProperty("PolicyId")]
        public long? PolicyId{ get; set; }

        /// <summary>
        /// 策略名。
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// 身份ID。
        /// </summary>
        [JsonProperty("IdentityId")]
        public long? IdentityId{ get; set; }

        /// <summary>
        /// 身份角色名。
        /// </summary>
        [JsonProperty("IdentityRoleName")]
        public string IdentityRoleName{ get; set; }

        /// <summary>
        /// 身份角色别名。
        /// </summary>
        [JsonProperty("IdentityRoleAliasName")]
        public string IdentityRoleAliasName{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 子账号名称
        /// </summary>
        [JsonProperty("OrgSubAccountName")]
        public string OrgSubAccountName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrgSubAccountUin", this.OrgSubAccountUin);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "IdentityId", this.IdentityId);
            this.SetParamSimple(map, prefix + "IdentityRoleName", this.IdentityRoleName);
            this.SetParamSimple(map, prefix + "IdentityRoleAliasName", this.IdentityRoleAliasName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "OrgSubAccountName", this.OrgSubAccountName);
        }
    }
}

