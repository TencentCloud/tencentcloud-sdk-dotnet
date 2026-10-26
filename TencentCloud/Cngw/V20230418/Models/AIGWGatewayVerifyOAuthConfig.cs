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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIGWGatewayVerifyOAuthConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>令牌校验方式</p><p>枚举值：</p><ul><li>JWTJWKS： JWTJWKS</li><li>Introspection： Introspection</li></ul><p>切换方式后另一方式专属字段不生效</p>
        /// </summary>
        [JsonProperty("VerifyMethod")]
        public string VerifyMethod{ get; set; }

        /// <summary>
        /// <p>令牌签发者，校验 iss；VerifyMethod=JWTJWKS 时必填</p>
        /// </summary>
        [JsonProperty("Issuer")]
        public string Issuer{ get; set; }

        /// <summary>
        /// <p>JWKS 地址</p><p>入参限制：VerifyMethod=JWTJWKS 时必填</p>
        /// </summary>
        [JsonProperty("JwksUri")]
        public string JwksUri{ get; set; }

        /// <summary>
        /// <p>校验 aud</p>
        /// </summary>
        [JsonProperty("Audience")]
        public string Audience{ get; set; }

        /// <summary>
        /// <p>JWKS 缓存秒数，默认 3600，必须大于 0</p><p>默认值：3600</p>
        /// </summary>
        [JsonProperty("JwksCacheTtl")]
        public ulong? JwksCacheTtl{ get; set; }

        /// <summary>
        /// <p>令牌内省端点</p><p>入参限制：VerifyMethod=Introspection 时必填</p>
        /// </summary>
        [JsonProperty("IntrospectionEndpoint")]
        public string IntrospectionEndpoint{ get; set; }

        /// <summary>
        /// <p>调用内省端点的 Client ID</p><p>入参限制：VerifyMethod=Introspection 时必填</p>
        /// </summary>
        [JsonProperty("IntrospectionClientId")]
        public string IntrospectionClientId{ get; set; }

        /// <summary>
        /// <p>调用内省端点的 Client Secret</p><p>入参限制：VerifyMethod=Introspection 时必填</p><p>加密落库，查询时无论 Enable 状态均脱敏</p>
        /// </summary>
        [JsonProperty("IntrospectionClientSecret")]
        public string IntrospectionClientSecret{ get; set; }

        /// <summary>
        /// <p>内省结果缓存秒数</p><p>默认值：60</p><p>0 表示不缓存</p>
        /// </summary>
        [JsonProperty("IntrospectionCacheTtl")]
        public ulong? IntrospectionCacheTtl{ get; set; }

        /// <summary>
        /// <p>逗号分隔的 scope 白名单；令牌需命中其一，否则 401</p>
        /// </summary>
        [JsonProperty("ScopeWhitelist")]
        public string ScopeWhitelist{ get; set; }

        /// <summary>
        /// <p>读取调用方令牌的 Header 名</p><p>默认值：Authorization</p>
        /// </summary>
        [JsonProperty("TokenHeader")]
        public string TokenHeader{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VerifyMethod", this.VerifyMethod);
            this.SetParamSimple(map, prefix + "Issuer", this.Issuer);
            this.SetParamSimple(map, prefix + "JwksUri", this.JwksUri);
            this.SetParamSimple(map, prefix + "Audience", this.Audience);
            this.SetParamSimple(map, prefix + "JwksCacheTtl", this.JwksCacheTtl);
            this.SetParamSimple(map, prefix + "IntrospectionEndpoint", this.IntrospectionEndpoint);
            this.SetParamSimple(map, prefix + "IntrospectionClientId", this.IntrospectionClientId);
            this.SetParamSimple(map, prefix + "IntrospectionClientSecret", this.IntrospectionClientSecret);
            this.SetParamSimple(map, prefix + "IntrospectionCacheTtl", this.IntrospectionCacheTtl);
            this.SetParamSimple(map, prefix + "ScopeWhitelist", this.ScopeWhitelist);
            this.SetParamSimple(map, prefix + "TokenHeader", this.TokenHeader);
        }
    }
}

