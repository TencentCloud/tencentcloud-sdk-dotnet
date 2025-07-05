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

    public class ComposeMediaItem : AbstractModel
    {
        
        /// <summary>
        /// 元素类型。取值有：
        /// <li>Video：视频元素。</li>
        /// <li>Audio：音频元素。</li>
        /// <li>Image：图片元素。</li>
        /// <li>Transition：转场元素。</li>
        /// <li>Subtitle：字幕元素。</li>
        /// <li>Empty：空白元素。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 视频元素，当 Type = Video 时有效。
        /// </summary>
        [JsonProperty("Video")]
        public ComposeVideoItem Video{ get; set; }

        /// <summary>
        /// 音频元素，当 Type = Audio 时有效。
        /// </summary>
        [JsonProperty("Audio")]
        public ComposeAudioItem Audio{ get; set; }

        /// <summary>
        /// 图片元素，当 Type = Image 时有效。
        /// </summary>
        [JsonProperty("Image")]
        public ComposeImageItem Image{ get; set; }

        /// <summary>
        /// 转场元素，当 Type = Transition 时有效。
        /// </summary>
        [JsonProperty("Transition")]
        public ComposeTransitionItem Transition{ get; set; }

        /// <summary>
        /// 字幕元素，当 Type = Subtitle 是有效。
        /// </summary>
        [JsonProperty("Subtitle")]
        public ComposeSubtitleItem Subtitle{ get; set; }

        /// <summary>
        /// 空白元素，当 Type = Empty 时有效。用于时间轴的占位。
        /// </summary>
        [JsonProperty("Empty")]
        public ComposeEmptyItem Empty{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "Video.", this.Video);
            this.SetParamObj(map, prefix + "Audio.", this.Audio);
            this.SetParamObj(map, prefix + "Image.", this.Image);
            this.SetParamObj(map, prefix + "Transition.", this.Transition);
            this.SetParamObj(map, prefix + "Subtitle.", this.Subtitle);
            this.SetParamObj(map, prefix + "Empty.", this.Empty);
        }
    }
}

