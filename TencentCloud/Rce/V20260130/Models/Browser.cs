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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Browser : AbstractModel
    {
        
        /// <summary>
        /// <p>与网站交互的浏览器的用户代理</p>
        /// </summary>
        [JsonProperty("UserAgent")]
        public string UserAgent{ get; set; }

        /// <summary>
        /// <p>浏览器支持的用户请求语言</p><p>参数格式：符合ISO 3166标准</p>
        /// </summary>
        [JsonProperty("AcceptLanguage")]
        public string AcceptLanguage{ get; set; }

        /// <summary>
        /// <p>浏览器当前网站内容的语言</p><p>参数格式：符合ISO 3166标准</p>
        /// </summary>
        [JsonProperty("ContentLanguage")]
        public string ContentLanguage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserAgent", this.UserAgent);
            this.SetParamSimple(map, prefix + "AcceptLanguage", this.AcceptLanguage);
            this.SetParamSimple(map, prefix + "ContentLanguage", this.ContentLanguage);
        }
    }
}

