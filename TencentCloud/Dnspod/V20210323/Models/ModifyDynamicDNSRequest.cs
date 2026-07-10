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

    public class ModifyDynamicDNSRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>域名</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>记录ID。 可以通过接口DescribeRecordList查到所有的解析记录列表以及对应的RecordId</p>
        /// </summary>
        [JsonProperty("RecordId")]
        public ulong? RecordId{ get; set; }

        /// <summary>
        /// <p>记录线路，中文，比如：默认。</p>
        /// </summary>
        [JsonProperty("RecordLine")]
        public string RecordLine{ get; set; }

        /// <summary>
        /// <p>域名 ID 。参数 DomainId 优先级比参数 Domain 高，如果传递参数 DomainId 将忽略参数 Domain 。</p>
        /// </summary>
        [JsonProperty("DomainId")]
        public ulong? DomainId{ get; set; }

        /// <summary>
        /// <p>主机记录，如 www，如果不传，默认为 @。</p>
        /// </summary>
        [JsonProperty("SubDomain")]
        public string SubDomain{ get; set; }

        /// <summary>
        /// <p>线路的 ID，英文字符串，比如：10=1。参数RecordLineId优先级高于RecordLine，如果同时传递二者，优先使用RecordLineId参数。</p>
        /// </summary>
        [JsonProperty("RecordLineId")]
        public string RecordLineId{ get; set; }

        /// <summary>
        /// <p>IP 地址，支持 IPv4、IPv6，例如 119.29.29.29 或者 2402:4e00::</p>
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// <p>TTL值，如果不传，默认为域名的TTL值。</p>
        /// </summary>
        [JsonProperty("Ttl")]
        [System.Obsolete]
        public ulong? Ttl{ get; set; }

        /// <summary>
        /// <p>TTL值，如果不传，默认为域名的TTL值。</p><p>新增规范参数，同时传递TTL和Ttl参数时，后端优先使用TTL参数</p>
        /// </summary>
        [JsonProperty("TTL")]
        public ulong? TTL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "RecordLine", this.RecordLine);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "SubDomain", this.SubDomain);
            this.SetParamSimple(map, prefix + "RecordLineId", this.RecordLineId);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "Ttl", this.Ttl);
            this.SetParamSimple(map, prefix + "TTL", this.TTL);
        }
    }
}

