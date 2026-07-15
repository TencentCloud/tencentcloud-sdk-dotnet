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

    public class AIGWOIDCAuthPluginConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>目标受众</p>
        /// </summary>
        [JsonProperty("Audience")]
        public string Audience{ get; set; }

        /// <summary>
        /// <p>是否BearerOnly</p><p>目前只能为true</p>
        /// </summary>
        [JsonProperty("BearerOnly")]
        public bool? BearerOnly{ get; set; }

        /// <summary>
        /// <p>授权范围</p>
        /// </summary>
        [JsonProperty("Scopes")]
        public string[] Scopes{ get; set; }

        /// <summary>
        /// <p>消费者标识</p>
        /// </summary>
        [JsonProperty("ConsumerClaim")]
        public string ConsumerClaim{ get; set; }

        /// <summary>
        /// <p>认证域</p>
        /// </summary>
        [JsonProperty("Realm")]
        public string Realm{ get; set; }

        /// <summary>
        /// <p>超时时间</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// <p>令牌端点认证方法</p><p>枚举值：</p><ul><li>client_secret_post： client_secret_post</li><li>client_secret_basic： client_secret_basic</li><li>private_key_jwt： private_key_jwt</li></ul>
        /// </summary>
        [JsonProperty("TokenEndpointAuthMethod")]
        public string TokenEndpointAuthMethod{ get; set; }

        /// <summary>
        /// <p>令牌内省端点</p>
        /// </summary>
        [JsonProperty("IntrospectionEndpoint")]
        public string IntrospectionEndpoint{ get; set; }

        /// <summary>
        /// <p>令牌内省端点认证方法</p><p>枚举值：</p><ul><li>client_secret_basic： client_secret_basic</li><li>client_secret_post： client_secret_post</li></ul>
        /// </summary>
        [JsonProperty("IntrospectionEndpointAuthMethod")]
        public string IntrospectionEndpointAuthMethod{ get; set; }

        /// <summary>
        /// <p>签发者地址</p>
        /// </summary>
        [JsonProperty("IssuerURL")]
        public string IssuerURL{ get; set; }

        /// <summary>
        /// <p>客户端 ID</p>
        /// </summary>
        [JsonProperty("ClientId")]
        public string ClientId{ get; set; }

        /// <summary>
        /// <p>客户端密钥</p>
        /// </summary>
        [JsonProperty("ClientSecret")]
        public string ClientSecret{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Audience", this.Audience);
            this.SetParamSimple(map, prefix + "BearerOnly", this.BearerOnly);
            this.SetParamArraySimple(map, prefix + "Scopes.", this.Scopes);
            this.SetParamSimple(map, prefix + "ConsumerClaim", this.ConsumerClaim);
            this.SetParamSimple(map, prefix + "Realm", this.Realm);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "TokenEndpointAuthMethod", this.TokenEndpointAuthMethod);
            this.SetParamSimple(map, prefix + "IntrospectionEndpoint", this.IntrospectionEndpoint);
            this.SetParamSimple(map, prefix + "IntrospectionEndpointAuthMethod", this.IntrospectionEndpointAuthMethod);
            this.SetParamSimple(map, prefix + "IssuerURL", this.IssuerURL);
            this.SetParamSimple(map, prefix + "ClientId", this.ClientId);
            this.SetParamSimple(map, prefix + "ClientSecret", this.ClientSecret);
        }
    }
}

