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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TextToSpeechAsyncRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>语音合成文本</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>音色ID</p>
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }

        /// <summary>
        /// <p>文本语言，默认中文</p>
        /// </summary>
        [JsonProperty("TextLang")]
        public string TextLang{ get; set; }

        /// <summary>
        /// <p>扩展参数，json字符串</p><p>synExt Object 语音合成扩展参数<br>  duration Float 合成音频时长，单位秒，示例：5.2<br>  sampleRate Integer 合成音频采样率，默认16000，支持[8000,16000,22050,32000,44100]<br>  pitch Integer 音调，默认0原音色输出，取值[-12, 12]</p><p>transExt Object 翻译扩展参数<br>  transInfo Object<br>   transDst String 目标语言，如en<br>  transRequirement String 翻译要求</p>
        /// </summary>
        [JsonProperty("ExtParam")]
        public string ExtParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
            this.SetParamSimple(map, prefix + "TextLang", this.TextLang);
            this.SetParamSimple(map, prefix + "ExtParam", this.ExtParam);
        }
    }
}

