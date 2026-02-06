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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyUserRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境id
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 用户Id, 不做修改
        /// </summary>
        [JsonProperty("Uid")]
        public string Uid{ get; set; }

        /// <summary>
        /// 用户名，用户名规则：1. 长度1-64字符 2. 只能包含大小写英文字母、数字和符号 . _ - 3. 只能以字母或数字开头 4. 不能重复，不传该字段或传空字符不修改
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 用户类型：0-内部用户、1-外部用户，默认0（内部用户），不传该字段或传空字符串不修改
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 密码，传入Uid时密码可不传。密码规则：1. 长度8-32字符（推荐12位以上） 2. 不能以特殊字符开头 3. 至少包含以下四项中的三项：小写字母a-z、大写字母A-Z、数字0-9、特殊字符()!@#$%^&*\|?><_-，不传该字段或传空字符串不修改
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 用户状态：ACTIVE（激活）、BLOCKED（冻结），默认冻结，不传该字段或传空字符串不修改
        /// </summary>
        [JsonProperty("UserStatus")]
        public string UserStatus{ get; set; }

        /// <summary>
        /// 用户昵称，长度2-64字符，不传该字段不修改，传空字符修改为空
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// 手机号，11位数字，不传该字段不修改，传空字符串修改为空
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// 邮箱地址，不传该字段不修改，传空字符修改为空
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 头像链接，可访问的公网URL，不传该字段不修改，传空字符串修改为空
        /// </summary>
        [JsonProperty("AvatarUrl")]
        public string AvatarUrl{ get; set; }

        /// <summary>
        /// 用户描述，最多200字符，不传该字段不修改，传空字符修改为空
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "UserStatus", this.UserStatus);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "AvatarUrl", this.AvatarUrl);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

