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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VideoEncodingPresetAudioSettingForUpdate : AbstractModel
    {
        
        /// <summary>
        /// 音频码率，单位：bps。
        /// 不填则不修改。
        /// </summary>
        [JsonProperty("Bitrate")]
        public string Bitrate{ get; set; }

        /// <summary>
        /// 音频声道数，可选值： 
        /// <li>1：单声道；</li>
        /// <li>2：双声道。</li> 
        /// 不填则不修改。
        /// </summary>
        [JsonProperty("Channels")]
        public ulong? Channels{ get; set; }

        /// <summary>
        /// 音频流的采样率，目前仅支持： 16000； 32000； 44100； 48000。单位：Hz。
        /// 不填则不修改。
        /// </summary>
        [JsonProperty("SampleRate")]
        public ulong? SampleRate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "Channels", this.Channels);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
        }
    }
}

