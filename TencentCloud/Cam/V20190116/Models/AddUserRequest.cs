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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddUserRequest : AbstractModel
    {
        
        /// <summary>
        /// 子用户用户名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 子用户备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 子用户是否可以登录控制台。传0子用户无法登录控制台，传1子用户可以登录控制台。
        /// </summary>
        [JsonProperty("ConsoleLogin")]
        public ulong? ConsoleLogin{ get; set; }

        /// <summary>
        /// 是否生成子用户密钥。传0不生成子用户密钥，传1生成子用户密钥。
        /// </summary>
        [JsonProperty("UseApi")]
        public ulong? UseApi{ get; set; }

        /// <summary>
        /// 子用户控制台登录密码，若未进行密码规则设置则默认密码规则为8位以上同时包含大写小字母、数字和特殊字符。只有可以登录控制台时才有效，如果传空并且上面指定允许登录控制台，则自动生成随机密码，随机密码规则为32位包含大写小字母、数字和特殊字符。
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 子用户是否要在下次登录时重置密码。传0子用户下次登录控制台不需重置密码，传1子用户下次登录控制台需要重置密码。
        /// </summary>
        [JsonProperty("NeedResetPassword")]
        public ulong? NeedResetPassword{ get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("PhoneNum")]
        public string PhoneNum{ get; set; }

        /// <summary>
        /// 区号
        /// </summary>
        [JsonProperty("CountryCode")]
        public string CountryCode{ get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ConsoleLogin", this.ConsoleLogin);
            this.SetParamSimple(map, prefix + "UseApi", this.UseApi);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "NeedResetPassword", this.NeedResetPassword);
            this.SetParamSimple(map, prefix + "PhoneNum", this.PhoneNum);
            this.SetParamSimple(map, prefix + "CountryCode", this.CountryCode);
            this.SetParamSimple(map, prefix + "Email", this.Email);
        }
    }
}

