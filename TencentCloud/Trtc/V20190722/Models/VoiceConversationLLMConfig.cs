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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VoiceConversationLLMConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>LLM 协议类型，如openai（OpenAI 兼容协议）。</p>
        /// </summary>
        [JsonProperty("LLMType")]
        public string LLMType{ get; set; }

        /// <summary>
        /// <p>模型名，如 gpt-4o-mini</p>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>OpenAI 协议兼容的 endpoint。</p>
        /// </summary>
        [JsonProperty("APIUrl")]
        public string APIUrl{ get; set; }

        /// <summary>
        /// <p>厂商 API Key。</p>
        /// </summary>
        [JsonProperty("APIKey")]
        public string APIKey{ get; set; }

        /// <summary>
        /// <p>系统提示词。</p>
        /// </summary>
        [JsonProperty("SystemPrompt")]
        public string SystemPrompt{ get; set; }

        /// <summary>
        /// <p>LLM 调用失败后，使用此文本生成 TTS音频。</p>
        /// </summary>
        [JsonProperty("FailureMessage")]
        public string FailureMessage{ get; set; }

        /// <summary>
        /// <p>单次回复最大 Token 数，0=不限制，默认值为0。注意：如果模型输出token数量大于设置的MaxTokens的值，会截断回复内容。</p>
        /// </summary>
        [JsonProperty("MaxTokens")]
        public ulong? MaxTokens{ get; set; }

        /// <summary>
        /// <p>是否开启思考模式（需结合提供厂商具体使用）。注意：开启思考模式会占用输出token数。</p>
        /// </summary>
        [JsonProperty("ThinkingMode")]
        public bool? ThinkingMode{ get; set; }

        /// <summary>
        /// <p>LLM 中缓存的对话轮次数量，范围 0~50。建议值[10, 30]。注意：指定轮次上下文的总 token 数不能超过 LLM 支持的上限。</p>
        /// </summary>
        [JsonProperty("MaxHistory")]
        public ulong? MaxHistory{ get; set; }

        /// <summary>
        /// <p>MCP 工具调用最大轮次，范围 0~50，默认 10。</p>
        /// </summary>
        [JsonProperty("MaxToolRound")]
        public ulong? MaxToolRound{ get; set; }

        /// <summary>
        /// <p>单次请求的超时事件（毫秒），范围 1000~60000，默认 10000。</p><p>单位：毫秒</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// <p>采样温度，范围 0.0~2.0，默认 1.0。</p>
        /// </summary>
        [JsonProperty("Temperature")]
        public float? Temperature{ get; set; }

        /// <summary>
        /// <p>采样概率，范围 0.0~1.0，默认 1.0。</p>
        /// </summary>
        [JsonProperty("TopP")]
        public float? TopP{ get; set; }

        /// <summary>
        /// <p>Mcp Server参数。</p>
        /// </summary>
        [JsonProperty("McpServer")]
        public VoiceConversationMcpServer McpServer{ get; set; }

        /// <summary>
        /// <p>自定义 HTTP 请求头。</p>
        /// </summary>
        [JsonProperty("CustomHeaders")]
        public KeyValueItem[] CustomHeaders{ get; set; }

        /// <summary>
        /// <p>各厂商独有的扩展参数（如 DeepSeek 的<code>reasoning_effort</code>、混元的 <code>enable_enhancement</code> 等）。</p>
        /// </summary>
        [JsonProperty("CustomFields")]
        public KeyValueItem[] CustomFields{ get; set; }

        /// <summary>
        /// <p>初始历史消息，每项为 <code>{&quot;Role&quot;: &quot;user&quot;/&quot;assistant&quot;/&quot;system&quot;, &quot;Content&quot;: &quot;xxx&quot;}</code>这种格式。</p>
        /// </summary>
        [JsonProperty("HistoryMessages")]
        public VoiceConversationHistoryMessage[] HistoryMessages{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LLMType", this.LLMType);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "APIUrl", this.APIUrl);
            this.SetParamSimple(map, prefix + "APIKey", this.APIKey);
            this.SetParamSimple(map, prefix + "SystemPrompt", this.SystemPrompt);
            this.SetParamSimple(map, prefix + "FailureMessage", this.FailureMessage);
            this.SetParamSimple(map, prefix + "MaxTokens", this.MaxTokens);
            this.SetParamSimple(map, prefix + "ThinkingMode", this.ThinkingMode);
            this.SetParamSimple(map, prefix + "MaxHistory", this.MaxHistory);
            this.SetParamSimple(map, prefix + "MaxToolRound", this.MaxToolRound);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "Temperature", this.Temperature);
            this.SetParamSimple(map, prefix + "TopP", this.TopP);
            this.SetParamObj(map, prefix + "McpServer.", this.McpServer);
            this.SetParamArrayObj(map, prefix + "CustomHeaders.", this.CustomHeaders);
            this.SetParamArrayObj(map, prefix + "CustomFields.", this.CustomFields);
            this.SetParamArrayObj(map, prefix + "HistoryMessages.", this.HistoryMessages);
        }
    }
}

