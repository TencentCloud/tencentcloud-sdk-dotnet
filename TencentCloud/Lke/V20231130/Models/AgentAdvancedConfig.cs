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

    public class AgentAdvancedConfig : AbstractModel
    {
        
        /// <summary>
        /// 是否开启澄清询问
        /// </summary>
        [JsonProperty("EnableClarification")]
        public bool? EnableClarification{ get; set; }

        /// <summary>
        /// 思考模式，0为效果优先，1为速度优先
        /// </summary>
        [JsonProperty("ThinkingMode")]
        public long? ThinkingMode{ get; set; }

        /// <summary>
        /// 最大推理轮数
        /// </summary>
        [JsonProperty("MaxReasoningRound")]
        public ulong? MaxReasoningRound{ get; set; }

        /// <summary>
        /// 上下文轮数
        /// </summary>
        [JsonProperty("HistoryLimit")]
        public ulong? HistoryLimit{ get; set; }

        /// <summary>
        /// 是否开启结构化输出
        /// </summary>
        [JsonProperty("EnableStructuredOutput")]
        public bool? EnableStructuredOutput{ get; set; }

        /// <summary>
        /// 结构化输出配置
        /// </summary>
        [JsonProperty("StructuredOutputConfig")]
        public StructuredOutputConfig StructuredOutputConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableClarification", this.EnableClarification);
            this.SetParamSimple(map, prefix + "ThinkingMode", this.ThinkingMode);
            this.SetParamSimple(map, prefix + "MaxReasoningRound", this.MaxReasoningRound);
            this.SetParamSimple(map, prefix + "HistoryLimit", this.HistoryLimit);
            this.SetParamSimple(map, prefix + "EnableStructuredOutput", this.EnableStructuredOutput);
            this.SetParamObj(map, prefix + "StructuredOutputConfig.", this.StructuredOutputConfig);
        }
    }
}

