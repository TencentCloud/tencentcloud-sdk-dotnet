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

    public class DescribeGlobalRoutesRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件。
        /// <li>global-route-id - String - （过滤条件）如全局路由唯一 Id，形如：gr-bmenrwu2。</li>
        /// <li>vpc-id - String - （过滤条件）VPC唯一Id， 形如： vpc-mcqaoy0f。</li>
        /// <li>gateway-id - String - （过滤条件）下一跳对象。</li>
        /// <li>gateway-type - String -  是否必填：否 - （过滤条件）按下一跳类型进行过滤。支持 NORMAL_CVM
        /// </li>
        /// <li>cdc-id - String - （过滤条件）CDC实例ID，形如：cluster-gbo27yc4。</li>
        /// <li>description - String - （过滤条件）描述。</li>
        /// <li>dest-cidr - String - （过滤条件）Ipv4目标网段。</li>
        /// <li>subnet-route-algorithm - String - （过滤条件）支持的 ECMP算法有：
        /// 
        ///    - ECMP_QUINTUPLE_HASH：五元组hash
        ///    - ECMP_SOURCE_DESTINATION_IP_HASH：源和目的IP hash
        ///    - ECMP_DESTINATION_IP_HASH：目的IP hash
        ///    - ECMP_SOURCE_IP_HASH：源IP hash
        /// </li>
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
        /// 全局路由唯一Id列表。
        /// </summary>
        [JsonProperty("GlobalRouteIds")]
        public string[] GlobalRouteIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "GlobalRouteIds.", this.GlobalRouteIds);
        }
    }
}

