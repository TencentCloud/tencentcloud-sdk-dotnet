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

    public class AIGWJWTCredentialConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>JWT 消费者标识，iss claim</p>
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// <p>签名算法，取值：HS256 HS384 HS512 RS256 RS384 RS512 ES256 ES384 ES512</p>
        /// </summary>
        [JsonProperty("Algorithm")]
        public string Algorithm{ get; set; }

        /// <summary>
        /// <p>HS 对称密钥，仅 Algorithm 为 HS256/HS384/HS512 时必填；RS/ES* 时留空</p>
        /// </summary>
        [JsonProperty("Secret")]
        public string Secret{ get; set; }

        /// <summary>
        /// <p>RS/ES PEM 格式公钥，仅 Algorithm 为 RS256/RS384/RS512/ES256/ES384/ES512 时必填；HS* 时留空</p>
        /// </summary>
        [JsonProperty("RSAPublicKey")]
        public string RSAPublicKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Algorithm", this.Algorithm);
            this.SetParamSimple(map, prefix + "Secret", this.Secret);
            this.SetParamSimple(map, prefix + "RSAPublicKey", this.RSAPublicKey);
        }
    }
}

