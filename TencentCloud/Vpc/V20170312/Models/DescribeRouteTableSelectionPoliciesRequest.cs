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

    public class DescribeRouteTableSelectionPoliciesRequest : AbstractModel
    {
        
        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回数量
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 过滤条件：
        /// <li>ccn-id - String -（过滤条件）CCN实例ID。</li>
        /// <li>instance-type - String -（过滤条件）关联实例类型:
        /// 私有网络: `VPC`
        /// 专线网关: `DIRECTCONNECT`
        /// 黑石私有网络: `BMVPC`
        /// EDGE设备: `EDGE`
        /// EDGE隧道: `EDGE_TUNNEL`
        /// EDGE网关: `EDGE_VPNGW`
        /// VPN网关：`VPNGW`</li>
        /// <li>ccn-route-table-id - String -（过滤条件）路由表ID。</li>
        /// <li>instance-id - String -（过滤条件）关联的实例ID。</li>
        /// <li>route-table-name - String -（过滤条件）路由表名称。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

