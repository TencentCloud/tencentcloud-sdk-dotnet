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

    public class AddPermissionPolicyToRoleConfigurationRequest : AbstractModel
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
        /// 权限策略类型。取值：  System：系统策略。复用 CAM 的系统策略。 Custom: 自定义策略。按照 CAM 权限策略语法和结构编写的自定义策略。 前期只支持系统策略，自定义策略后期在支持
        /// </summary>
        [JsonProperty("RolePolicyType")]
        public string RolePolicyType{ get; set; }

        /// <summary>
        /// 权限策略名称，长度最大为 20策略，每个策略长度最大32个字符。
        /// </summary>
        [JsonProperty("RolePolicyNames")]
        public string[] RolePolicyNames{ get; set; }

        /// <summary>
        /// 策略详情。
        /// </summary>
        [JsonProperty("RolePolicies")]
        public PolicyDetail[] RolePolicies{ get; set; }

        /// <summary>
        /// 自定义策略内容。长度：最大 4096 个字符。当RolePolicyType为Inline时，该参数必须配置。关于权限策略的语法和结构，请参见权限策略语法和结构。
        /// </summary>
        [JsonProperty("CustomPolicyDocument")]
        public string CustomPolicyDocument{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "RoleConfigurationId", this.RoleConfigurationId);
            this.SetParamSimple(map, prefix + "RolePolicyType", this.RolePolicyType);
            this.SetParamArraySimple(map, prefix + "RolePolicyNames.", this.RolePolicyNames);
            this.SetParamArrayObj(map, prefix + "RolePolicies.", this.RolePolicies);
            this.SetParamSimple(map, prefix + "CustomPolicyDocument", this.CustomPolicyDocument);
        }
    }
}

