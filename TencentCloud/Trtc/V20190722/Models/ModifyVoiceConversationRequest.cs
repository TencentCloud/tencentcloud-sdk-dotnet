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

    public class ModifyVoiceConversationRequest : AbstractModel
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
        /// <p>需要保证同一个任务，每次更新请求中的SequenceNumber递增，防止请求乱序。</p>
        /// </summary>
        [JsonProperty("SequenceNumber")]
        public ulong? SequenceNumber{ get; set; }

        /// <summary>
        /// <p>大模型配置。<strong>仅 <code>Cascade</code> 模式生效</strong>；<code>S2S</code> 模式报错。</p>
        /// </summary>
        [JsonProperty("LLMConfig")]
        public VoiceConversationLLMConfig LLMConfig{ get; set; }

        /// <summary>
        /// <p>端到端语音大模型配置。仅 <strong><code>S2S</code> 模式</strong>生效；<code>Cascade</code> 报错。</p>
        /// </summary>
        [JsonProperty("S2SConfig")]
        public VoiceConversationS2SConfig S2SConfig{ get; set; }

        /// <summary>
        /// <p>对话控制配置。<strong>仅 <code>Cascade</code> 模式生效</strong>。</p>
        /// </summary>
        [JsonProperty("DialogConfig")]
        public VoiceConversationDialogConfig DialogConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "SequenceNumber", this.SequenceNumber);
            this.SetParamObj(map, prefix + "LLMConfig.", this.LLMConfig);
            this.SetParamObj(map, prefix + "S2SConfig.", this.S2SConfig);
            this.SetParamObj(map, prefix + "DialogConfig.", this.DialogConfig);
        }
    }
}

