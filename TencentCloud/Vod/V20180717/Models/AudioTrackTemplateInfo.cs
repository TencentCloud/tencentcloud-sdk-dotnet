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

    public class AudioTrackTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// 模板唯一标识。
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// 音频轨编码格式。
        /// 当 Container 为 mp3 时，可选值为：
        /// <li>libmp3lame。</li>
        /// 当 Container 为 ogg 或 flac 时，可选值为：
        /// <li>flac。</li>
        /// 当 Container 为 m4a 时，可选值为：
        /// <li>libfdk_aac；</li>
        /// <li>libmp3lame；</li>
        /// <li>ac3。</li>
        /// 当视频轨 Container 为 mp4 或 flv 时，可选值为：
        /// <li>libfdk_aac：更适合 mp4；</li>
        /// <li>libmp3lame：更适合 flv；</li>
        /// <li>mp2。</li>
        /// 当视频轨 Container 为  hls 时，可选值为：
        /// <li>libfdk_aac；</li>
        /// <li>libmp3lame。</li>
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// 音频流的码率，取值范围：0 和 [26, 256]，单位：kbps。
        /// 当取值为 0，表示音频码率和原始音频保持一致。
        /// </summary>
        [JsonProperty("Bitrate")]
        public ulong? Bitrate{ get; set; }

        /// <summary>
        /// 音频流的采样率，可选值：
        /// <li>32000</li>
        /// <li>44100</li>
        /// <li>48000</li>
        /// 单位：Hz。
        /// </summary>
        [JsonProperty("SampleRate")]
        public ulong? SampleRate{ get; set; }

        /// <summary>
        /// 模板类型，可选值：
        /// <li>Preset：系统预置模板；</li>
        /// <li>Custom：用户自定义模板。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 模板名称，长度限制：64 个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 模板描述信息，长度限制：256 个字符。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 音频通道方式，可选值：
        /// <li>1：单通道</li>
        /// <li>2：双通道</li>
        /// <li>6：立体声</li>
        /// 默认值：2。
        /// </summary>
        [JsonProperty("AudioChannel")]
        public long? AudioChannel{ get; set; }

        /// <summary>
        /// 模板创建时间，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F)。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 模板最后修改时间，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F)。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "AudioChannel", this.AudioChannel);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

