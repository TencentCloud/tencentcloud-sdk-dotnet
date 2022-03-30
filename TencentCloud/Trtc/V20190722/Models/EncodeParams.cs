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
        /// 混流-输出流音频采样率。取值为[48000, 44100, 32000, 24000, 16000, 8000]，单位是Hz。
        /// </summary>
        [JsonProperty("AudioSampleRate")]
        public ulong? AudioSampleRate{ get; set; }

        /// <summary>
        /// 混流-输出流音频码率。取值范围[8,500]，单位为kbps。
        /// </summary>
        [JsonProperty("AudioBitrate")]
        public ulong? AudioBitrate{ get; set; }

        /// <summary>
        /// 混流-输出流音频声道数，取值范围[1,2]，1表示混流输出音频为单声道，2表示混流输出音频为双声道。
        /// </summary>
        [JsonProperty("AudioChannels")]
        public ulong? AudioChannels{ get; set; }

        /// <summary>
        /// 混流-输出流宽，音视频输出时必填。取值范围[0,1920]，单位为像素值。
        /// </summary>
        [JsonProperty("VideoWidth")]
        public ulong? VideoWidth{ get; set; }

        /// <summary>
        /// 混流-输出流高，音视频输出时必填。取值范围[0,1080]，单位为像素值。
        /// </summary>
        [JsonProperty("VideoHeight")]
        public ulong? VideoHeight{ get; set; }

        /// <summary>
        /// 混流-输出流码率，音视频输出时必填。取值范围[1,10000]，单位为kbps。
        /// </summary>
        [JsonProperty("VideoBitrate")]
        public ulong? VideoBitrate{ get; set; }

        /// <summary>
        /// 混流-输出流帧率，音视频输出时必填。取值范围[1,60]，表示混流的输出帧率可选范围为1到60fps。
        /// </summary>
        [JsonProperty("VideoFramerate")]
        public ulong? VideoFramerate{ get; set; }

        /// <summary>
        /// 混流-输出流gop，音视频输出时必填。取值范围[1,5]，单位为秒。
        /// </summary>
        [JsonProperty("VideoGop")]
        public ulong? VideoGop{ get; set; }

        /// <summary>
        /// 混流-输出流背景色，取值是十进制整数。常用的颜色有：
        /// 红色：0xff0000，对应的十进制整数是16724736。
        /// 黄色：0xffff00。对应的十进制整数是16776960。
        /// 绿色：0x33cc00。对应的十进制整数是3394560。
        /// 蓝色：0x0066ff。对应的十进制整数是26367。
        /// 黑色：0x000000。对应的十进制整数是0。
        /// 白色：0xFFFFFF。对应的十进制整数是16777215。
        /// 灰色：0x999999。对应的十进制整数是10066329。
        /// </summary>
        [JsonProperty("BackgroundColor")]
        public ulong? BackgroundColor{ get; set; }

        /// <summary>
        /// 混流-输出流背景图片，取值为实时音视频控制台上传的图片ID。
        /// </summary>
        [JsonProperty("BackgroundImageId")]
        public ulong? BackgroundImageId{ get; set; }

        /// <summary>
        /// 混流-输出流音频编码类型，取值范围[0,1, 2]，0为LC-AAC，1为HE-AAC，2为HE-AACv2。默认值为0。当音频编码设置为HE-AACv2时，只支持输出流音频声道数为双声道。HE-AAC和HE-AACv2支持的输出流音频采样率范围为[48000, 44100, 32000, 24000, 16000]
        /// </summary>
        [JsonProperty("AudioCodec")]
        public ulong? AudioCodec{ get; set; }

        /// <summary>
        /// 混流-输出流背景图片URL地址，支持png、jpg、jpeg、bmp格式，暂不支持透明通道。URL链接长度限制为512字节。BackgroundImageUrl和BackgroundImageId参数都填时，以BackgroundImageUrl为准。图片大小限制不超过2MB。
        /// </summary>
        [JsonProperty("BackgroundImageUrl")]
        public string BackgroundImageUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
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
            this.SetParamSimple(map, prefix + "BackgroundImageId", this.BackgroundImageId);
            this.SetParamSimple(map, prefix + "AudioCodec", this.AudioCodec);
            this.SetParamSimple(map, prefix + "BackgroundImageUrl", this.BackgroundImageUrl);
        }
    }
}

