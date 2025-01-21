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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyUserRoleRequest : AbstractModel
    {
        
        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 角色ID 列表
        /// </summary>
        [JsonProperty("RoleIdList")]
        public long?[] RoleIdList{ get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// 手机区号
        /// </summary>
        [JsonProperty("AreaCode")]
        public string AreaCode{ get; set; }

        /// <summary>
        /// 企业微信应用用户id
        /// </summary>
        [JsonProperty("AppUserId")]
        public string AppUserId{ get; set; }

        /// <summary>
        /// 是否开启手机验证码登录（0 关闭，1 开启）
        /// </summary>
        [JsonProperty("LoginSecurityStatus")]
        public long? LoginSecurityStatus{ get; set; }

        /// <summary>
        /// 是否开启密码过期提醒（0 关闭，1 开启
        /// </summary>
        [JsonProperty("ResetPassWordTip")]
        public long? ResetPassWordTip{ get; set; }

        /// <summary>
        /// 强制修改密码（0 关闭，1 开启）
        /// </summary>
        [JsonProperty("ForceResetPassWord")]
        public long? ForceResetPassWord{ get; set; }

        /// <summary>
        /// 密码过期提醒时间，30、60、90（默认）、180天
        /// </summary>
        [JsonProperty("PasswordExpired")]
        public long? PasswordExpired{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamArraySimple(map, prefix + "RoleIdList.", this.RoleIdList);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "AreaCode", this.AreaCode);
            this.SetParamSimple(map, prefix + "AppUserId", this.AppUserId);
            this.SetParamSimple(map, prefix + "LoginSecurityStatus", this.LoginSecurityStatus);
            this.SetParamSimple(map, prefix + "ResetPassWordTip", this.ResetPassWordTip);
            this.SetParamSimple(map, prefix + "ForceResetPassWord", this.ForceResetPassWord);
            this.SetParamSimple(map, prefix + "PasswordExpired", this.PasswordExpired);
        }
    }
}

