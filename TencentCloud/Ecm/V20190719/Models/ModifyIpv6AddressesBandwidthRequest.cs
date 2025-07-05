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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyIpv6AddressesBandwidthRequest : AbstractModel
    {
        
        /// <summary>
        /// ECM 地域
        /// </summary>
        [JsonProperty("EcmRegion")]
        public string EcmRegion{ get; set; }

        /// <summary>
        /// 修改的目标带宽，单位Mbps
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public long? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// IPV6地址。Ipv6Addresses和Ipv6AddressId必须且只能传一个
        /// </summary>
        [JsonProperty("Ipv6Addresses")]
        public Ipv6Address[] Ipv6Addresses{ get; set; }

        /// <summary>
        /// IPV6地址对应的唯一ID，形如eip-xxxxxxxx。Ipv6Addresses和Ipv6AddressId必须且只能传一个
        /// </summary>
        [JsonProperty("Ipv6AddressIds")]
        public string[] Ipv6AddressIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EcmRegion", this.EcmRegion);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamArrayObj(map, prefix + "Ipv6Addresses.", this.Ipv6Addresses);
            this.SetParamArraySimple(map, prefix + "Ipv6AddressIds.", this.Ipv6AddressIds);
        }
    }
}

