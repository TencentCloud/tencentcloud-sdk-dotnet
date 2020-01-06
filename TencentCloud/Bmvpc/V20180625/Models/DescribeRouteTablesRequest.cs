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

    public class DescribeRouteTablesRequest : AbstractModel
    {
        
        /// <summary>
        /// 路由表实例ID，例如：rtb-azd4dt1c。
        /// </summary>
        [JsonProperty("RouteTableIds")]
        public string[] RouteTableIds{ get; set; }

        /// <summary>
        /// 过滤条件，参数不支持同时指定RouteTableIds和Filters。
        /// route-table-id - String - （过滤条件）路由表实例ID。
        /// route-table-name - String - （过滤条件）路由表名称。
        /// route-table-id-like - String - （模糊过滤条件）路由表实例ID。
        /// route-table-name-like - String - （模糊过滤条件）路由表名称。
        /// vpc-id - String - （过滤条件）VPC实例ID，形如：vpc-f49l6u0z。
        /// zone - String - （过滤条件）可用区。
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
        /// 排序字段, 支持按“RouteTableId”，“VpcId”, "RouteTableName", "CreateTime"
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// 排序方向, “asc”、“desc”
        /// </summary>
        [JsonProperty("OrderDirection")]
        public string OrderDirection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "RouteTableIds.", this.RouteTableIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
        }
    }
}

