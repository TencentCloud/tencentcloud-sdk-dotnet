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

    public class DescribeTrafficMirrorFilterRulesRequest : AbstractModel
    {
        
        /// <summary>
        /// 流量镜像唯一ID
        /// </summary>
        [JsonProperty("TrafficMirrorId")]
        public string TrafficMirrorId{ get; set; }

        /// <summary>
        /// 流量镜像出站、入站过滤唯一ID列表。
        /// </summary>
        [JsonProperty("TrafficMirrorFilterRuleIds")]
        public string[] TrafficMirrorFilterRuleIds{ get; set; }

        /// <summary>
        /// <li>traffic-mirror-filter-rule-id - String - （过滤条件） 流量镜像过滤规则，形如：tmfi-qfhrb7yj。 </li>
        /// <li>action - String - （过滤条件）策略， 支持类型： ACCEPT， DROP。 </li>
        /// <li>description - String - （过滤条件）描述。 </li>
        /// <li>direction - String - （过滤条件）方向, 支持类型：INGRESS， EGRESS。</li>
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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TrafficMirrorId", this.TrafficMirrorId);
            this.SetParamArraySimple(map, prefix + "TrafficMirrorFilterRuleIds.", this.TrafficMirrorFilterRuleIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

