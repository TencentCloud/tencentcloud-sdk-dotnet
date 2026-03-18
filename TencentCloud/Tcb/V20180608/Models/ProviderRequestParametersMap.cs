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

    public class ProviderRequestParametersMap : AbstractModel
    {
        
        /// <summary>
        /// OAuth 标准协议中的 client_id。不同第三方平台的字段名称可能不同，例如微信平台对应 appid、新浪微博对应 app_id。
        /// </summary>
        [JsonProperty("ClientId")]
        public string ClientId{ get; set; }

        /// <summary>
        /// OAuth 标准协议中的 client_secret，用于身份认证源的密钥鉴权。请妥善保管，避免泄露。
        /// </summary>
        [JsonProperty("ClientSecret")]
        public string ClientSecret{ get; set; }

        /// <summary>
        /// OAuth 标准协议中的 redirect_uri，即授权回调地址。用户完成第三方认证后将重定向至该地址。
        /// </summary>
        [JsonProperty("RedirectUri")]
        public string RedirectUri{ get; set; }

        /// <summary>
        /// 身份源注册用户时自动绑定的角色 ID。配置后，通过该身份源注册的新用户将自动关联指定角色。
        /// </summary>
        [JsonProperty("RegisterUserRoleId")]
        public string RegisterUserRoleId{ get; set; }

        /// <summary>
        /// 身份源注册用户时是否自动授予许可证。取值范围：
        /// TRUE：自动授权许可证
        /// FALSE：不自动授权（默认值）
        /// </summary>
        [JsonProperty("RegisterUserAutoLicense")]
        public string RegisterUserAutoLicense{ get; set; }

        /// <summary>
        /// OAuth 获取 Token 时认证信息的请求位置。取值范围：
        /// URL：将认证信息放在请求 URL 参数中
        /// Headers：将认证信息放在请求 Header 中
        /// Body：将认证信息放在请求 Body 中
        /// </summary>
        [JsonProperty("AuthPosition")]
        public string AuthPosition{ get; set; }

        /// <summary>
        /// OAuth 授权模式匹配的参数字段名。用于指定获取 Token 请求中 grant_type 参数对应的字段名称。
        /// </summary>
        [JsonProperty("GrantType")]
        public string GrantType{ get; set; }

        /// <summary>
        /// OAuth 授权模式类型。用于指定 grant_type 的值，例如 client_credentials 表示客户端凭证模式。
        /// </summary>
        [JsonProperty("ClientCredentials")]
        public string ClientCredentials{ get; set; }

        /// <summary>
        /// OAuth 返回中 access_token 的映射字段名。若第三方平台返回的 Token 字段名不是标准的 access_token，可通过此字段指定实际字段名。
        /// </summary>
        [JsonProperty("AccessToken")]
        public string AccessToken{ get; set; }

        /// <summary>
        /// OAuth 返回中 Token 有效期的映射字段名。若第三方平台返回的有效期字段名不是标准的 expires_in，可通过此字段指定实际字段名。
        /// </summary>
        [JsonProperty("ExpiresIn")]
        public string ExpiresIn{ get; set; }

        /// <summary>
        /// 身份源注册用户时的用户类型。取值范围：
        /// externalUser：外部用户
        /// internalUser：内部用户
        /// 默认值为 externalUser。
        /// </summary>
        [JsonProperty("RegisterUserType")]
        public string RegisterUserType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientId", this.ClientId);
            this.SetParamSimple(map, prefix + "ClientSecret", this.ClientSecret);
            this.SetParamSimple(map, prefix + "RedirectUri", this.RedirectUri);
            this.SetParamSimple(map, prefix + "RegisterUserRoleId", this.RegisterUserRoleId);
            this.SetParamSimple(map, prefix + "RegisterUserAutoLicense", this.RegisterUserAutoLicense);
            this.SetParamSimple(map, prefix + "AuthPosition", this.AuthPosition);
            this.SetParamSimple(map, prefix + "GrantType", this.GrantType);
            this.SetParamSimple(map, prefix + "ClientCredentials", this.ClientCredentials);
            this.SetParamSimple(map, prefix + "AccessToken", this.AccessToken);
            this.SetParamSimple(map, prefix + "ExpiresIn", this.ExpiresIn);
            this.SetParamSimple(map, prefix + "RegisterUserType", this.RegisterUserType);
        }
    }
}

