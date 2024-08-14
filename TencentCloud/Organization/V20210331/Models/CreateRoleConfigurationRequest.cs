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

    public class CreateRoleConfigurationRequest : AbstractModel
    {
        
        /// <summary>
        /// 空间 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 访问配置名称。格式：包含英文字母、数字或短划线（-）。 长度：最大 128 个字符。
        /// </summary>
        [JsonProperty("RoleConfigurationName")]
        public string RoleConfigurationName{ get; set; }

        /// <summary>
        /// 访问配置的描述。 长度：最大 1024 个字符。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 会话持续时间。 CIC用户使用访问配置访问集团账号目标账号时，会话最多保持的时间。 单位：秒。 取值范围：900~43200（15 分钟~12 小时）。 默认值：3600（1 小时）。
        /// </summary>
        [JsonProperty("SessionDuration")]
        public long? SessionDuration{ get; set; }

        /// <summary>
        /// 初始访问页面。 CIC用户使用访问配置访问集团账号目标账号时，初始访问的页面地址。 该页面必须是腾讯云控制台页面。默认为空，表示跳转到腾讯云控制台首页。
        /// </summary>
        [JsonProperty("RelayState")]
        public string RelayState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "RoleConfigurationName", this.RoleConfigurationName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "SessionDuration", this.SessionDuration);
            this.SetParamSimple(map, prefix + "RelayState", this.RelayState);
        }
    }
}

