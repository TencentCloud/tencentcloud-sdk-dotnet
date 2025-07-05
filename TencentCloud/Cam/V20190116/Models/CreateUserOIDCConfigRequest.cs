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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateUserOIDCConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 身份提供商URL。OpenID Connect身份提供商标识。
        /// 对应企业IdP提供的Openid-configuration中"issuer"字段的值。
        /// </summary>
        [JsonProperty("IdentityUrl")]
        public string IdentityUrl{ get; set; }

        /// <summary>
        /// 客户端ID，在OpenID Connect身份提供商注册的客户端ID。
        /// </summary>
        [JsonProperty("ClientId")]
        public string ClientId{ get; set; }

        /// <summary>
        /// 授权请求Endpoint，OpenID Connect身份提供商授权地址。对应企业IdP提供的Openid-configuration中"authorization_endpoint"字段的值。
        /// </summary>
        [JsonProperty("AuthorizationEndpoint")]
        public string AuthorizationEndpoint{ get; set; }

        /// <summary>
        /// 授权请求Response type，固定值id_token
        /// </summary>
        [JsonProperty("ResponseType")]
        public string ResponseType{ get; set; }

        /// <summary>
        /// 授权请求Response mode。授权请求返回模式，form_post和fragment两种可选模式，推荐选择form_post模式。
        /// </summary>
        [JsonProperty("ResponseMode")]
        public string ResponseMode{ get; set; }

        /// <summary>
        /// 映射字段名称。IdP的id_token中哪一个字段映射到子用户的用户名，通常是sub或者name字段
        /// </summary>
        [JsonProperty("MappingFiled")]
        public string MappingFiled{ get; set; }

        /// <summary>
        /// 签名公钥，需要base64_encode。验证OpenID Connect身份提供商ID Token签名的公钥。为了您的账号安全，建议您定期轮换签名公钥。
        /// </summary>
        [JsonProperty("IdentityKey")]
        public string IdentityKey{ get; set; }

        /// <summary>
        /// 授权请求Scope。openid; email;profile。授权请求信息范围。默认必选openid。
        /// </summary>
        [JsonProperty("Scope")]
        public string[] Scope{ get; set; }

        /// <summary>
        /// 描述信息。由用户自行定义。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdentityUrl", this.IdentityUrl);
            this.SetParamSimple(map, prefix + "ClientId", this.ClientId);
            this.SetParamSimple(map, prefix + "AuthorizationEndpoint", this.AuthorizationEndpoint);
            this.SetParamSimple(map, prefix + "ResponseType", this.ResponseType);
            this.SetParamSimple(map, prefix + "ResponseMode", this.ResponseMode);
            this.SetParamSimple(map, prefix + "MappingFiled", this.MappingFiled);
            this.SetParamSimple(map, prefix + "IdentityKey", this.IdentityKey);
            this.SetParamArraySimple(map, prefix + "Scope.", this.Scope);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

