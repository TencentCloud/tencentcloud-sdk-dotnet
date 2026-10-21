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

namespace TencentCloud.Fwm.V20250611.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyCfwShareRoleRequest : AbstractModel
    {
        
        /// <summary>
        /// 云防火墙共享角色，取值：sharer（共享者）、user（使用者）、none（无共享角色）。共享者→使用者禁止直接变更，需先设为 none
        /// </summary>
        [JsonProperty("CfwShareRole")]
        public string CfwShareRole{ get; set; }

        /// <summary>
        /// 使用者Id
        /// </summary>
        [JsonProperty("UserMemberId")]
        public string UserMemberId{ get; set; }

        /// <summary>
        /// 共享者账号ID，CfwShareRole 为 user 时必填
        /// </summary>
        [JsonProperty("SharerMemberId")]
        public string SharerMemberId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CfwShareRole", this.CfwShareRole);
            this.SetParamSimple(map, prefix + "UserMemberId", this.UserMemberId);
            this.SetParamSimple(map, prefix + "SharerMemberId", this.SharerMemberId);
        }
    }
}

