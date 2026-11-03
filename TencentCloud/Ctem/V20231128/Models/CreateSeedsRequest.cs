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

namespace TencentCloud.Ctem.V20231128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSeedsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>企业ID</p>
        /// </summary>
        [JsonProperty("CustomerId")]
        public long? CustomerId{ get; set; }

        /// <summary>
        /// <p>ip种子数组</p>
        /// </summary>
        [JsonProperty("Ips")]
        public string[] Ips{ get; set; }

        /// <summary>
        /// <p>icon种子数组</p>
        /// </summary>
        [JsonProperty("Icons")]
        public string[] Icons{ get; set; }

        /// <summary>
        /// <p>主域名种子数组</p>
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// <p>title种子数组</p>
        /// </summary>
        [JsonProperty("Titles")]
        public string[] Titles{ get; set; }

        /// <summary>
        /// <p>子域名种子数组</p>
        /// </summary>
        [JsonProperty("SubDomains")]
        public string[] SubDomains{ get; set; }

        /// <summary>
        /// <p>关键词种子数组</p>
        /// </summary>
        [JsonProperty("Keywords")]
        public string[] Keywords{ get; set; }

        /// <summary>
        /// <p>母公司种子数组</p>
        /// </summary>
        [JsonProperty("ParentCompanies")]
        public string[] ParentCompanies{ get; set; }

        /// <summary>
        /// <p>关键词用途：leakage_code代码泄露/leakage_data其他泄露/wechat_applet微信小程序/wechat_official_account微信公众号，不填=全部用途</p>
        /// </summary>
        [JsonProperty("KeywordPurposes")]
        public string[] KeywordPurposes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CustomerId", this.CustomerId);
            this.SetParamArraySimple(map, prefix + "Ips.", this.Ips);
            this.SetParamArraySimple(map, prefix + "Icons.", this.Icons);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamArraySimple(map, prefix + "Titles.", this.Titles);
            this.SetParamArraySimple(map, prefix + "SubDomains.", this.SubDomains);
            this.SetParamArraySimple(map, prefix + "Keywords.", this.Keywords);
            this.SetParamArraySimple(map, prefix + "ParentCompanies.", this.ParentCompanies);
            this.SetParamArraySimple(map, prefix + "KeywordPurposes.", this.KeywordPurposes);
        }
    }
}

