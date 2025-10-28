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
        /// 审校任务状态：
        /// 
        /// - Success: 成功
        /// - Processing: 处理中，请等待
        /// - Failed: 失败
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 大模型审校结果
        /// </summary>
        [JsonProperty("ModerationResult")]
        public string ModerationResult{ get; set; }

        /// <summary>
        /// 审校任务失败原因，仅当任务失败时有值
        /// </summary>
        [JsonProperty("FailureReason")]
        public string FailureReason{ get; set; }

        /// <summary>
        /// 审校任务开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 本次检测的违规点列表
        /// </summary>
        [JsonProperty("ReviewedLabels")]
        public string[] ReviewedLabels{ get; set; }

        /// <summary>
        /// 违规明细
        /// </summary>
        [JsonProperty("Details")]
        public FinancialLLMViolationDetail[] Details{ get; set; }

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
            this.SetParamSimple(map, prefix + "ModerationResult", this.ModerationResult);
            this.SetParamSimple(map, prefix + "FailureReason", this.FailureReason);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamArraySimple(map, prefix + "ReviewedLabels.", this.ReviewedLabels);
            this.SetParamArrayObj(map, prefix + "Details.", this.Details);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

