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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateUserRequest : AbstractModel
    {
        
        /// <summary>
        /// 用户名, 3-20个字符, 必须以英文字母开头，且不能包含字母、数字、.、_、-以外的字符
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 用户姓名，最大长度20个字符，不能包含空白字符
        /// </summary>
        [JsonProperty("RealName")]
        public string RealName{ get; set; }

        /// <summary>
        /// 按照"国家地区代码|手机号"的格式输入，如: "+86|xxxxxxxx"。手机号和邮箱参数至少传一项
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// 电子邮件。手机号和邮箱参数至少传一项
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 用户生效时间，如:"2021-09-22T00:00:00+00:00"
        /// 生效、失效时间不填则用户长期有效
        /// </summary>
        [JsonProperty("ValidateFrom")]
        public string ValidateFrom{ get; set; }

        /// <summary>
        /// 用户失效时间，如:"2021-09-23T00:00:00+00:00"
        /// 生效、失效时间不填则用户长期有效
        /// </summary>
        [JsonProperty("ValidateTo")]
        public string ValidateTo{ get; set; }

        /// <summary>
        /// 所属用户组ID集合
        /// </summary>
        [JsonProperty("GroupIdSet")]
        public ulong?[] GroupIdSet{ get; set; }

        /// <summary>
        /// 认证方式，0 - 本地， 1 - LDAP， 2 - OAuth 不传则默认为0
        /// </summary>
        [JsonProperty("AuthType")]
        public ulong? AuthType{ get; set; }

        /// <summary>
        /// 访问时间段限制， 由0、1组成的字符串，长度168(7 × 24)，代表该用户在一周中允许访问的时间段。字符串中第N个字符代表在一周中的第N个小时， 0 - 代表不允许访问，1 - 代表允许访问
        /// </summary>
        [JsonProperty("ValidateTime")]
        public string ValidateTime{ get; set; }

        /// <summary>
        /// 所属部门ID，如：“1.2.3”
        /// </summary>
        [JsonProperty("DepartmentId")]
        public string DepartmentId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "RealName", this.RealName);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "ValidateFrom", this.ValidateFrom);
            this.SetParamSimple(map, prefix + "ValidateTo", this.ValidateTo);
            this.SetParamArraySimple(map, prefix + "GroupIdSet.", this.GroupIdSet);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "ValidateTime", this.ValidateTime);
            this.SetParamSimple(map, prefix + "DepartmentId", this.DepartmentId);
        }
    }
}

