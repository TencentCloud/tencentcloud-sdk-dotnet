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

    public class TextToSpeechSyncRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>合成文本，语音合成时必填，文本长度不超过2000字节</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>音色Id，指定音色合成时填写，支持系统音色和设计、克隆音色。</p>
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
        /// <p>输出相关参数</p><p>可以指定输出形式等。默认输出音频base64。</p>
        /// </summary>
        [JsonProperty("Output")]
        public TextToSpeechSyncOutputOption Output{ get; set; }

        /// <summary>
        /// <p>同步语音合成拓展参数。<code>ExtParam</code> 支持的字段：</p><ul>  <li><code>model</code> (string)：合成模型，可选 <code>minimax-speech-2.8-hd</code>、<code>minimax-speech-2.8-turbo</code>、<code>minimax-speech-2.6-hd</code>、<code>minimax-speech-2.6-turbo</code>、<code>minimax-speech-02-hd</code>、<code>minimax-speech-02-turbo</code>；默认 <code>minimax-speech-2.8-hd</code>。</li>  <li><code>voice_setting</code> (object)：音色微调，可选字段：    <ul>      <li><code>speed</code> (float)：语速，<code>[0.5, 2.0]</code>，默认 <code>1.0</code>。</li>      <li><code>vol</code> (float)：音量，<code>(0, 10]</code>，默认 <code>1.0</code>。</li>      <li><code>pitch</code> (int)：音调，<code>[-12, 12]</code>，默认 <code>0</code>。</li>      <li><code>emotion</code> (string)：情绪，可选 <code>happy</code> / <code>sad</code> / <code>angry</code> / <code>fearful</code> / <code>disgusted</code> / <code>surprised</code> / <code>calm</code> / <code>fluent</code> / <code>whisper</code>。</li>    </ul>  </li>  <li><code>audio_setting</code> (object)：音频输出参数，可选字段：    <ul>      <li><code>sample_rate</code> (int)：采样率，可选 <code>8000</code> / <code>16000</code> / <code>22050</code> / <code>24000</code> / <code>32000</code> / <code>44100</code>，默认 <code>16000</code>。</li>      <li><code>format</code> (string)：音频格式，可选 <code>mp3</code> / <code>wav</code>，默认 <code>wav</code>。</li>      <li><code>duration</code> (float)：目标时长（秒）。</li>      <li><code>cut_silence</code> (bool)：是否裁剪静音段。</li>    </ul>  </li></ul>
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
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "LanguageBoost", this.LanguageBoost);
            this.SetParamObj(map, prefix + "Output.", this.Output);
            this.SetParamSimple(map, prefix + "ExtParam", this.ExtParam);
        }
    }
}

