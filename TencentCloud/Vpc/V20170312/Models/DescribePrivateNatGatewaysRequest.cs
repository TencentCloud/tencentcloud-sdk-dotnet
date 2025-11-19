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

    public class DescribePrivateNatGatewaysRequest : AbstractModel
    {
        
        /// <summary>
        /// 私网网关唯一`ID`，形如：`intranat-0g3blj80`。
        /// 注意：NatGatewayIds和Filters参数互斥，不能同时传入。
        /// </summary>
        [JsonProperty("NatGatewayIds")]
        public string[] NatGatewayIds{ get; set; }

        /// <summary>
        /// 过滤条件。<li>NatGatewayId - String - 私网网关唯一`ID`，形如：`intranat-0g3blj80`。</li><li>NatGatewayName - String - 专线网关名称，默认模糊查询。</li><li>VpcId - String - 私网网关所在`VpcId`。</li><li>TagKey - Tag数组 - 私网网关标签键值对数组</li><li>intranat-status - String - （过滤条件）NAT实例当前状态，形如：`AVAILABLE`。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 排序字段。可选值：NatGatewayId、NatGatewayName、CreatedTime。
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// 排序方式。可选值：ASC、DESC。分别表示升序、降序。
        /// </summary>
        [JsonProperty("OrderDirection")]
        public string OrderDirection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "NatGatewayIds.", this.NatGatewayIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
        }
    }
}

