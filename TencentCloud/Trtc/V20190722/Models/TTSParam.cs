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

    public class TTSParam : AbstractModel
    {
        
        /// <summary>
        /// <p>tts模型参数，仅支持填写&quot;flow_02_turbo&quot;。</p>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>tts语言，必须在TranslationParam 的TargetLang列表中。</p>
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// <p>需要TTS播报的主播用户，该主播用户必须在订阅白名单里并且不在订阅黑名单里。</p>
        /// </summary>
        [JsonProperty("TargetUser")]
        public TranscriptionUserInfoParams TargetUser{ get; set; }

        /// <summary>
        /// <p>TTS 音频回推到房间的机器人用户。</p>
        /// </summary>
        [JsonProperty("TTSRobotUser")]
        public TranscriptionUserInfoParams TTSRobotUser{ get; set; }

        /// <summary>
        /// <p>TTS的声音配置参数。</p>
        /// </summary>
        [JsonProperty("Voice")]
        public TTSVoice Voice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamObj(map, prefix + "TargetUser.", this.TargetUser);
            this.SetParamObj(map, prefix + "TTSRobotUser.", this.TTSRobotUser);
            this.SetParamObj(map, prefix + "Voice.", this.Voice);
        }
    }
}

