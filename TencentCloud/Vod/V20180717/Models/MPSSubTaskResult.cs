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

    public class MPSSubTaskResult : AbstractModel
    {
        
        /// <summary>
        /// 任务类型。MPS 的 WorkflowTask 结构中的具体子任务类型。取值：
        /// <li>MediaProcess.Transcode：音视频转码任务。</li>
        /// <li>AiAnalysis.DeLogo：智能擦除任务。</li>
        /// <li>AiAnalysis.ClassificationTask：智能分类任务。</li>
        /// <li>AiAnalysis.CoverTask：智能封面任务。</li>
        /// <li>AiAnalysis.TagTask：智能标签任务。</li>
        /// <li>AiAnalysis.FrameTagTask：智能按帧标签任务。</li>
        /// <li>AiAnalysis.HighlightTask：智能高光任务。</li>
        /// <li>AiAnalysis.SegmentTask：智能拆条任务。</li>
        /// <li>AiAnalysis.HeadTailTask：智能片头片尾任务。</li>
        /// <li>AiAnalysis.DescriptionTask：智能摘要任务。</li>
        /// <li>AiAnalysis.HorizontalToVerticalTask：智能横转竖任务。</li>
        /// <li>AiAnalysis.DubbingTask：智能译制任务。</li>
        /// <li>AiAnalysis.VideoRemakeTask：智能去重任务。</li>
        /// <li>AiAnalysis.VideoComprehensionTask：视频理解任务。</li>
        /// <li>SmartSubtitle.AsrFullTextTask：智能语音全文识别任务。</li>
        /// <li>SmartSubtitle.TransTextTask：	翻译结果。</li>
        /// <li>SmartSubtitle.PureSubtitleTransTask：返回纯字幕文件翻译结果。</li>
        /// <li>SmartSubtitle.OcrFullTextTask：智能文字提取字幕任务。</li>
        /// <li>SmartErase：智能擦除任务。</li>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 任务状态。有 PROCESSING，SUCCESS 和 FAIL 三种。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 错误码。返回0时成功，其他值为失败。
        /// </summary>
        [JsonProperty("ErrCode")]
        public string ErrCode{ get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// MPS 视频处理任务输入。该字段对应 MPS 任务返回中的 Input 结果，以 JSON 格式返回。
        /// </summary>
        [JsonProperty("Input")]
        public string Input{ get; set; }

        /// <summary>
        /// MPS 视频处理任务输出。
        /// </summary>
        [JsonProperty("Output")]
        public MPSTaskOutput Output{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "Input", this.Input);
            this.SetParamObj(map, prefix + "Output.", this.Output);
        }
    }
}

