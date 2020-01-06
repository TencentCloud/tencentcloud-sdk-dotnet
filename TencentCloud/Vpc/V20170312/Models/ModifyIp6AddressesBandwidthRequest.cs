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
        /// 修改的目标带宽，单位Mbps
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public long? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// IPV6地址。Ip6Addresses和Ip6AddressId必须且只能传一个
        /// </summary>
        [JsonProperty("Ip6Addresses")]
        public string[] Ip6Addresses{ get; set; }

        /// <summary>
        /// IPV6地址对应的唯一ID，形如eip-xxxxxxxx。Ip6Addresses和Ip6AddressId必须且只能传一个
        /// </summary>
        [JsonProperty("Ip6AddressIds")]
        public string[] Ip6AddressIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamArraySimple(map, prefix + "Ip6Addresses.", this.Ip6Addresses);
            this.SetParamArraySimple(map, prefix + "Ip6AddressIds.", this.Ip6AddressIds);
        }
    }
}

