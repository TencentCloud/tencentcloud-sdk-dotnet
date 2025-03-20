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

    public class ProcessMediaRequest : AbstractModel
    {
        
        /// <summary>
        /// 媒体处理的文件输入信息。
        /// </summary>
        [JsonProperty("InputInfo")]
        public MediaInputInfo InputInfo{ get; set; }

        /// <summary>
        /// 媒体处理输出文件的目标存储。不填则继承 InputInfo 中的存储位置。
        /// 注意：当InputInfo.Type为URL时，该参数是必填项
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// 媒体处理生成的文件输出的目标目录，必选以 / 开头和结尾，如`/movie/201907/`。
        /// 如果不填，表示与 InputInfo 中文件所在的目录一致。
        /// </summary>
        [JsonProperty("OutputDir")]
        public string OutputDir{ get; set; }

        /// <summary>
        /// 编排ID。
        /// 注意1：对于OutputStorage、OutputDir参数：
        /// <li>当服务编排中子任务节点配置了OutputStorage、OutputDir时，该子任务节点中配置的输出作为子任务的输出。</li>
        /// <li>当服务编排中子任务节点没有配置OutputStorage、OutputDir时，若创建任务接口（ProcessMedia）有指定输出，将覆盖原有编排的默认输出。</li>
        /// <li>即输出设置的优先级：编排子任务节点 > 任务接口指定 > 对应编排内的配置 </li>
        /// 注意2：对于TaskNotifyConfig参数，若创建任务接口（ProcessMedia）有设置，将覆盖原有编排的默认回调。
        /// 
        /// 注意3：编排的 Trigger 只是用来自动化触发场景，在手动发起的请求中已经配置的 Trigger 无意义。
        /// </summary>
        [JsonProperty("ScheduleId")]
        public long? ScheduleId{ get; set; }

        /// <summary>
        /// 媒体处理类型任务参数。
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
        /// 媒体质检类型任务参数。
        /// </summary>
        [JsonProperty("AiQualityControlTask")]
        public AiQualityControlTaskInput AiQualityControlTask{ get; set; }

        /// <summary>
        /// 任务的事件通知信息，不填代表不获取事件通知。
        /// </summary>
        [JsonProperty("TaskNotifyConfig")]
        public TaskNotifyConfig TaskNotifyConfig{ get; set; }

        /// <summary>
        /// 任务流的优先级，数值越大优先级越高，取值范围是-10到 10，不填代表0。
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }

        /// <summary>
        /// 用于去重的识别码，如果三天内曾有过相同的识别码的请求，则本次的请求会返回错误。最长 50 个字符，不传该参数或者参数为空字符串则本次请求不做去重操作。
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 来源上下文，用于透传用户请求信息，任务流状态变更回调将返回该字段值，最长 1000 个字符。
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// 任务类型，默认Online
        /// <li> Online：实时任务</li>
        /// <li> Offline：闲时任务，不保证实效性，默认3天内处理完</li>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 资源ID，需要保证对应资源是开启状态。默认为帐号主资源ID。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 智能字幕
        /// </summary>
        [JsonProperty("SmartSubtitlesTask")]
        public SmartSubtitlesTaskInput SmartSubtitlesTask{ get; set; }

        /// <summary>
        /// 是否跳过元信息获取，可选值： 
        /// 0：表示不跳过 
        /// 1：表示跳过 
        /// 默认值：0	
        /// </summary>
        [JsonProperty("SkipMateData")]
        public long? SkipMateData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "InputInfo.", this.InputInfo);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamSimple(map, prefix + "OutputDir", this.OutputDir);
            this.SetParamSimple(map, prefix + "ScheduleId", this.ScheduleId);
            this.SetParamObj(map, prefix + "MediaProcessTask.", this.MediaProcessTask);
            this.SetParamObj(map, prefix + "AiContentReviewTask.", this.AiContentReviewTask);
            this.SetParamObj(map, prefix + "AiAnalysisTask.", this.AiAnalysisTask);
            this.SetParamObj(map, prefix + "AiRecognitionTask.", this.AiRecognitionTask);
            this.SetParamObj(map, prefix + "AiQualityControlTask.", this.AiQualityControlTask);
            this.SetParamObj(map, prefix + "TaskNotifyConfig.", this.TaskNotifyConfig);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamObj(map, prefix + "SmartSubtitlesTask.", this.SmartSubtitlesTask);
            this.SetParamSimple(map, prefix + "SkipMateData", this.SkipMateData);
        }
    }
}

