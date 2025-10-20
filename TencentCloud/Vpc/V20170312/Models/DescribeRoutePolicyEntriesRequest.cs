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

    public class DescribeRoutePolicyEntriesRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件，参数不支持同时指定RoutePolicyEntryIds和Filters。
        /// <li>route-policy-id - String - （过滤条件）路由接收策略实例ID，形如：rrp-f49l6u0z。</li>
        /// <li>cidr-block - String - （过滤条件）CIDR(只取掩码前的子网部分)，形如：10.0.0.0/8。</li>
        /// <li>priority - Integer - （过滤条件）优先级，形如：20。</li>
        /// <li>gateway-type - String - （过滤条件）下一跳类型，形如：CVM。</li>
        /// <li>gateway-id - String - （过滤条件）下一跳实例唯一ID，形如：ccn-f49l6u0z。</li>
        /// <li>route-type - String - （过滤条件）路由类型，取值：USER（用户路由），NETD（网络探测下发的路由），CCN（云联网路由）。</li>
        /// <li>action - String - （过滤条件）动作，取值：DROP（丢弃），DISABLE（接收且禁用），ACCEPT（接收且启用）。</li>
        /// <li>description - String - （过滤条件）描述，形如：TEST。</li>
        /// <li>route-policy-item-id - String - （过滤条件）路由接收策略条目唯一ID，形如：rrpi-dq782kw7。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 请求对象个数。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 排序字段。当前只支持优先级Prioriry字段。
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// 排序方向。
        /// ASC：升序。
        /// DESC：降序。
        /// </summary>
        [JsonProperty("OrderDirection")]
        public string OrderDirection{ get; set; }

        /// <summary>
        /// 路由策略条目ID。
        /// </summary>
        [JsonProperty("RoutePolicyEntryIds")]
        public string[] RoutePolicyEntryIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
            this.SetParamArraySimple(map, prefix + "RoutePolicyEntryIds.", this.RoutePolicyEntryIds);
        }
    }
}

