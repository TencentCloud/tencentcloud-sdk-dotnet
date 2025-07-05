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

    public class ProcessLiveStreamRequest : AbstractModel
    {
        
        /// <summary>
        /// 直播流 URL（必须是直播文件地址，支持 rtmp，hls 和 flv, trtc 等）。
        /// trtc地址如下：
        ///  trtc: //trtc.rtc.qq.com/mps/`<roomid>`?sdkappid=`<sdkappid>`&userid=`<userid>`&usersig=<`usersig>`
        /// `<roomid>` 为trtc的房间号id, 为数字
        /// `<sdkappid>` 为trtc的sdk app id
        /// `<userid>` 为服务进入房间的用户id,可以区分谁是机器人
        /// <`usersig>` 为trtc 用户的签名
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 任务的事件通知信息，用于指定直播流处理的结果。
        /// </summary>
        [JsonProperty("TaskNotifyConfig")]
        public LiveStreamTaskNotifyConfig TaskNotifyConfig{ get; set; }

        /// <summary>
        /// 直播流处理输出文件的目标存储。如处理有文件输出，该参数为必填项。
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// 直播流处理生成的文件输出的目标目录，如`/movie/201909/`，如果不填为 `/` 目录。
        /// </summary>
        [JsonProperty("OutputDir")]
        public string OutputDir{ get; set; }

        /// <summary>
        /// 视频内容审核类型任务参数。
        /// </summary>
        [JsonProperty("AiContentReviewTask")]
        public AiContentReviewTaskInput AiContentReviewTask{ get; set; }

        /// <summary>
        /// 视频内容识别类型任务参数。
        /// </summary>
        [JsonProperty("AiRecognitionTask")]
        public AiRecognitionTaskInput AiRecognitionTask{ get; set; }

        /// <summary>
        /// 视频内容分析类型任务参数。
        /// </summary>
        [JsonProperty("AiAnalysisTask")]
        public AiAnalysisTaskInput AiAnalysisTask{ get; set; }

        /// <summary>
        /// 媒体质检类型任务参数。
        /// </summary>
        [JsonProperty("AiQualityControlTask")]
        public AiQualityControlTaskInput AiQualityControlTask{ get; set; }

        /// <summary>
        /// 用于去重的识别码，如果七天内曾有过相同的识别码的请求，则本次的请求会返回错误。最长 50 个字符，不带或者带空字符串表示不做去重。
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 来源上下文，用于透传用户请求信息，任务流状态变更回调将返回该字段值，最长 1000 个字符。
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// 直播编排ID。
        /// 注意1：对于OutputStorage、OutputDir参数：
        /// <li>当服务编排中子任务节点配置了OutputStorage、OutputDir时，该子任务节点中配置的输出作为子任务的输出。</li>
        /// <li>当服务编排中子任务节点没有配置OutputStorage、OutputDir时，若对直播流发起处理（ProcessLiveStream）有输出，将覆盖原有编排的默认输出。</li>
        /// 注意2：对于TaskNotifyConfig参数，若创建任务接口（ProcessLiveStream）有设置，将覆盖原有编排的默认回调。
        /// </summary>
        [JsonProperty("ScheduleId")]
        public long? ScheduleId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamObj(map, prefix + "TaskNotifyConfig.", this.TaskNotifyConfig);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamSimple(map, prefix + "OutputDir", this.OutputDir);
            this.SetParamObj(map, prefix + "AiContentReviewTask.", this.AiContentReviewTask);
            this.SetParamObj(map, prefix + "AiRecognitionTask.", this.AiRecognitionTask);
            this.SetParamObj(map, prefix + "AiAnalysisTask.", this.AiAnalysisTask);
            this.SetParamObj(map, prefix + "AiQualityControlTask.", this.AiQualityControlTask);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "ScheduleId", this.ScheduleId);
        }
    }
}

