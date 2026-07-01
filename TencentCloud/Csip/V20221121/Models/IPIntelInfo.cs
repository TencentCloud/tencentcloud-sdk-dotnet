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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IPIntelInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>情报标签（如常规木马、漏洞软件、窃密木马）</p>
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// <p>研判依据</p>
        /// </summary>
        [JsonProperty("Basis")]
        public string Basis{ get; set; }

        /// <summary>
        /// <p>所属运营商</p>
        /// </summary>
        [JsonProperty("ISP")]
        public string ISP{ get; set; }

        /// <summary>
        /// <p>地理位置</p>
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// <p>家族团伙</p>
        /// </summary>
        [JsonProperty("Characteristic")]
        public string Characteristic{ get; set; }

        /// <summary>
        /// <p>IP画像</p>
        /// </summary>
        [JsonProperty("Purpose")]
        public string Purpose{ get; set; }

        /// <summary>
        /// <p>反查域名列表</p>
        /// </summary>
        [JsonProperty("Referer")]
        public DomainInfo[] Referer{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Basis", this.Basis);
            this.SetParamSimple(map, prefix + "ISP", this.ISP);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "Characteristic", this.Characteristic);
            this.SetParamSimple(map, prefix + "Purpose", this.Purpose);
            this.SetParamArrayObj(map, prefix + "Referer.", this.Referer);
        }
    }
}

