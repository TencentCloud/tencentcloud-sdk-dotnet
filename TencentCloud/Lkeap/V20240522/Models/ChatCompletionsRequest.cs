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

namespace TencentCloud.Lkeap.V20240522.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChatCompletionsRequest : AbstractModel
    {
        
        /// <summary>
        /// 模型名称
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// 聊天上下文信息。
        /// 说明：
        /// 1. 长度最多为 40，按对话时间从旧到新在数组中排列。
        /// 2. Message.Role 可选值：system、user、assistant。
        /// 其中，system 角色可选，如存在则必须位于列表的最开始。user 和 assistant 需交替出现，以 user 提问开始，user 提问结束，Content 不能为空。Role 的顺序示例：[system（可选） user assistant user assistant user ...]。
        /// </summary>
        [JsonProperty("Messages")]
        public Message[] Messages{ get; set; }

        /// <summary>
        /// 是否流式输出
        /// </summary>
        [JsonProperty("Stream")]
        public bool? Stream{ get; set; }

        /// <summary>
        /// 控制生成的随机性，较高的值会产生更多样化的输出。
        /// </summary>
        [JsonProperty("Temperature")]
        public float? Temperature{ get; set; }

        /// <summary>
        /// 模型最大输出长度（单位 token），不包含思维链内容。
        /// 默认为4096，取值范围：各个模型不同，参考各个模型最大输出长度（示例：4k，即4096）。
        /// 输出 token 的总长度受模型的上下文长度限制。
        /// </summary>
        [JsonProperty("MaxTokens")]
        public long? MaxTokens{ get; set; }

        /// <summary>
        /// 是否启用联网搜索
        /// </summary>
        [JsonProperty("EnableSearch")]
        public bool? EnableSearch{ get; set; }

        /// <summary>
        /// 思维链开关，本参数仅在deepseek v3.1时生效
        /// </summary>
        [JsonProperty("Thinking")]
        public Thinking Thinking{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamArrayObj(map, prefix + "Messages.", this.Messages);
            this.SetParamSimple(map, prefix + "Stream", this.Stream);
            this.SetParamSimple(map, prefix + "Temperature", this.Temperature);
            this.SetParamSimple(map, prefix + "MaxTokens", this.MaxTokens);
            this.SetParamSimple(map, prefix + "EnableSearch", this.EnableSearch);
            this.SetParamObj(map, prefix + "Thinking.", this.Thinking);
        }
    }
}

