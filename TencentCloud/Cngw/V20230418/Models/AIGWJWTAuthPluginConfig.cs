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

    public class AIGWJWTAuthPluginConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>签名的header名称列表</p>
        /// </summary>
        [JsonProperty("HeaderNames")]
        public string[] HeaderNames{ get; set; }

        /// <summary>
        /// <p>签名的cookie名称列表</p>
        /// </summary>
        [JsonProperty("CookieNames")]
        public string[] CookieNames{ get; set; }

        /// <summary>
        /// <p>签名的URL参数名称列表</p>
        /// </summary>
        [JsonProperty("URIParamNames")]
        public string[] URIParamNames{ get; set; }

        /// <summary>
        /// <p>消费者标识</p>
        /// </summary>
        [JsonProperty("KeyClaimName")]
        public string KeyClaimName{ get; set; }

        /// <summary>
        /// <p>标准消费者校验</p><p>枚举值：</p><ul><li>exp： exp</li><li>nbf： nbf</li></ul>
        /// </summary>
        [JsonProperty("ClaimsToVerify")]
        public string[] ClaimsToVerify{ get; set; }

        /// <summary>
        /// <p>最大有效期</p>
        /// </summary>
        [JsonProperty("MaximumExpiration")]
        public long? MaximumExpiration{ get; set; }

        /// <summary>
        /// <p>是否Base64编码</p>
        /// </summary>
        [JsonProperty("SecretIsBase64")]
        public bool? SecretIsBase64{ get; set; }

        /// <summary>
        /// <p>CORS预检验证</p>
        /// </summary>
        [JsonProperty("RunOnPreFlight")]
        public bool? RunOnPreFlight{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "HeaderNames.", this.HeaderNames);
            this.SetParamArraySimple(map, prefix + "CookieNames.", this.CookieNames);
            this.SetParamArraySimple(map, prefix + "URIParamNames.", this.URIParamNames);
            this.SetParamSimple(map, prefix + "KeyClaimName", this.KeyClaimName);
            this.SetParamArraySimple(map, prefix + "ClaimsToVerify.", this.ClaimsToVerify);
            this.SetParamSimple(map, prefix + "MaximumExpiration", this.MaximumExpiration);
            this.SetParamSimple(map, prefix + "SecretIsBase64", this.SecretIsBase64);
            this.SetParamSimple(map, prefix + "RunOnPreFlight", this.RunOnPreFlight);
        }
    }
}

