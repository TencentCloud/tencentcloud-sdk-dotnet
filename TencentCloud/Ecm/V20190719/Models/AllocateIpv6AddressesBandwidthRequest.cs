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

    public class AllocateIpv6AddressesBandwidthRequest : AbstractModel
    {
        
        /// <summary>
        /// ECM 地域。
        /// </summary>
        [JsonProperty("EcmRegion")]
        public string EcmRegion{ get; set; }

        /// <summary>
        /// 需要开通公网访问能力的IPV6地址。
        /// </summary>
        [JsonProperty("Ipv6Addresses")]
        public string[] Ipv6Addresses{ get; set; }

        /// <summary>
        /// 带宽，单位Mbps，默认是1Mbps。
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public long? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// 网络计费模式，当前支持 BANDWIDTH_PACKAGE。
        /// </summary>
        [JsonProperty("InternetChargeType")]
        public string InternetChargeType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EcmRegion", this.EcmRegion);
            this.SetParamArraySimple(map, prefix + "Ipv6Addresses.", this.Ipv6Addresses);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "InternetChargeType", this.InternetChargeType);
        }
    }
}

