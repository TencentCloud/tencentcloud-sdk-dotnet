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

    public class DeleteRoleAssignmentRequest : AbstractModel
    {
        
        /// <summary>
        /// 空间 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 权限配置ID。
        /// </summary>
        [JsonProperty("RoleConfigurationId")]
        public string RoleConfigurationId{ get; set; }

        /// <summary>
        /// 同步的集团账号目标账号的类型，ManagerUin管理账号;MemberUin成员账号
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// 集团账号目标账号的UIN
        /// </summary>
        [JsonProperty("TargetUin")]
        public long? TargetUin{ get; set; }

        /// <summary>
        /// CAM 用户同步的身份类型。取值： User：表示同步的身份是用户。 Group：表示同步的身份是用户组。
        /// </summary>
        [JsonProperty("PrincipalType")]
        public string PrincipalType{ get; set; }

        /// <summary>
        /// 用户同步 ID。取值： 当PrincipalType取值为Group时，该值为用户组 ID（g-********）， 当PrincipalType取值为User时，该值为用户 ID（u-********）。 	
        /// </summary>
        [JsonProperty("PrincipalId")]
        public string PrincipalId{ get; set; }

        /// <summary>
        /// 当您移除一个集团账号目标账号上使用某权限配置的最后一个授权时，是否同时解除权限配置部署。取值： DeprovisionForLastRoleAssignmentOnAccount：解除权限配置部署。 None（默认值）：不解除权限配置部署。
        /// </summary>
        [JsonProperty("DeprovisionStrategy")]
        public string DeprovisionStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "RoleConfigurationId", this.RoleConfigurationId);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "TargetUin", this.TargetUin);
            this.SetParamSimple(map, prefix + "PrincipalType", this.PrincipalType);
            this.SetParamSimple(map, prefix + "PrincipalId", this.PrincipalId);
            this.SetParamSimple(map, prefix + "DeprovisionStrategy", this.DeprovisionStrategy);
        }
    }
}

