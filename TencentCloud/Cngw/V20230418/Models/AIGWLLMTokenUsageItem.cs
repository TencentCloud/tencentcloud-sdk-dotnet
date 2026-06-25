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

    public class AIGWLLMTokenUsageItem : AbstractModel
    {
        
        /// <summary>
        /// <p>消费者Id</p>
        /// </summary>
        [JsonProperty("ConsumerId")]
        public string ConsumerId{ get; set; }

        /// <summary>
        /// <p>消费者名称</p>
        /// </summary>
        [JsonProperty("ConsumerName")]
        public string ConsumerName{ get; set; }

        /// <summary>
        /// <p>消费者组信息列表</p>
        /// </summary>
        [JsonProperty("ConsumerGroups")]
        public AIGWConsumerGroupBrief[] ConsumerGroups{ get; set; }

        /// <summary>
        /// <p>模型服务Id</p>
        /// </summary>
        [JsonProperty("ModelServiceId")]
        public string ModelServiceId{ get; set; }

        /// <summary>
        /// <p>模型服务名称</p>
        /// </summary>
        [JsonProperty("ModelServiceName")]
        public string ModelServiceName{ get; set; }

        /// <summary>
        /// <p>输入Token数（包含缓存命中Token数）</p>
        /// </summary>
        [JsonProperty("InputTokens")]
        public long? InputTokens{ get; set; }

        /// <summary>
        /// <p>命中缓存输入Token数</p>
        /// </summary>
        [JsonProperty("CacheReadInputTokens")]
        public long? CacheReadInputTokens{ get; set; }

        /// <summary>
        /// <p>输出Token数</p>
        /// </summary>
        [JsonProperty("OutputTokens")]
        public long? OutputTokens{ get; set; }

        /// <summary>
        /// <p>消耗总Token数</p>
        /// </summary>
        [JsonProperty("TotalTokens")]
        public long? TotalTokens{ get; set; }

        /// <summary>
        /// <p>请求总数</p>
        /// </summary>
        [JsonProperty("RequestCount")]
        public long? RequestCount{ get; set; }

        /// <summary>
        /// <p>花费成本</p>
        /// </summary>
        [JsonProperty("Cost")]
        public string Cost{ get; set; }

        /// <summary>
        /// <p>成本货币单位</p><p>枚举值：</p><ul><li>CNY： 人民币</li></ul><p>当前仅支持CNY</p>
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConsumerId", this.ConsumerId);
            this.SetParamSimple(map, prefix + "ConsumerName", this.ConsumerName);
            this.SetParamArrayObj(map, prefix + "ConsumerGroups.", this.ConsumerGroups);
            this.SetParamSimple(map, prefix + "ModelServiceId", this.ModelServiceId);
            this.SetParamSimple(map, prefix + "ModelServiceName", this.ModelServiceName);
            this.SetParamSimple(map, prefix + "InputTokens", this.InputTokens);
            this.SetParamSimple(map, prefix + "CacheReadInputTokens", this.CacheReadInputTokens);
            this.SetParamSimple(map, prefix + "OutputTokens", this.OutputTokens);
            this.SetParamSimple(map, prefix + "TotalTokens", this.TotalTokens);
            this.SetParamSimple(map, prefix + "RequestCount", this.RequestCount);
            this.SetParamSimple(map, prefix + "Cost", this.Cost);
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
        }
    }
}

