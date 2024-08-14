/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class RoleAssignments : AbstractModel
    {
        
        /// <summary>
        /// 权限配置ID。
        /// </summary>
        [JsonProperty("RoleConfigurationId")]
        public string RoleConfigurationId{ get; set; }

        /// <summary>
        /// 权限配置名称。
        /// </summary>
        [JsonProperty("RoleConfigurationName")]
        public string RoleConfigurationName{ get; set; }

        /// <summary>
        /// 集团账号目标账号的UIN。
        /// </summary>
        [JsonProperty("TargetUin")]
        public long? TargetUin{ get; set; }

        /// <summary>
        /// 同步的集团账号目标账号的类型，ManagerUin管理账号;MemberUin成员账号。
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// CAM 用户同步的身份 ID。取值： 当PrincipalType取值为Group时，该值为CIC 用户组 ID（g-********）。 当PrincipalType取值为User时，该值为CIC 用户 ID（u-********）。
        /// </summary>
        [JsonProperty("PrincipalId")]
        public string PrincipalId{ get; set; }

        /// <summary>
        /// CAM 用户同步的身份类型。取值： User：表示该 CAM 用户同步的身份是CIC用户。 Group：表示该 CAM 用户同步的身份是CIC用户组。
        /// </summary>
        [JsonProperty("PrincipalType")]
        public string PrincipalType{ get; set; }

        /// <summary>
        /// 用户名称或者用户组名称
        /// </summary>
        [JsonProperty("PrincipalName")]
        public string PrincipalName{ get; set; }

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
        /// 集团账号目标账号的名称。
        /// </summary>
        [JsonProperty("TargetName")]
        public string TargetName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoleConfigurationId", this.RoleConfigurationId);
            this.SetParamSimple(map, prefix + "RoleConfigurationName", this.RoleConfigurationName);
            this.SetParamSimple(map, prefix + "TargetUin", this.TargetUin);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "PrincipalId", this.PrincipalId);
            this.SetParamSimple(map, prefix + "PrincipalType", this.PrincipalType);
            this.SetParamSimple(map, prefix + "PrincipalName", this.PrincipalName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "TargetName", this.TargetName);
        }
    }
}

