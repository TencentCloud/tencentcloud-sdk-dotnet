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

    public class RoleConfigurationProvisionings : AbstractModel
    {
        
        /// <summary>
        /// Deployed: 部署成功 DeployedRequired：需要重新部署 DeployFailed：部署失败
        /// </summary>
        [JsonProperty("DeploymentStatus")]
        public string DeploymentStatus{ get; set; }

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
        /// 集团账号目标账号的UIN
        /// </summary>
        [JsonProperty("TargetUin")]
        public long? TargetUin{ get; set; }

        /// <summary>
        /// 集团账号目标账号的名称。
        /// </summary>
        [JsonProperty("TargetName")]
        public string TargetName{ get; set; }

        /// <summary>
        /// 创建时间，
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 修改时间，
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 同步的集团账号目标账号的类型，ManagerUin管理账号;MemberUin成员账号
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeploymentStatus", this.DeploymentStatus);
            this.SetParamSimple(map, prefix + "RoleConfigurationId", this.RoleConfigurationId);
            this.SetParamSimple(map, prefix + "RoleConfigurationName", this.RoleConfigurationName);
            this.SetParamSimple(map, prefix + "TargetUin", this.TargetUin);
            this.SetParamSimple(map, prefix + "TargetName", this.TargetName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
        }
    }
}

