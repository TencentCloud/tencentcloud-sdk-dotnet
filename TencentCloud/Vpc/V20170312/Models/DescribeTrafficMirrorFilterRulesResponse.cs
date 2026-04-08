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

    public class DescribeTrafficMirrorFilterRulesResponse : AbstractModel
    {
        
        /// <summary>
        /// 流量镜像实例唯一ID。
        /// </summary>
        [JsonProperty("TrafficMirrorId")]
        public string TrafficMirrorId{ get; set; }

        /// <summary>
        /// 流量镜像入站过滤规则。
        /// </summary>
        [JsonProperty("IngressFilterRules")]
        public TrafficMirrorFilter[] IngressFilterRules{ get; set; }

        /// <summary>
        /// 流量镜像出站过滤规则。
        /// </summary>
        [JsonProperty("EgressFilterRules")]
        public TrafficMirrorFilter[] EgressFilterRules{ get; set; }

        /// <summary>
        /// 符合条件的实例数量。分页查询的时候，如果IngressFilterRules的长度加上IngressFilterRules的长度，小于limit的时候表示已经查询完毕。
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TrafficMirrorId", this.TrafficMirrorId);
            this.SetParamArrayObj(map, prefix + "IngressFilterRules.", this.IngressFilterRules);
            this.SetParamArrayObj(map, prefix + "EgressFilterRules.", this.EgressFilterRules);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

