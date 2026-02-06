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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OAuthSetting : AbstractModel
    {
        
        /// <summary>
        /// 是否开启OAuth认证
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// OAuth认证方式。
        /// </summary>
        [JsonProperty("AuthMethod")]
        public string AuthMethod{ get; set; }

        /// <summary>
        /// OAuth认证客户端Id。
        /// </summary>
        [JsonProperty("ClientId")]
        public string ClientId{ get; set; }

        /// <summary>
        /// 获取OAuth认证授权码URL。
        /// </summary>
        [JsonProperty("CodeUrl")]
        public string CodeUrl{ get; set; }

        /// <summary>
        /// 获取OAuth令牌URL。
        /// </summary>
        [JsonProperty("TokenUrl")]
        public string TokenUrl{ get; set; }

        /// <summary>
        /// 获取OAuth用户信息URL。
        /// </summary>
        [JsonProperty("UserInfoUrl")]
        public string UserInfoUrl{ get; set; }

        /// <summary>
        /// 使用Okta认证时指定范围。
        /// </summary>
        [JsonProperty("Scopes")]
        public string[] Scopes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "AuthMethod", this.AuthMethod);
            this.SetParamSimple(map, prefix + "ClientId", this.ClientId);
            this.SetParamSimple(map, prefix + "CodeUrl", this.CodeUrl);
            this.SetParamSimple(map, prefix + "TokenUrl", this.TokenUrl);
            this.SetParamSimple(map, prefix + "UserInfoUrl", this.UserInfoUrl);
            this.SetParamArraySimple(map, prefix + "Scopes.", this.Scopes);
        }
    }
}

