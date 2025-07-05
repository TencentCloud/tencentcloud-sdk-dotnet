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

    public class DescribeTrafficMirrorsRequest : AbstractModel
    {
        
        /// <summary>
        /// 流量镜像实例ID集合
        /// </summary>
        [JsonProperty("TrafficMirrorIds")]
        public string[] TrafficMirrorIds{ get; set; }

        /// <summary>
        /// 流量镜像查询过滤调节。
        /// vpc-id ：VPC实例ID，例如：vpc-f49l6u0z。
        /// traffic-mirror-id：流量镜像实例ID。
        /// traffic-mirror-name：流量镜像名称。
        /// tag-key ：按照标签键进行过滤。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter Filters{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TrafficMirrorIds.", this.TrafficMirrorIds);
            this.SetParamObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

