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

namespace TencentCloud.Dasb.V20191018.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class User : AbstractModel
    {
        
        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [JsonProperty("RealName")]
        public string RealName{ get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 电子邮件
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 生效起始时间
        /// </summary>
        [JsonProperty("ValidateFrom")]
        public string ValidateFrom{ get; set; }

        /// <summary>
        /// 生效结束时间
        /// </summary>
        [JsonProperty("ValidateTo")]
        public string ValidateTo{ get; set; }

        /// <summary>
        /// 所属用户组列表
        /// </summary>
        [JsonProperty("GroupSet")]
        public Group[] GroupSet{ get; set; }

        /// <summary>
        /// 认证方式，0-本地 1-ldap
        /// </summary>
        [JsonProperty("AuthType")]
        public ulong? AuthType{ get; set; }

        /// <summary>
        /// 生效时间段, 0、1组成的字符串，长度168(7*24), 代表该用户的生效时间. 0 - 未生效，1 - 生效
        /// </summary>
        [JsonProperty("ValidateTime")]
        public string ValidateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "RealName", this.RealName);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "ValidateFrom", this.ValidateFrom);
            this.SetParamSimple(map, prefix + "ValidateTo", this.ValidateTo);
            this.SetParamArrayObj(map, prefix + "GroupSet.", this.GroupSet);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "ValidateTime", this.ValidateTime);
        }
    }
}

