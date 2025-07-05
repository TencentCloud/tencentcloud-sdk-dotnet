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

namespace TencentCloud.Dc.V20180410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDirectConnectTunnelRequest : AbstractModel
    {
        
        /// <summary>
        /// 物理专线ID，例如：dc-kd7d06of。
        /// </summary>
        [JsonProperty("DirectConnectId")]
        public string DirectConnectId{ get; set; }

        /// <summary>
        /// 专用通道名称。
        /// </summary>
        [JsonProperty("DirectConnectTunnelName")]
        public string DirectConnectTunnelName{ get; set; }

        /// <summary>
        /// 物理专线owner，缺省为当前客户（物理专线 owner）
        /// 共享专线时这里需要填写共享专线的开发商账号 ID。
        /// </summary>
        [JsonProperty("DirectConnectOwnerAccount")]
        public string DirectConnectOwnerAccount{ get; set; }

        /// <summary>
        /// 网络类型，枚举：VPC、CCN、NAT；默认为VPC。VPC：私有网络；CCN：云联网；NAT：NAT网络）。
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// 网络地域。
        /// </summary>
        [JsonProperty("NetworkRegion")]
        public string NetworkRegion{ get; set; }

        /// <summary>
        /// 私有网络统一ID，在NetworkType为VPC时必填，且与专线网关所属的VPCID一致；NetworkType为其它组网类型时可不填，内部会统一处理。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 专线网关ID，例如 dcg-d545ddf。
        /// </summary>
        [JsonProperty("DirectConnectGatewayId")]
        public string DirectConnectGatewayId{ get; set; }

        /// <summary>
        /// 专线带宽，单位：Mbps；默认是物理专线带宽值。
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// 路由类型，枚举：BGP、STATIC；默认为BGP 。（BGP ：BGP路由；STATIC：静态）。
        /// </summary>
        [JsonProperty("RouteType")]
        public string RouteType{ get; set; }

        /// <summary>
        /// BgpPeer，用户侧bgp信息，包括Asn和AuthKey。
        /// </summary>
        [JsonProperty("BgpPeer")]
        public BgpPeer BgpPeer{ get; set; }

        /// <summary>
        /// 静态路由，用户IDC的网段地址。
        /// </summary>
        [JsonProperty("RouteFilterPrefixes")]
        public RouteFilterPrefix[] RouteFilterPrefixes{ get; set; }

        /// <summary>
        /// vlan，范围：0 ~ 3000。
        /// 0：不开启子接口，默认值是非0。
        /// </summary>
        [JsonProperty("Vlan")]
        public long? Vlan{ get; set; }

        /// <summary>
        /// TencentAddress，腾讯侧互联 IP。
        /// </summary>
        [JsonProperty("TencentAddress")]
        public string TencentAddress{ get; set; }

        /// <summary>
        /// CustomerAddress，用户侧互联 IP。
        /// </summary>
        [JsonProperty("CustomerAddress")]
        public string CustomerAddress{ get; set; }

        /// <summary>
        /// TencentBackupAddress，腾讯侧备用互联 IP。
        /// </summary>
        [JsonProperty("TencentBackupAddress")]
        public string TencentBackupAddress{ get; set; }

        /// <summary>
        /// 高速上云服务ID。
        /// </summary>
        [JsonProperty("CloudAttachId")]
        public string CloudAttachId{ get; set; }

        /// <summary>
        /// 是否开启BFD。
        /// </summary>
        [JsonProperty("BfdEnable")]
        public long? BfdEnable{ get; set; }

        /// <summary>
        /// 是否开启NQA。
        /// </summary>
        [JsonProperty("NqaEnable")]
        public long? NqaEnable{ get; set; }

        /// <summary>
        /// BFD配置信息。
        /// </summary>
        [JsonProperty("BfdInfo")]
        public BFDInfo BfdInfo{ get; set; }

        /// <summary>
        /// NQA配置信息。
        /// </summary>
        [JsonProperty("NqaInfo")]
        public NQAInfo NqaInfo{ get; set; }

        /// <summary>
        /// 标签键值对
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DirectConnectId", this.DirectConnectId);
            this.SetParamSimple(map, prefix + "DirectConnectTunnelName", this.DirectConnectTunnelName);
            this.SetParamSimple(map, prefix + "DirectConnectOwnerAccount", this.DirectConnectOwnerAccount);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "NetworkRegion", this.NetworkRegion);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "DirectConnectGatewayId", this.DirectConnectGatewayId);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "RouteType", this.RouteType);
            this.SetParamObj(map, prefix + "BgpPeer.", this.BgpPeer);
            this.SetParamArrayObj(map, prefix + "RouteFilterPrefixes.", this.RouteFilterPrefixes);
            this.SetParamSimple(map, prefix + "Vlan", this.Vlan);
            this.SetParamSimple(map, prefix + "TencentAddress", this.TencentAddress);
            this.SetParamSimple(map, prefix + "CustomerAddress", this.CustomerAddress);
            this.SetParamSimple(map, prefix + "TencentBackupAddress", this.TencentBackupAddress);
            this.SetParamSimple(map, prefix + "CloudAttachId", this.CloudAttachId);
            this.SetParamSimple(map, prefix + "BfdEnable", this.BfdEnable);
            this.SetParamSimple(map, prefix + "NqaEnable", this.NqaEnable);
            this.SetParamObj(map, prefix + "BfdInfo.", this.BfdInfo);
            this.SetParamObj(map, prefix + "NqaInfo.", this.NqaInfo);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

