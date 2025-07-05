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

    public class AssignIpv6AddressesRequest : AbstractModel
    {
        
        /// <summary>
        /// ECM 地域
        /// </summary>
        [JsonProperty("EcmRegion")]
        public string EcmRegion{ get; set; }

        /// <summary>
        /// 弹性网卡实例ID，形如：eni-1snva0vd。目前只支持主网卡上分配。
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public string NetworkInterfaceId{ get; set; }

        /// <summary>
        /// 指定的IPv6地址列表，单次最多指定10个。与入参Ipv6AddressCount合并计算配额。与Ipv6AddressCount必填一个。
        /// </summary>
        [JsonProperty("Ipv6Addresses")]
        public Ipv6Address[] Ipv6Addresses{ get; set; }

        /// <summary>
        /// 自动分配IPv6地址个数，内网IP地址个数总和不能超过配数。与入参Ipv6Addresses合并计算配额。与Ipv6Addresses必填一个。
        /// </summary>
        [JsonProperty("Ipv6AddressCount")]
        public long? Ipv6AddressCount{ get; set; }

        /// <summary>
        /// ipv6运营商如下：
        /// CTCC：中国电信
        /// CUCC：中国联通
        /// CMCC：中国移动
        /// </summary>
        [JsonProperty("ISPType")]
        public string ISPType{ get; set; }

        /// <summary>
        /// 是否跳过校验一个网卡只能分配一个IPv6 CIDR。该字段通常为true（用于兼容存量子机只有一个地址的情形）。
        /// </summary>
        [JsonProperty("SkipCheckIPv6Address")]
        public bool? SkipCheckIPv6Address{ get; set; }

        /// <summary>
        /// 是否跳过自动开通公网带宽。通常为true(根据运营系统的用户配置来决定是否自动开通，以支持当前子机购买时的行为）。
        /// </summary>
        [JsonProperty("SkipAllocateBandwidth")]
        public bool? SkipAllocateBandwidth{ get; set; }

        /// <summary>
        /// 该字段没有使用（已过期）。
        /// </summary>
        [JsonProperty("Ipv6ISP")]
        [System.Obsolete]
        public string Ipv6ISP{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EcmRegion", this.EcmRegion);
            this.SetParamSimple(map, prefix + "NetworkInterfaceId", this.NetworkInterfaceId);
            this.SetParamArrayObj(map, prefix + "Ipv6Addresses.", this.Ipv6Addresses);
            this.SetParamSimple(map, prefix + "Ipv6AddressCount", this.Ipv6AddressCount);
            this.SetParamSimple(map, prefix + "ISPType", this.ISPType);
            this.SetParamSimple(map, prefix + "SkipCheckIPv6Address", this.SkipCheckIPv6Address);
            this.SetParamSimple(map, prefix + "SkipAllocateBandwidth", this.SkipAllocateBandwidth);
            this.SetParamSimple(map, prefix + "Ipv6ISP", this.Ipv6ISP);
        }
    }
}

