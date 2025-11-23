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
        /// 企业ID
        /// </summary>
        [JsonProperty("CustomerId")]
        public long? CustomerId{ get; set; }

        /// <summary>
        /// ip种子数组
        /// </summary>
        [JsonProperty("Ips")]
        public string[] Ips{ get; set; }

        /// <summary>
        /// icon种子数组
        /// </summary>
        [JsonProperty("Icons")]
        public string[] Icons{ get; set; }

        /// <summary>
        /// 主域名种子数组
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// title种子数组
        /// </summary>
        [JsonProperty("Titles")]
        public string[] Titles{ get; set; }

        /// <summary>
        /// 子域名种子数组
        /// </summary>
        [JsonProperty("SubDomains")]
        public string[] SubDomains{ get; set; }

        /// <summary>
        /// 关键词种子数组
        /// </summary>
        [JsonProperty("Keywords")]
        public string[] Keywords{ get; set; }

        /// <summary>
        /// 母公司种子数组
        /// </summary>
        [JsonProperty("ParentCompanies")]
        public string[] ParentCompanies{ get; set; }


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
        }
    }
}

