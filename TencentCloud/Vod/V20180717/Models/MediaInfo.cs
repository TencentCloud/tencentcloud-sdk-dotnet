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

    public class MediaInfo : AbstractModel
    {
        
        /// <summary>
        /// 基础信息。包括视频名称、分类、播放地址、封面图片等。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BasicInfo")]
        public MediaBasicInfo BasicInfo{ get; set; }

        /// <summary>
        /// 元信息。包括大小、时长、视频流信息、音频流信息等。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetaData")]
        public MediaMetaData MetaData{ get; set; }

        /// <summary>
        /// 转码结果信息。包括该视频转码生成的各种码率的视频的地址、规格、码率、分辨率等。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TranscodeInfo")]
        public MediaTranscodeInfo TranscodeInfo{ get; set; }

        /// <summary>
        /// 转动图结果信息。对视频转动图（如 gif）后，动图相关信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AnimatedGraphicsInfo")]
        public MediaAnimatedGraphicsInfo AnimatedGraphicsInfo{ get; set; }

        /// <summary>
        /// 采样截图信息。对视频采样截图后，相关截图信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SampleSnapshotInfo")]
        public MediaSampleSnapshotInfo SampleSnapshotInfo{ get; set; }

        /// <summary>
        /// 雪碧图信息。对视频截取雪碧图之后，雪碧的相关信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageSpriteInfo")]
        public MediaImageSpriteInfo ImageSpriteInfo{ get; set; }

        /// <summary>
        /// 指定时间点截图信息。对视频依照指定时间点截图后，各个截图的信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SnapshotByTimeOffsetInfo")]
        public MediaSnapshotByTimeOffsetInfo SnapshotByTimeOffsetInfo{ get; set; }

        /// <summary>
        /// 视频打点信息。对视频设置的各个打点信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KeyFrameDescInfo")]
        public MediaKeyFrameDescInfo KeyFrameDescInfo{ get; set; }

        /// <summary>
        /// 转自适应码流信息。包括规格、加密类型、打包格式等相关信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdaptiveDynamicStreamingInfo")]
        public MediaAdaptiveDynamicStreamingInfo AdaptiveDynamicStreamingInfo{ get; set; }

        /// <summary>
        /// 小程序审核信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MiniProgramReviewInfo")]
        public MediaMiniProgramReviewInfo MiniProgramReviewInfo{ get; set; }

        /// <summary>
        /// 媒体文件唯一标识 ID。
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "BasicInfo.", this.BasicInfo);
            this.SetParamObj(map, prefix + "MetaData.", this.MetaData);
            this.SetParamObj(map, prefix + "TranscodeInfo.", this.TranscodeInfo);
            this.SetParamObj(map, prefix + "AnimatedGraphicsInfo.", this.AnimatedGraphicsInfo);
            this.SetParamObj(map, prefix + "SampleSnapshotInfo.", this.SampleSnapshotInfo);
            this.SetParamObj(map, prefix + "ImageSpriteInfo.", this.ImageSpriteInfo);
            this.SetParamObj(map, prefix + "SnapshotByTimeOffsetInfo.", this.SnapshotByTimeOffsetInfo);
            this.SetParamObj(map, prefix + "KeyFrameDescInfo.", this.KeyFrameDescInfo);
            this.SetParamObj(map, prefix + "AdaptiveDynamicStreamingInfo.", this.AdaptiveDynamicStreamingInfo);
            this.SetParamObj(map, prefix + "MiniProgramReviewInfo.", this.MiniProgramReviewInfo);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
        }
    }
}

