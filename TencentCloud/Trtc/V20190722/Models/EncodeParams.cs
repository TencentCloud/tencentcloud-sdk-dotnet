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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EncodeParams : AbstractModel
    {
        
        /// <summary>
        /// 混流-输出流音频采样率
        /// </summary>
        [JsonProperty("AudioSampleRate")]
        public ulong? AudioSampleRate{ get; set; }

        /// <summary>
        /// 混流-输出流音频码率，单位Kbps
        /// </summary>
        [JsonProperty("AudioBitrate")]
        public ulong? AudioBitrate{ get; set; }

        /// <summary>
        /// 混流-输出流音频声道数
        /// </summary>
        [JsonProperty("AudioChannels")]
        public ulong? AudioChannels{ get; set; }

        /// <summary>
        /// 混流-输出流宽，音视频输出时必填
        /// </summary>
        [JsonProperty("VideoWidth")]
        public ulong? VideoWidth{ get; set; }

        /// <summary>
        /// 混流-输出流高，音视频输出时必填
        /// </summary>
        [JsonProperty("VideoHeight")]
        public ulong? VideoHeight{ get; set; }

        /// <summary>
        /// 混流-输出流码率，单位Kbps，音视频输出时必填
        /// </summary>
        [JsonProperty("VideoBitrate")]
        public ulong? VideoBitrate{ get; set; }

        /// <summary>
        /// 混流-输出流帧率，音视频输出时必填
        /// </summary>
        [JsonProperty("VideoFramerate")]
        public ulong? VideoFramerate{ get; set; }

        /// <summary>
        /// 混流-输出流gop，音视频输出时必填
        /// </summary>
        [JsonProperty("VideoGop")]
        public ulong? VideoGop{ get; set; }

        /// <summary>
        /// 混流-输出流背景色
        /// </summary>
        [JsonProperty("BackgroundColor")]
        public ulong? BackgroundColor{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AudioSampleRate", this.AudioSampleRate);
            this.SetParamSimple(map, prefix + "AudioBitrate", this.AudioBitrate);
            this.SetParamSimple(map, prefix + "AudioChannels", this.AudioChannels);
            this.SetParamSimple(map, prefix + "VideoWidth", this.VideoWidth);
            this.SetParamSimple(map, prefix + "VideoHeight", this.VideoHeight);
            this.SetParamSimple(map, prefix + "VideoBitrate", this.VideoBitrate);
            this.SetParamSimple(map, prefix + "VideoFramerate", this.VideoFramerate);
            this.SetParamSimple(map, prefix + "VideoGop", this.VideoGop);
            this.SetParamSimple(map, prefix + "BackgroundColor", this.BackgroundColor);
        }
    }
}

