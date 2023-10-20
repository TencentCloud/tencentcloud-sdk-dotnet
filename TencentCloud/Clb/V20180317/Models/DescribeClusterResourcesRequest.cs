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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClusterResourcesRequest : AbstractModel
    {
        
        /// <summary>
        /// 返回集群中资源列表数目，默认为20，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 返回集群中资源列表起始偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 查询集群中资源列表条件，详细的过滤条件如下：
        /// <li> cluster-id - String - 是否必填：否 - （过滤条件）按照 集群 的唯一ID过滤，如 ："tgw-12345678","stgw-12345678","vpcgw-12345678"。</li>
        /// <li> vip - String - 是否必填：否 - （过滤条件）按照vip过滤。</li>
        /// <li> loadbalancer-id - String - 是否必填：否 - （过滤条件）按照负载均衡唯一ID过滤。</li>
        /// <li> idle - String 是否必填：否 - （过滤条件）按照是否闲置过滤，如"True","False"。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

