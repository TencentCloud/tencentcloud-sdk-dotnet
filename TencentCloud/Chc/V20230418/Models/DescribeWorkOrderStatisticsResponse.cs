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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeWorkOrderStatisticsResponse : AbstractModel
    {
        
        /// <summary>
        /// 总工单数量
        /// </summary>
        [JsonProperty("TotalNum")]
        public ulong? TotalNum{ get; set; }

        /// <summary>
        /// 进行中的工单数量
        /// </summary>
        [JsonProperty("ProcessingNum")]
        public ulong? ProcessingNum{ get; set; }

        /// <summary>
        /// 待确认的工单数量
        /// </summary>
        [JsonProperty("ConfirmingNum")]
        public ulong? ConfirmingNum{ get; set; }

        /// <summary>
        /// 完成的工单数量
        /// </summary>
        [JsonProperty("FinishNum")]
        public ulong? FinishNum{ get; set; }

        /// <summary>
        /// 拒绝的工单数量
        /// </summary>
        [JsonProperty("RejectNum")]
        public ulong? RejectNum{ get; set; }

        /// <summary>
        /// 异常的工单数量
        /// </summary>
        [JsonProperty("ExceptionNum")]
        public ulong? ExceptionNum{ get; set; }

        /// <summary>
        /// 客户取消的工单数量
        /// </summary>
        [JsonProperty("CancelNum")]
        public ulong? CancelNum{ get; set; }

        /// <summary>
        /// 围笼进出审核的工单数量
        /// </summary>
        [JsonProperty("CheckingNum")]
        public ulong? CheckingNum{ get; set; }

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
            this.SetParamSimple(map, prefix + "TotalNum", this.TotalNum);
            this.SetParamSimple(map, prefix + "ProcessingNum", this.ProcessingNum);
            this.SetParamSimple(map, prefix + "ConfirmingNum", this.ConfirmingNum);
            this.SetParamSimple(map, prefix + "FinishNum", this.FinishNum);
            this.SetParamSimple(map, prefix + "RejectNum", this.RejectNum);
            this.SetParamSimple(map, prefix + "ExceptionNum", this.ExceptionNum);
            this.SetParamSimple(map, prefix + "CancelNum", this.CancelNum);
            this.SetParamSimple(map, prefix + "CheckingNum", this.CheckingNum);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

