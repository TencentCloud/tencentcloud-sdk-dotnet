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

    public class MediaTranscodeItem : AbstractModel
    {
        
        /// <summary>
        /// <p>转码后的视频文件地址。</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>转码规格 ID，参见<a href="https://cloud.tencent.com/document/product/266/33476">转码参数模板</a>。<br><font color="red">注意：取值 0 表示原始文件。</font></p>
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// <p>视频流码率平均值与音频流码率平均值之和， 单位：bps。</p>
        /// </summary>
        [JsonProperty("Bitrate")]
        public long? Bitrate{ get; set; }

        /// <summary>
        /// <p>视频流高度的最大值，单位：px。</p>
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// <p>视频流宽度的最大值，单位：px。</p>
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// <p>媒体文件总大小，单位：字节。</p><li>当媒体文件为 HLS 时，大小是 m3u8 和 ts 文件大小的总和。</li>
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// <p>视频时长，单位：秒。</p>
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// <p>视频的 md5 值。</p>
        /// </summary>
        [JsonProperty("Md5")]
        public string Md5{ get; set; }

        /// <summary>
        /// <p>容器类型，例如 m4a，mp4 等。</p>
        /// </summary>
        [JsonProperty("Container")]
        public string Container{ get; set; }

        /// <summary>
        /// <p>视频流信息。</p>
        /// </summary>
        [JsonProperty("VideoStreamSet")]
        public MediaVideoStreamItem[] VideoStreamSet{ get; set; }

        /// <summary>
        /// <p>音频流信息。</p>
        /// </summary>
        [JsonProperty("AudioStreamSet")]
        public MediaAudioStreamItem[] AudioStreamSet{ get; set; }

        /// <summary>
        /// <p>数字水印类型。可选值：</p><li>Trace 表示经过溯源水印处理；</li><li>CopyRight 表示经过版权水印处理；</li><li>None 表示没有经过数字水印处理。</li>
        /// </summary>
        [JsonProperty("DigitalWatermarkType")]
        public string DigitalWatermarkType{ get; set; }

        /// <summary>
        /// <p>版权信息。</p>
        /// </summary>
        [JsonProperty("CopyRightWatermarkText")]
        public string CopyRightWatermarkText{ get; set; }

        /// <summary>
        /// <p>数字水印模板id。</p>
        /// </summary>
        [JsonProperty("BlindWatermarkDefinition")]
        public long? BlindWatermarkDefinition{ get; set; }

        /// <summary>
        /// <p>转码生成的新FileId，请求开启独立媒资输出时有效。</p>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "Md5", this.Md5);
            this.SetParamSimple(map, prefix + "Container", this.Container);
            this.SetParamArrayObj(map, prefix + "VideoStreamSet.", this.VideoStreamSet);
            this.SetParamArrayObj(map, prefix + "AudioStreamSet.", this.AudioStreamSet);
            this.SetParamSimple(map, prefix + "DigitalWatermarkType", this.DigitalWatermarkType);
            this.SetParamSimple(map, prefix + "CopyRightWatermarkText", this.CopyRightWatermarkText);
            this.SetParamSimple(map, prefix + "BlindWatermarkDefinition", this.BlindWatermarkDefinition);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
        }
    }
}

