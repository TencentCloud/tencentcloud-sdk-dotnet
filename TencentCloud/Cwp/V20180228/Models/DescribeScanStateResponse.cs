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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeScanStateResponse : AbstractModel
    {
        
        /// <summary>
        /// 0 从未扫描过、 1 扫描中、 2扫描完成、 3停止中、 4停止完成
        /// </summary>
        [JsonProperty("ScanState")]
        public ulong? ScanState{ get; set; }

        /// <summary>
        /// 扫描进度
        /// </summary>
        [JsonProperty("Schedule")]
        public ulong? Schedule{ get; set; }

        /// <summary>
        /// 任务Id
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// 任务扫描的漏洞id
        /// </summary>
        [JsonProperty("VulId")]
        public ulong?[] VulId{ get; set; }

        /// <summary>
        /// 0一键检测 1定时检测
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 开始扫描时间
        /// </summary>
        [JsonProperty("ScanBeginTime")]
        public string ScanBeginTime{ get; set; }

        /// <summary>
        /// 扫描漏洞数
        /// </summary>
        [JsonProperty("RiskEventCount")]
        public ulong? RiskEventCount{ get; set; }

        /// <summary>
        /// 扫描结束时间
        /// </summary>
        [JsonProperty("ScanEndTime")]
        public string ScanEndTime{ get; set; }

        /// <summary>
        /// 任务扫描的KB编号
        /// </summary>
        [JsonProperty("KBNumber")]
        public string[] KBNumber{ get; set; }

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
            this.SetParamSimple(map, prefix + "ScanState", this.ScanState);
            this.SetParamSimple(map, prefix + "Schedule", this.Schedule);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamArraySimple(map, prefix + "VulId.", this.VulId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ScanBeginTime", this.ScanBeginTime);
            this.SetParamSimple(map, prefix + "RiskEventCount", this.RiskEventCount);
            this.SetParamSimple(map, prefix + "ScanEndTime", this.ScanEndTime);
            this.SetParamArraySimple(map, prefix + "KBNumber.", this.KBNumber);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

