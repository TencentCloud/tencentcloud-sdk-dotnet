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

    public class ModifyLoginConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境 ID，用于指定需要修改登录策略的云开发环境。
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 手机号短信登录开关。设置为 true 开启手机号短信登录，允许用户使用手机号和短信验证码进行登录和注册；设置为 false 关闭手机号短信登录。
        /// </summary>
        [JsonProperty("PhoneNumberLogin")]
        public bool? PhoneNumberLogin{ get; set; }

        /// <summary>
        /// 邮箱登录开关。设置为 true 开启邮箱登录，允许用户使用邮箱和密码进行登录和注册；设置为 false 关闭邮箱登录。
        /// </summary>
        [JsonProperty("EmailLogin")]
        public bool? EmailLogin{ get; set; }

        /// <summary>
        /// 用户名密码登录开关。设置为 true 开启用户名密码登录，允许用户使用用户名和密码进行登录和注册；设置为 false 关闭用户名密码登录。
        /// </summary>
        [JsonProperty("UserNameLogin")]
        public bool? UserNameLogin{ get; set; }

        /// <summary>
        /// 匿名登录开关。设置为 true 开启匿名登录，允许用户无需注册即可以匿名身份访问应用；设置为 false 关闭匿名登录。
        /// </summary>
        [JsonProperty("AnonymousLogin")]
        public bool? AnonymousLogin{ get; set; }

        /// <summary>
        /// 短信验证码发送配置，用于设置短信验证码的发送通道类型和日发送限额。不传则不修改当前配置。
        /// </summary>
        [JsonProperty("SmsVerificationConfig")]
        public VerificationConfig SmsVerificationConfig{ get; set; }

        /// <summary>
        /// MFA 多因子认证登录配置，用于设置多因子认证开关及验证方式（短信、邮箱、TOTP、强制绑定手机号）。不传则不修改当前配置。
        /// </summary>
        [JsonProperty("MfaConfig")]
        public MFALoginConfig MfaConfig{ get; set; }

        /// <summary>
        /// 密码更新策略配置，用于设置首次登录强制修改密码和定期强制修改密码策略。不传则不修改当前配置。
        /// </summary>
        [JsonProperty("PwdUpdateStrategy")]
        public PasswordUpdateLoginConfig PwdUpdateStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "PhoneNumberLogin", this.PhoneNumberLogin);
            this.SetParamSimple(map, prefix + "EmailLogin", this.EmailLogin);
            this.SetParamSimple(map, prefix + "UserNameLogin", this.UserNameLogin);
            this.SetParamSimple(map, prefix + "AnonymousLogin", this.AnonymousLogin);
            this.SetParamObj(map, prefix + "SmsVerificationConfig.", this.SmsVerificationConfig);
            this.SetParamObj(map, prefix + "MfaConfig.", this.MfaConfig);
            this.SetParamObj(map, prefix + "PwdUpdateStrategy.", this.PwdUpdateStrategy);
        }
    }
}

