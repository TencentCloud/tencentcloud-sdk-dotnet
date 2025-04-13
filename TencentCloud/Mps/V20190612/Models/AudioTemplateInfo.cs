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

    public class AudioTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// 音频流的编码格式。
        /// 当不需要对音频进行转码时，可选值为：
        /// <li>copy。</li>
        /// 当外层参数 Container 为 mp3 时，可选值为：
        /// <li>mp3。</li>
        /// 当外层参数 Container 为 ogg 或 flac 时，可选值为：
        /// <li>flac。</li>
        /// 当外层参数 Container 为 m4a 时，可选值为：
        /// <li>aac；</li>
        /// <li>ac3。</li>
        /// 当外层参数 Container 为 mp4 或 flv 时，可选值为：
        /// <li>aac：更适合 mp4；</li>
        /// <li>mp3：更适合 flv；</li>
        /// <li>mp2。</li>
        /// 当外层参数 Container 为 hls 时，可选值为：
        /// <li>aac；</li>
        /// <li>mp3;</li>
        /// <li>eac3：自适应转码音轨合并时使用。</li>
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// 音频流的码率，取值范围：0 和 [26, 256]，单位：kbps。
        /// 当取值为 0，表示音频码率和原始音频保持一致。
        /// 注意：如果使用自适应转码音轨合并TrackChannelInfo参数，取值范围：
        /// 1）、不能填0；
        /// 2）、Codec为：aac时，取值范围：[26, 256];
        /// 3）、Codec为：ac3时，取值范围：[26, 640];
        /// 4)、Codec为：eac3时，取值范围：[26, 6144]，备注：当SampleRate为44100HZ，最大值为：5644，当SampleRate为48000HZ，最大值为：6144，
        /// 
        /// </summary>
        [JsonProperty("Bitrate")]
        public long? Bitrate{ get; set; }

        /// <summary>
        /// 音频流的采样率，不同编码标准支持的采样率选项不同。详细参考[音频采样率支持范围文档]https://cloud.tencent.com/document/product/862/77166#f3b039f1-d817-4a96-b4e4-90132d31cd53
        /// 单位：Hz
        /// 注意：请确保源音频流的采样率在上述选项范围内，否则可能导致转码失败！
        /// </summary>
        [JsonProperty("SampleRate")]
        public ulong? SampleRate{ get; set; }

        /// <summary>
        /// 音频通道方式，可选值：
        /// <li>1：单通道</li>
        /// <li>2：双通道</li>
        /// <li>6：5.1声道</li>
        /// 当媒体的封装格式是音频格式时（flac，ogg，mp3，m4a）时，声道数不允许设为5.1声道。
        /// 默认值：2。
        /// </summary>
        [JsonProperty("AudioChannel")]
        public long? AudioChannel{ get; set; }

        /// <summary>
        /// 合并音轨信息。
        /// 注意：此字段只是自适应转码生效，
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TrackChannelInfo")]
        public AudioTrackChannelInfo TrackChannelInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "AudioChannel", this.AudioChannel);
            this.SetParamObj(map, prefix + "TrackChannelInfo.", this.TrackChannelInfo);
        }
    }
}

