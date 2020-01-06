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

namespace TencentCloud.Bmvpc.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubnetCreateInputInfo : AbstractModel
    {
        
        /// <summary>
        /// 子网名称，可任意命名，但不得超过60个字符
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// 子网网段，子网网段必须在VPC网段内，相同VPC内子网网段不能重叠
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// 是否开启子网分布式网关，默认传1，传0为关闭子网分布式网关。关闭分布式网关子网用于云服务器化子网，此子网中只能有一台物理机，同时此物理机及其上子机只能在此子网中
        /// </summary>
        [JsonProperty("DistributedFlag")]
        public ulong? DistributedFlag{ get; set; }

        /// <summary>
        /// 是否开启dhcp relay ，关闭为0，开启为1。默认为0
        /// </summary>
        [JsonProperty("DhcpEnable")]
        public ulong? DhcpEnable{ get; set; }

        /// <summary>
        /// DHCP SERVER 的IP地址数组。IP地址为相同VPC的子网内分配的IP
        /// </summary>
        [JsonProperty("DhcpServerIp")]
        public string[] DhcpServerIp{ get; set; }

        /// <summary>
        /// 预留的IP个数。从该子网的最大可分配IP倒序分配N个IP 用于DHCP 动态分配使用的地址段
        /// </summary>
        [JsonProperty("IpReserve")]
        public ulong? IpReserve{ get; set; }

        /// <summary>
        /// 子网绑定的vlanId。VlanId取值范围为2000-2999。创建物理机子网，VlanId默认为5; 创建docker子网或者虚拟子网，VlanId默认会分配2000--2999未使用的数值。
        /// </summary>
        [JsonProperty("VlanId")]
        public ulong? VlanId{ get; set; }

        /// <summary>
        /// 黑石子网的可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 是否25G子网，1为是，0为否。
        /// </summary>
        [JsonProperty("IsSmartNic")]
        public ulong? IsSmartNic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "DistributedFlag", this.DistributedFlag);
            this.SetParamSimple(map, prefix + "DhcpEnable", this.DhcpEnable);
            this.SetParamArraySimple(map, prefix + "DhcpServerIp.", this.DhcpServerIp);
            this.SetParamSimple(map, prefix + "IpReserve", this.IpReserve);
            this.SetParamSimple(map, prefix + "VlanId", this.VlanId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "IsSmartNic", this.IsSmartNic);
        }
    }
}

