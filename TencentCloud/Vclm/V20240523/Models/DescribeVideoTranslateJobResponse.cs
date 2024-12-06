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

namespace TencentCloud.Vclm.V20240523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVideoTranslateJobResponse : AbstractModel
    {
        
        /// <summary>
        /// 任务状态。0: 任务初始化。 1：音频转译中。 2：音频转译失败。 3：音频转译成功。 4：音频结果待确认。 5：音频结果已确认完毕。6：视频转译中。 7：视频转译失败。 8：视频转译成功。	
        /// </summary>
        [JsonProperty("JobStatus")]
        public long? JobStatus{ get; set; }

        /// <summary>
        /// 本次任务出错的错误码，用来定位问题原因。
        /// </summary>
        [JsonProperty("JobErrorCode")]
        public string JobErrorCode{ get; set; }

        /// <summary>
        /// 任务错误信息，错误码出现的原因。
        /// </summary>
        [JsonProperty("JobErrorMsg")]
        public string JobErrorMsg{ get; set; }

        /// <summary>
        /// 视频转译生成结果视频url，有效期1天。当JobStatus为8时，该字段返回视频Url。
        /// </summary>
        [JsonProperty("ResultVideoUrl")]
        public string ResultVideoUrl{ get; set; }

        /// <summary>
        /// 音频转译后分句翻译内容，包含分句起始时间、源识别文本以及翻译后文本。
        /// 当JobStatus为3、4时，该字段返回分句翻译数据。
        /// </summary>
        [JsonProperty("TranslateResults")]
        public TranslateResult[] TranslateResults{ get; set; }

        /// <summary>
        /// 是否需要确认翻译结果。0：不需要，1：需要。	
        /// </summary>
        [JsonProperty("JobConfirm")]
        [System.Obsolete]
        public long? JobConfirm{ get; set; }

        /// <summary>
        /// 音频任务 ID。	
        /// </summary>
        [JsonProperty("JobAudioTaskId")]
        [System.Obsolete]
        public string JobAudioTaskId{ get; set; }

        /// <summary>
        /// 视频审核任务ID。
        /// </summary>
        [JsonProperty("JobVideoModerationId")]
        [System.Obsolete]
        public string JobVideoModerationId{ get; set; }

        /// <summary>
        /// 音频审核任务 ID。
        /// </summary>
        [JsonProperty("JobAudioModerationId")]
        [System.Obsolete]
        public string JobAudioModerationId{ get; set; }

        /// <summary>
        /// 口型驱动任务 ID。
        /// </summary>
        [JsonProperty("JobVideoId")]
        [System.Obsolete]
        public string JobVideoId{ get; set; }

        /// <summary>
        /// 视频素材原始 URL。
        /// </summary>
        [JsonProperty("OriginalVideoUrl")]
        [System.Obsolete]
        public string OriginalVideoUrl{ get; set; }

        /// <summary>
        /// 文本片段及其时间戳。
        /// </summary>
        [JsonProperty("AsrTimestamps")]
        public AsrTimestamps[] AsrTimestamps{ get; set; }

        /// <summary>
        /// 提交视频转译任务时的 requestId。
        /// </summary>
        [JsonProperty("JobSubmitReqId")]
        [System.Obsolete]
        public string JobSubmitReqId{ get; set; }

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
            this.SetParamSimple(map, prefix + "JobStatus", this.JobStatus);
            this.SetParamSimple(map, prefix + "JobErrorCode", this.JobErrorCode);
            this.SetParamSimple(map, prefix + "JobErrorMsg", this.JobErrorMsg);
            this.SetParamSimple(map, prefix + "ResultVideoUrl", this.ResultVideoUrl);
            this.SetParamArrayObj(map, prefix + "TranslateResults.", this.TranslateResults);
            this.SetParamSimple(map, prefix + "JobConfirm", this.JobConfirm);
            this.SetParamSimple(map, prefix + "JobAudioTaskId", this.JobAudioTaskId);
            this.SetParamSimple(map, prefix + "JobVideoModerationId", this.JobVideoModerationId);
            this.SetParamSimple(map, prefix + "JobAudioModerationId", this.JobAudioModerationId);
            this.SetParamSimple(map, prefix + "JobVideoId", this.JobVideoId);
            this.SetParamSimple(map, prefix + "OriginalVideoUrl", this.OriginalVideoUrl);
            this.SetParamArrayObj(map, prefix + "AsrTimestamps.", this.AsrTimestamps);
            this.SetParamSimple(map, prefix + "JobSubmitReqId", this.JobSubmitReqId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

