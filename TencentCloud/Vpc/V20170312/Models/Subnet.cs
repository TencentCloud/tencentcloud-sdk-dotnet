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

    public class Subnet : AbstractModel
    {
        
        /// <summary>
        /// `VPC`实例`ID`。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网实例`ID`，例如：subnet-bthucmmy。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 子网名称。
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// 子网的 `IPv4` `CIDR`。
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// 是否默认子网。
        /// </summary>
        [JsonProperty("IsDefault")]
        public bool? IsDefault{ get; set; }

        /// <summary>
        /// 是否开启广播。
        /// </summary>
        [JsonProperty("EnableBroadcast")]
        public bool? EnableBroadcast{ get; set; }

        /// <summary>
        /// 可用区。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 路由表实例ID，例如：rtb-l2h8d7c2。
        /// </summary>
        [JsonProperty("RouteTableId")]
        public string RouteTableId{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 可用`IP`数。
        /// </summary>
        [JsonProperty("AvailableIpAddressCount")]
        public ulong? AvailableIpAddressCount{ get; set; }

        /// <summary>
        /// 子网的 `IPv6` `CIDR`。
        /// </summary>
        [JsonProperty("Ipv6CidrBlock")]
        public string Ipv6CidrBlock{ get; set; }

        /// <summary>
        /// 关联`ACL`ID
        /// </summary>
        [JsonProperty("NetworkAclId")]
        public string NetworkAclId{ get; set; }

        /// <summary>
        /// 是否为 `SNAT` 地址池子网。
        /// </summary>
        [JsonProperty("IsRemoteVpcSnat")]
        public bool? IsRemoteVpcSnat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "EnableBroadcast", this.EnableBroadcast);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "RouteTableId", this.RouteTableId);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "AvailableIpAddressCount", this.AvailableIpAddressCount);
            this.SetParamSimple(map, prefix + "Ipv6CidrBlock", this.Ipv6CidrBlock);
            this.SetParamSimple(map, prefix + "NetworkAclId", this.NetworkAclId);
            this.SetParamSimple(map, prefix + "IsRemoteVpcSnat", this.IsRemoteVpcSnat);
        }
    }
}

