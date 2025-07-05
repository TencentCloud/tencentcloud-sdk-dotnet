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

    public class ComposeAudioStream : AbstractModel
    {
        
        /// <summary>
        /// 音频流的编码方式，可选值：
        /// <li>AAC：AAC 编码（默认），用于容器为 mp4。</li>
        /// <li>MP3：mp3 编码，用于容器为 mp3。</li>
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// 音频流的采样率，单位：Hz，可选值：
        /// <li>16000（默认）</li>
        /// <li>32000</li>
        /// <li>44100</li>
        /// <li>48000</li>
        /// </summary>
        [JsonProperty("SampleRate")]
        public long? SampleRate{ get; set; }

        /// <summary>
        /// 声道数，可选值：
        /// <li>1：单声道 。</li>
        /// <li>2：双声道（默认）。</li>
        /// </summary>
        [JsonProperty("AudioChannel")]
        public long? AudioChannel{ get; set; }

        /// <summary>
        /// 参考码率，单位 kbps，范围：26~10000。
        /// 如果设置，编码时会尽量按该码率进行编码。
        /// 如果不设置，服务将根据音频参数自动采用合适的码率。
        /// </summary>
        [JsonProperty("Bitrate")]
        public long? Bitrate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "AudioChannel", this.AudioChannel);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
        }
    }
}

