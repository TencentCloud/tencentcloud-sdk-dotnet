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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Route : AbstractModel
    {
        
        /// <summary>
        /// 创建IPv4目的网段，取值不能在私有网络网段内，例如：112.20.51.0/24。
        /// </summary>
        [JsonProperty("DestinationCidrBlock")]
        public string DestinationCidrBlock{ get; set; }

        /// <summary>
        /// 下一跳类型，目前我们支持的类型有：
        /// CVM：公网网关类型的云服务器；
        /// VPN：VPN网关；
        /// DIRECTCONNECT：专线网关；
        /// PEERCONNECTION：对等连接；
        /// HAVIP：高可用虚拟IP；
        /// NAT：公网NAT网关; 
        /// NORMAL_CVM：普通云服务器；
        /// EIP：云服务器的公网IP；
        /// LOCAL_GATEWAY：CDC本地网关；
        /// INTRANAT：私网NAT网关；
        /// USER_CCN：云联网（自定义路由）；
        /// GWLB_ENDPOINT：网关负载均衡终端节点。
        /// </summary>
        [JsonProperty("GatewayType")]
        public string GatewayType{ get; set; }

        /// <summary>
        /// 下一跳地址，这里只需要指定不同下一跳类型的网关ID，系统会自动匹配到下一跳地址。
        /// 特殊说明：
        /// GatewayType为NORMAL_CVM时，GatewayId填写实例的内网IP。
        /// GatewayType为EIP时，GatewayId填写0。
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// 路由策略ID。IPv4路由策略ID是有意义的值，IPv6路由策略是无意义的值0。后续建议完全使用字符串唯一ID `RouteItemId`操作路由策略。
        /// 该字段在删除时必填，其他字段无需填写。
        /// </summary>
        [JsonProperty("RouteId")]
        public ulong? RouteId{ get; set; }

        /// <summary>
        /// 路由策略描述。
        /// </summary>
        [JsonProperty("RouteDescription")]
        public string RouteDescription{ get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// 路由类型，目前我们支持的类型有：
        /// USER：用户路由；
        /// NETD：网络探测路由，创建网络探测实例时，系统默认下发，不可编辑与删除；
        /// CCN：云联网路由，系统默认下发，不可编辑与删除。
        /// 用户只能添加和操作 USER 类型的路由。
        /// </summary>
        [JsonProperty("RouteType")]
        public string RouteType{ get; set; }

        /// <summary>
        /// 路由表实例ID，例如：rtb-azd4dt1c。
        /// </summary>
        [JsonProperty("RouteTableId")]
        public string RouteTableId{ get; set; }

        /// <summary>
        /// 创建IPv6目的网段，取值不能在私有网络网段内，例如：2402:4e00:1000:810b::/64。
        /// </summary>
        [JsonProperty("DestinationIpv6CidrBlock")]
        public string DestinationIpv6CidrBlock{ get; set; }

        /// <summary>
        /// 路由唯一策略ID。
        /// </summary>
        [JsonProperty("RouteItemId")]
        public string RouteItemId{ get; set; }

        /// <summary>
        /// 路由策略是否发布到云联网。该字段仅做出参使用，作为入参字段时此参数不生效。
        /// </summary>
        [JsonProperty("PublishedToVbc")]
        public bool? PublishedToVbc{ get; set; }

        /// <summary>
        /// 路由策略创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// CDC 集群唯一 ID。
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DestinationCidrBlock", this.DestinationCidrBlock);
            this.SetParamSimple(map, prefix + "GatewayType", this.GatewayType);
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "RouteId", this.RouteId);
            this.SetParamSimple(map, prefix + "RouteDescription", this.RouteDescription);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "RouteType", this.RouteType);
            this.SetParamSimple(map, prefix + "RouteTableId", this.RouteTableId);
            this.SetParamSimple(map, prefix + "DestinationIpv6CidrBlock", this.DestinationIpv6CidrBlock);
            this.SetParamSimple(map, prefix + "RouteItemId", this.RouteItemId);
            this.SetParamSimple(map, prefix + "PublishedToVbc", this.PublishedToVbc);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
        }
    }
}

