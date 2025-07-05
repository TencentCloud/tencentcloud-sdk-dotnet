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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLoadBalancerOverviewResponse : AbstractModel
    {
        
        /// <summary>
        /// 负载均衡总数
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// 运行中的负载均衡数目
        /// </summary>
        [JsonProperty("RunningCount")]
        public long? RunningCount{ get; set; }

        /// <summary>
        /// 隔离中的负载均衡数目
        /// </summary>
        [JsonProperty("IsolationCount")]
        public long? IsolationCount{ get; set; }

        /// <summary>
        /// 即将到期的负载均衡数目
        /// </summary>
        [JsonProperty("WillExpireCount")]
        public long? WillExpireCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "RunningCount", this.RunningCount);
            this.SetParamSimple(map, prefix + "IsolationCount", this.IsolationCount);
            this.SetParamSimple(map, prefix + "WillExpireCount", this.WillExpireCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

