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

    public class AiAnalysisResult : AbstractModel
    {
        
        /// <summary>
        /// 任务的类型，可以取的值有：
        /// <li>Classification：智能分类</li>
        /// <li>Cover：智能封面</li>
        /// <li>Tag：智能标签</li>
        /// <li>FrameTag：智能按帧标签</li>
        /// <li>Highlight：智能精彩集锦</li>
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
        /// 视频内容分析智能精彩集锦任务的查询结果，当任务类型为 Highlight 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HighlightTask")]
        public AiAnalysisTaskHighlightResult HighlightTask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "ClassificationTask.", this.ClassificationTask);
            this.SetParamObj(map, prefix + "CoverTask.", this.CoverTask);
            this.SetParamObj(map, prefix + "TagTask.", this.TagTask);
            this.SetParamObj(map, prefix + "FrameTagTask.", this.FrameTagTask);
            this.SetParamObj(map, prefix + "HighlightTask.", this.HighlightTask);
        }
    }
}

