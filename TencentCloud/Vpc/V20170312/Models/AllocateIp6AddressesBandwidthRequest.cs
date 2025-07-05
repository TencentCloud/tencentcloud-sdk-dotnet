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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AllocateIp6AddressesBandwidthRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要开通公网访问能力的IPv6地址，可以使用[DescribeIp6Addresses](https://cloud.tencent.com/document/product/215/40089)接口查询Ip6Addresses。
        /// </summary>
        [JsonProperty("Ip6Addresses")]
        public string[] Ip6Addresses{ get; set; }

        /// <summary>
        /// 带宽上限，单位Mbps。可调整的带宽上限值参考产品文档中[IPv6 计费限制说明](https://cloud.tencent.com/document/product/1142/38369#IPv6)。
        /// 默认值：1Mbps
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public long? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// 网络计费模式。IPv6当前支持：<li>TRAFFIC_POSTPAID_BY_HOUR：流量按小时后付费</li><li>BANDWIDTH_PACKAGE：共享带宽包付费</li>
        /// 默认值：TRAFFIC_POSTPAID_BY_HOUR
        /// </summary>
        [JsonProperty("InternetChargeType")]
        public string InternetChargeType{ get; set; }

        /// <summary>
        /// 带宽包id，设定该参数且InternetChargeType为BANDWIDTH_PACKAGE，则表示创建的IPv6加入该带宽包并采用带宽包计费。可以使用[DescribeBandwidthPackages](https://cloud.tencent.com/document/product/215/19209)接口查询BandwidthPackageId。
        /// </summary>
        [JsonProperty("BandwidthPackageId")]
        public string BandwidthPackageId{ get; set; }

        /// <summary>
        /// 需要关联的标签列表。	
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Ip6Addresses.", this.Ip6Addresses);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "InternetChargeType", this.InternetChargeType);
            this.SetParamSimple(map, prefix + "BandwidthPackageId", this.BandwidthPackageId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

