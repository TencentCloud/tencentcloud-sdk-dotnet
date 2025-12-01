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

namespace TencentCloud.Evt.V20250217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRoleUserRequest : AbstractModel
    {
        
        /// <summary>
        /// 角色体系ID
        /// </summary>
        [JsonProperty("RoleSystemId")]
        public long? RoleSystemId{ get; set; }

        /// <summary>
        /// 人员ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 人员名称
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        [JsonProperty("Enabled")]
        public ulong? Enabled{ get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// 属性列表
        /// </summary>
        [JsonProperty("Attributes")]
        public UserAttribute[] Attributes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoleSystemId", this.RoleSystemId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamArrayObj(map, prefix + "Attributes.", this.Attributes);
        }
    }
}

