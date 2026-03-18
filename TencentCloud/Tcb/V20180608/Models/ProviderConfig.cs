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

    public class ProviderConfig : AbstractModel
    {
        
        /// <summary>
        /// 身份提供方的唯一标识符（Issuer URL），用于验证 ID Token 中的 iss 字段。仅当 ProviderType 为 OIDC 时需要填写，值通常为第三方 OIDC 服务的根地址，例如：https://accounts.google.com。填写后平台将自动通过 /.well-known/openid-configuration 发现并填充 AuthorizationEndpoint、TokenEndpoint、UserinfoEndpoint、JwksUri 等端点地址。详情参考 OpenID Connect Discovery 标准。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Issuer")]
        public string Issuer{ get; set; }

        /// <summary>
        /// 第三方身份提供方的 JSON Web Key Set 地址，用于获取公钥以验证 ID Token 签名。仅当 ProviderType 为 OIDC 时需要填写。若已填写 Issuer，该字段将通过 OpenID Connect Discovery 自动获取，无需手动填写。详情参考 OpenID Connect Discovery 标准。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JwksUri")]
        public string JwksUri{ get; set; }

        /// <summary>
        /// 在第三方身份提供方注册的应用客户端 ID，用于标识当前接入应用。当 ProviderType 为 OIDC 或 OAUTH 时必须填写，可在对应平台的开发者控制台中获取。详情参考 OAuth 2.0 标准。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientId")]
        public string ClientId{ get; set; }

        /// <summary>
        /// 在第三方身份提供方注册的应用客户端密钥，与 ClientId 配合使用，用于在 Token 端点进行身份验证。当 ProviderType 为 OIDC 或 OAUTH 时必须填写，请妥善保管，避免泄露。详情参考 OAuth 2.0 标准。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientSecret")]
        public string ClientSecret{ get; set; }

        /// <summary>
        /// OAuth 授权完成后第三方平台回调的地址，需与在第三方平台注册的回调地址完全一致，否则授权将失败。当 ProviderType 为 OIDC 或 OAUTH 时必须填写，并需在对应平台的开发者控制台中配置该地址为合法回调地址。详情参考 OAuth 2.0 标准。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RedirectUri")]
        public string RedirectUri{ get; set; }

        /// <summary>
        /// 向第三方身份提供方申请的权限范围，多个 scope 之间用空格分隔。当 ProviderType 为 OIDC 或 OAUTH 时必须填写，OIDC 场景下通常至少包含 openid，如需获取用户邮箱或手机号可追加 email、phone 等。若已填写 Issuer 且未指定 Scope，将自动使用 OpenID Connect Discovery 返回的 scopes_supported。详情参考 OAuth 2.0 标准。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Scope")]
        public string Scope{ get; set; }

        /// <summary>
        /// 第三方身份提供方的授权端点地址，用于发起 OAuth/OIDC 授权请求，引导用户跳转至第三方登录页面。当 ProviderType 为 OIDC 或 OAUTH 时必须填写。若已填写 Issuer，该字段将通过 OpenID Connect Discovery 自动获取，无需手动填写。详情参考 OAuth 2.0 / OIDC 标准。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthorizationEndpoint")]
        public string AuthorizationEndpoint{ get; set; }

        /// <summary>
        /// 第三方身份提供方的 Token 端点地址，用于通过授权码（code）换取 Access Token 和 ID Token。当 ProviderType 为 OIDC 或 OAUTH 时必须填写。若已填写 Issuer，该字段将通过 OpenID Connect Discovery 自动获取，无需手动填写。详情参考 OAuth 2.0 / OIDC 标准。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TokenEndpoint")]
        public string TokenEndpoint{ get; set; }

        /// <summary>
        /// 第三方身份提供方的用户信息端点地址，用于通过 Access Token 获取用户的基本信息（如昵称、头像、邮箱等）。当 ProviderType 为 OIDC 或 OAUTH 且需要获取用户详细信息时填写。若已填写 Issuer，该字段将通过 OpenID Connect Discovery 自动获取，无需手动填写。详情参考 OIDC 标准。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserinfoEndpoint")]
        public string UserinfoEndpoint{ get; set; }

        /// <summary>
        /// OAuth/OIDC 授权请求的响应类型，决定授权端点返回的内容。可选值：code（授权码模式，推荐）、token（隐式模式，直接返回 Access Token）、id_token（直接返回 ID Token）。当 ProviderType 为 OIDC 时默认使用 id_token，其他类型默认使用 code。当 ProviderType 为 OIDC 或 OAUTH 时可选填写。详情参考 OAuth 2.0 / OIDC 标准。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseType")]
        public string ResponseType{ get; set; }

        /// <summary>
        /// 第三方身份提供方的单点退出端点地址。配置后，用户退出当前应用时将被跳转至该地址，使第三方 IDP 的登录态也一并失效，实现单点退出（SLO）。适用于 OIDC、OAUTH、SAML 等所有支持单点退出的身份源类型。不填则退出时仅清除本平台登录态。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SignoutEndpoint")]
        public string SignoutEndpoint{ get; set; }

        /// <summary>
        /// Token 端点的客户端身份验证方式，决定请求 Token 时如何传递 ClientId 和 ClientSecret。可选值：CLIENT_SECRET_POST（将凭证放在请求 Body 中传递）、CLIENT_SECRET_BASIC（将凭证通过 HTTP Basic Auth Header 传递）。当 ProviderType 为 OIDC 或 OAUTH 时可选填写，默认使用 CLIENT_SECRET_POST。详情参考 OIDC 标准。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TokenEndpointAuthMethod")]
        public string TokenEndpointAuthMethod{ get; set; }

        /// <summary>
        /// SAML 身份提供方的 Metadata XML 内容，包含 IDP 的实体 ID、SSO 端点地址、签名证书等关键信息，平台将据此完成 SAML 协议的对接配置。仅当 ProviderType 为 SAML 时可填写，通常可从第三方 IDP 的管理控制台中下载获取。详情参考 SAML 2.0 标准。
        /// </summary>
        [JsonProperty("SamlMetadata")]
        public string SamlMetadata{ get; set; }

        /// <summary>
        /// 请求参数映射配置，用于处理非标准 OAuth 协议的参数转换。默认情况下平台严格遵循 OAuth 2.0 标准进行参数传递，若对接的第三方平台（如微信、企业微信等）使用了非标准的参数名称或传参方式，可通过该字段配置自定义的参数映射规则，以确保请求参数与第三方平台的要求一致。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestParametersMap")]
        public ProviderRequestParametersMap RequestParametersMap{ get; set; }

        /// <summary>
        /// 响应参数映射配置，用于处理非标准 OAuth 协议的响应参数转换。默认情况下平台严格遵循 OAuth 2.0 标准解析响应参数，若对接的第三方平台（如微信、企业微信等）返回了非标准的字段名称或数据结构，可通过该字段配置自定义的响应参数映射规则，将第三方返回的字段映射为平台标准字段。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResponseParametersMap")]
        public ProviderResponseParametersMap ResponseParametersMap{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Issuer", this.Issuer);
            this.SetParamSimple(map, prefix + "JwksUri", this.JwksUri);
            this.SetParamSimple(map, prefix + "ClientId", this.ClientId);
            this.SetParamSimple(map, prefix + "ClientSecret", this.ClientSecret);
            this.SetParamSimple(map, prefix + "RedirectUri", this.RedirectUri);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "AuthorizationEndpoint", this.AuthorizationEndpoint);
            this.SetParamSimple(map, prefix + "TokenEndpoint", this.TokenEndpoint);
            this.SetParamSimple(map, prefix + "UserinfoEndpoint", this.UserinfoEndpoint);
            this.SetParamSimple(map, prefix + "ResponseType", this.ResponseType);
            this.SetParamSimple(map, prefix + "SignoutEndpoint", this.SignoutEndpoint);
            this.SetParamSimple(map, prefix + "TokenEndpointAuthMethod", this.TokenEndpointAuthMethod);
            this.SetParamSimple(map, prefix + "SamlMetadata", this.SamlMetadata);
            this.SetParamObj(map, prefix + "RequestParametersMap.", this.RequestParametersMap);
            this.SetParamObj(map, prefix + "ResponseParametersMap.", this.ResponseParametersMap);
        }
    }
}

