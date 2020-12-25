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

namespace TencentCloud.Dc.V20180410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DirectConnectTunnelExtra : AbstractModel
    {
        
        /// <summary>
        /// 专用通道ID
        /// </summary>
        [JsonProperty("DirectConnectTunnelId")]
        public string DirectConnectTunnelId{ get; set; }

        /// <summary>
        /// 物理专线ID
        /// </summary>
        [JsonProperty("DirectConnectId")]
        public string DirectConnectId{ get; set; }

        /// <summary>
        /// 专用通道状态
        /// AVAILABLE:就绪或者已连接
        /// PENDING:申请中
        /// ALLOCATING:配置中
        /// ALLOCATED:配置完成
        /// ALTERING:修改中
        /// DELETING:删除中
        /// DELETED:删除完成
        /// COMFIRMING:待接受
        /// REJECTED:拒绝
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 物理专线的拥有者，开发商账号 ID
        /// </summary>
        [JsonProperty("DirectConnectOwnerAccount")]
        public string DirectConnectOwnerAccount{ get; set; }

        /// <summary>
        /// 专用通道的拥有者，开发商账号 ID
        /// </summary>
        [JsonProperty("OwnerAccount")]
        public string OwnerAccount{ get; set; }

        /// <summary>
        /// 网络类型，分别为VPC、BMVPC、CCN
        ///  VPC：私有网络 ，BMVPC：黑石网络，CCN：云联网
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// VPC地域对应的网络名，如ap-guangzhou
        /// </summary>
        [JsonProperty("NetworkRegion")]
        public string NetworkRegion{ get; set; }

        /// <summary>
        /// 私有网络统一 ID 或者黑石网络统一 ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 专线网关 ID
        /// </summary>
        [JsonProperty("DirectConnectGatewayId")]
        public string DirectConnectGatewayId{ get; set; }

        /// <summary>
        /// BGP ：BGP路由 STATIC：静态 默认为 BGP 路由
        /// </summary>
        [JsonProperty("RouteType")]
        public string RouteType{ get; set; }

        /// <summary>
        /// 用户侧BGP，Asn，AuthKey
        /// </summary>
        [JsonProperty("BgpPeer")]
        public BgpPeer BgpPeer{ get; set; }

        /// <summary>
        /// 用户侧网段地址
        /// </summary>
        [JsonProperty("RouteFilterPrefixes")]
        public RouteFilterPrefix[] RouteFilterPrefixes{ get; set; }

        /// <summary>
        /// 互联网通道公网网段地址
        /// </summary>
        [JsonProperty("PublicAddresses")]
        public RouteFilterPrefix[] PublicAddresses{ get; set; }

        /// <summary>
        /// 专用通道的Vlan
        /// </summary>
        [JsonProperty("Vlan")]
        public long? Vlan{ get; set; }

        /// <summary>
        /// 腾讯侧互联 IP
        /// </summary>
        [JsonProperty("TencentAddress")]
        public string TencentAddress{ get; set; }

        /// <summary>
        /// 腾讯侧备用互联IP
        /// </summary>
        [JsonProperty("TencentBackupAddress")]
        public string TencentBackupAddress{ get; set; }

        /// <summary>
        /// 用户侧互联 IP
        /// </summary>
        [JsonProperty("CustomerAddress")]
        public string CustomerAddress{ get; set; }

        /// <summary>
        /// 专用通道名称
        /// </summary>
        [JsonProperty("DirectConnectTunnelName")]
        public string DirectConnectTunnelName{ get; set; }

        /// <summary>
        /// 专用通道创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 专用通道带宽值
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// 关联的网络自定义探测ID
        /// </summary>
        [JsonProperty("NetDetectId")]
        public string NetDetectId{ get; set; }

        /// <summary>
        /// BGP community开关
        /// </summary>
        [JsonProperty("EnableBGPCommunity")]
        public bool? EnableBGPCommunity{ get; set; }

        /// <summary>
        /// 是否为Nat通道
        /// </summary>
        [JsonProperty("NatType")]
        public long? NatType{ get; set; }

        /// <summary>
        /// VPC地域简码，如gz、cd
        /// </summary>
        [JsonProperty("VpcRegion")]
        public string VpcRegion{ get; set; }

        /// <summary>
        /// 是否开启BFD
        /// </summary>
        [JsonProperty("BfdEnable")]
        public long? BfdEnable{ get; set; }

        /// <summary>
        /// 是否开启NQA
        /// </summary>
        [JsonProperty("NqaEnable")]
        public long? NqaEnable{ get; set; }

        /// <summary>
        /// 专用通道接入点类型
        /// </summary>
        [JsonProperty("AccessPointType")]
        public string AccessPointType{ get; set; }

        /// <summary>
        /// 专线网关名称
        /// </summary>
        [JsonProperty("DirectConnectGatewayName")]
        public string DirectConnectGatewayName{ get; set; }

        /// <summary>
        /// VPC名称
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// 专用通道关联的物理专线是否签署了用户协议
        /// </summary>
        [JsonProperty("SignLaw")]
        public bool? SignLaw{ get; set; }

        /// <summary>
        /// BFD配置信息
        /// </summary>
        [JsonProperty("BfdInfo")]
        public BFDInfo BfdInfo{ get; set; }

        /// <summary>
        /// NQA配置信息
        /// </summary>
        [JsonProperty("NqaInfo")]
        public NQAInfo NqaInfo{ get; set; }

        /// <summary>
        /// BGP状态
        /// </summary>
        [JsonProperty("BgpStatus")]
        public BGPStatus BgpStatus{ get; set; }

        /// <summary>
        /// 是否开启IPv6
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IPv6Enable")]
        public long? IPv6Enable{ get; set; }

        /// <summary>
        /// 腾讯侧互联IPv6地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TencentIPv6Address")]
        public string TencentIPv6Address{ get; set; }

        /// <summary>
        /// 腾讯侧备用互联IPv6地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TencentBackupIPv6Address")]
        public string TencentBackupIPv6Address{ get; set; }

        /// <summary>
        /// BGPv6状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BgpIPv6Status")]
        public BGPStatus BgpIPv6Status{ get; set; }

        /// <summary>
        /// 用户侧互联IPv6地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomerIPv6Address")]
        public string CustomerIPv6Address{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DirectConnectTunnelId", this.DirectConnectTunnelId);
            this.SetParamSimple(map, prefix + "DirectConnectId", this.DirectConnectId);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "DirectConnectOwnerAccount", this.DirectConnectOwnerAccount);
            this.SetParamSimple(map, prefix + "OwnerAccount", this.OwnerAccount);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "NetworkRegion", this.NetworkRegion);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "DirectConnectGatewayId", this.DirectConnectGatewayId);
            this.SetParamSimple(map, prefix + "RouteType", this.RouteType);
            this.SetParamObj(map, prefix + "BgpPeer.", this.BgpPeer);
            this.SetParamArrayObj(map, prefix + "RouteFilterPrefixes.", this.RouteFilterPrefixes);
            this.SetParamArrayObj(map, prefix + "PublicAddresses.", this.PublicAddresses);
            this.SetParamSimple(map, prefix + "Vlan", this.Vlan);
            this.SetParamSimple(map, prefix + "TencentAddress", this.TencentAddress);
            this.SetParamSimple(map, prefix + "TencentBackupAddress", this.TencentBackupAddress);
            this.SetParamSimple(map, prefix + "CustomerAddress", this.CustomerAddress);
            this.SetParamSimple(map, prefix + "DirectConnectTunnelName", this.DirectConnectTunnelName);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "NetDetectId", this.NetDetectId);
            this.SetParamSimple(map, prefix + "EnableBGPCommunity", this.EnableBGPCommunity);
            this.SetParamSimple(map, prefix + "NatType", this.NatType);
            this.SetParamSimple(map, prefix + "VpcRegion", this.VpcRegion);
            this.SetParamSimple(map, prefix + "BfdEnable", this.BfdEnable);
            this.SetParamSimple(map, prefix + "NqaEnable", this.NqaEnable);
            this.SetParamSimple(map, prefix + "AccessPointType", this.AccessPointType);
            this.SetParamSimple(map, prefix + "DirectConnectGatewayName", this.DirectConnectGatewayName);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "SignLaw", this.SignLaw);
            this.SetParamObj(map, prefix + "BfdInfo.", this.BfdInfo);
            this.SetParamObj(map, prefix + "NqaInfo.", this.NqaInfo);
            this.SetParamObj(map, prefix + "BgpStatus.", this.BgpStatus);
            this.SetParamSimple(map, prefix + "IPv6Enable", this.IPv6Enable);
            this.SetParamSimple(map, prefix + "TencentIPv6Address", this.TencentIPv6Address);
            this.SetParamSimple(map, prefix + "TencentBackupIPv6Address", this.TencentBackupIPv6Address);
            this.SetParamObj(map, prefix + "BgpIPv6Status.", this.BgpIPv6Status);
            this.SetParamSimple(map, prefix + "CustomerIPv6Address", this.CustomerIPv6Address);
        }
    }
}

