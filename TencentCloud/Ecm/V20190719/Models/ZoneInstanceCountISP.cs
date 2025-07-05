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

    public class ZoneInstanceCountISP : AbstractModel
    {
        
        /// <summary>
        /// 创建实例的可用区。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 在当前可用区创建的实例数目。
        /// </summary>
        [JsonProperty("InstanceCount")]
        public long? InstanceCount{ get; set; }

        /// <summary>
        /// 运营商如下：
        /// CTCC：中国电信
        /// CUCC：中国联通
        /// CMCC：中国移动
        /// CMCC;CUCC;CTCC：三网；三网需要开通白名单，请直接联系腾讯云客服。
        /// </summary>
        [JsonProperty("ISP")]
        public string ISP{ get; set; }

        /// <summary>
        /// 指定私有网络编号，SubnetId与VpcId必须同时指定或不指定
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 指定子网编号，SubnetId与VpcId必须同时指定或不指定
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 指定主网卡内网IP。条件：SubnetId与VpcId必须同时指定，并且IP数量与InstanceCount相同，多IP主机副网卡内网IP在相同子网内通过DHCP获取。
        /// </summary>
        [JsonProperty("PrivateIpAddresses")]
        public string[] PrivateIpAddresses{ get; set; }

        /// <summary>
        /// 为弹性网卡指定随机生成的IPv6地址数量，单网情况下是1，单网需要ISP 只能为单网运营商，三网情况3
        /// </summary>
        [JsonProperty("Ipv6AddressCount")]
        public long? Ipv6AddressCount{ get; set; }

        /// <summary>
        /// 指定创建三网ipv6地址，使用的subnet数组，只创建ipv4不创建ipv6和单网ipv6子网依然使用SubnetId字段；
        /// 该数组必须且仅支持传入三个不同的子网，并且这三个子网各自分配了电信、联通、移动三个运营商的其中一个IPV6 CIDR网段
        /// </summary>
        [JsonProperty("Ipv6SubnetIds")]
        public string[] Ipv6SubnetIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "ISP", this.ISP);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamArraySimple(map, prefix + "PrivateIpAddresses.", this.PrivateIpAddresses);
            this.SetParamSimple(map, prefix + "Ipv6AddressCount", this.Ipv6AddressCount);
            this.SetParamArraySimple(map, prefix + "Ipv6SubnetIds.", this.Ipv6SubnetIds);
        }
    }
}

