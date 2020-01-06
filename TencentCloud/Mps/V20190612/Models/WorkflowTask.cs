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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkflowTask : AbstractModel
    {
        
        /// <summary>
        /// 视频处理任务 ID。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 任务流状态，取值：
        /// <li>PROCESSING：处理中；</li>
        /// <li>FINISH：已完成。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 已弃用，请使用各个具体任务的 ErrCode。
        /// </summary>
        [JsonProperty("ErrCode")]
        public long? ErrCode{ get; set; }

        /// <summary>
        /// 已弃用，请使用各个具体任务的 Message。
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 视频处理的目标文件信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InputInfo")]
        public MediaInputInfo InputInfo{ get; set; }

        /// <summary>
        /// 原始视频的元信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetaData")]
        public MediaMetaData MetaData{ get; set; }

        /// <summary>
        /// 视频处理任务的执行状态与结果。
        /// </summary>
        [JsonProperty("MediaProcessResultSet")]
        public MediaProcessTaskResult[] MediaProcessResultSet{ get; set; }

        /// <summary>
        /// 视频内容审核任务的执行状态与结果。
        /// </summary>
        [JsonProperty("AiContentReviewResultSet")]
        public AiContentReviewResult[] AiContentReviewResultSet{ get; set; }

        /// <summary>
        /// 视频内容分析任务的执行状态与结果。
        /// </summary>
        [JsonProperty("AiAnalysisResultSet")]
        public AiAnalysisResult[] AiAnalysisResultSet{ get; set; }

        /// <summary>
        /// 视频内容识别任务的执行状态与结果。
        /// </summary>
        [JsonProperty("AiRecognitionResultSet")]
        public AiRecognitionResult[] AiRecognitionResultSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamObj(map, prefix + "InputInfo.", this.InputInfo);
            this.SetParamObj(map, prefix + "MetaData.", this.MetaData);
            this.SetParamArrayObj(map, prefix + "MediaProcessResultSet.", this.MediaProcessResultSet);
            this.SetParamArrayObj(map, prefix + "AiContentReviewResultSet.", this.AiContentReviewResultSet);
            this.SetParamArrayObj(map, prefix + "AiAnalysisResultSet.", this.AiAnalysisResultSet);
            this.SetParamArrayObj(map, prefix + "AiRecognitionResultSet.", this.AiRecognitionResultSet);
        }
    }
}

