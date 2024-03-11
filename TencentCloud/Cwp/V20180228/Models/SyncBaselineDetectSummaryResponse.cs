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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SyncBaselineDetectSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// 处理进度
        /// </summary>
        [JsonProperty("ProgressRate")]
        public long? ProgressRate{ get; set; }

        /// <summary>
        /// 未通过策略总数
        /// </summary>
        [JsonProperty("NotPassPolicyCount")]
        public long? NotPassPolicyCount{ get; set; }

        /// <summary>
        /// 主机总数
        /// </summary>
        [JsonProperty("HostCount")]
        public long? HostCount{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 1:即将进行首次扫描   0:已经扫描过了
        /// </summary>
        [JsonProperty("WillFirstScan")]
        public long? WillFirstScan{ get; set; }

        /// <summary>
        /// 正在检测的任务ID
        /// </summary>
        [JsonProperty("DetectingTaskIds")]
        public long?[] DetectingTaskIds{ get; set; }

        /// <summary>
        /// 扫描中剩余时间(分钟)
        /// </summary>
        [JsonProperty("LeftMins")]
        public long? LeftMins{ get; set; }

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
            this.SetParamSimple(map, prefix + "ProgressRate", this.ProgressRate);
            this.SetParamSimple(map, prefix + "NotPassPolicyCount", this.NotPassPolicyCount);
            this.SetParamSimple(map, prefix + "HostCount", this.HostCount);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "WillFirstScan", this.WillFirstScan);
            this.SetParamArraySimple(map, prefix + "DetectingTaskIds.", this.DetectingTaskIds);
            this.SetParamSimple(map, prefix + "LeftMins", this.LeftMins);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

