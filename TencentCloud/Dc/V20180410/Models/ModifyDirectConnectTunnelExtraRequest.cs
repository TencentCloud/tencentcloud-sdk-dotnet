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

    public class ModifyDirectConnectTunnelExtraRequest : AbstractModel
    {
        
        /// <summary>
        /// 专用通道ID
        /// </summary>
        [JsonProperty("DirectConnectTunnelId")]
        public string DirectConnectTunnelId{ get; set; }

        /// <summary>
        /// 专用通道的Vlan
        /// </summary>
        [JsonProperty("Vlan")]
        public long? Vlan{ get; set; }

        /// <summary>
        /// 用户侧BGP，Asn，AuthKey
        /// </summary>
        [JsonProperty("BgpPeer")]
        public BgpPeer BgpPeer{ get; set; }

        /// <summary>
        /// 用户侧过滤网段地址
        /// </summary>
        [JsonProperty("RouteFilterPrefixes")]
        public RouteFilterPrefix RouteFilterPrefixes{ get; set; }

        /// <summary>
        /// 腾讯侧互联IP
        /// </summary>
        [JsonProperty("TencentAddress")]
        public string TencentAddress{ get; set; }

        /// <summary>
        /// 腾讯侧备用互联IP
        /// </summary>
        [JsonProperty("TencentBackupAddress")]
        public string TencentBackupAddress{ get; set; }

        /// <summary>
        /// 用户侧互联IP
        /// </summary>
        [JsonProperty("CustomerAddress")]
        public string CustomerAddress{ get; set; }

        /// <summary>
        /// 专用通道带宽值
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// BGP community开关
        /// </summary>
        [JsonProperty("EnableBGPCommunity")]
        public bool? EnableBGPCommunity{ get; set; }

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
        /// 0：停用IPv6
        /// 1: 启用IPv6
        /// </summary>
        [JsonProperty("IPv6Enable")]
        public long? IPv6Enable{ get; set; }

        /// <summary>
        /// 去往用户侧的路由信息
        /// </summary>
        [JsonProperty("CustomerIDCRoutes")]
        public RouteFilterPrefix[] CustomerIDCRoutes{ get; set; }

        /// <summary>
        /// 是否开启巨帧
        /// 1：开启
        /// 0：不开启
        /// </summary>
        [JsonProperty("JumboEnable")]
        public long? JumboEnable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DirectConnectTunnelId", this.DirectConnectTunnelId);
            this.SetParamSimple(map, prefix + "Vlan", this.Vlan);
            this.SetParamObj(map, prefix + "BgpPeer.", this.BgpPeer);
            this.SetParamObj(map, prefix + "RouteFilterPrefixes.", this.RouteFilterPrefixes);
            this.SetParamSimple(map, prefix + "TencentAddress", this.TencentAddress);
            this.SetParamSimple(map, prefix + "TencentBackupAddress", this.TencentBackupAddress);
            this.SetParamSimple(map, prefix + "CustomerAddress", this.CustomerAddress);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "EnableBGPCommunity", this.EnableBGPCommunity);
            this.SetParamSimple(map, prefix + "BfdEnable", this.BfdEnable);
            this.SetParamSimple(map, prefix + "NqaEnable", this.NqaEnable);
            this.SetParamObj(map, prefix + "BfdInfo.", this.BfdInfo);
            this.SetParamObj(map, prefix + "NqaInfo.", this.NqaInfo);
            this.SetParamSimple(map, prefix + "IPv6Enable", this.IPv6Enable);
            this.SetParamArrayObj(map, prefix + "CustomerIDCRoutes.", this.CustomerIDCRoutes);
            this.SetParamSimple(map, prefix + "JumboEnable", this.JumboEnable);
        }
    }
}

