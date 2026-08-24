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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VirtualPrivateCloud : AbstractModel
    {
        
        /// <summary>
        /// 私有网络ID，形如 vpc-xxxxxxxx。私有网络ID可通过登录控制台查询，也可通过调用接口 [DescribeVpcEx]的返回值中的unVpcId字段获取。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有网络子网ID，形如 subnet-xxxxxxxx。私有网络子网ID可通过登录控制台查询，也可通过调用接口 [DescribeSubnets](https://cloud.tencent.com/document/api/215/15784) 的返回值中的 unSubnetId 字段获取。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 私有网络子网名称。
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// 是否用作公网网关。公网网关只有在实例拥有公网IP以及处于私有网络下时才能正常使用。取值范围：true（用作公网网关）/false（不作为公网网关），默认取值：false。
        /// </summary>
        [JsonProperty("AsVpcGateway")]
        public bool? AsVpcGateway{ get; set; }

        /// <summary>
        /// 私有网络子网 IP 数组，在创建实例、修改实例 vpc 属性操作中可使用此参数。当前仅批量创建多台实例时支持传入相同子网的多个 IP。
        /// </summary>
        [JsonProperty("PrivateIpAddresses")]
        public string[] PrivateIpAddresses{ get; set; }

        /// <summary>
        /// 私有网络名称，仅做展示用。
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// 为弹性网卡指定随机生成的 IPv6 地址数量。
        /// </summary>
        [JsonProperty("Ipv6AddressCount")]
        public long? Ipv6AddressCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
            this.SetParamSimple(map, prefix + "AsVpcGateway", this.AsVpcGateway);
            this.SetParamArraySimple(map, prefix + "PrivateIpAddresses.", this.PrivateIpAddresses);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "Ipv6AddressCount", this.Ipv6AddressCount);
        }
    }
}

