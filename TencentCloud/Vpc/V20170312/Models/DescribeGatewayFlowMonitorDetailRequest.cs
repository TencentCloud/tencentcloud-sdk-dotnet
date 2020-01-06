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

    public class DescribeGatewayFlowMonitorDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// 时间点。表示要查询这分钟内的明细。如：`2019-02-28 18:15:20`，将查询 `18:15` 这一分钟内的明细。
        /// </summary>
        [JsonProperty("TimePoint")]
        public string TimePoint{ get; set; }

        /// <summary>
        /// VPN网关实例ID，形如：`vpn-ltjahce6`。
        /// </summary>
        [JsonProperty("VpnId")]
        public string VpnId{ get; set; }

        /// <summary>
        /// 专线网关实例ID，形如：`dcg-ltjahce6`。
        /// </summary>
        [JsonProperty("DirectConnectGatewayId")]
        public string DirectConnectGatewayId{ get; set; }

        /// <summary>
        /// 对等连接实例ID，形如：`pcx-ltjahce6`。
        /// </summary>
        [JsonProperty("PeeringConnectionId")]
        public string PeeringConnectionId{ get; set; }

        /// <summary>
        /// NAT网关实例ID，形如：`nat-ltjahce6`。
        /// </summary>
        [JsonProperty("NatId")]
        public string NatId{ get; set; }

        /// <summary>
        /// 偏移量。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回数量。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 排序字段。支持 `InPkg` `OutPkg` `InTraffic` `OutTraffic`。
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// 排序方法。顺序：`ASC`，倒序：`DESC`。
        /// </summary>
        [JsonProperty("OrderDirection")]
        public string OrderDirection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimePoint", this.TimePoint);
            this.SetParamSimple(map, prefix + "VpnId", this.VpnId);
            this.SetParamSimple(map, prefix + "DirectConnectGatewayId", this.DirectConnectGatewayId);
            this.SetParamSimple(map, prefix + "PeeringConnectionId", this.PeeringConnectionId);
            this.SetParamSimple(map, prefix + "NatId", this.NatId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
        }
    }
}

