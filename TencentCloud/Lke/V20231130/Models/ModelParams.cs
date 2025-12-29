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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModelParams : AbstractModel
    {
        
        /// <summary>
        /// 温度
        /// </summary>
        [JsonProperty("Temperature")]
        public float? Temperature{ get; set; }

        /// <summary>
        /// Top_P
        /// </summary>
        [JsonProperty("TopP")]
        public float? TopP{ get; set; }

        /// <summary>
        /// 随机种子
        /// </summary>
        [JsonProperty("Seed")]
        public long? Seed{ get; set; }

        /// <summary>
        /// 存在惩罚
        /// </summary>
        [JsonProperty("PresencePenalty")]
        public float? PresencePenalty{ get; set; }

        /// <summary>
        /// 频率惩罚
        /// </summary>
        [JsonProperty("FrequencyPenalty")]
        public float? FrequencyPenalty{ get; set; }

        /// <summary>
        /// 重复惩罚
        /// </summary>
        [JsonProperty("RepetitionPenalty")]
        public float? RepetitionPenalty{ get; set; }

        /// <summary>
        /// 最大输出长度
        /// </summary>
        [JsonProperty("MaxTokens")]
        public long? MaxTokens{ get; set; }

        /// <summary>
        /// 停止序列
        /// </summary>
        [JsonProperty("StopSequences")]
        public string[] StopSequences{ get; set; }

        /// <summary>
        /// 输出格式
        /// </summary>
        [JsonProperty("ReplyFormat")]
        public string ReplyFormat{ get; set; }

        /// <summary>
        /// 深度思考值
        /// disabled
        /// enabled
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeepThinking")]
        public string DeepThinking{ get; set; }

        /// <summary>
        /// 效果 disabled low medium high
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReasoningEffort")]
        public string ReasoningEffort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Temperature", this.Temperature);
            this.SetParamSimple(map, prefix + "TopP", this.TopP);
            this.SetParamSimple(map, prefix + "Seed", this.Seed);
            this.SetParamSimple(map, prefix + "PresencePenalty", this.PresencePenalty);
            this.SetParamSimple(map, prefix + "FrequencyPenalty", this.FrequencyPenalty);
            this.SetParamSimple(map, prefix + "RepetitionPenalty", this.RepetitionPenalty);
            this.SetParamSimple(map, prefix + "MaxTokens", this.MaxTokens);
            this.SetParamArraySimple(map, prefix + "StopSequences.", this.StopSequences);
            this.SetParamSimple(map, prefix + "ReplyFormat", this.ReplyFormat);
            this.SetParamSimple(map, prefix + "DeepThinking", this.DeepThinking);
            this.SetParamSimple(map, prefix + "ReasoningEffort", this.ReasoningEffort);
        }
    }
}

