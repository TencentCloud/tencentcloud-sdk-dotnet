/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Nlp.V20190408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TestingTextGenerationRequest : AbstractModel
    {
        
        /// <summary>
        /// 会话内容,按对话时间从旧到新在数组中排列。
        /// </summary>
        [JsonProperty("Messages")]
        public TextGenerationMessage[] Messages{ get; set; }

        /// <summary>
        /// 模型名称，当前固定为TestingModel
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// 会话id。
        /// </summary>
        [JsonProperty("QueryId")]
        public string QueryId{ get; set; }

        /// <summary>
        /// 超参数temperature, 该参数用于控制生成文本中重复内容。取值区间为[0.0, 2.0], 非必要不建议使用, 不合理的取值会影响效果。默认为1.0。
        /// </summary>
        [JsonProperty("Temperature")]
        public float? Temperature{ get; set; }

        /// <summary>
        /// 超参数top_p, 该参数用于控制生成文本的多样性。较小的"top_p"值会限制模型的选择范围，使生成的文本更加一致和确定性。较大的"top_p"值会扩大选择范围，使生成的文本更加多样化和随机。取值区间为[0.0, 1.0], 非必要不建议使用, 不合理的取值会影响效果。默认值为1.0。
        /// </summary>
        [JsonProperty("TopP")]
        public float? TopP{ get; set; }

        /// <summary>
        /// 超参数top_k,该参数用于控制生成文本的多样性和可控性，较小的"top_k"值会限制模型的选择范围，使生成的文本更加一致和确定性。较大的"top_k"值会扩大选择范围，使生成的文本更加多样化和随机。取值区间为[1, 100]，默认值 40。
        /// </summary>
        [JsonProperty("TopK")]
        public float? TopK{ get; set; }

        /// <summary>
        /// 重复惩罚项,该参数用于用于控制生成文本中重复内容。建议范围[1.0, 1.05]非必要不建议使用, 不合理的取值会影响效果。默认为1。
        /// </summary>
        [JsonProperty("RepetitionPenalty")]
        public float? RepetitionPenalty{ get; set; }

        /// <summary>
        /// 输出结果最大tokens数量。取值区间为(0, 1024]。默认值为768。
        /// </summary>
        [JsonProperty("OutputSeqLen")]
        public long? OutputSeqLen{ get; set; }

        /// <summary>
        /// 输入文本的最大 tokens 数量。取值区间为(0, 1024]。默认值为256。
        /// </summary>
        [JsonProperty("MaxInputSeqLen")]
        public long? MaxInputSeqLen{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Messages.", this.Messages);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "QueryId", this.QueryId);
            this.SetParamSimple(map, prefix + "Temperature", this.Temperature);
            this.SetParamSimple(map, prefix + "TopP", this.TopP);
            this.SetParamSimple(map, prefix + "TopK", this.TopK);
            this.SetParamSimple(map, prefix + "RepetitionPenalty", this.RepetitionPenalty);
            this.SetParamSimple(map, prefix + "OutputSeqLen", this.OutputSeqLen);
            this.SetParamSimple(map, prefix + "MaxInputSeqLen", this.MaxInputSeqLen);
        }
    }
}

