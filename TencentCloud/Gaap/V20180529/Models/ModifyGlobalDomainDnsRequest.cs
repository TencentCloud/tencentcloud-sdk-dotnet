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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyGlobalDomainDnsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>解析记录ID</p>
        /// </summary>
        [JsonProperty("DnsRecordId")]
        public ulong? DnsRecordId{ get; set; }

        /// <summary>
        /// <p>域名ID</p>
        /// </summary>
        [JsonProperty("DomainId")]
        public string DomainId{ get; set; }

        /// <summary>
        /// <p>国家ID列表</p>
        /// </summary>
        [JsonProperty("NationCountryInnerCodes")]
        public string[] NationCountryInnerCodes{ get; set; }

        /// <summary>
        /// <p>通道ID列表</p>
        /// </summary>
        [JsonProperty("ProxyIdList")]
        public string[] ProxyIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DnsRecordId", this.DnsRecordId);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamArraySimple(map, prefix + "NationCountryInnerCodes.", this.NationCountryInnerCodes);
            this.SetParamArraySimple(map, prefix + "ProxyIdList.", this.ProxyIdList);
        }
    }
}

