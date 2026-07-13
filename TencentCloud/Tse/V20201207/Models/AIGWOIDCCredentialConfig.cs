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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIGWOIDCCredentialConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>IdP 注册的 client_id</p>
        /// </summary>
        [JsonProperty("ClientId")]
        public string ClientId{ get; set; }

        /// <summary>
        /// <p>IdP 注册的 client_secret</p>
        /// </summary>
        [JsonProperty("ClientSecret")]
        public string ClientSecret{ get; set; }

        /// <summary>
        /// <p>IdP Issuer URL</p>
        /// </summary>
        [JsonProperty("IssuerURL")]
        public string IssuerURL{ get; set; }

        /// <summary>
        /// <p>IdP 中该用户的 claim 值</p>
        /// </summary>
        [JsonProperty("ConsumerClaimValue")]
        public string ConsumerClaimValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientId", this.ClientId);
            this.SetParamSimple(map, prefix + "ClientSecret", this.ClientSecret);
            this.SetParamSimple(map, prefix + "IssuerURL", this.IssuerURL);
            this.SetParamSimple(map, prefix + "ConsumerClaimValue", this.ConsumerClaimValue);
        }
    }
}

