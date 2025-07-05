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

    public class UpdateCustomPolicyForRoleConfigurationRequest : AbstractModel
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
        /// 权限策略名称，长度最大为 32 个字符。
        /// </summary>
        [JsonProperty("CustomPolicyName")]
        public string CustomPolicyName{ get; set; }

        /// <summary>
        /// 自定义策略内容。长度：最大 4096 个字符。当RolePolicyType为Inline时，该参数必须配置。关于权限策略的语法和结构，请参见权限策略语法和结构。
        /// </summary>
        [JsonProperty("NewCustomPolicyDocument")]
        public string NewCustomPolicyDocument{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "RoleConfigurationId", this.RoleConfigurationId);
            this.SetParamSimple(map, prefix + "CustomPolicyName", this.CustomPolicyName);
            this.SetParamSimple(map, prefix + "NewCustomPolicyDocument", this.NewCustomPolicyDocument);
        }
    }
}

