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

    public class SubnetInfo : AbstractModel
    {
        
        /// <summary>
        /// 私有网络的唯一ID。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// VPC的名称。
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// VPC的CIDR。
        /// </summary>
        [JsonProperty("VpcCidrBlock")]
        public string VpcCidrBlock{ get; set; }

        /// <summary>
        /// 私有网络的唯一ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 子网名称。
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// 子网CIDR。
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// 子网类型。0: 黑石物理机子网; 6: ccs子网; 7 Docker子网; 8: 虚拟机子网
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 可用区ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// 子网物理机的个数
        /// </summary>
        [JsonProperty("CpmNum")]
        public ulong? CpmNum{ get; set; }

        /// <summary>
        /// 子网的VlanId。
        /// </summary>
        [JsonProperty("VlanId")]
        public ulong? VlanId{ get; set; }

        /// <summary>
        /// 是否开启分布式网关 ，关闭为0，开启为1。
        /// </summary>
        [JsonProperty("DistributedFlag")]
        public ulong? DistributedFlag{ get; set; }

        /// <summary>
        /// 是否开启dhcp relay ，关闭为0，开启为1。默认为0。
        /// </summary>
        [JsonProperty("DhcpEnable")]
        public ulong? DhcpEnable{ get; set; }

        /// <summary>
        /// DHCP SERVER 的IP地址数组。IP地址为相同VPC的子网内分配的IP。
        /// </summary>
        [JsonProperty("DhcpServerIp")]
        public string[] DhcpServerIp{ get; set; }

        /// <summary>
        /// 预留的IP个数。从该子网的最大可分配IP倒序分配N个IP 用于DHCP 动态分配使用的地址段。
        /// </summary>
        [JsonProperty("IpReserve")]
        public ulong? IpReserve{ get; set; }

        /// <summary>
        /// 子网中可用的IP个数
        /// </summary>
        [JsonProperty("AvailableIpNum")]
        public ulong? AvailableIpNum{ get; set; }

        /// <summary>
        /// 子网中总共的IP个数
        /// </summary>
        [JsonProperty("TotalIpNum")]
        public ulong? TotalIpNum{ get; set; }

        /// <summary>
        /// 子网创建时间
        /// </summary>
        [JsonProperty("SubnetCreateTime")]
        public string SubnetCreateTime{ get; set; }

        /// <summary>
        /// 25G子网标识
        /// </summary>
        [JsonProperty("IsSmartNic")]
        public ulong? IsSmartNic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "VpcCidrBlock", this.VpcCidrBlock);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "CpmNum", this.CpmNum);
            this.SetParamSimple(map, prefix + "VlanId", this.VlanId);
            this.SetParamSimple(map, prefix + "DistributedFlag", this.DistributedFlag);
            this.SetParamSimple(map, prefix + "DhcpEnable", this.DhcpEnable);
            this.SetParamArraySimple(map, prefix + "DhcpServerIp.", this.DhcpServerIp);
            this.SetParamSimple(map, prefix + "IpReserve", this.IpReserve);
            this.SetParamSimple(map, prefix + "AvailableIpNum", this.AvailableIpNum);
            this.SetParamSimple(map, prefix + "TotalIpNum", this.TotalIpNum);
            this.SetParamSimple(map, prefix + "SubnetCreateTime", this.SubnetCreateTime);
            this.SetParamSimple(map, prefix + "IsSmartNic", this.IsSmartNic);
        }
    }
}

