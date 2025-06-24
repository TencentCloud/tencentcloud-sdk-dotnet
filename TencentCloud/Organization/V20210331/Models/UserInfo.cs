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

    public class UserInfo : AbstractModel
    {
        
        /// <summary>
        /// 查询username。
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 用户的名。
        /// </summary>
        [JsonProperty("FirstName")]
        public string FirstName{ get; set; }

        /// <summary>
        /// 用户的姓。
        /// </summary>
        [JsonProperty("LastName")]
        public string LastName{ get; set; }

        /// <summary>
        /// 用户的显示名称。
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// 用户的描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 用户的电子邮箱。目录内必须唯一。
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 用户状态 Enabled：启用， Disabled：禁用。
        /// </summary>
        [JsonProperty("UserStatus")]
        public string UserStatus{ get; set; }

        /// <summary>
        /// 用户类型  Manual：手动创建，Synchronized：外部导入。
        /// </summary>
        [JsonProperty("UserType")]
        public string UserType{ get; set; }

        /// <summary>
        /// 用户 ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 用户的创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 用户的修改时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 是否选中
        /// </summary>
        [JsonProperty("IsSelected")]
        public bool? IsSelected{ get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "FirstName", this.FirstName);
            this.SetParamSimple(map, prefix + "LastName", this.LastName);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "UserStatus", this.UserStatus);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "IsSelected", this.IsSelected);
            this.SetParamSimple(map, prefix + "Password", this.Password);
        }
    }
}

