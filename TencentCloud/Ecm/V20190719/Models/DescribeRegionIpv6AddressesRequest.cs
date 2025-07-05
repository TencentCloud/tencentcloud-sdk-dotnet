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

    public class DescribeRegionIpv6AddressesRequest : AbstractModel
    {
        
        /// <summary>
        /// ECM 地域，为空时返回所有地域的IPv6地址。
        /// </summary>
        [JsonProperty("EcmRegion")]
        public string EcmRegion{ get; set; }

        /// <summary>
        /// 详细的过滤条件如下：
        /// address-id - String - 是否必填：否 - （过滤条件）按照 EIP 的 ID 过滤。
        /// address-ip - String - 是否必填：否 - （过滤条件）按照 EIP 的 IP 地址过滤。
        /// network-interface-id - String - 是否必填：否 - （过滤条件）按照弹性网卡的唯一ID过滤。
        /// instance-id - String - 是否必填：否 - （过滤条件）按照 EIP 所绑定的实例 ID 过滤。
        /// vpc-id - String - 是否必填：否 - （过滤条件）按照 EIP 所在 VPC 的 ID 进行过滤。
        /// address-isp - String - 是否必填：否 - （过滤条件）按照 EIP 的运营商进行过滤。
        /// address-status  - String - 是否必填：否 - （过滤条件）按照 EIP  的状态信息进行过滤。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。关于Offset的更进一步介绍请参考 API 简介中的相关小节。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。关于Limit的更进一步介绍请参考 API 简介中的相关小节。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EcmRegion", this.EcmRegion);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

