/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AudioInfo : AbstractModel
    {
        
        /// <summary>
        /// 音频码率，取值范围：0 和 [26, 256]，单位：kbps。
        /// 注意：当取值为 0，表示音频码率和原始音频保持一致。
        /// </summary>
        [JsonProperty("Bitrate")]
        public long? Bitrate{ get; set; }

        /// <summary>
        /// 音频编码器，可选项：aac,mp3,ac3,flac,mp2。
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// 声道数，可选项：
        /// 1：单声道，
        /// 2：双声道，
        /// 6：立体声。
        /// </summary>
        [JsonProperty("Channel")]
        public long? Channel{ get; set; }

        /// <summary>
        /// 采样率，单位：Hz。可选项：32000，44100,48000
        /// </summary>
        [JsonProperty("SampleRate")]
        public long? SampleRate{ get; set; }

        /// <summary>
        /// 音频降噪信息
        /// </summary>
        [JsonProperty("Denoise")]
        public Denoise Denoise{ get; set; }

        /// <summary>
        /// 开启添加静音，可选项：
        /// 0：不开启，
        /// 1：开启，
        /// 默认不开启
        /// </summary>
        [JsonProperty("EnableMuteAudio")]
        public long? EnableMuteAudio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamObj(map, prefix + "Denoise.", this.Denoise);
            this.SetParamSimple(map, prefix + "EnableMuteAudio", this.EnableMuteAudio);
        }
    }
}

