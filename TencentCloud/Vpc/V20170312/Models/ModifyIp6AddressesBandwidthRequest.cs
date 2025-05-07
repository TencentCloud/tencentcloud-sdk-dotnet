/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class ModifyIp6AddressesBandwidthRequest : AbstractModel
    {
        
        /// <summary>
        /// 修改的目标带宽，单位Mbps。可调整的带宽上限值参考产品文档中[IPv6 计费限制说明](https://cloud.tencent.com/document/product/1142/38369)。
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public long? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// IPv6地址。可以使用[DescribeIp6Addresses](https://cloud.tencent.com/document/product/215/40089)接口查询Ip6Addresses。Ip6Addresses和Ip6AddressIds必须且只能传一个。
        /// </summary>
        [JsonProperty("Ip6Addresses")]
        public string[] Ip6Addresses{ get; set; }

        /// <summary>
        /// IPv6地址对应的唯一ID，形如eip-xxxxxxxx。可以使用[DescribeIp6Addresses](https://cloud.tencent.com/document/product/215/40089)接口查询Ip6AddressIds。Ip6Addresses和Ip6AddressIds必须且只能传一个。
        /// </summary>
        [JsonProperty("Ip6AddressIds")]
        public string[] Ip6AddressIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamArraySimple(map, prefix + "Ip6Addresses.", this.Ip6Addresses);
            this.SetParamArraySimple(map, prefix + "Ip6AddressIds.", this.Ip6AddressIds);
        }
    }
}

