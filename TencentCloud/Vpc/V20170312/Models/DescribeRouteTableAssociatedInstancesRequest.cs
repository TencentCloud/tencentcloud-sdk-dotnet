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

    public class DescribeRouteTableAssociatedInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件：
        /// <li>ccn-id - String -（过滤条件）CCN实例ID。</li>
        /// <li>ccn-route-table-id - String -（过滤条件）路由表ID。</li>
        /// <li>instance-type - String -（过滤条件）实例类型：
        /// 私有网络: `VPC`
        /// 专线网关: `DIRECTCONNECT`
        /// 黑石私有网络: `BMVPC`
        /// EDGE设备: `EDGE`
        /// EDGE隧道: `EDGE_TUNNEL`
        /// EDGE网关: `EDGE_VPNGW`
        /// VPN网关：`VPNGW`</li>
        /// <li>instance-id- String -（过滤条件）实例ID。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 一次查询最大返回的数量。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

