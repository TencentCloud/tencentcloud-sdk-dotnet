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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaMetaData : AbstractModel
    {
        
        /// <summary>
        /// 上传的媒体文件大小（视频为 HLS 时，大小是 m3u8 和 ts 文件大小的总和），单位：字节。
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// 容器类型，例如 m4a，mp4 等。
        /// </summary>
        [JsonProperty("Container")]
        public string Container{ get; set; }

        /// <summary>
        /// 视频流码率平均值与音频流码率平均值之和，单位：bps。
        /// </summary>
        [JsonProperty("Bitrate")]
        public long? Bitrate{ get; set; }

        /// <summary>
        /// 视频流高度的最大值，单位：px。
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// 视频流宽度的最大值，单位：px。
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// 视频时长，单位：秒。
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// 视频拍摄时的选择角度，单位：度。
        /// </summary>
        [JsonProperty("Rotate")]
        public long? Rotate{ get; set; }

        /// <summary>
        /// 视频流信息。
        /// </summary>
        [JsonProperty("VideoStreamSet")]
        public MediaVideoStreamItem[] VideoStreamSet{ get; set; }

        /// <summary>
        /// 音频流信息。
        /// </summary>
        [JsonProperty("AudioStreamSet")]
        public MediaAudioStreamItem[] AudioStreamSet{ get; set; }

        /// <summary>
        /// 视频时长，单位：秒。
        /// </summary>
        [JsonProperty("VideoDuration")]
        public float? VideoDuration{ get; set; }

        /// <summary>
        /// 音频时长，单位：秒。
        /// </summary>
        [JsonProperty("AudioDuration")]
        public float? AudioDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "Container", this.Container);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "Rotate", this.Rotate);
            this.SetParamArrayObj(map, prefix + "VideoStreamSet.", this.VideoStreamSet);
            this.SetParamArrayObj(map, prefix + "AudioStreamSet.", this.AudioStreamSet);
            this.SetParamSimple(map, prefix + "VideoDuration", this.VideoDuration);
            this.SetParamSimple(map, prefix + "AudioDuration", this.AudioDuration);
        }
    }
}

