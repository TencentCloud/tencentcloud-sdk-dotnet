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

    public class ModifyProviderRequest : AbstractModel
    {
        
        /// <summary>
        /// 云开发环境 ID，用于唯一标识当前操作所属的云开发环境。
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 身份源的唯一标识符，用于指定需要修改的目标身份源。格式要求：2~32 位，仅支持小写英文字母和数字，不可包含空格或特殊字符。例如：github、google。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 身份源的显示名称，支持国际化多语言配置。用户在登录页面看到的身份源名称将使用该字段，建议根据实际业务场景填写易于识别的名称，例如：GitHub、Google 等。
        /// </summary>
        [JsonProperty("Name")]
        public LocalizedMessage Name{ get; set; }

        /// <summary>
        /// 身份源图标的访问地址，将展示在登录页的身份源按钮上。建议使用 64×64 像素的 SVG 格式图片以保证清晰度，支持 HTTP/HTTPS 公网可访问的图片链接。
        /// </summary>
        [JsonProperty("Picture")]
        public string Picture{ get; set; }

        /// <summary>
        /// 身份源对应的官方主页地址。该信息将在用户查看自己的第三方账号绑定列表时展示，帮助用户识别已绑定的身份源来源。例如 GitHub 身份源可填写：https://github.com。
        /// </summary>
        [JsonProperty("Homepage")]
        public string Homepage{ get; set; }

        /// <summary>
        /// 身份源协议类型，决定该身份源使用何种认证协议与第三方平台对接。可选值：
        /// OAUTH：标准 OAuth 2.0 协议
        /// OIDC：OpenID Connect 协议
        /// SAML：SAML 2.0 协议
        /// WX_MICRO_APP：微信小程序登录
        /// WX_QRCODE_MICRO_APP：微信小程序扫码登录
        /// WX_CLOUDBASE_MICRO_APP：云开发托管小程序登录
        /// WX_MP：微信公众号网页授权登录
        /// WX_OPEN：微信开放平台扫码登录
        /// WX_WORK_INTERNAL：企业微信自建应用登录
        /// WX_WORK_AGENT：企业微信代开发应用登录
        /// WX_WORK_THIRD_PARTY：企业微信第三方应用登录
        /// WX_WORK_THIRD_PARTY_ASSOCIATION：企业微信第三方应用关联登录
        /// CUSTOM：自定义登录
        /// EMAIL：邮箱登录
        /// </summary>
        [JsonProperty("ProviderType")]
        public string ProviderType{ get; set; }

        /// <summary>
        /// 身份认证源协议连接配置，包含与第三方平台对接所需的核心参数，如 ClientId、ClientSecret、授权端点、Token 端点、回调地址、Scope、SAML Metadata、请求和响应参数映射等。不同 ProviderType 对应不同的配置项要求。注意：CUSTOM 和 EMAIL 类型的身份源，其存储后端类型（StorageDb）不可修改。
        /// </summary>
        [JsonProperty("Config")]
        public ProviderConfig Config{ get; set; }

        /// <summary>
        /// 是否开启透传登录模式。可选值：TRUE（开启）、FALSE（关闭，默认值）。开启后，平台不会持久化存储用户数据，仅将第三方身份源返回的用户信息透传给业务方，适用于不希望平台留存用户数据的场景。注意：开启透传模式时，ReuseUserId 将被强制设为 TRUE，AutoSignUpWithProviderUser 将被强制设为 FALSE。
        /// </summary>
        [JsonProperty("TransparentMode")]
        public string TransparentMode{ get; set; }

        /// <summary>
        /// 身份源的启用状态。可选值：TRUE（启用，用户可通过该身份源登录）、FALSE（禁用，登录入口将被隐藏，已有绑定关系不受影响）、UNSPECIFIED（默认为 TRUE）。
        /// </summary>
        [JsonProperty("On")]
        public string On{ get; set; }

        /// <summary>
        /// 身份源的详细描述信息，支持国际化多语言配置。可用于向用户说明该身份源的用途或使用场景，例如：谷歌授权登录。
        /// </summary>
        [JsonProperty("Description")]
        public LocalizedMessage Description{ get; set; }

        /// <summary>
        /// 是否直接复用第三方身份源的用户 ID 作为平台用户 ID。可选值：TRUE（开启，返回的用户 ID 将直接使用第三方身份源的用户 ID，适用于已有用户体系迁移场景）、FALSE（关闭，由平台生成独立用户 ID）、UNSPECIFIED（默认为 FALSE，但当 TransparentMode 为 TRUE 时将被强制设为 TRUE）。注意：开启后需确保第三方用户 ID 的全局唯一性，避免 ID 冲突。
        /// </summary>
        [JsonProperty("ReuseUserId")]
        public string ReuseUserId{ get; set; }

        /// <summary>
        /// 邮箱身份源的专项配置，包含邮件服务商、发件人地址、SMTP 配置等参数，用于支持通过邮箱验证码或邮箱密码方式进行身份认证。仅当身份源 ID 为 email 时有效。若该身份源不存在，系统将自动创建一个默认关闭的邮箱身份源。
        /// </summary>
        [JsonProperty("EmailConfig")]
        public EmailProviderConfig EmailConfig{ get; set; }

        /// <summary>
        /// 是否开启邮箱自动关联登录。可选值：TRUE（开启）、FALSE（关闭）、UNSPECIFIED（默认为 FALSE）。开启后，若第三方身份源返回的邮箱与系统中已有用户的邮箱一致，则自动将该第三方账号与已有用户关联并完成登录，无需用户手动绑定。
        /// </summary>
        [JsonProperty("AutoSignInWhenEmailMatch")]
        public string AutoSignInWhenEmailMatch{ get; set; }

        /// <summary>
        /// 是否开启手机号自动关联登录。可选值：TRUE（开启）、FALSE（关闭）、UNSPECIFIED（默认行为等同 TRUE）。开启后，若第三方身份源返回的手机号与系统中已有用户的手机号一致，则自动将该第三方账号与已有用户关联并完成登录，无需用户手动绑定。注意：该字段默认行为（UNSPECIFIED）与 AutoSignInWhenEmailMatch 不同，手机号匹配在未显式关闭时默认生效。
        /// </summary>
        [JsonProperty("AutoSignInWhenPhoneNumberMatch")]
        public string AutoSignInWhenPhoneNumberMatch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamObj(map, prefix + "Name.", this.Name);
            this.SetParamSimple(map, prefix + "Picture", this.Picture);
            this.SetParamSimple(map, prefix + "Homepage", this.Homepage);
            this.SetParamSimple(map, prefix + "ProviderType", this.ProviderType);
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamSimple(map, prefix + "TransparentMode", this.TransparentMode);
            this.SetParamSimple(map, prefix + "On", this.On);
            this.SetParamObj(map, prefix + "Description.", this.Description);
            this.SetParamSimple(map, prefix + "ReuseUserId", this.ReuseUserId);
            this.SetParamObj(map, prefix + "EmailConfig.", this.EmailConfig);
            this.SetParamSimple(map, prefix + "AutoSignInWhenEmailMatch", this.AutoSignInWhenEmailMatch);
            this.SetParamSimple(map, prefix + "AutoSignInWhenPhoneNumberMatch", this.AutoSignInWhenPhoneNumberMatch);
        }
    }
}

