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

    public class VoiceConversationDialogConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>打断模式。</p><p>枚举值：</p><ul><li>0： 自动打断（ASR 出文本打断 TTS，配合InterruptSpeechDuration 使用，默认）</li><li>1： 手动打断（仅服务端/客户端接口 Interrupt 命令打断）</li><li>2： 关键词打断</li></ul>
        /// </summary>
        [JsonProperty("InterruptMode")]
        public ulong? InterruptMode{ get; set; }

        /// <summary>
        /// <p>自动打断的最小用户语音持续时长（毫秒），默认 200</p><p>单位：毫秒</p>
        /// </summary>
        [JsonProperty("InterruptSpeechDuration")]
        public ulong? InterruptSpeechDuration{ get; set; }

        /// <summary>
        /// <p>预设的关键词，关键词打断，适用于需要用户明确表达意图才能打断的场景。最多支持128个关键词，InterruptMode 为2时生效，</p>
        /// </summary>
        [JsonProperty("InterruptKeywords")]
        public string[] InterruptKeywords{ get; set; }

        /// <summary>
        /// <p>用户静音多久后 Bot 主动追问，范围 0~300，0 表示关闭（默认）。</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("SilenceFollowUp")]
        public ulong? SilenceFollowUp{ get; set; }

        /// <summary>
        /// <p>主动追问的文本。</p>
        /// </summary>
        [JsonProperty("SilenceFollowUpText")]
        public string SilenceFollowUpText{ get; set; }

        /// <summary>
        /// <p>主播首次进房主动播报的欢迎语，主播退房后再次进房也会播报。</p>
        /// </summary>
        [JsonProperty("WelcomeMessage")]
        public string WelcomeMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InterruptMode", this.InterruptMode);
            this.SetParamSimple(map, prefix + "InterruptSpeechDuration", this.InterruptSpeechDuration);
            this.SetParamArraySimple(map, prefix + "InterruptKeywords.", this.InterruptKeywords);
            this.SetParamSimple(map, prefix + "SilenceFollowUp", this.SilenceFollowUp);
            this.SetParamSimple(map, prefix + "SilenceFollowUpText", this.SilenceFollowUpText);
            this.SetParamSimple(map, prefix + "WelcomeMessage", this.WelcomeMessage);
        }
    }
}

