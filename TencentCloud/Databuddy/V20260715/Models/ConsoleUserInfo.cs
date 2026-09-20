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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConsoleUserInfo : AbstractModel
    {
        
        /// <summary>
        /// 用户 UIN
        /// </summary>
        [JsonProperty("UserUin")]
        public string UserUin{ get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// 角色列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Roles")]
        public RoleBasicInfo[] Roles{ get; set; }

        /// <summary>
        /// 用户来源，group：用户组、user:用户
        /// </summary>
        [JsonProperty("UserSource")]
        public string UserSource{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 是否主账号
        /// </summary>
        [JsonProperty("IsOwner")]
        public bool? IsOwner{ get; set; }

        /// <summary>
        /// 0: 普通用户 1: entraId用户
        /// </summary>
        [JsonProperty("UserTag")]
        public long? UserTag{ get; set; }

        /// <summary>
        /// 是否具有 admin 权限的子账号
        /// </summary>
        [JsonProperty("IsAdmin")]
        public bool? IsAdmin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserUin", this.UserUin);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamArrayObj(map, prefix + "Roles.", this.Roles);
            this.SetParamSimple(map, prefix + "UserSource", this.UserSource);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "IsOwner", this.IsOwner);
            this.SetParamSimple(map, prefix + "UserTag", this.UserTag);
            this.SetParamSimple(map, prefix + "IsAdmin", this.IsAdmin);
        }
    }
}

