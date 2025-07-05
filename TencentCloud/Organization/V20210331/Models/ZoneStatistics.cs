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

    public class ZoneStatistics : AbstractModel
    {
        
        /// <summary>
        /// 用户配额。
        /// </summary>
        [JsonProperty("UserQuota")]
        public long? UserQuota{ get; set; }

        /// <summary>
        /// 用户组配额。
        /// </summary>
        [JsonProperty("GroupQuota")]
        public long? GroupQuota{ get; set; }

        /// <summary>
        /// 权限配置配额。
        /// </summary>
        [JsonProperty("RoleConfigurationQuota")]
        public long? RoleConfigurationQuota{ get; set; }

        /// <summary>
        /// 权限配置绑定的系统策略配额。
        /// </summary>
        [JsonProperty("SystemPolicyPerRoleConfigurationQuota")]
        public long? SystemPolicyPerRoleConfigurationQuota{ get; set; }

        /// <summary>
        /// 用户数。
        /// </summary>
        [JsonProperty("UserCount")]
        public long? UserCount{ get; set; }

        /// <summary>
        /// 用户组数。
        /// </summary>
        [JsonProperty("GroupCount")]
        public long? GroupCount{ get; set; }

        /// <summary>
        /// 权限配置数
        /// </summary>
        [JsonProperty("RoleConfigurationCount")]
        public long? RoleConfigurationCount{ get; set; }

        /// <summary>
        /// 同步用户数。
        /// </summary>
        [JsonProperty("UserProvisioningCount")]
        public long? UserProvisioningCount{ get; set; }

        /// <summary>
        /// 同步角色数。
        /// </summary>
        [JsonProperty("RoleConfigurationSyncCount")]
        public long? RoleConfigurationSyncCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserQuota", this.UserQuota);
            this.SetParamSimple(map, prefix + "GroupQuota", this.GroupQuota);
            this.SetParamSimple(map, prefix + "RoleConfigurationQuota", this.RoleConfigurationQuota);
            this.SetParamSimple(map, prefix + "SystemPolicyPerRoleConfigurationQuota", this.SystemPolicyPerRoleConfigurationQuota);
            this.SetParamSimple(map, prefix + "UserCount", this.UserCount);
            this.SetParamSimple(map, prefix + "GroupCount", this.GroupCount);
            this.SetParamSimple(map, prefix + "RoleConfigurationCount", this.RoleConfigurationCount);
            this.SetParamSimple(map, prefix + "UserProvisioningCount", this.UserProvisioningCount);
            this.SetParamSimple(map, prefix + "RoleConfigurationSyncCount", this.RoleConfigurationSyncCount);
        }
    }
}

