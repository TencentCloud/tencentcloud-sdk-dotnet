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

    public class UpdateRoleConfigurationRequest : AbstractModel
    {
        
        /// <summary>
        /// 空间 ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 权限配置 ID
        /// </summary>
        [JsonProperty("RoleConfigurationId")]
        public string RoleConfigurationId{ get; set; }

        /// <summary>
        /// 新的权限配置描述。  长度：最大 1024 个字符。
        /// </summary>
        [JsonProperty("NewDescription")]
        public string NewDescription{ get; set; }

        /// <summary>
        /// 新的会话持续时间。  CIC 用户使用权限配置访问集团账号目标账号时，会话最多保持的时间。  单位：秒。  取值范围：900-43200（15 分钟-12 小时）。
        /// </summary>
        [JsonProperty("NewSessionDuration")]
        public long? NewSessionDuration{ get; set; }

        /// <summary>
        /// 新的初始访问页面。  CIC 用户使用权限配置访问集团账号目标账号时，初始访问的页面地址。  该页面必须是腾讯云控制台页面。
        /// </summary>
        [JsonProperty("NewRelayState")]
        public string NewRelayState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "RoleConfigurationId", this.RoleConfigurationId);
            this.SetParamSimple(map, prefix + "NewDescription", this.NewDescription);
            this.SetParamSimple(map, prefix + "NewSessionDuration", this.NewSessionDuration);
            this.SetParamSimple(map, prefix + "NewRelayState", this.NewRelayState);
        }
    }
}

