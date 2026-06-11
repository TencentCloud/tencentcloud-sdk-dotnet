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

    public class AsyncTextToSpeechRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>需要转语音的文字内容，最大允许50000字符，注意 1汉字=2字符</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>文本转语音的声音配置</p>
        /// </summary>
        [JsonProperty("Voice")]
        public Voice Voice{ get; set; }

        /// <summary>
        /// <p>TRTC的SdkAppId</p>
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// <p>文本转语音的输出音频的格式</p>
        /// </summary>
        [JsonProperty("AudioFormat")]
        public AudioFormat AudioFormat{ get; set; }

        /// <summary>
        /// <p>TTS的模型，当前固定为：flow_02_turbo</p><p>枚举值：</p><ul><li>flow_02_turbo： flow_02_turbo</li></ul>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>多音字/生僻字发音纠正词典条目。指定特定词语在本次请求中使用的发音。</p>
        /// </summary>
        [JsonProperty("PronunciationDict")]
        public PronunciationDict[] PronunciationDict{ get; set; }

        /// <summary>
        /// <p>默认为0，0表示不生成字幕，1表示生成字幕</p>
        /// </summary>
        [JsonProperty("AlignmentMode")]
        public ulong? AlignmentMode{ get; set; }

        /// <summary>
        /// <p>需要合成的语言，默认为空，表示自动识别</p><p>枚举值：</p><ul><li>zh： 中文</li><li>en： 英文</li><li>ja： 日语</li><li>ko： 韩语</li><li>yue： 粤语</li><li>ms： 马来语</li><li>ar： 阿拉伯语</li><li>id： 印尼语</li><li>th： 泰语</li><li>vi： 越南语</li></ul>
        /// </summary>
        [JsonProperty("LanguageCode")]
        public string LanguageCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamObj(map, prefix + "Voice.", this.Voice);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamObj(map, prefix + "AudioFormat.", this.AudioFormat);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamArrayObj(map, prefix + "PronunciationDict.", this.PronunciationDict);
            this.SetParamSimple(map, prefix + "AlignmentMode", this.AlignmentMode);
            this.SetParamSimple(map, prefix + "LanguageCode", this.LanguageCode);
        }
    }
}

