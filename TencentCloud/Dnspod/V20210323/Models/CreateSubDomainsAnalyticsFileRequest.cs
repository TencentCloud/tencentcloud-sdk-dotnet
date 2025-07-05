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

    public class CreateSubDomainsAnalyticsFileRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要查询解析量的域名数组。
        /// </summary>
        [JsonProperty("Domains")]
        public SubDomainsAnalyticsParamsItem[] Domains{ get; set; }

        /// <summary>
        /// 查询解析量的时间区间起点。如：2023-01-01。
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// 查询解析量子域名类型。
        /// 1：子域名
        /// 2：无解析量子域名
        /// </summary>
        [JsonProperty("SubDomainType")]
        public ulong? SubDomainType{ get; set; }

        /// <summary>
        /// 查询解析量的统计维度。默认为 DATE。
        /// DATE：按天统计
        /// HOUR：按小时统计
        /// </summary>
        [JsonProperty("DNSFormat")]
        public string DNSFormat{ get; set; }

        /// <summary>
        /// 查询解析量的时间区间终点。如：2023-01-01。默认为当天。
        /// </summary>
        [JsonProperty("EndDate")]
        public string EndDate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Domains.", this.Domains);
            this.SetParamSimple(map, prefix + "StartDate", this.StartDate);
            this.SetParamSimple(map, prefix + "SubDomainType", this.SubDomainType);
            this.SetParamSimple(map, prefix + "DNSFormat", this.DNSFormat);
            this.SetParamSimple(map, prefix + "EndDate", this.EndDate);
        }
    }
}

