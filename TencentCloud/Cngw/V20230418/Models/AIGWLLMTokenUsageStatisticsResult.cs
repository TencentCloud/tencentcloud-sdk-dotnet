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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIGWLLMTokenUsageStatisticsResult : AbstractModel
    {
        
        /// <summary>
        /// <p>查询时间范围内请求总数</p>
        /// </summary>
        [JsonProperty("TotalRequestCount")]
        public long? TotalRequestCount{ get; set; }

        /// <summary>
        /// <p>查询时间范围内总输入Token数（包含命中缓存的Token数）</p>
        /// </summary>
        [JsonProperty("TotalInputTokens")]
        public long? TotalInputTokens{ get; set; }

        /// <summary>
        /// <p>查询时间范围内总输出Token数</p>
        /// </summary>
        [JsonProperty("TotalOutputTokens")]
        public long? TotalOutputTokens{ get; set; }

        /// <summary>
        /// <p>查询时间范围内总命中缓存输入Token数</p>
        /// </summary>
        [JsonProperty("TotalCachedReadInputTokens")]
        public long? TotalCachedReadInputTokens{ get; set; }

        /// <summary>
        /// <p>查询时间范围内总成本</p>
        /// </summary>
        [JsonProperty("TotalCost")]
        public string TotalCost{ get; set; }

        /// <summary>
        /// <p>成本货币单位</p>
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// <p>查询时间范围内成本最高的消费者</p>
        /// </summary>
        [JsonProperty("TopConsumers")]
        public AIGWTopConsumersItem[] TopConsumers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalRequestCount", this.TotalRequestCount);
            this.SetParamSimple(map, prefix + "TotalInputTokens", this.TotalInputTokens);
            this.SetParamSimple(map, prefix + "TotalOutputTokens", this.TotalOutputTokens);
            this.SetParamSimple(map, prefix + "TotalCachedReadInputTokens", this.TotalCachedReadInputTokens);
            this.SetParamSimple(map, prefix + "TotalCost", this.TotalCost);
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
            this.SetParamArrayObj(map, prefix + "TopConsumers.", this.TopConsumers);
        }
    }
}

