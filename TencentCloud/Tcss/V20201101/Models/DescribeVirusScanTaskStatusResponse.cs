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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVirusScanTaskStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// 查杀容器个数
        /// </summary>
        [JsonProperty("ContainerTotal")]
        public ulong? ContainerTotal{ get; set; }

        /// <summary>
        /// 风险容器个数
        /// </summary>
        [JsonProperty("RiskContainerCnt")]
        public ulong? RiskContainerCnt{ get; set; }

        /// <summary>
        /// 扫描状态 任务状态:
        /// SCAN_NONE:无， 
        /// SCAN_SCANNING:正在扫描中，
        /// SCAN_FINISH：扫描完成， 
        /// SCAN_TIMEOUT：扫描超时
        /// SCAN_CANCELING: 取消中
        /// SCAN_CANCELED:已取消
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 扫描进度 I
        /// </summary>
        [JsonProperty("Schedule")]
        public ulong? Schedule{ get; set; }

        /// <summary>
        /// 已经扫描了的容器个数
        /// </summary>
        [JsonProperty("ContainerScanCnt")]
        public ulong? ContainerScanCnt{ get; set; }

        /// <summary>
        /// 风险个数
        /// </summary>
        [JsonProperty("RiskCnt")]
        public ulong? RiskCnt{ get; set; }

        /// <summary>
        /// 剩余扫描时间
        /// </summary>
        [JsonProperty("LeftSeconds")]
        public ulong? LeftSeconds{ get; set; }

        /// <summary>
        /// 扫描开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 扫描结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 扫描类型，"CYCLE"：周期扫描， "MANUAL"：手动扫描
        /// </summary>
        [JsonProperty("ScanType")]
        public string ScanType{ get; set; }

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
            this.SetParamSimple(map, prefix + "ContainerTotal", this.ContainerTotal);
            this.SetParamSimple(map, prefix + "RiskContainerCnt", this.RiskContainerCnt);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Schedule", this.Schedule);
            this.SetParamSimple(map, prefix + "ContainerScanCnt", this.ContainerScanCnt);
            this.SetParamSimple(map, prefix + "RiskCnt", this.RiskCnt);
            this.SetParamSimple(map, prefix + "LeftSeconds", this.LeftSeconds);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ScanType", this.ScanType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

