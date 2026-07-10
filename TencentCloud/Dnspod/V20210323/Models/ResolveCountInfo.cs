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

namespace TencentCloud.Dnspod.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResolveCountInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>当前统计周期解析量总计</p>
        /// </summary>
        [JsonProperty("DnsTotal")]
        [System.Obsolete]
        public ulong? DnsTotal{ get; set; }

        /// <summary>
        /// <p>当前查询的域名</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>当前统计周期开始时间</p>
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// <p>当前统计周期结束时间</p>
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }

        /// <summary>
        /// <p>当前统计的子域名</p>
        /// </summary>
        [JsonProperty("SubDomain")]
        public string SubDomain{ get; set; }

        /// <summary>
        /// <p>数据统计格式，取值为minute、hour、day，分别表示按十分钟、小时、天统计数据</p>
        /// </summary>
        [JsonProperty("DnsFormat")]
        [System.Obsolete]
        public string DnsFormat{ get; set; }

        /// <summary>
        /// <p>当前统计周期解析量总计</p>
        /// </summary>
        [JsonProperty("DNSTotal")]
        public ulong? DNSTotal{ get; set; }

        /// <summary>
        /// <p>数据统计格式，取值为minute、hour、day，分别表示按十分钟、小时、天统计数据</p>
        /// </summary>
        [JsonProperty("DNSFormat")]
        public string DNSFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DnsTotal", this.DnsTotal);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "StartDate", this.StartDate);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
            this.SetParamSimple(map, prefix + "SubDomain", this.SubDomain);
            this.SetParamSimple(map, prefix + "DnsFormat", this.DnsFormat);
            this.SetParamSimple(map, prefix + "DNSTotal", this.DNSTotal);
            this.SetParamSimple(map, prefix + "DNSFormat", this.DNSFormat);
        }
    }
}

