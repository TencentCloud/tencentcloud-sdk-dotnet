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

    public class CustomGuardrailAuthConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>网关访问审核引擎的鉴权方式：none 无鉴权（创建默认值）；api_key 在指定 HTTP Header 中发送凭据。与客户端访问 AI 网关时使用的鉴权相互独立。none 模式不应携带 HeaderName 或 ApiKey。</p>
        /// </summary>
        [JsonProperty("AuthType")]
        public string AuthType{ get; set; }

        /// <summary>
        /// <p>api_key 模式的鉴权 Header 名，例如 X-Audit-Key 或 Authorization。需为有效 Header 名；不能使用 Content-Type、Accept 或 x-cngw-audit- 前缀的保留名称。不建议使用 Host、Content-Length 等会影响 HTTP 协议语义的头。</p>
        /// </summary>
        [JsonProperty("HeaderName")]
        public string HeaderName{ get; set; }

        /// <summary>
        /// <p>只读：是否已保存审核引擎鉴权密钥。不会返回密钥本身；修改时无需回传此字段。</p>
        /// </summary>
        [JsonProperty("HasApiKey")]
        public bool? HasApiKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "HeaderName", this.HeaderName);
            this.SetParamSimple(map, prefix + "HasApiKey", this.HasApiKey);
        }
    }
}

