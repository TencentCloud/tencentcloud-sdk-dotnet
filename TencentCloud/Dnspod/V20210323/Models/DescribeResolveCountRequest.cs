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

    public class DescribeResolveCountRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>要查询解析量的域名</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>查询的开始时间，格式：YYYY-MM-DD，最多允许查询最近32天的数据。</p>
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// <p>查询的结束时间，格式：YYYY-MM-DD，最多允许查询最近32天的数据。</p>
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }

        /// <summary>
        /// <p>数据统计格式</p><p>枚举值：</p><ul><li>minute： 按十分钟维度统计数据</li><li>hour： 按小时维度统计数据</li><li>day： 按天维度统计数据</li></ul>
        /// </summary>
        [JsonProperty("DnsFormat")]
        [System.Obsolete]
        public string DnsFormat{ get; set; }

        /// <summary>
        /// <p>域名 ID 。参数 DomainId 优先级比参数 Domain 高，如果传递参数 DomainId 将忽略参数 Domain 。可以通过接口DescribeDomainList查到所有的Domain以及DomainId</p>
        /// </summary>
        [JsonProperty("DomainId")]
        public ulong? DomainId{ get; set; }

        /// <summary>
        /// <p>数据统计格式</p><p>枚举值：</p><ul><li>minute： 按十分钟维度统计数据</li><li>hour： 按小时维度统计数据</li><li>day： 按天维度统计数据</li></ul><p>新增规范参数，同时传递DNSFormat和DnsFormat参数时，后端优先使用DNSFormat参数</p>
        /// </summary>
        [JsonProperty("DNSFormat")]
        public string DNSFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "StartDate", this.StartDate);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
            this.SetParamSimple(map, prefix + "DnsFormat", this.DnsFormat);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "DNSFormat", this.DNSFormat);
        }
    }
}

