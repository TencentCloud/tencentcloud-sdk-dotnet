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

    public class CloneVoiceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>克隆音频base64编码</p>
        /// </summary>
        [JsonProperty("AudioData")]
        public string AudioData{ get; set; }

        /// <summary>
        /// <p>克隆音频Url，AudioData为空时有效</p>
        /// </summary>
        [JsonProperty("AudioUrl")]
        public string AudioUrl{ get; set; }

        /// <summary>
        /// <p>克隆音频语言，默认中文。 当前支持语言同语音合成TextLang</p>
        /// </summary>
        [JsonProperty("AudioLang")]
        public string AudioLang{ get; set; }

        /// <summary>
        /// <p>音色属性。音色查询和匹配使用</p>
        /// </summary>
        [JsonProperty("VoiceProfile")]
        public VoiceProfile VoiceProfile{ get; set; }

        /// <summary>
        /// <p>试听文本</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>试听文本语言，不填默认自动检测。当前支持语言同语音合成</p>
        /// </summary>
        [JsonProperty("TextLang")]
        public string TextLang{ get; set; }

        /// <summary>
        /// <p>输出相关参数，可以指定输出音频形式等。默认输出音频base64。</p>
        /// </summary>
        [JsonProperty("Output")]
        public SyncDubbingOutputOption Output{ get; set; }

        /// <summary>
        /// <p>扩展参数，json字符串</p>
        /// </summary>
        [JsonProperty("ExtParam")]
        public string ExtParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AudioData", this.AudioData);
            this.SetParamSimple(map, prefix + "AudioUrl", this.AudioUrl);
            this.SetParamSimple(map, prefix + "AudioLang", this.AudioLang);
            this.SetParamObj(map, prefix + "VoiceProfile.", this.VoiceProfile);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "TextLang", this.TextLang);
            this.SetParamObj(map, prefix + "Output.", this.Output);
            this.SetParamSimple(map, prefix + "ExtParam", this.ExtParam);
        }
    }
}

