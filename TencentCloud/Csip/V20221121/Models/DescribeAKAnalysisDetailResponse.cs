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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAKAnalysisDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 告警AI分析状态 -1 分析失败 0 未分析 1 分析中 2 分析成功，真实告警 3 分析成功，可疑告警
        /// </summary>
        [JsonProperty("AIStatus")]
        public long? AIStatus{ get; set; }

        /// <summary>
        /// AI分析任务ID
        /// </summary>
        [JsonProperty("AITaskID")]
        public string AITaskID{ get; set; }

        /// <summary>
        /// 告警AI分析结果，base64格式，避免数据被拦截
        /// </summary>
        [JsonProperty("AIResult")]
        public string AIResult{ get; set; }

        /// <summary>
        /// 反馈建议
        /// </summary>
        [JsonProperty("Feedback")]
        public string Feedback{ get; set; }

        /// <summary>
        /// 反馈状态  0表示没有反馈，1表示认可，2表示不认可
        /// </summary>
        [JsonProperty("FeedbackResult")]
        public long? FeedbackResult{ get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [JsonProperty("FailedReason")]
        public string FailedReason{ get; set; }

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
            this.SetParamSimple(map, prefix + "AIStatus", this.AIStatus);
            this.SetParamSimple(map, prefix + "AITaskID", this.AITaskID);
            this.SetParamSimple(map, prefix + "AIResult", this.AIResult);
            this.SetParamSimple(map, prefix + "Feedback", this.Feedback);
            this.SetParamSimple(map, prefix + "FeedbackResult", this.FeedbackResult);
            this.SetParamSimple(map, prefix + "FailedReason", this.FailedReason);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

