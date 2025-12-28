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

    public class AiAnalysisResult : AbstractModel
    {
        
        /// <summary>
        /// 任务的类型，可以取的值有：
        /// <li>Classification：智能分类</li>
        /// <li>Cover：智能封面</li>
        /// <li>Tag：智能标签</li>
        /// <li>FrameTag：智能按帧标签</li>
        /// <li>Highlight：智能精彩集锦</li>
        /// <li>DeLogo：智能擦除</li>
        /// <li>Description：大模型摘要</li>
        /// <li>Dubbing：智能译制</li>
        /// <li>VideoRemake: 视频去重</li>
        /// <li>VideoComprehension: 视频（音频）理解</li>
        /// <li>Cutout：视频抠图</li>
        /// <li>Reel：智能成片</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 视频内容分析智能分类任务的查询结果，当任务类型为 Classification 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClassificationTask")]
        public AiAnalysisTaskClassificationResult ClassificationTask{ get; set; }

        /// <summary>
        /// 视频内容分析智能封面任务的查询结果，当任务类型为 Cover 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CoverTask")]
        public AiAnalysisTaskCoverResult CoverTask{ get; set; }

        /// <summary>
        /// 视频内容分析智能标签任务的查询结果，当任务类型为 Tag 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagTask")]
        public AiAnalysisTaskTagResult TagTask{ get; set; }

        /// <summary>
        /// 视频内容分析智能按帧标签任务的查询结果，当任务类型为 FrameTag 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrameTagTask")]
        public AiAnalysisTaskFrameTagResult FrameTagTask{ get; set; }

        /// <summary>
        /// 视频内容分析集锦任务的查询结果，当任务类型为 Highlight时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HighlightTask")]
        public AiAnalysisTaskHighlightResult HighlightTask{ get; set; }

        /// <summary>
        /// 视频内容分析智能擦除任务的查询结果，当任务类型为 DeLogo 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeLogoTask")]
        public AiAnalysisTaskDelLogoResult DeLogoTask{ get; set; }

        /// <summary>
        /// 视频内容分析拆条任务的查询结果，当任务类型为 SegmentRecognition 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SegmentTask")]
        public AiAnalysisTaskSegmentResult SegmentTask{ get; set; }

        /// <summary>
        /// 视频内容分析片头片尾任务的查询结果，当任务类型为 HeadTailRecognition 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HeadTailTask")]
        public AiAnalysisTaskHeadTailResult HeadTailTask{ get; set; }

        /// <summary>
        /// 视频内容分析摘要任务的查询结果，当任务类型为 Description 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DescriptionTask")]
        public AiAnalysisTaskDescriptionResult DescriptionTask{ get; set; }

        /// <summary>
        /// 视频内容分析横转竖任务的查询结果，当任务类型为 HorizontalToVertical 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HorizontalToVerticalTask")]
        public AiAnalysisTaskHorizontalToVerticalResult HorizontalToVerticalTask{ get; set; }

        /// <summary>
        /// 视频内容分析译制任务的查询结果，当任务类型为 Dubbing 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DubbingTask")]
        public AiAnalysisTaskDubbingResult DubbingTask{ get; set; }

        /// <summary>
        /// 视频内容分析去重任务的查询结果，当任务类型为 VideoRemake 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VideoRemakeTask")]
        public AiAnalysisTaskVideoRemakeResult VideoRemakeTask{ get; set; }

        /// <summary>
        /// 视频（音频）理解任务的查询结果，当任务类型为 VideoComprehension 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VideoComprehensionTask")]
        public AiAnalysisTaskVideoComprehensionResult VideoComprehensionTask{ get; set; }

        /// <summary>
        /// 视频内容分析抠图任务的查询结果，当任务类型为Cutout时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CutoutTask")]
        public AiAnalysisTaskCutoutResult CutoutTask{ get; set; }

        /// <summary>
        /// 视频内容分析成片任务的查询结果，当任务类型为Reel时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReelTask")]
        public AiAnalysisTaskReelResult ReelTask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "ClassificationTask.", this.ClassificationTask);
            this.SetParamObj(map, prefix + "CoverTask.", this.CoverTask);
            this.SetParamObj(map, prefix + "TagTask.", this.TagTask);
            this.SetParamObj(map, prefix + "FrameTagTask.", this.FrameTagTask);
            this.SetParamObj(map, prefix + "HighlightTask.", this.HighlightTask);
            this.SetParamObj(map, prefix + "DeLogoTask.", this.DeLogoTask);
            this.SetParamObj(map, prefix + "SegmentTask.", this.SegmentTask);
            this.SetParamObj(map, prefix + "HeadTailTask.", this.HeadTailTask);
            this.SetParamObj(map, prefix + "DescriptionTask.", this.DescriptionTask);
            this.SetParamObj(map, prefix + "HorizontalToVerticalTask.", this.HorizontalToVerticalTask);
            this.SetParamObj(map, prefix + "DubbingTask.", this.DubbingTask);
            this.SetParamObj(map, prefix + "VideoRemakeTask.", this.VideoRemakeTask);
            this.SetParamObj(map, prefix + "VideoComprehensionTask.", this.VideoComprehensionTask);
            this.SetParamObj(map, prefix + "CutoutTask.", this.CutoutTask);
            this.SetParamObj(map, prefix + "ReelTask.", this.ReelTask);
        }
    }
}

