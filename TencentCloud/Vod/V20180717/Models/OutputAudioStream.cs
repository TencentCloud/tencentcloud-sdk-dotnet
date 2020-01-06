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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OutputAudioStream : AbstractModel
    {
        
        /// <summary>
        /// 音频流的编码格式，可选值：
        /// <li>libfdk_aac：适合 mp4 文件。</li>
        /// 默认值：libfdk_aac。
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// 音频流的采样率，可选值：
        /// <li>16000</li>
        /// <li>32000</li>
        /// <li>44100</li>
        /// <li>48000</li>
        /// 单位：Hz。
        /// 默认值：16000。
        /// </summary>
        [JsonProperty("SampleRate")]
        public long? SampleRate{ get; set; }

        /// <summary>
        /// 音频声道数，可选值：
        /// <li>1：单声道 。</li>
        /// <li>2：双声道</li>
        /// 默认值：2。
        /// </summary>
        [JsonProperty("AudioChannel")]
        public long? AudioChannel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "AudioChannel", this.AudioChannel);
        }
    }
}

