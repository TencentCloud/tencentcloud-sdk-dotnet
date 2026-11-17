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
        /// <p>模型系列，区分大小写，默认 MiniMax。</p><p>枚举值：</p><ul><li>MiniMax</li><li>ElevenLabs</li></ul>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>模型版本，不填时使用该模型系列的默认版本。</p><p>各模型支持版本：</p><ul><li><p>MiniMax：minimax-speech-2.8-hd（默认）、minimax-speech-2.8-turbo、minimax-speech-2.6-hd、minimax-speech-2.6-turbo、minimax-speech-02-hd、minimax-speech-02-turbo</p></li><li><p>ElevenLabs：custom-model-ll-v3（默认）、custom-model-ll-mlv2、custom-model-ll-fv2.5、custom-model-ll-fv2、custom-model-ll-v4、custom-model-ll-v4tb</p></li></ul>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

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
        /// <p><strong>ExtParam</strong> 是 JSON 字符串字段，用于指定各模型的高级合成参数。字段名中的 . 表示嵌套对象，如 req_params.audio_params.speech_rate，需按层级组成本地 JSON 对象后整体转义传入。未列出的字段不生效。</p><hr><h3 id="MiniMax">MiniMax</h3><ul><li>model（string）：合成模型，可选 minimax-speech-2.8-hd、minimax-speech-2.8-turbo、minimax-speech-2.6-hd、minimax-speech-2.6-turbo、minimax-speech-02-hd、minimax-speech-02-turbo，默认 minimax-speech-2.8-hd</li><li>voice_setting.speed（float）：语速，取值范围 [0.5, 2.0]，默认 1.0</li><li>voice_setting.vol（float）：音量，取值范围 (0, 10]，默认 1.0</li><li>voice_setting.pitch（integer）：音调，取值范围 [-12, 12]，默认 0</li><li>voice_setting.emotion（string）：情绪，可选 happy、sad、angry、fearful、disgusted、surprised、calm、fluent、whisper</li><li>audio_setting.format（string）：音频格式，可选 mp3、wav，默认 wav</li><li>audio_setting.sample_rate（integer）：采样率，可选 8000、16000、22050、24000、32000、44100，默认 16000</li><li>audio_setting.duration（float）：目标时长，单位秒</li><li>audio_setting.cut_silence（boolean）：是否裁剪静音段</li></ul><hr><h3 id="ElevenLabs">ElevenLabs</h3><ul><li>language_code（string）：语言代码（ISO 639-1），用于强制语种与文本归一化</li><li>previous_text（string）：上一段文本（衔接上下文）</li><li>next_text（string）：下一段文本</li><li>seed（integer）：确定性采样种子，范围 [0, 4294967295]</li><li>apply_text_normalization（string）：文本规范化，可选 auto、on、off</li><li>apply_language_text_normalization（boolean）：是否启用语种相关的文本规范化</li><li>voice_settings.stability（float）：稳定性，默认 0.5</li><li>voice_settings.similarity_boost（float）：音色相似度，默认 0.75</li><li>voice_settings.style（float）：风格夸张度，默认 0</li><li>voice_settings.use_speaker_boost（boolean）：是否增强音色相似度，默认 true</li><li>voice_settings.speed（float）：语速，取值范围 [0.5, 2.0]，默认 1.0</li><li>audio_setting.format（string）：音频格式，可选 mp3、opus、alaw、pcm</li><li>audio_setting.sample_rate（integer）：采样率，需与 format 匹配</li><li>audio_setting.bitrate（integer）：比特率，需与 format、sample_rate 匹配</li></ul><hr>
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
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "LanguageBoost", this.LanguageBoost);
            this.SetParamSimple(map, prefix + "ExtParam", this.ExtParam);
            this.SetParamObj(map, prefix + "Output.", this.Output);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
        }
    }
}

