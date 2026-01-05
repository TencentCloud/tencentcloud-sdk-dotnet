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

    public class DescribeScanTaskDetailsResponse : AbstractModel
    {
        
        /// <summary>
        /// 扫描任务信息列表
        /// </summary>
        [JsonProperty("ScanTaskDetailList")]
        public ScanTaskDetails[] ScanTaskDetailList{ get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

        /// <summary>
        /// 扫描机器总数
        /// </summary>
        [JsonProperty("ScanMachineCount")]
        public ulong? ScanMachineCount{ get; set; }

        /// <summary>
        /// 发现风险机器数
        /// </summary>
        [JsonProperty("RiskMachineCount")]
        public ulong? RiskMachineCount{ get; set; }

        /// <summary>
        /// 扫描开始时间
        /// </summary>
        [JsonProperty("ScanBeginTime")]
        public string ScanBeginTime{ get; set; }

        /// <summary>
        /// 扫描结束时间
        /// </summary>
        [JsonProperty("ScanEndTime")]
        public string ScanEndTime{ get; set; }

        /// <summary>
        /// 检测时间
        /// </summary>
        [JsonProperty("ScanTime")]
        public ulong? ScanTime{ get; set; }

        /// <summary>
        /// 扫描进度
        /// </summary>
        [JsonProperty("ScanProgress")]
        public ulong? ScanProgress{ get; set; }

        /// <summary>
        /// 扫描剩余时间
        /// </summary>
        [JsonProperty("ScanLeftTime")]
        public ulong? ScanLeftTime{ get; set; }

        /// <summary>
        /// 扫描内容
        /// </summary>
        [JsonProperty("ScanContent")]
        public string[] ScanContent{ get; set; }

        /// <summary>
        /// 漏洞信息
        /// </summary>
        [JsonProperty("VulInfo")]
        public VulDetailInfo[] VulInfo{ get; set; }

        /// <summary>
        /// 风险事件个数
        /// </summary>
        [JsonProperty("RiskEventCount")]
        public ulong? RiskEventCount{ get; set; }

        /// <summary>
        /// 0一键检测 1定时检测
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 任务是否全部正在被停止 ture是
        /// </summary>
        [JsonProperty("StoppingAll")]
        public bool? StoppingAll{ get; set; }

        /// <summary>
        /// 扫描出漏洞个数
        /// </summary>
        [JsonProperty("VulCount")]
        public ulong? VulCount{ get; set; }

        /// <summary>
        /// 单独扫描kb时的信息
        /// </summary>
        [JsonProperty("PatchInfo")]
        public PatchInfoDetail[] PatchInfo{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "ScanTaskDetailList.", this.ScanTaskDetailList);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "ScanMachineCount", this.ScanMachineCount);
            this.SetParamSimple(map, prefix + "RiskMachineCount", this.RiskMachineCount);
            this.SetParamSimple(map, prefix + "ScanBeginTime", this.ScanBeginTime);
            this.SetParamSimple(map, prefix + "ScanEndTime", this.ScanEndTime);
            this.SetParamSimple(map, prefix + "ScanTime", this.ScanTime);
            this.SetParamSimple(map, prefix + "ScanProgress", this.ScanProgress);
            this.SetParamSimple(map, prefix + "ScanLeftTime", this.ScanLeftTime);
            this.SetParamArraySimple(map, prefix + "ScanContent.", this.ScanContent);
            this.SetParamArrayObj(map, prefix + "VulInfo.", this.VulInfo);
            this.SetParamSimple(map, prefix + "RiskEventCount", this.RiskEventCount);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "StoppingAll", this.StoppingAll);
            this.SetParamSimple(map, prefix + "VulCount", this.VulCount);
            this.SetParamArrayObj(map, prefix + "PatchInfo.", this.PatchInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

