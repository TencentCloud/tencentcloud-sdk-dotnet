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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EditingTaskResult : AbstractModel
    {
        
        /// <summary>
        /// 编辑任务 ID。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 编辑任务状态。 
        /// 1：执行中；2：已完成。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 视频标签识别结果。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagTaskResult")]
        public TagTaskResult TagTaskResult{ get; set; }

        /// <summary>
        /// 视频分类识别结果。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClassificationTaskResult")]
        public ClassificationTaskResult ClassificationTaskResult{ get; set; }

        /// <summary>
        /// 智能拆条结果。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StripTaskResult")]
        public StripTaskResult StripTaskResult{ get; set; }

        /// <summary>
        /// 智能集锦结果。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HighlightsTaskResult")]
        public HighlightsTaskResult HighlightsTaskResult{ get; set; }

        /// <summary>
        /// 智能封面结果。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CoverTaskResult")]
        public CoverTaskResult CoverTaskResult{ get; set; }

        /// <summary>
        /// 片头片尾识别结果。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OpeningEndingTaskResult")]
        public OpeningEndingTaskResult OpeningEndingTaskResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "TagTaskResult.", this.TagTaskResult);
            this.SetParamObj(map, prefix + "ClassificationTaskResult.", this.ClassificationTaskResult);
            this.SetParamObj(map, prefix + "StripTaskResult.", this.StripTaskResult);
            this.SetParamObj(map, prefix + "HighlightsTaskResult.", this.HighlightsTaskResult);
            this.SetParamObj(map, prefix + "CoverTaskResult.", this.CoverTaskResult);
            this.SetParamObj(map, prefix + "OpeningEndingTaskResult.", this.OpeningEndingTaskResult);
        }
    }
}

