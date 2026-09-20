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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAppStatisticsOverviewResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>首 tokens 平均耗时（毫秒）</p>
        /// </summary>
        [JsonProperty("AvgFirstTokenTime")]
        public string AvgFirstTokenTime{ get; set; }

        /// <summary>
        /// <p>总 tokens 平均耗时（毫秒）</p>
        /// </summary>
        [JsonProperty("AvgTotalTokenTime")]
        public string AvgTotalTokenTime{ get; set; }

        /// <summary>
        /// <p>应用调用成功率（百分比，0~100）</p>
        /// </summary>
        [JsonProperty("CallSuccessRate")]
        public float? CallSuccessRate{ get; set; }

        /// <summary>
        /// <p>回复类型分布列表；按 app_type 统计，已补全所有回复方式并按固定顺序返回，无数据的回复方式 call_count 为 0</p>
        /// </summary>
        [JsonProperty("ReplyTypeDistributionList")]
        public Distribution[] ReplyTypeDistributionList{ get; set; }

        /// <summary>
        /// <p>总调用次数</p>
        /// </summary>
        [JsonProperty("TotalCallCount")]
        public string TotalCallCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "AvgFirstTokenTime", this.AvgFirstTokenTime);
            this.SetParamSimple(map, prefix + "AvgTotalTokenTime", this.AvgTotalTokenTime);
            this.SetParamSimple(map, prefix + "CallSuccessRate", this.CallSuccessRate);
            this.SetParamArrayObj(map, prefix + "ReplyTypeDistributionList.", this.ReplyTypeDistributionList);
            this.SetParamSimple(map, prefix + "TotalCallCount", this.TotalCallCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

