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

    public class CreateVoiceConversationRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>TRTC的<a href="https://cloud.tencent.com/document/product/647/46351#sdkappid">SdkAppId</a>，和对话的房间所对应的SdkAppId相同。</p>
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// <p>TRTC的<a href="https://cloud.tencent.com/document/product/647/46351#roomid">RoomId</a>，对话的TRTC房间所对应的RoomId。注：房间号类型默认为整型，若房间号类型为字符串，请通过RoomIdType指定。</p>
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// <p>房间信息RoomType，必须和对话的房间所对应的RoomId类型相同，0为整型房间号，1为字符串房间号。</p><p>枚举值：</p><ul><li>0： 数字房间号</li><li>1： 字符串房间号</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("RoomIdType")]
        public ulong? RoomIdType{ get; set; }

        /// <summary>
        /// <p>对话机器人相关配置。</p>
        /// </summary>
        [JsonProperty("AgentConfig")]
        public VoiceConversationConfig AgentConfig{ get; set; }

        /// <summary>
        /// <p>对话链路模式：<code>Cascade</code>（默认，三段式）/ <code>S2S</code>（端到端语音大模型）。</p><p>枚举值：</p><ul><li>Cascade： 默认，三段式</li><li>S2S： 端到端语音大模型</li></ul><p>默认值：Cascade</p>
        /// </summary>
        [JsonProperty("ConversationMode")]
        public string ConversationMode{ get; set; }

        /// <summary>
        /// <p>端到端语音大模型配置。<strong>仅 <code>S2S</code> 模式必填</strong>；<code>Cascade</code> 模式忽略。</p>
        /// </summary>
        [JsonProperty("S2SConfig")]
        public VoiceConversationS2SConfig S2SConfig{ get; set; }

        /// <summary>
        /// <p>语音识别配置。<strong>仅 <code>Cascade</code> 模式必填</strong>；<code>S2S</code> 模式忽略。</p>
        /// </summary>
        [JsonProperty("STTConfig")]
        public VoiceConversationSTTConfig STTConfig{ get; set; }

        /// <summary>
        /// <p>大模型配置。<strong>仅 <code>Cascade</code> 模式必填</strong>；<code>S2S</code> 模式忽略。</p>
        /// </summary>
        [JsonProperty("LLMConfig")]
        public VoiceConversationLLMConfig LLMConfig{ get; set; }

        /// <summary>
        /// <p>语音合成配置。<strong>仅 <code>Cascade</code> 模式必填</strong>；<code>S2S</code> 模式忽略。</p>
        /// </summary>
        [JsonProperty("TTSConfig")]
        public VoiceConversationTTSConfig TTSConfig{ get; set; }

        /// <summary>
        /// <p>对话控制配置，<code>S2S</code> 模式不支持填写该参数。</p>
        /// </summary>
        [JsonProperty("DialogConfig")]
        public VoiceConversationDialogConfig DialogConfig{ get; set; }

        /// <summary>
        /// <p>视觉理解配置，<code>S2S</code> 模式不支持填写该参数。</p>
        /// </summary>
        [JsonProperty("VisionConfig")]
        public VoiceConversationVisionConfig VisionConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "RoomIdType", this.RoomIdType);
            this.SetParamObj(map, prefix + "AgentConfig.", this.AgentConfig);
            this.SetParamSimple(map, prefix + "ConversationMode", this.ConversationMode);
            this.SetParamObj(map, prefix + "S2SConfig.", this.S2SConfig);
            this.SetParamObj(map, prefix + "STTConfig.", this.STTConfig);
            this.SetParamObj(map, prefix + "LLMConfig.", this.LLMConfig);
            this.SetParamObj(map, prefix + "TTSConfig.", this.TTSConfig);
            this.SetParamObj(map, prefix + "DialogConfig.", this.DialogConfig);
            this.SetParamObj(map, prefix + "VisionConfig.", this.VisionConfig);
        }
    }
}

