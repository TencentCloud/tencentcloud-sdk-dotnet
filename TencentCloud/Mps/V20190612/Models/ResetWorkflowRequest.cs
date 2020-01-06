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

    public class ResetWorkflowRequest : AbstractModel
    {
        
        /// <summary>
        /// 工作流 ID。
        /// </summary>
        [JsonProperty("WorkflowId")]
        public long? WorkflowId{ get; set; }

        /// <summary>
        /// 工作流名称，最多128字符。同一个用户该名称唯一。
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }

        /// <summary>
        /// 工作流绑定的触发规则，当上传视频命中该规则到该对象时即触发工作流。
        /// </summary>
        [JsonProperty("Trigger")]
        public WorkflowTrigger Trigger{ get; set; }

        /// <summary>
        /// 视频处理的文件输出配置。不填则继承 Trigger 中的存储位置。
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// 视频处理生成的文件输出的目标目录，如`/movie/201907/`。如果不填，表示与触发文件所在的目录一致，即`{inputDir}`。
        /// </summary>
        [JsonProperty("OutputDir")]
        public string OutputDir{ get; set; }

        /// <summary>
        /// 视频处理类型任务参数。
        /// </summary>
        [JsonProperty("MediaProcessTask")]
        public MediaProcessTaskInput MediaProcessTask{ get; set; }

        /// <summary>
        /// 视频内容审核类型任务参数。
        /// </summary>
        [JsonProperty("AiContentReviewTask")]
        public AiContentReviewTaskInput AiContentReviewTask{ get; set; }

        /// <summary>
        /// 视频内容分析类型任务参数。
        /// </summary>
        [JsonProperty("AiAnalysisTask")]
        public AiAnalysisTaskInput AiAnalysisTask{ get; set; }

        /// <summary>
        /// 视频内容识别类型任务参数。
        /// </summary>
        [JsonProperty("AiRecognitionTask")]
        public AiRecognitionTaskInput AiRecognitionTask{ get; set; }

        /// <summary>
        /// 工作流的优先级，数值越大优先级越高，取值范围是 -10 到 10，不填代表 0。
        /// </summary>
        [JsonProperty("TaskPriority")]
        public long? TaskPriority{ get; set; }

        /// <summary>
        /// 任务的事件通知信息，不填代表不获取事件通知。
        /// </summary>
        [JsonProperty("TaskNotifyConfig")]
        public TaskNotifyConfig TaskNotifyConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamObj(map, prefix + "Trigger.", this.Trigger);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamSimple(map, prefix + "OutputDir", this.OutputDir);
            this.SetParamObj(map, prefix + "MediaProcessTask.", this.MediaProcessTask);
            this.SetParamObj(map, prefix + "AiContentReviewTask.", this.AiContentReviewTask);
            this.SetParamObj(map, prefix + "AiAnalysisTask.", this.AiAnalysisTask);
            this.SetParamObj(map, prefix + "AiRecognitionTask.", this.AiRecognitionTask);
            this.SetParamSimple(map, prefix + "TaskPriority", this.TaskPriority);
            this.SetParamObj(map, prefix + "TaskNotifyConfig.", this.TaskNotifyConfig);
        }
    }
}

