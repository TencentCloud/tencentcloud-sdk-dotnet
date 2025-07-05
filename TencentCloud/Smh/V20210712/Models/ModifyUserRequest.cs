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

namespace TencentCloud.Smh.V20210712.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyUserRequest : AbstractModel
    {
        
        /// <summary>
        /// 媒体库 ID。
        /// </summary>
        [JsonProperty("LibraryId")]
        public string LibraryId{ get; set; }

        /// <summary>
        /// 用于唯一查找用户的过滤器。
        /// </summary>
        [JsonProperty("Filter")]
        public UserFilter Filter{ get; set; }

        /// <summary>
        /// 用户角色，当只支持 user。
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// 是否启用。
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// 手机号国家码，不传默认为 null，此时无法使用该登录方式进行登录。
        /// </summary>
        [JsonProperty("CountryCode")]
        public string CountryCode{ get; set; }

        /// <summary>
        /// 手机号码，不传默认为 null，此时无法使用该登录方式进行登录。如果与同一媒体库内已有手机号重复则报错。CountryCode 和 PhoneNumber 必须同时传入或同时不传入。
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// 邮箱，不传默认为 null，此时无法使用该登录方式进行登录。如果与同一媒体库内已有邮箱重复则报错。
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 账号，不传默认为 null，此时无法使用该登录方式进行登录。如果与同一媒体库内已有账号重复则报错。只能使用大小写字母、数字、中划线、下划线、小数点，长度不超过 50 个字符。
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName{ get; set; }

        /// <summary>
        /// 密码的 base64 形式，不传默认为 null，此时无法使用该登录方式进行登录。AccountName 和 AccountPassword 必须同时传入或同时不传入。
        /// </summary>
        [JsonProperty("AccountPassword")]
        public string AccountPassword{ get; set; }

        /// <summary>
        /// 第三方账号 ID，用于关联第三方账号体系，不传默认为 null，此时无法使用该登录方式进行登录。如果与同一媒体库内已有第三方账号重复则报错。只能使用大小写字母、数字、中划线、下划线、小数点，长度不超过 200 个字符。
        /// </summary>
        [JsonProperty("AccountUserId")]
        public string AccountUserId{ get; set; }

        /// <summary>
        /// 备注。不超过 255 个字符。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 昵称。不超过 100 个字符。
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// 用户头像地址。不超过 255 个字符。
        /// </summary>
        [JsonProperty("Avatar")]
        public string Avatar{ get; set; }

        /// <summary>
        /// 自定义信息。不超过 255 个字符。
        /// </summary>
        [JsonProperty("Customize")]
        public string Customize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LibraryId", this.LibraryId);
            this.SetParamObj(map, prefix + "Filter.", this.Filter);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "CountryCode", this.CountryCode);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "AccountName", this.AccountName);
            this.SetParamSimple(map, prefix + "AccountPassword", this.AccountPassword);
            this.SetParamSimple(map, prefix + "AccountUserId", this.AccountUserId);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "Avatar", this.Avatar);
            this.SetParamSimple(map, prefix + "Customize", this.Customize);
        }
    }
}

