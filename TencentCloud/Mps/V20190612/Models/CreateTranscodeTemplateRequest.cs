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

    public class CreateTranscodeTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>封装格式，可选值：mp4、flv、hls、ts、webm、mkv、mxf、mov、mp3、flac、ogg、m4a、wav。其中，mp3、flac、ogg、m4a、wav 为纯音频文件。</p>
        /// </summary>
        [JsonProperty("Container")]
        public string Container{ get; set; }

        /// <summary>
        /// <p>转码模板名称，长度限制：64 个字符。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>模板描述信息，长度限制：256 个字符。</p>
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>是否去除视频数据，可选值：</p><li>0：保留</li><li>1：去除</li>默认值：0。
        /// </summary>
        [JsonProperty("RemoveVideo")]
        public long? RemoveVideo{ get; set; }

        /// <summary>
        /// <p>是否去除音频数据，可选值：</p><li>0：保留</li><li>1：去除</li>默认值：0。
        /// </summary>
        [JsonProperty("RemoveAudio")]
        public long? RemoveAudio{ get; set; }

        /// <summary>
        /// <p>视频流配置参数，当 RemoveVideo 为 0，该字段必填。</p>
        /// </summary>
        [JsonProperty("VideoTemplate")]
        public VideoTemplateInfo VideoTemplate{ get; set; }

        /// <summary>
        /// <p>音频流配置参数，当 RemoveAudio 为 0，该字段必填。</p>
        /// </summary>
        [JsonProperty("AudioTemplate")]
        public AudioTemplateInfo AudioTemplate{ get; set; }

        /// <summary>
        /// <p>极速高清转码参数。</p>
        /// </summary>
        [JsonProperty("TEHDConfig")]
        public TEHDConfig TEHDConfig{ get; set; }

        /// <summary>
        /// <p>音视频增强配置。</p>
        /// </summary>
        [JsonProperty("EnhanceConfig")]
        public EnhanceConfig EnhanceConfig{ get; set; }

        /// <summary>
        /// <p>扩展参数，序列化的 json 字符串。</p>
        /// </summary>
        [JsonProperty("StdExtInfo")]
        public string StdExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Container", this.Container);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "RemoveVideo", this.RemoveVideo);
            this.SetParamSimple(map, prefix + "RemoveAudio", this.RemoveAudio);
            this.SetParamObj(map, prefix + "VideoTemplate.", this.VideoTemplate);
            this.SetParamObj(map, prefix + "AudioTemplate.", this.AudioTemplate);
            this.SetParamObj(map, prefix + "TEHDConfig.", this.TEHDConfig);
            this.SetParamObj(map, prefix + "EnhanceConfig.", this.EnhanceConfig);
            this.SetParamSimple(map, prefix + "StdExtInfo", this.StdExtInfo);
        }
    }
}

