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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryDashboardOverviewResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>时间范围内所有服务的总 QPS（每秒请求数）均值</p><p>单位：请求每秒</p>
        /// </summary>
        [JsonProperty("TotalRequestsPerSecond")]
        public float? TotalRequestsPerSecond{ get; set; }

        /// <summary>
        /// <p>时间范围内全局 P99 延迟均值（毫秒）</p><p>单位：毫秒</p>
        /// </summary>
        [JsonProperty("AverageP99LatencyMs")]
        public float? AverageP99LatencyMs{ get; set; }

        /// <summary>
        /// <p>时间范围内全局错误率均值（0~1，如 0.02 表示 2%）</p><p>取值范围：[0, 1]</p>
        /// </summary>
        [JsonProperty("ErrorRate")]
        public float? ErrorRate{ get; set; }

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
            this.SetParamSimple(map, prefix + "TotalRequestsPerSecond", this.TotalRequestsPerSecond);
            this.SetParamSimple(map, prefix + "AverageP99LatencyMs", this.AverageP99LatencyMs);
            this.SetParamSimple(map, prefix + "ErrorRate", this.ErrorRate);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

