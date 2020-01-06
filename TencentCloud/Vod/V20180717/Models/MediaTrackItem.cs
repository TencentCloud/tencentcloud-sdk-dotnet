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

    public class MediaTrackItem : AbstractModel
    {
        
        /// <summary>
        /// 片段类型。取值有：
        /// <li>Video：视频片段。</li>
        /// <li>Audio：音频片段。</li>
        /// <li>Sticker：贴图片段。</li>
        /// <li>Transition：转场。</li>
        /// <li>Empty：空白片段。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 视频片段，当 Type = Video 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VideoItem")]
        public VideoTrackItem VideoItem{ get; set; }

        /// <summary>
        /// 音频片段，当 Type = Audio 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AudioItem")]
        public AudioTrackItem AudioItem{ get; set; }

        /// <summary>
        /// 贴图片段，当 Type = Sticker 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StickerItem")]
        public StickerTrackItem StickerItem{ get; set; }

        /// <summary>
        /// 转场，当 Type = Transition 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TransitionItem")]
        public MediaTransitionItem TransitionItem{ get; set; }

        /// <summary>
        /// 空白片段，当 Type = Empty 时有效。空片段用于时间轴的占位。<li>如需要两个音频片段之间有一段时间的静音，可以用 EmptyTrackItem 来进行占位。</li>
        /// <li>使用 EmptyTrackItem 进行占位，来定位某个Item。</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EmptyItem")]
        public EmptyTrackItem EmptyItem{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "VideoItem.", this.VideoItem);
            this.SetParamObj(map, prefix + "AudioItem.", this.AudioItem);
            this.SetParamObj(map, prefix + "StickerItem.", this.StickerItem);
            this.SetParamObj(map, prefix + "TransitionItem.", this.TransitionItem);
            this.SetParamObj(map, prefix + "EmptyItem.", this.EmptyItem);
        }
    }
}

