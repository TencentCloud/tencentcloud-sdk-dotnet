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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OAuthConfig : AbstractModel
    {
        
        /// <summary>
        /// OAuth服务方授权页url地址
        /// </summary>
        [JsonProperty("AuthorizationUrl")]
        public string AuthorizationUrl{ get; set; }

        /// <summary>
        /// 客户端ID
        /// </summary>
        [JsonProperty("ClientId")]
        public string ClientId{ get; set; }

        /// <summary>
        /// 客户端密钥
        /// </summary>
        [JsonProperty("ClientSecret")]
        public string ClientSecret{ get; set; }

        /// <summary>
        /// 请求授权的数据范围
        /// </summary>
        [JsonProperty("ScopeList")]
        public string[] ScopeList{ get; set; }

        /// <summary>
        /// 获取access token的url地址
        /// </summary>
        [JsonProperty("TokenUrl")]
        public string TokenUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuthorizationUrl", this.AuthorizationUrl);
            this.SetParamSimple(map, prefix + "ClientId", this.ClientId);
            this.SetParamSimple(map, prefix + "ClientSecret", this.ClientSecret);
            this.SetParamArraySimple(map, prefix + "ScopeList.", this.ScopeList);
            this.SetParamSimple(map, prefix + "TokenUrl", this.TokenUrl);
        }
    }
}

