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

    public class UnassignIpv6AddressesRequest : AbstractModel
    {
        
        /// <summary>
        /// 弹性网卡实例`ID`，形如：`eni-m6dyj72l`。可通过[DescribeNetworkInterfaces](https://cloud.tencent.com/document/product/215/15817)接口获取。
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public string NetworkInterfaceId{ get; set; }

        /// <summary>
        /// 指定的`IPv6`地址列表，单次最多指定10个。
        /// </summary>
        [JsonProperty("Ipv6Addresses")]
        public Ipv6Address[] Ipv6Addresses{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetworkInterfaceId", this.NetworkInterfaceId);
            this.SetParamArrayObj(map, prefix + "Ipv6Addresses.", this.Ipv6Addresses);
        }
    }
}

