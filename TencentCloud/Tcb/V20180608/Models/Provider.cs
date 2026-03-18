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

    public class Provider : AbstractModel
    {
        
        /// <summary>
        /// 身份源的唯一标识符，用于在系统内区分不同的身份源。格式要求：2~32 位，仅支持小写英文字母和数字，不可包含空格或特殊字符。创建后不可修改
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 身份源的安全认证配置，包含与第三方平台对接所需的核心参数，如 ClientId、ClientSecret、授权端点、Token 端点、回调地址、Scope 等。不同 ProviderType 对应不同的配置项。CUSTOM 类型无需手动配置（系统自动填充），OIDC 类型会根据 Issuer 自动补全端点信息，SAML 类型需提供 SamlMetadata（最大 10KB）
        /// </summary>
        [JsonProperty("Config")]
        public ProviderConfig Config{ get; set; }

        /// <summary>
        /// 身份源的显示名称，支持国际化多语言配置。用户在登录页面看到的身份源名称将使用该字段，建议根据实际业务场景填写易于识别的名称。未传入时默认使用 Id 值作为显示名称
        /// </summary>
        [JsonProperty("Name")]
        public LocalizedMessage Name{ get; set; }

        /// <summary>
        /// 身份源图标的访问地址，将展示在登录页的身份源按钮上。建议使用 64×64 像素的 SVG 格式图片以保证清晰度，支持 HTTP/HTTPS 公网可访问的图片链接
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Picture")]
        public string Picture{ get; set; }

        /// <summary>
        /// 身份源对应的官方主页地址。该信息将在用户查看自己的第三方账号绑定列表时展示，帮助用户识别已绑定的身份源来源。例如 GitHub 身份源可填写：https://github.com
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Homepage")]
        public string Homepage{ get; set; }

        /// <summary>
        /// 身份源协议类型，决定该身份源使用何种认证协议与第三方平台对接。可选值：OAUTH（标准 OAuth 2.0 协议）、OIDC（OpenID Connect 协议）、SAML（SAML 2.0 协议）、CUSTOM（自定义登录，使用 RSA 密钥对签名验证）、EMAIL（邮箱登录，需配合 EmailConfig 使用）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProviderType")]
        public string ProviderType{ get; set; }

        /// <summary>
        /// 控制第三方身份源登录时是否自动注册系统用户。可选值：TRUE（始终自动注册，无论第三方返回的用户信息是否包含手机号或邮箱）、FALSE（不自动注册，需用户手动绑定）、UNSPECIFIED（默认行为：仅当第三方身份源返回的用户信息中包含手机号或邮箱时才自动注册，否则登录完成后要求用户绑定手机号方可继续使用）。注意：企业微信类型（WX_WORK_AGENT/WX_WORK_INTERNAL/WX_WORK_THIRD_PARTY/WX_WORK_THIRD_PARTY_ASSOCIATION）和微信小程序类型（WX_MICRO_APP/WX_QRCODE_MICRO_APP/WX_OPEN）在 UNSPECIFIED 时会自动设为 TRUE。当 TransparentMode 为 TRUE 时，该字段将被强制设为 FALSE
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoSignUpWithProviderUser")]
        public string AutoSignUpWithProviderUser{ get; set; }

        /// <summary>
        /// 身份源的启用状态。可选值：TRUE（启用，用户可通过该身份源登录）、FALSE（禁用，已有绑定关系不受影响）。未传入时默认为 TRUE（启用）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("On")]
        public string On{ get; set; }

        /// <summary>
        /// 身份源的详细描述信息，支持国际化多语言配置。可用于向用户说明该身份源的用途或使用场景。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public LocalizedMessage Description{ get; set; }

        /// <summary>
        /// 是否开启信息透传模式。可选值：TRUE（仅登录模式：平台不持久化存储用户数据，仅将第三方身份源返回的用户信息透传给业务方，适用于不希望平台留存用户数据的场景）、FALSE（登录且注册模式：平台正常注册并存储用户信息，默认值）。注意：开启透传模式时，AutoSignUpWithProviderUser 将被强制设为 FALSE；若 ReuseUserId 为 UNSPECIFIED，将被自动设为 TRUE。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TransparentMode")]
        public string TransparentMode{ get; set; }

        /// <summary>
        /// 是否直接复用第三方身份源返回的用户标识（如 OpenID、UnionID 等）作为平台用户 ID。可选值：TRUE（开启，平台用户 ID 将直接使用第三方身份源返回的用户标识，适用于已有用户体系迁移场景）、FALSE（关闭，由平台生成独立用户 ID）。注意：开启后需确保第三方用户标识的全局唯一性，避免 ID 冲突。当 TransparentMode 为 TRUE 且该字段为 UNSPECIFIED 时，将被自动设为 TRUE
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReuseUserId")]
        public string ReuseUserId{ get; set; }

        /// <summary>
        /// 邮箱身份源的专项配置，仅当 ProviderType 为 EMAIL 时有效且必填。包含邮件服务商、发件人地址、SMTP 配置等参数，用于支持通过邮箱验证码方式进行身份认证。支持两种模式：自有 SMTP 服务器（需填写完整的 SMTP 配置）和平台代发（EmailConfig.On 设为 TRUE 时由平台随机分配 SMTP 服务器）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EmailConfig")]
        public EmailProviderConfig EmailConfig{ get; set; }

        /// <summary>
        /// 是否开启邮箱自动关联登录。可选值：TRUE（开启）、FALSE（关闭）、UNSPECIFIED（默认为 FALSE）。开启后，若第三方身份源返回的邮箱与系统中已有用户的邮箱一致，则自动将该第三方账号与已有用户关联绑定并完成登录，无需用户手动绑定
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoSignInWhenEmailMatch")]
        public string AutoSignInWhenEmailMatch{ get; set; }

        /// <summary>
        /// 是否开启手机号自动关联登录。可选值：TRUE（开启）、FALSE（关闭）、UNSPECIFIED（默认行为等同于 TRUE，即默认开启）。开启后，若第三方身份源返回的手机号与系统中已有用户的手机号一致，则自动将该第三方账号与已有用户关联绑定并完成登录，无需用户手动绑定
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoSignInWhenPhoneNumberMatch")]
        public string AutoSignInWhenPhoneNumberMatch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamObj(map, prefix + "Name.", this.Name);
            this.SetParamSimple(map, prefix + "Picture", this.Picture);
            this.SetParamSimple(map, prefix + "Homepage", this.Homepage);
            this.SetParamSimple(map, prefix + "ProviderType", this.ProviderType);
            this.SetParamSimple(map, prefix + "AutoSignUpWithProviderUser", this.AutoSignUpWithProviderUser);
            this.SetParamSimple(map, prefix + "On", this.On);
            this.SetParamObj(map, prefix + "Description.", this.Description);
            this.SetParamSimple(map, prefix + "TransparentMode", this.TransparentMode);
            this.SetParamSimple(map, prefix + "ReuseUserId", this.ReuseUserId);
            this.SetParamObj(map, prefix + "EmailConfig.", this.EmailConfig);
            this.SetParamSimple(map, prefix + "AutoSignInWhenEmailMatch", this.AutoSignInWhenEmailMatch);
            this.SetParamSimple(map, prefix + "AutoSignInWhenPhoneNumberMatch", this.AutoSignInWhenPhoneNumberMatch);
        }
    }
}

