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
        /// <p>自定义角色体系的ID</p><p>角色体系ID</p>
        /// </summary>
        [JsonProperty("RoleSystemId")]
        public long? RoleSystemId{ get; set; }

        /// <summary>
        /// <p>要添加的自定义用户ID，建议与腾讯云-子用户的用户名称保持一致</p><p>人员ID</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// <p>自定义用户的名称</p><p>人员名称</p>
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// <p>是否启用当前用户</p>枚举值：<ul><li> 1： 启用</li><li> 2： 禁用</li></ul><p>是否启用</p>
        /// </summary>
        [JsonProperty("Enabled")]
        public ulong? Enabled{ get; set; }

        /// <summary>
        /// <p>自定义用户的手机号</p><p>手机号</p>
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// <p>自定义用户的身份属性列表</p><p>属性列表</p>
        /// </summary>
        [JsonProperty("Attributes")]
        public UserAttribute[] Attributes{ get; set; }

        /// <summary>
        /// <p>自定义用户与腾讯云-子用户关联，如果不传默认按照子用户名称进行匹配</p>
        /// </summary>
        [JsonProperty("TencentUin")]
        public ulong? TencentUin{ get; set; }


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
            this.SetParamSimple(map, prefix + "TencentUin", this.TencentUin);
        }
    }
}

