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

    public class DescribeLoginConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// 是否开启邮箱登录方式。true 表示已开启，允许用户使用邮箱和密码进行登录；false 表示已关闭。
        /// </summary>
        [JsonProperty("EmailLogin")]
        public bool? EmailLogin{ get; set; }

        /// <summary>
        /// 是否开启匿名登录方式。true 表示已开启，允许用户无需注册即可以匿名身份登录；false 表示已关闭。
        /// </summary>
        [JsonProperty("AnonymousLogin")]
        public bool? AnonymousLogin{ get; set; }

        /// <summary>
        /// 是否开启用户名密码登录方式。true 表示已开启，允许用户使用用户名和密码进行登录；false 表示已关闭。
        /// </summary>
        [JsonProperty("UserNameLogin")]
        public bool? UserNameLogin{ get; set; }

        /// <summary>
        /// 短信验证码发送配置，包含短信发送通道类型、自定义 APIs 数据源、调用方法及每日发送限额等信息。
        /// </summary>
        [JsonProperty("SmsVerificationConfig")]
        public VerificationConfig SmsVerificationConfig{ get; set; }

        /// <summary>
        /// 是否开启手机号短信登录方式。true 表示已开启，允许用户使用手机号和短信验证码进行登录和注册；false 表示已关闭。
        /// </summary>
        [JsonProperty("PhoneNumberLogin")]
        public bool? PhoneNumberLogin{ get; set; }

        /// <summary>
        /// MFA 多因子认证登录配置，包含 MFA 开关及各验证方式（短信、邮箱、TOTP、强制绑定手机号）的启用状态。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MfaConfig")]
        public MFALoginConfig MfaConfig{ get; set; }

        /// <summary>
        /// 密码修改策略配置，包含首次登录强制修改密码开关及定期修改密码策略（周期和时间单位）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PwdUpdateStrategy")]
        public PasswordUpdateLoginConfig PwdUpdateStrategy{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EmailLogin", this.EmailLogin);
            this.SetParamSimple(map, prefix + "AnonymousLogin", this.AnonymousLogin);
            this.SetParamSimple(map, prefix + "UserNameLogin", this.UserNameLogin);
            this.SetParamObj(map, prefix + "SmsVerificationConfig.", this.SmsVerificationConfig);
            this.SetParamSimple(map, prefix + "PhoneNumberLogin", this.PhoneNumberLogin);
            this.SetParamObj(map, prefix + "MfaConfig.", this.MfaConfig);
            this.SetParamObj(map, prefix + "PwdUpdateStrategy.", this.PwdUpdateStrategy);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

