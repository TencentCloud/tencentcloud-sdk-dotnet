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

    public class ProcessMediaRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>媒体处理的文件输入信息。</p>
        /// </summary>
        [JsonProperty("InputInfo")]
        public MediaInputInfo InputInfo{ get; set; }

        /// <summary>
        /// <p>媒体处理输出文件的目标存储。不填则继承 InputInfo 中的存储位置。<br>注意：当InputInfo.Type为URL时，该参数是必填项</p>
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// <p>媒体处理生成的文件输出的目标目录，必选以 / 开头和结尾，如<code>/movie/201907/</code>。<br>如果不填，表示与 InputInfo 中文件所在的目录一致。</p>
        /// </summary>
        [JsonProperty("OutputDir")]
        public string OutputDir{ get; set; }

        /// <summary>
        /// <p>编排ID。<br>注意1：对于OutputStorage、OutputDir参数：</p><li>当服务编排中子任务节点配置了OutputStorage、OutputDir时，该子任务节点中配置的输出作为子任务的输出。</li><li>当服务编排中子任务节点没有配置OutputStorage、OutputDir时，若创建任务接口（ProcessMedia）有指定输出，将覆盖原有编排的默认输出。</li><li>即输出设置的优先级：编排子任务节点 &gt; 任务接口指定 &gt; 对应编排内的配置 </li>注意2：对于TaskNotifyConfig参数，若创建任务接口（ProcessMedia）有设置，将覆盖原有编排的默认回调。<p>注意3：编排的 Trigger 只是用来自动化触发场景，在手动发起的请求中已经配置的 Trigger 无意义。</p>
        /// </summary>
        [JsonProperty("ScheduleId")]
        public long? ScheduleId{ get; set; }

        /// <summary>
        /// <p>媒体处理类型任务参数。</p>
        /// </summary>
        [JsonProperty("MediaProcessTask")]
        public MediaProcessTaskInput MediaProcessTask{ get; set; }

        /// <summary>
        /// <p>视频内容审核类型任务参数。</p>
        /// </summary>
        [JsonProperty("AiContentReviewTask")]
        public AiContentReviewTaskInput AiContentReviewTask{ get; set; }

        /// <summary>
        /// <p>视频内容分析类型任务参数。</p>
        /// </summary>
        [JsonProperty("AiAnalysisTask")]
        public AiAnalysisTaskInput AiAnalysisTask{ get; set; }

        /// <summary>
        /// <p>视频内容识别类型任务参数。</p>
        /// </summary>
        [JsonProperty("AiRecognitionTask")]
        public AiRecognitionTaskInput AiRecognitionTask{ get; set; }

        /// <summary>
        /// <p>媒体质检类型任务参数。</p>
        /// </summary>
        [JsonProperty("AiQualityControlTask")]
        public AiQualityControlTaskInput AiQualityControlTask{ get; set; }

        /// <summary>
        /// <p>智能字幕</p>
        /// </summary>
        [JsonProperty("SmartSubtitlesTask")]
        public SmartSubtitlesTaskInput SmartSubtitlesTask{ get; set; }

        /// <summary>
        /// <p>智能擦除类型任务参数</p>
        /// </summary>
        [JsonProperty("SmartEraseTask")]
        public SmartEraseTaskInput SmartEraseTask{ get; set; }

        /// <summary>
        /// <p>任务的事件通知信息，不填代表不获取事件通知。</p>
        /// </summary>
        [JsonProperty("TaskNotifyConfig")]
        public TaskNotifyConfig TaskNotifyConfig{ get; set; }

        /// <summary>
        /// <p>任务流的优先级，数值越大优先级越高，取值范围是-10到 10，不填代表0。</p>
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }

        /// <summary>
        /// <p>用于去重的识别码，如果三天内曾有过相同的识别码的请求，则本次的请求会返回错误。最长 50 个字符，不传该参数或者参数为空字符串则本次请求不做去重操作。</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>来源上下文，用于透传用户请求信息，任务流状态变更回调将返回该字段值，最长 1000 个字符。</p>
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// <p>任务类型，默认Online</p><li> Online：实时任务</li><li> Offline：闲时任务，不保证实效性，默认3天内处理完</li>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// <p>资源ID，需要保证对应资源是开启状态。默认为账号主资源ID。</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>媒体编排任务组<br>注意：填写此参数ScheduleId字段将失效，Activities优先级大于ScheduleId</p>
        /// </summary>
        [JsonProperty("Activities")]
        public Activity[] Activities{ get; set; }

        /// <summary>
        /// <p>是否跳过元信息获取，可选值：<br>0：表示不跳过<br>1：表示跳过<br>默认值：0</p>
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
            this.SetParamObj(map, prefix + "SmartSubtitlesTask.", this.SmartSubtitlesTask);
            this.SetParamObj(map, prefix + "SmartEraseTask.", this.SmartEraseTask);
            this.SetParamObj(map, prefix + "TaskNotifyConfig.", this.TaskNotifyConfig);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamArrayObj(map, prefix + "Activities.", this.Activities);
            this.SetParamSimple(map, prefix + "SkipMateData", this.SkipMateData);
        }
    }
}

