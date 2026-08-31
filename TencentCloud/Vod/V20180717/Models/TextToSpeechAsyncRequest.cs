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

namespace TencentCloud.Vod.V20180717.Models
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
        /// <p>点播应用 ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public string SubAppId{ get; set; }

        /// <summary>
        /// <p>语言增强，如 "zh" "en" "auto"，默认 "auto"</p>
        /// </summary>
        [JsonProperty("LanguageBoost")]
        public string LanguageBoost{ get; set; }

        /// <summary>
        /// <p>文本合成语音（异步）拓展参数。ExtParam 支持的字段：</p><ul><li>model (string)：合成模型，可选 minimax-speech-2.8-hd、minimax-speech-2.8-turbo、minimax-speech-2.6-hd、minimax-speech-2.6-turbo、minimax-speech-02-hd、minimax-speech-02-turbo；默认 minimax-speech-2.8-hd。</li><li>text_lang (string)：文本语言，如 zh / en；与入参 LanguageBoost 同义，同时传入时以 ExtParam 为准。</li><li>audio_setting (object)：音频输出与音色微调参数（注意：异步接口的语速、音量、音调、情绪均在 audio_setting 下，与同步接口的 voice_setting 不同），可选字段：<ul><li>speed (float)：语速，[0.5, 2.0]，默认 1.0。</li><li>vol (float)：音量，(0, 10]，默认 1.0。</li><li>pitch (int)：音调，[-12, 12]，默认 0。</li><li>emotion (string)：情绪，可选 happy / sad / angry / fearful / disgusted / surprised / calm / fluent / whisper。</li><li>sample_rate (int)：采样率，可选 8000 / 16000 / 22050 / 24000 / 32000 / 44100，默认 16000。</li><li>format (string)：音频格式，可选 mp3 / wav，默认 wav。</li><li>duration (float)：目标时长（秒）。</li><li>cut_silence (bool)：是否裁剪静音段。</li></ul></li></ul>
        /// </summary>
        [JsonProperty("ExtParam")]
        public string ExtParam{ get; set; }

        /// <summary>
        /// <p>输出相关参数</p><p>可以指定输出形式等。默认输出音频url。</p>
        /// </summary>
        [JsonProperty("Output")]
        public TextToSpeechAsyncOutputOption Output{ get; set; }

        /// <summary>
        /// <p>标识来源上下文，用于透传用户请求信息，在回调和任务流状态变更回调将返回该字段值，最长 1000 个字符。</p>
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// <p>用于任务去重的识别码，如果三天内曾有过相同的识别码的请求，则本次的请求会返回错误。最长 50 个字符，不带或者带空字符串表示不做去重。</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "LanguageBoost", this.LanguageBoost);
            this.SetParamSimple(map, prefix + "ExtParam", this.ExtParam);
            this.SetParamObj(map, prefix + "Output.", this.Output);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
        }
    }
}

