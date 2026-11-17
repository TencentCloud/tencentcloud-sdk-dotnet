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

    public class ControlVoiceConversationRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>TRTC的<a href="https://cloud.tencent.com/document/product/647/46351#sdkappid">SdkAppId</a>，和对话的房间所对应的SdkAppId相同。</p>
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// <p>对话任务的唯一Id，在启动对话成功后会返回。</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>控制指令。</p><p>枚举值：</p><ul><li>&quot;Interrupt&quot;： 强制打断</li><li>&quot;invokellm&quot;： 文本注入 LLM：向当前对话上下文注入一段文本，触发一轮 LLM 回复。<code>S2S</code>模式不支持该指令</li><li>invoketts： 文本注入TTS：向当前TTS注入文本，触发TTS播报。<code>S2S</code>模式不支持该指令</li></ul>
        /// </summary>
        [JsonProperty("Command")]
        public string Command{ get; set; }

        /// <summary>
        /// <p>注入LLM的配置，<code>Command=invokellm</code> 时必填</p>
        /// </summary>
        [JsonProperty("InvokeLLM")]
        public VoiceConversationInvokeLLM InvokeLLM{ get; set; }

        /// <summary>
        /// <p>注入TTS的配置，<code>Command=invoketts</code> 时必填</p>
        /// </summary>
        [JsonProperty("InvokeTTS")]
        public VoiceConversationInvokeTTS InvokeTTS{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Command", this.Command);
            this.SetParamObj(map, prefix + "InvokeLLM.", this.InvokeLLM);
            this.SetParamObj(map, prefix + "InvokeTTS.", this.InvokeTTS);
        }
    }
}

