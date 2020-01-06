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

    public class ParseLiveStreamProcessNotificationResponse : AbstractModel
    {
        
        /// <summary>
        /// 直播流处理结果类型，包含：
        /// <li>AiReviewResult：内容审核结果；</li>
        /// <li>AiRecognitionResult：内容识别结果；</li>
        /// <li>ProcessEof：直播流处理结束。</li>
        /// </summary>
        [JsonProperty("NotificationType")]
        public string NotificationType{ get; set; }

        /// <summary>
        /// 视频处理任务 ID。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 直播流处理错误信息，当 NotificationType 为 ProcessEof 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcessEofInfo")]
        public LiveStreamProcessErrorInfo ProcessEofInfo{ get; set; }

        /// <summary>
        /// 内容审核结果，当 NotificationType 为 AiReviewResult 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AiReviewResultInfo")]
        public LiveStreamAiReviewResultInfo AiReviewResultInfo{ get; set; }

        /// <summary>
        /// 内容识别结果，当 NotificationType 为 AiRecognitionResult 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AiRecognitionResultInfo")]
        public LiveStreamAiRecognitionResultInfo AiRecognitionResultInfo{ get; set; }

        /// <summary>
        /// 用于去重的识别码，如果七天内曾有过相同的识别码的请求，则本次的请求会返回错误。最长50个字符，不带或者带空字符串表示不做去重。
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 来源上下文，用于透传用户请求信息，任务流状态变更回调将返回该字段值，最长1000个字符。
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NotificationType", this.NotificationType);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamObj(map, prefix + "ProcessEofInfo.", this.ProcessEofInfo);
            this.SetParamObj(map, prefix + "AiReviewResultInfo.", this.AiReviewResultInfo);
            this.SetParamObj(map, prefix + "AiRecognitionResultInfo.", this.AiRecognitionResultInfo);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

