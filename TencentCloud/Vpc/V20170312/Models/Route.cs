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

    public class Route : AbstractModel
    {
        
        /// <summary>
        /// 目的网段，取值不能在私有网络网段内，例如：112.20.51.0/24。
        /// </summary>
        [JsonProperty("DestinationCidrBlock")]
        public string DestinationCidrBlock{ get; set; }

        /// <summary>
        /// 下一跳类型，目前我们支持的类型有：
        /// CVM：公网网关类型的云服务器；
        /// VPN：VPN网关；
        /// DIRECTCONNECT：专线网关；
        /// PEERCONNECTION：对等连接；
        /// SSLVPN：sslvpn网关；
        /// NAT：NAT网关; 
        /// NORMAL_CVM：普通云服务器；
        /// EIP：云服务器的公网IP；
        /// CCN：云联网。
        /// </summary>
        [JsonProperty("GatewayType")]
        public string GatewayType{ get; set; }

        /// <summary>
        /// 下一跳地址，这里只需要指定不同下一跳类型的网关ID，系统会自动匹配到下一跳地址。
        /// 特别注意：当 GatewayType 为 EIP 时，GatewayId 固定值 '0'
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// 路由策略ID。
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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DestinationCidrBlock", this.DestinationCidrBlock);
            this.SetParamSimple(map, prefix + "GatewayType", this.GatewayType);
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "RouteId", this.RouteId);
            this.SetParamSimple(map, prefix + "RouteDescription", this.RouteDescription);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "RouteType", this.RouteType);
        }
    }
}

