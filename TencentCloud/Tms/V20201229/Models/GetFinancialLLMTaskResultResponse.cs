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

namespace TencentCloud.Tms.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetFinancialLLMTaskResultResponse : AbstractModel
    {
        
        /// <summary>
        /// TaskId对应的任务的状态：
        /// - Success: 任务已完成
        /// - Processing: 任务进行中，建议10秒后再查询
        /// - Failed: 任务失败
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 该字段标识服务检测到的违规点，具体内容参阅数据结构[FinancialLLMViolationDetail](https://cloud.tencent.com/document/api/1124/51861#FinancialLLMViolationDetail)
        /// </summary>
        [JsonProperty("Details")]
        public FinancialLLMViolationDetail[] Details{ get; set; }

        /// <summary>
        /// 本次检测的违规点列表
        /// </summary>
        [JsonProperty("ReviewedLabels")]
        public string[] ReviewedLabels{ get; set; }

        /// <summary>
        /// 审校任务的开始时间
        /// 示例值：2025-09-25 19:42:35
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 若审校任务失败（Status="Failed"），该字段返回失败的具体原因。
        /// 示例值：文档解析失败
        /// </summary>
        [JsonProperty("FailureReason")]
        public string FailureReason{ get; set; }

        /// <summary>
        /// 该字段为历史结构字段，不再推荐使用。
        /// </summary>
        [JsonProperty("ModerationResult")]
        public string ModerationResult{ get; set; }

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
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Details.", this.Details);
            this.SetParamArraySimple(map, prefix + "ReviewedLabels.", this.ReviewedLabels);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "FailureReason", this.FailureReason);
            this.SetParamSimple(map, prefix + "ModerationResult", this.ModerationResult);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

