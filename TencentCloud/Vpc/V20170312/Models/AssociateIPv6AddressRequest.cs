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

    public class AssociateIPv6AddressRequest : AbstractModel
    {
        
        /// <summary>
        /// 弹性公网IPv6唯一ID，EIPv6 唯一 ID 形如：eipv6-11112222。可以使用[DescribeIPv6Addresses](https://cloud.tencent.com/document/api/215/113677)接口获取IPv6AddressId。
        /// </summary>
        [JsonProperty("IPv6AddressId")]
        public string IPv6AddressId{ get; set; }

        /// <summary>
        /// 要绑定的实例 ID。实例 ID 形如：ins-djflxkvi。可通过登录控制台查询，也可通过 DescribeInstances 接口返回值中的InstanceId获取。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 要绑定的弹性网卡 ID。 弹性网卡 ID 形如：eni-11112222。NetworkInterfaceId 与 InstanceId 不可同时指定。弹性网卡 ID 可通过登录[控制台](https://console.cloud.tencent.com/vpc/eni?rid=1)查询，也可通过[DescribeNetworkInterfaces](https://cloud.tencent.com/document/api/215/15817)接口返回值中的networkInterfaceId获取。
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public string NetworkInterfaceId{ get; set; }

        /// <summary>
        /// 要绑定的内网 IPv6。如果指定了 NetworkInterfaceId 则也必须指定 PrivateIPv6Address ，表示将 EIP 绑定到指定弹性网卡的指定内网 IP 上。同时要确保指定的 PrivateIPv6Address 是指定的 NetworkInterfaceId 上的一个内网 IPv6。指定弹性网卡的内网 IPv6 可通过登录[控制台](https://console.cloud.tencent.com/vpc/eni?rid=1)查询，也可通过[DescribeNetworkInterfaces](https://cloud.tencent.com/document/api/215/15817)接口返回值中的Ipv6AddressSet.Address获取。
        /// </summary>
        [JsonProperty("PrivateIPv6Address")]
        public string PrivateIPv6Address{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IPv6AddressId", this.IPv6AddressId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "NetworkInterfaceId", this.NetworkInterfaceId);
            this.SetParamSimple(map, prefix + "PrivateIPv6Address", this.PrivateIPv6Address);
        }
    }
}

