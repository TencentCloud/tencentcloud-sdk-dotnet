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

    public class ParseLiveStreamProcessNotificationResponse : AbstractModel
    {
        
        /// <summary>
        /// 直播流处理结果类型，包含：
        /// <li>AiReviewResult：内容审核结果；</li>
        /// <li>AiRecognitionResult：内容识别结果；</li>
        /// <li>LiveRecordResult：直播录制结果；</li>
        /// <li>AiQualityControlResult：媒体质检结果；</li>
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
        /// 内容分析结果，当 NotificationType 为 AiAnalysisResult 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AiAnalysisResultInfo")]
        public LiveStreamAiAnalysisResultInfo AiAnalysisResultInfo{ get; set; }

        /// <summary>
        /// 媒体质检结果，当 NotificationType 为 AiQualityControlResult 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AiQualityControlResultInfo")]
        public LiveStreamAiQualityControlResultInfo AiQualityControlResultInfo{ get; set; }

        /// <summary>
        /// 直播录制结果，当 NotificationType 为 LiveRecordResult 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LiveRecordResultInfo")]
        public LiveStreamRecordResultInfo LiveRecordResultInfo{ get; set; }

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
        /// - 过期时间，事件通知签名过期 UNIX 时间戳。 - 来自媒体处理的消息通知默认过期时间是10分钟，如果一条消息通知中的 Timestamp 值所指定的时间已经过期，则可以判定这条通知无效，进而可以防止网络重放攻击。 - Timestamp 的格式为十进制 UNIX 时间戳，即从1970年01月01日（UTC/GMT 的午夜）开始所经过的秒数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Timestamp")]
        public long? Timestamp{ get; set; }

        /// <summary>
        /// 事件通知安全签名 Sign = MD5（Timestamp + NotifyKey）。说明：媒体处理把Timestamp 和 TaskNotifyConfig 里面的NotifyKey 进行字符串拼接后通过 MD5 计算得出 Sign 值，并将其放在通知消息里，您的后台服务器在收到通知消息后可以根据同样的算法确认 Sign 是否正确，进而确认消息是否确实来自媒体处理后台。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Sign")]
        public string Sign{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NotificationType", this.NotificationType);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamObj(map, prefix + "ProcessEofInfo.", this.ProcessEofInfo);
            this.SetParamObj(map, prefix + "AiReviewResultInfo.", this.AiReviewResultInfo);
            this.SetParamObj(map, prefix + "AiRecognitionResultInfo.", this.AiRecognitionResultInfo);
            this.SetParamObj(map, prefix + "AiAnalysisResultInfo.", this.AiAnalysisResultInfo);
            this.SetParamObj(map, prefix + "AiQualityControlResultInfo.", this.AiQualityControlResultInfo);
            this.SetParamObj(map, prefix + "LiveRecordResultInfo.", this.LiveRecordResultInfo);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "Sign", this.Sign);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

