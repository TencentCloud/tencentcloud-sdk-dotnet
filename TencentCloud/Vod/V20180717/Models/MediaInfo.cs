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

    public class MediaInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>基础信息。包括视频名称、分类、播放地址、封面图片等。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BasicInfo")]
        public MediaBasicInfo BasicInfo{ get; set; }

        /// <summary>
        /// <p>元信息。包括大小、时长、视频流信息、音频流信息等。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetaData")]
        public MediaMetaData MetaData{ get; set; }

        /// <summary>
        /// <p>转码结果信息。包括该视频转码生成的各种码率的视频的地址、规格、码率、分辨率等。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TranscodeInfo")]
        public MediaTranscodeInfo TranscodeInfo{ get; set; }

        /// <summary>
        /// <p>转动图结果信息。对视频转动图（如 gif）后，动图相关信息。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AnimatedGraphicsInfo")]
        public MediaAnimatedGraphicsInfo AnimatedGraphicsInfo{ get; set; }

        /// <summary>
        /// <p>采样截图信息。对视频采样截图后，相关截图信息。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SampleSnapshotInfo")]
        public MediaSampleSnapshotInfo SampleSnapshotInfo{ get; set; }

        /// <summary>
        /// <p>雪碧图信息。对视频截取雪碧图之后，雪碧的相关信息。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageSpriteInfo")]
        public MediaImageSpriteInfo ImageSpriteInfo{ get; set; }

        /// <summary>
        /// <p>指定时间点截图信息。对视频依照指定时间点截图后，各个截图的信息。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SnapshotByTimeOffsetInfo")]
        public MediaSnapshotByTimeOffsetInfo SnapshotByTimeOffsetInfo{ get; set; }

        /// <summary>
        /// <p>视频打点信息。对视频设置的各个打点信息。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KeyFrameDescInfo")]
        public MediaKeyFrameDescInfo KeyFrameDescInfo{ get; set; }

        /// <summary>
        /// <p>转自适应码流信息。包括规格、加密类型、打包格式等相关信息。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdaptiveDynamicStreamingInfo")]
        public MediaAdaptiveDynamicStreamingInfo AdaptiveDynamicStreamingInfo{ get; set; }

        /// <summary>
        /// <p>小程序审核信息。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MiniProgramReviewInfo")]
        public MediaMiniProgramReviewInfo MiniProgramReviewInfo{ get; set; }

        /// <summary>
        /// <p>字幕信息。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubtitleInfo")]
        public MediaSubtitleInfo SubtitleInfo{ get; set; }

        /// <summary>
        /// <p>媒体文件唯一标识 ID。</p>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <p>审核信息。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReviewInfo")]
        public FileReviewInfo ReviewInfo{ get; set; }

        /// <summary>
        /// <p>MPS智能媒资信息</p>
        /// </summary>
        [JsonProperty("MPSAiMediaInfo")]
        public MPSAiMediaInfo MPSAiMediaInfo{ get; set; }

        /// <summary>
        /// <p>图片理解信息。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageUnderstandingInfo")]
        public ImageUnderstandingInfo ImageUnderstandingInfo{ get; set; }

        /// <summary>
        /// <p>智能知识库信息。</p>
        /// </summary>
        [JsonProperty("KnowledgeBasesInfo")]
        public KnowledgeBasesInfo KnowledgeBasesInfo{ get; set; }

        /// <summary>
        /// <p>人脸识别信息。</p>
        /// </summary>
        [JsonProperty("FaceRecognitionInfo")]
        public FaceRecognitionInfo FaceRecognitionInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
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
            this.SetParamObj(map, prefix + "SubtitleInfo.", this.SubtitleInfo);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamObj(map, prefix + "ReviewInfo.", this.ReviewInfo);
            this.SetParamObj(map, prefix + "MPSAiMediaInfo.", this.MPSAiMediaInfo);
            this.SetParamObj(map, prefix + "ImageUnderstandingInfo.", this.ImageUnderstandingInfo);
            this.SetParamObj(map, prefix + "KnowledgeBasesInfo.", this.KnowledgeBasesInfo);
            this.SetParamObj(map, prefix + "FaceRecognitionInfo.", this.FaceRecognitionInfo);
        }
    }
}

