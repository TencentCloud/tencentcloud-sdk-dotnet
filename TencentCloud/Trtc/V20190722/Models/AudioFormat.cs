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

    public class AudioFormat : AbstractModel
    {
        
        /// <summary>
        /// <p>生成的音频格式</p><ul><li><p>TextToSpeechSSE 流式接口</p><p>支持 pcm,mp3,  默认: pcm</p></li><li><p>TextToSpeech 非流式接口</p><p>支持 pcm,wav,mp3,  默认: pcm</p></li><li><p>AsyncTextToSpeech<br>支持pcm,mp3, 默认: mp3</p></li></ul>
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// <p>生成的音频采样率，默认24000<br>可选</p><ul><li>16000</li><li>24000</li></ul>
        /// </summary>
        [JsonProperty("SampleRate")]
        public ulong? SampleRate{ get; set; }

        /// <summary>
        /// <p>MP3 比特率 (kbps)，仅对 MP3 格式生效, 可以选： <code>64</code>, <code>128</code>, <code>192</code>, <code>256</code> ,  默认： <code>128</code></p>
        /// </summary>
        [JsonProperty("Bitrate")]
        public ulong? Bitrate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
        }
    }
}

