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

namespace TencentCloud.Gwlb.V20240906.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeGatewayLoadBalancersRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>网关负载均衡实例ID。支持批量筛选的实例ID数量上限为20个。</p>
        /// </summary>
        [JsonProperty("LoadBalancerIds")]
        public string[] LoadBalancerIds{ get; set; }

        /// <summary>
        /// <p>一次批量返回网关负载均衡实例的数量，默认为20，最大值为100。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>返回网关负载均衡实例列表的起始偏移量，默认0。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>查询负载均衡详细信息列表的过滤条件，每次请求的Filters的上限为10，Filter.Values的上限为100。Filter.Name和Filter.Values皆为必填项。详细的过滤条件如下：- VpcId - String - 是否必填：否 - （过滤条件）按照网关负载均衡实例所属的私有网络过滤，如“vpc-bhqk****”。- Vips - String  - 是否必填：否 - （过滤条件）按照网关负载均衡实例的VIP进行过滤，如“10.1.1.1”- tag:tag-key - String - 是否必填：否 - （过滤条件）按照GWLB标签键值对进行过滤，tag-key使用具体的标签键进行替换。</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>搜索字段，模糊匹配名称、VIP。</p>
        /// </summary>
        [JsonProperty("SearchKey")]
        public string SearchKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "LoadBalancerIds.", this.LoadBalancerIds);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "SearchKey", this.SearchKey);
        }
    }
}

