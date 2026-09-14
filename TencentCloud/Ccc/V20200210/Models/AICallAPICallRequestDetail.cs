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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AICallAPICallRequestDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>HTTP 请求方法，如 GET、POST。</p>
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// <p>请求地址。</p>
        /// </summary>
        [JsonProperty("URL")]
        public string URL{ get; set; }

        /// <summary>
        /// <p>请求参数（节点配置的入参与 URL query），json 序列化后的字符串，键升序排列。敏感值已脱敏，无参数时为空字符串。</p>
        /// </summary>
        [JsonProperty("Params")]
        public string Params{ get; set; }

        /// <summary>
        /// <p>请求头，json 序列化后的字符串，键升序排列。敏感值已脱敏，无请求头时为空字符串。</p>
        /// </summary>
        [JsonProperty("Headers")]
        public string Headers{ get; set; }

        /// <summary>
        /// <p>请求体，超长时被截断，是否截断见 Truncated。</p>
        /// </summary>
        [JsonProperty("Body")]
        public string Body{ get; set; }

        /// <summary>
        /// <p>请求体 Body 是否被截断。</p>
        /// </summary>
        [JsonProperty("Truncated")]
        public bool? Truncated{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "URL", this.URL);
            this.SetParamSimple(map, prefix + "Params", this.Params);
            this.SetParamSimple(map, prefix + "Headers", this.Headers);
            this.SetParamSimple(map, prefix + "Body", this.Body);
            this.SetParamSimple(map, prefix + "Truncated", this.Truncated);
        }
    }
}

