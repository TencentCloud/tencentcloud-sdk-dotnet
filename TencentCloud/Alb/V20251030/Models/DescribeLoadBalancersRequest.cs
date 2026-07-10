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
        /// 查询过滤条件，支持以下几个字段
        /// - **LoadBalancerId**: 负载均衡实例 ID
        /// - **LoadBalancerName**: 负载均衡名称
        /// - **LoadBalancerStatus**: 负载均衡状态
        /// - **VpcId**: 私有网络 ID
        /// - **tag:tag-key**：按标签键值对筛选，tag-key 请替换为实际的标签键。例如 `tag:env` 表示按标签键 `env` 筛选。
        /// - **AddressType**: 网络类型
        ///     - **Intranet**: 内网
        ///     - **Internet**: 公网 
        /// - **AddressIpVersion**:
        ///     - **IPv4**: IPv4 地址
        ///     - **IPv6** IPv6 地址
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 分批次查询时每次显示的条目数。取值范围：**1**~**100**，默认值：**20**。
        /// 
        /// </summary>
        [JsonProperty("MaxResults")]
        public long? MaxResults{ get; set; }

        /// <summary>
        /// 是否拥有下一次查询的令牌（Token）。取值：
        /// - 第一次查询和没有下一次查询时，均无需填写。
        /// - 如果有下一次查询，取值为上一次API调用返回的**NextToken**值。
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

