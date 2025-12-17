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

    public class DescribeRoutePoliciesRequest : AbstractModel
    {
        
        /// <summary>
        /// 路由策略实例唯一ID。形如：rrp-q7ywkx31。每次请求的实例的上限为100。参数不支持同时指定RoutePolicyIds和Filters。
        /// </summary>
        [JsonProperty("RoutePolicyIds")]
        public string[] RoutePolicyIds{ get; set; }

        /// <summary>
        /// 过滤条件，不支持同时指定RoutePolicyIds和Filters参数。
        /// 支持的过滤条件如下：
        /// <li>route-policy-name：路由策略实例名称，支持模糊查询。</li>
        /// <li>route-policy-description：路由策略实例描述，支持模糊查询。</li>
        /// <li>route-policy-id ：路由策略实例ID，例如：rrp-q7ywkx3w。</li>
        /// 
        ///   **说明：**若同一个过滤条件（Filter）存在多个Values，则同一Filter下Values间的关系为逻辑或（OR）关系；若存在多个过滤条件（Filter），Filter之间的关系为逻辑与（AND）关系。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public string Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public string Limit{ get; set; }

        /// <summary>
        /// 是否返回路由策略条目。默认为False。当该参数为False时，仍然会返回空的返回空的RoutePolicyEntrySet。
        /// </summary>
        [JsonProperty("NeedRoutePolicyEntry")]
        public bool? NeedRoutePolicyEntry{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "RoutePolicyIds.", this.RoutePolicyIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "NeedRoutePolicyEntry", this.NeedRoutePolicyEntry);
        }
    }
}

