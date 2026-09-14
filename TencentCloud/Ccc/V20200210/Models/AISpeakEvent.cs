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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AISpeakEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>本次话术是否允许被用户VAD打断</p>
        /// </summary>
        [JsonProperty("CanBeInterrupted")]
        public bool? CanBeInterrupted{ get; set; }

        /// <summary>
        /// <p>智能体播报的话术文本内容</p>
        /// </summary>
        [JsonProperty("SpokenText")]
        public string SpokenText{ get; set; }

        /// <summary>
        /// <p>智能体发言类型</p><p>枚举值：</p><ul><li>Script： 智能体话术</li><li>KnowledgeBase： 知识库</li><li>LLMFallback： 大模型兜底</li><li>NoResponseTip： 无响应提示</li><li>SmartFollowUp： 智能追问</li><li>FAQ： FAQ</li><li>TransferWaitingPrompt： 转人工 - 排队等待音</li><li>PlayNoResponseEndPrompt： 无响应挂断前放音</li><li>PlayQueuePrompt： 转人工 - 排队前放音</li><li>PlayPromptBeforeReception： 转人工 - 接待前放音</li><li>PlayQueueTimeoutPrompt： 转人工 - 排队超时放音</li><li>PlayTransferFailPrompt： 转人工 - 转人工失败放音</li><li>Dtmf： DTMF收号（按键用户输入）</li><li>PlayDtmfPrompt： 按键节点 - 播放提示音</li><li>PlayInvalidDtmfPrompt： 按键节点 - 输入错误提示音</li><li>PlayDtmfTimeoutPrompt： 按键节点 - 超时提示音</li><li>TransferAgentPrompt： 转接智能体 - 转接至目标智能体提示音</li><li>Other： 其他类型</li></ul>
        /// </summary>
        [JsonProperty("SpokenType")]
        public string SpokenType{ get; set; }

        /// <summary>
        /// <p>本次响应生成的时延结果</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LatencyMetrics")]
        public AICallLatencyMetrics LatencyMetrics{ get; set; }

        /// <summary>
        /// <p>用户回复命中的知识库问题标题，仅 SpokenType 为 KnowledgeBase 或 FAQ 等命中知识库的场景有值。</p>
        /// </summary>
        [JsonProperty("KnowledgeName")]
        public string KnowledgeName{ get; set; }

        /// <summary>
        /// <p>节点跳转的原因，仅画布为灵活模式时有值</p>
        /// </summary>
        [JsonProperty("TraverseReason")]
        public string TraverseReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CanBeInterrupted", this.CanBeInterrupted);
            this.SetParamSimple(map, prefix + "SpokenText", this.SpokenText);
            this.SetParamSimple(map, prefix + "SpokenType", this.SpokenType);
            this.SetParamObj(map, prefix + "LatencyMetrics.", this.LatencyMetrics);
            this.SetParamSimple(map, prefix + "KnowledgeName", this.KnowledgeName);
            this.SetParamSimple(map, prefix + "TraverseReason", this.TraverseReason);
        }
    }
}

