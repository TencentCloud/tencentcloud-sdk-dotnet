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

    public class DescribeRoutePoliciesRequest : AbstractModel
    {
        
        /// <summary>
        /// 路由表实例ID，例如：rtb-afg8md3c。
        /// </summary>
        [JsonProperty("RouteTableId")]
        public string RouteTableId{ get; set; }

        /// <summary>
        /// 路由策略实例ID，例如：rti-azd4dt1c。
        /// </summary>
        [JsonProperty("RoutePolicyIds")]
        public string[] RoutePolicyIds{ get; set; }

        /// <summary>
        /// 过滤条件，参数不支持同时指定RoutePolicyIds和Filters。
        /// route-table-id - String - （过滤条件）路由表实例ID。
        /// vpc-id - String - （过滤条件）VPC实例ID，形如：vpc-f49l6u0z。
        /// route-policy-id - String - （过滤条件）路由策略ID。
        /// route-policy-description-like - String -（过滤条件）路由项备注。
        /// route-policy-type - String - （过滤条件）路由项策略类型。
        /// destination-cidr-like - String - （过滤条件）路由项目的地址。
        /// gateway-id-like - String - （过滤条件）路由项下一跳网关。
        /// gateway-type - String - （过滤条件）路由项下一条网关类型。
        /// enable - Bool - （过滤条件）路由策略是否启用。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 初始行的偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 每页行数，默认为20。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RouteTableId", this.RouteTableId);
            this.SetParamArraySimple(map, prefix + "RoutePolicyIds.", this.RoutePolicyIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

