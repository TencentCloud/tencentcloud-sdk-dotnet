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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLoadBalancersRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>查询过滤条件，支持以下几个字段</p><ul><li><strong>LoadBalancerId</strong>: 负载均衡实例 ID</li><li><strong>LoadBalancerName</strong>: 负载均衡名称</li><li><strong>LoadBalancerStatus</strong>: 负载均衡状态</li><li><strong>VpcId</strong>: 私有网络 ID</li><li><strong>tag:tag-key</strong>：按标签键值对筛选，tag-key 请替换为实际的标签键。例如 <code>tag:env</code> 表示按标签键 <code>env</code> 筛选。</li><li><strong>AddressType</strong>: 网络类型<ul><li><strong>Intranet</strong>: 内网</li><li><strong>Internet</strong>: 公网 </li></ul></li><li><strong>AddressIpVersion</strong>:<ul><li><strong>IPv4</strong>: IPv4 地址</li><li><strong>IPv6</strong> IPv6 地址</li></ul></li><li><strong>SecurityGroupId</strong>: 安全组ID</li></ul>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>分批次查询时每次显示的条目数。取值范围：<strong>1</strong>~<strong>100</strong>，默认值：<strong>20</strong>。</p>
        /// </summary>
        [JsonProperty("MaxResults")]
        public long? MaxResults{ get; set; }

        /// <summary>
        /// <p>是否拥有下一次查询的令牌（Token）。取值：</p><ul><li>第一次查询和没有下一次查询时，均无需填写。</li><li>如果有下一次查询，取值为上一次API调用返回的<strong>NextToken</strong>值。</li></ul>
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
        }
    }
}

