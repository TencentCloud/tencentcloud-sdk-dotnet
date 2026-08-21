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

    public class DescribeCSIPLicenseBindScheduleResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>任务ID</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// <p>任务状态：INIT-初始化 / RUNNING-进行中 / DONE-已完成 / FAILED-已失败</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>进度百分比 0-100</p>
        /// </summary>
        [JsonProperty("Schedule")]
        public long? Schedule{ get; set; }

        /// <summary>
        /// <p>全部机器数（不受过滤影响）</p>
        /// </summary>
        [JsonProperty("Total")]
        public long? Total{ get; set; }

        /// <summary>
        /// <p>成功数</p>
        /// </summary>
        [JsonProperty("SuccessNum")]
        public long? SuccessNum{ get; set; }

        /// <summary>
        /// <p>失败数</p>
        /// </summary>
        [JsonProperty("FailedNum")]
        public long? FailedNum{ get; set; }

        /// <summary>
        /// <p>失败明细（全量，含机器额外信息）</p>
        /// </summary>
        [JsonProperty("FailedList")]
        public LicenseBindFailedItem[] FailedList{ get; set; }

        /// <summary>
        /// <p>逐机器明细（受 Filters + 分页影响）</p>
        /// </summary>
        [JsonProperty("List")]
        public LicenseBindScheduleItem[] List{ get; set; }

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
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Schedule", this.Schedule);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "SuccessNum", this.SuccessNum);
            this.SetParamSimple(map, prefix + "FailedNum", this.FailedNum);
            this.SetParamArrayObj(map, prefix + "FailedList.", this.FailedList);
            this.SetParamArrayObj(map, prefix + "List.", this.List);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

