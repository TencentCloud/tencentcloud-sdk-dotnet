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

    public class VpcResource : AbstractModel
    {
        
        /// <summary>
        /// 私有网络ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有网络名称
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// 私有网络的CIDR
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// 子网个数
        /// </summary>
        [JsonProperty("SubnetNum")]
        public ulong? SubnetNum{ get; set; }

        /// <summary>
        /// NAT个数
        /// </summary>
        [JsonProperty("NatNum")]
        public ulong? NatNum{ get; set; }

        /// <summary>
        /// VPC状态
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 是否开启监控
        /// </summary>
        [JsonProperty("MonitorFlag")]
        public bool? MonitorFlag{ get; set; }

        /// <summary>
        /// 物理机个数
        /// </summary>
        [JsonProperty("CpmNum")]
        public ulong? CpmNum{ get; set; }

        /// <summary>
        /// 可用IP个数
        /// </summary>
        [JsonProperty("LeaveIpNum")]
        public ulong? LeaveIpNum{ get; set; }

        /// <summary>
        /// 负载均衡个数
        /// </summary>
        [JsonProperty("LbNum")]
        public ulong? LbNum{ get; set; }

        /// <summary>
        /// 流量镜像网关个数
        /// </summary>
        [JsonProperty("TrafficMirrorNum")]
        public ulong? TrafficMirrorNum{ get; set; }

        /// <summary>
        /// 弹性IP个数
        /// </summary>
        [JsonProperty("EipNum")]
        public ulong? EipNum{ get; set; }

        /// <summary>
        /// 专线网关个数
        /// </summary>
        [JsonProperty("PlgwNum")]
        public ulong? PlgwNum{ get; set; }

        /// <summary>
        /// 专线通道个数
        /// </summary>
        [JsonProperty("PlvpNum")]
        public ulong? PlvpNum{ get; set; }

        /// <summary>
        /// ssl vpn网关个数
        /// </summary>
        [JsonProperty("SslVpnGwNum")]
        public ulong? SslVpnGwNum{ get; set; }

        /// <summary>
        /// 对等链接个数
        /// </summary>
        [JsonProperty("VpcPeerNum")]
        public ulong? VpcPeerNum{ get; set; }

        /// <summary>
        /// ipsec vpn网关个数
        /// </summary>
        [JsonProperty("IpsecVpnGwNum")]
        public ulong? IpsecVpnGwNum{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 是否老专区VPC
        /// </summary>
        [JsonProperty("IsOld")]
        public bool? IsOld{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "SubnetNum", this.SubnetNum);
            this.SetParamSimple(map, prefix + "NatNum", this.NatNum);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "MonitorFlag", this.MonitorFlag);
            this.SetParamSimple(map, prefix + "CpmNum", this.CpmNum);
            this.SetParamSimple(map, prefix + "LeaveIpNum", this.LeaveIpNum);
            this.SetParamSimple(map, prefix + "LbNum", this.LbNum);
            this.SetParamSimple(map, prefix + "TrafficMirrorNum", this.TrafficMirrorNum);
            this.SetParamSimple(map, prefix + "EipNum", this.EipNum);
            this.SetParamSimple(map, prefix + "PlgwNum", this.PlgwNum);
            this.SetParamSimple(map, prefix + "PlvpNum", this.PlvpNum);
            this.SetParamSimple(map, prefix + "SslVpnGwNum", this.SslVpnGwNum);
            this.SetParamSimple(map, prefix + "VpcPeerNum", this.VpcPeerNum);
            this.SetParamSimple(map, prefix + "IpsecVpnGwNum", this.IpsecVpnGwNum);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "IsOld", this.IsOld);
        }
    }
}

