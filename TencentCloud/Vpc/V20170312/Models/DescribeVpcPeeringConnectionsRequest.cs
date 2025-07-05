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

    public class DescribeVpcPeeringConnectionsRequest : AbstractModel
    {
        
        /// <summary>
        /// 对等连接唯一ID数组。
        /// </summary>
        [JsonProperty("PeeringConnectionIds")]
        public string[] PeeringConnectionIds{ get; set; }

        /// <summary>
        /// 过滤条件，参数不支持同时指定PeeringConnectionIds和Filters。
        /// <li>vpc-id - String - （过滤条件）VPC实例ID，形如：vpc-f49l6u0z。</li>
        /// <li>state String - （过滤条件）对等连接状态，可选值有：PENDING，投放中；ACTIVE，使用中；EXPIRED，已过期；REJECTED，拒绝。</li>
        /// <li>peering-connection-name - String - （过滤条件）对等连接名称。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 请求对象个数。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 排序字段，可选值有：CreatedTime，PeeringConnectionName。
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// 排序方式：DESC，降序；ASC，升序。
        /// </summary>
        [JsonProperty("OrderDirection")]
        public string OrderDirection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "PeeringConnectionIds.", this.PeeringConnectionIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
        }
    }
}

