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

    public class ComposeTargetInfo : AbstractModel
    {
        
        /// <summary>
        /// 封装容器格式，可选值：
        /// <li>mp4：视频文件（默认）。</li>
        /// <li>mp3：纯音频文件。</li>
        /// </summary>
        [JsonProperty("Container")]
        public string Container{ get; set; }

        /// <summary>
        /// 是否去除视频数据，可选值：
        /// <li>0：保留（默认）。</li>
        /// <li>1：去除。</li>
        /// </summary>
        [JsonProperty("RemoveVideo")]
        public long? RemoveVideo{ get; set; }

        /// <summary>
        /// 是否去除音频数据，可选值：
        /// <li>0：保留（默认）。</li>
        /// <li>1：去除。</li>
        /// </summary>
        [JsonProperty("RemoveAudio")]
        public long? RemoveAudio{ get; set; }

        /// <summary>
        /// 输出视频流信息。
        /// </summary>
        [JsonProperty("VideoStream")]
        public ComposeVideoStream VideoStream{ get; set; }

        /// <summary>
        /// 输出音频流信息。
        /// </summary>
        [JsonProperty("AudioStream")]
        public ComposeAudioStream AudioStream{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Container", this.Container);
            this.SetParamSimple(map, prefix + "RemoveVideo", this.RemoveVideo);
            this.SetParamSimple(map, prefix + "RemoveAudio", this.RemoveAudio);
            this.SetParamObj(map, prefix + "VideoStream.", this.VideoStream);
            this.SetParamObj(map, prefix + "AudioStream.", this.AudioStream);
        }
    }
}

