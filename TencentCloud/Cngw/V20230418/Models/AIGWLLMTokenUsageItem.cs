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
        /// <p>消费者当前直接所属组列表。网关版本不低于 3.9.8 时，从 Kong CP 当前目录补齐全部直接所属组的 ID、名称和 ConsumerGroupPath，不按 IsPrimary 筛选；无所属组为 []。更早版本保留原消费者组信息且省略路径。</p>
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
        /// <p>按 Dimension 聚合的维度键值；未传 Dimension 的二维列表不使用此字段。</p><p>Key 顺序：</p><ul><li>SecretKey：SecretKeyId、SecretKeyName</li><li>Model：ModelName</li><li>ModelAPI：ModelAPIId、ModelAPIName</li><li>ModelService：ModelServiceId、ModelServiceName</li><li>Consumer：ConsumerId、ConsumerName、ConsumerGroupId、ConsumerGroupName、ConsumerGroupPath</li><li>ConsumerGroup 组行：ConsumerGroupId、ConsumerGroupName、MemberCount、ConsumerGroupPath</li></ul><p>3.9.8 起，消费者行的 ConsumerGroupId、ConsumerGroupName、ConsumerGroupPath 数组按同一下标对应，表示当前全部直接所属组，不按 IsPrimary 筛选；无所属组为 []。组行的 MemberCount 是当前节点及下属存在且未软删消费者的去重人数，不是历史活跃人数；人数已知为零时为 ["0"]，未知为 []。路径来自 Kong CP 当前目录，多父节点使用确定性展示路径；元数据缺失时名称回退 ID，路径为 []。更早版本保留原字段，省略 ConsumerGroupPath。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DimensionList")]
        public AIGWLLMResourceDimension[] DimensionList{ get; set; }


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
            this.SetParamArrayObj(map, prefix + "DimensionList.", this.DimensionList);
        }
    }
}

