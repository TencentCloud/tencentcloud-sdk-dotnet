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

    public class SecuritySetting : AbstractModel
    {
        
        /// <summary>
        /// 认证方式设置
        /// </summary>
        [JsonProperty("AuthMode")]
        public AuthModeSetting AuthMode{ get; set; }

        /// <summary>
        /// 密码安全设置
        /// </summary>
        [JsonProperty("Password")]
        public PasswordSetting Password{ get; set; }

        /// <summary>
        /// 登录安全设置
        /// </summary>
        [JsonProperty("Login")]
        public LoginSetting Login{ get; set; }

        /// <summary>
        /// LDAP配置信息
        /// </summary>
        [JsonProperty("LDAP")]
        public LDAPSetting LDAP{ get; set; }

        /// <summary>
        /// OAuth配置信息
        /// </summary>
        [JsonProperty("OAuth")]
        public OAuthSetting OAuth{ get; set; }

        /// <summary>
        /// 国密认证方式设置
        /// </summary>
        [JsonProperty("AuthModeGM")]
        public AuthModeSetting AuthModeGM{ get; set; }

        /// <summary>
        /// 资产重连次数
        /// </summary>
        [JsonProperty("Reconnection")]
        public ReconnectionSetting Reconnection{ get; set; }

        /// <summary>
        /// 大区环境网络设置
        /// </summary>
        [JsonProperty("EnvInternetAccess")]
        public EnvInternetAccessSetting EnvInternetAccess{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "AuthMode.", this.AuthMode);
            this.SetParamObj(map, prefix + "Password.", this.Password);
            this.SetParamObj(map, prefix + "Login.", this.Login);
            this.SetParamObj(map, prefix + "LDAP.", this.LDAP);
            this.SetParamObj(map, prefix + "OAuth.", this.OAuth);
            this.SetParamObj(map, prefix + "AuthModeGM.", this.AuthModeGM);
            this.SetParamObj(map, prefix + "Reconnection.", this.Reconnection);
            this.SetParamObj(map, prefix + "EnvInternetAccess.", this.EnvInternetAccess);
        }
    }
}

