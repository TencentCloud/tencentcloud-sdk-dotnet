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

    public class RoleConfiguration : AbstractModel
    {
        
        /// <summary>
        /// 权限配置配置ID。
        /// </summary>
        [JsonProperty("RoleConfigurationId")]
        public string RoleConfigurationId{ get; set; }

        /// <summary>
        /// 权限配置配名称。
        /// </summary>
        [JsonProperty("RoleConfigurationName")]
        public string RoleConfigurationName{ get; set; }

        /// <summary>
        /// 权限配置的描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 会话持续时间。CIC 用户使用访问配置访问成员账号时，会话最多保持的时间。
        /// 单位：秒。
        /// </summary>
        [JsonProperty("SessionDuration")]
        public long? SessionDuration{ get; set; }

        /// <summary>
        /// 初始访问页面。CIC 用户使用访问配置访问成员账号时，初始访问的页面地址。
        /// </summary>
        [JsonProperty("RelayState")]
        public string RelayState{ get; set; }

        /// <summary>
        /// 权限配置的创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 权限配置的更新时间。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 如果有入参FilterTargets查询成员账号是否配置过权限，配置了返回true，否则返回false。
        /// </summary>
        [JsonProperty("IsSelected")]
        public bool? IsSelected{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoleConfigurationId", this.RoleConfigurationId);
            this.SetParamSimple(map, prefix + "RoleConfigurationName", this.RoleConfigurationName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "SessionDuration", this.SessionDuration);
            this.SetParamSimple(map, prefix + "RelayState", this.RelayState);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "IsSelected", this.IsSelected);
        }
    }
}

