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

    public class ResetProcedureTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>任务流名字</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p><b>点播<a href="/document/product/266/14574">应用</a> ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>模板描述信息，长度限制：256 个字符。</p>
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>视频处理类型任务参数。</p>
        /// </summary>
        [JsonProperty("MediaProcessTask")]
        public MediaProcessTaskInput MediaProcessTask{ get; set; }

        /// <summary>
        /// <p>AI 智能内容审核类型任务参数 *。<br><font color="red">*：该参数用于发起旧版审核，不建议使用。推荐使用 ReviewAudioVideoTask 参数发起审核。</font></p>
        /// </summary>
        [JsonProperty("AiContentReviewTask")]
        public AiContentReviewTaskInput AiContentReviewTask{ get; set; }

        /// <summary>
        /// <p>AI 智能内容分析类型任务参数。</p>
        /// </summary>
        [JsonProperty("AiAnalysisTask")]
        public AiAnalysisTaskInput AiAnalysisTask{ get; set; }

        /// <summary>
        /// <p>AI 内容识别类型任务参数。</p>
        /// </summary>
        [JsonProperty("AiRecognitionTaskSet")]
        public AiRecognitionTaskInput[] AiRecognitionTaskSet{ get; set; }

        /// <summary>
        /// <p>该参数已不推荐使用，建议使用 AiRecognitionTaskSet。</p>
        /// </summary>
        [JsonProperty("AiRecognitionTask")]
        [System.Obsolete]
        public AiRecognitionTaskInput AiRecognitionTask{ get; set; }

        /// <summary>
        /// <p>音视频审核类型任务参数。</p>
        /// </summary>
        [JsonProperty("ReviewAudioVideoTask")]
        public ProcedureReviewAudioVideoTaskInput ReviewAudioVideoTask{ get; set; }

        /// <summary>
        /// <p>导入智能媒资知识库任务参数。</p>
        /// </summary>
        [JsonProperty("ImportMediaKnowledgeTaskSet")]
        public ImportMediaKnowledgeTaskInput[] ImportMediaKnowledgeTaskSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamObj(map, prefix + "MediaProcessTask.", this.MediaProcessTask);
            this.SetParamObj(map, prefix + "AiContentReviewTask.", this.AiContentReviewTask);
            this.SetParamObj(map, prefix + "AiAnalysisTask.", this.AiAnalysisTask);
            this.SetParamArrayObj(map, prefix + "AiRecognitionTaskSet.", this.AiRecognitionTaskSet);
            this.SetParamObj(map, prefix + "AiRecognitionTask.", this.AiRecognitionTask);
            this.SetParamObj(map, prefix + "ReviewAudioVideoTask.", this.ReviewAudioVideoTask);
            this.SetParamArrayObj(map, prefix + "ImportMediaKnowledgeTaskSet.", this.ImportMediaKnowledgeTaskSet);
        }
    }
}

