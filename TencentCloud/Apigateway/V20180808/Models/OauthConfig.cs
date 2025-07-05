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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OauthConfig : AbstractModel
    {
        
        /// <summary>
        /// 公钥，用于验证用户token。
        /// </summary>
        [JsonProperty("PublicKey")]
        public string PublicKey{ get; set; }

        /// <summary>
        /// token传递位置。
        /// </summary>
        [JsonProperty("TokenLocation")]
        public string TokenLocation{ get; set; }

        /// <summary>
        /// 重定向地址，用于引导用户登录操作。
        /// </summary>
        [JsonProperty("LoginRedirectUrl")]
        public string LoginRedirectUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PublicKey", this.PublicKey);
            this.SetParamSimple(map, prefix + "TokenLocation", this.TokenLocation);
            this.SetParamSimple(map, prefix + "LoginRedirectUrl", this.LoginRedirectUrl);
        }
    }
}

