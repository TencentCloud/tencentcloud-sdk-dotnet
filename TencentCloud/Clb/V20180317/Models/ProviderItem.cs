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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProviderItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Provider 标识（如 openai）</p>
        /// </summary>
        [JsonProperty("Provider")]
        public string Provider{ get; set; }

        /// <summary>
        /// <p>显示名称（如 OpenAI）</p>
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// <p>模型协议列表</p>
        /// </summary>
        [JsonProperty("Protocols")]
        public string[] Protocols{ get; set; }

        /// <summary>
        /// <p>英文显示名称</p>
        /// </summary>
        [JsonProperty("EnglishDisplayName")]
        public string EnglishDisplayName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamArraySimple(map, prefix + "Protocols.", this.Protocols);
            this.SetParamSimple(map, prefix + "EnglishDisplayName", this.EnglishDisplayName);
        }
    }
}

