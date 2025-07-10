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

    public class AgentModelInfo : AbstractModel
    {
        
        /// <summary>
        /// 模型名称
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// 模型别名
        /// </summary>
        [JsonProperty("ModelAliasName")]
        public string ModelAliasName{ get; set; }

        /// <summary>
        /// 模型温度
        /// </summary>
        [JsonProperty("Temperature")]
        public float? Temperature{ get; set; }

        /// <summary>
        /// 模型TopP
        /// </summary>
        [JsonProperty("TopP")]
        public float? TopP{ get; set; }

        /// <summary>
        /// 模型是否可用
        /// </summary>
        [JsonProperty("IsEnabled")]
        public bool? IsEnabled{ get; set; }

        /// <summary>
        /// 对话历史条数限制
        /// </summary>
        [JsonProperty("HistoryLimit")]
        public ulong? HistoryLimit{ get; set; }

        /// <summary>
        /// 模型上下文长度字符限制
        /// </summary>
        [JsonProperty("ModelContextWordsLimit")]
        public string ModelContextWordsLimit{ get; set; }

        /// <summary>
        /// 指令长度字符限制
        /// </summary>
        [JsonProperty("InstructionsWordsLimit")]
        public ulong? InstructionsWordsLimit{ get; set; }

        /// <summary>
        /// 单次会话最大推理轮数
        /// </summary>
        [JsonProperty("MaxReasoningRound")]
        public ulong? MaxReasoningRound{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelAliasName", this.ModelAliasName);
            this.SetParamSimple(map, prefix + "Temperature", this.Temperature);
            this.SetParamSimple(map, prefix + "TopP", this.TopP);
            this.SetParamSimple(map, prefix + "IsEnabled", this.IsEnabled);
            this.SetParamSimple(map, prefix + "HistoryLimit", this.HistoryLimit);
            this.SetParamSimple(map, prefix + "ModelContextWordsLimit", this.ModelContextWordsLimit);
            this.SetParamSimple(map, prefix + "InstructionsWordsLimit", this.InstructionsWordsLimit);
            this.SetParamSimple(map, prefix + "MaxReasoningRound", this.MaxReasoningRound);
        }
    }
}

