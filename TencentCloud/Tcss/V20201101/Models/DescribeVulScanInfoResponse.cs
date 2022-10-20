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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVulScanInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 本次扫描的本地镜像总数
        /// </summary>
        [JsonProperty("LocalImageScanCount")]
        public long? LocalImageScanCount{ get; set; }

        /// <summary>
        /// 忽略的漏洞数量
        /// </summary>
        [JsonProperty("IgnoreVulCount")]
        public long? IgnoreVulCount{ get; set; }

        /// <summary>
        /// 漏洞扫描的开始时间
        /// </summary>
        [JsonProperty("ScanStartTime")]
        public string ScanStartTime{ get; set; }

        /// <summary>
        /// 漏洞扫描的结束时间
        /// </summary>
        [JsonProperty("ScanEndTime")]
        public string ScanEndTime{ get; set; }

        /// <summary>
        /// 发现风险镜像数量
        /// </summary>
        [JsonProperty("FoundRiskImageCount")]
        public long? FoundRiskImageCount{ get; set; }

        /// <summary>
        /// 本地发现漏洞数量
        /// </summary>
        [JsonProperty("FoundVulCount")]
        public long? FoundVulCount{ get; set; }

        /// <summary>
        /// 扫描进度
        /// </summary>
        [JsonProperty("ScanProgress")]
        public float? ScanProgress{ get; set; }

        /// <summary>
        /// 本次扫描的仓库镜像总数
        /// </summary>
        [JsonProperty("RegistryImageScanCount")]
        public long? RegistryImageScanCount{ get; set; }

        /// <summary>
        /// 本地镜像最近一次的漏洞任务扫描ID
        /// </summary>
        [JsonProperty("LocalTaskID")]
        public long? LocalTaskID{ get; set; }

        /// <summary>
        /// 扫描状态:NOT_SCAN:未扫描，SCANNING:扫描中,SCANNED:完成，CANCELED：扫描停止
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 剩余时间，秒
        /// </summary>
        [JsonProperty("RemainingTime")]
        public float? RemainingTime{ get; set; }

        /// <summary>
        /// 仓库镜像最近一次的漏洞任务扫描ID
        /// </summary>
        [JsonProperty("RegistryTaskID")]
        public long? RegistryTaskID{ get; set; }

        /// <summary>
        /// 仓库发现漏洞数量
        /// </summary>
        [JsonProperty("RegistryFoundVulCount")]
        public long? RegistryFoundVulCount{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LocalImageScanCount", this.LocalImageScanCount);
            this.SetParamSimple(map, prefix + "IgnoreVulCount", this.IgnoreVulCount);
            this.SetParamSimple(map, prefix + "ScanStartTime", this.ScanStartTime);
            this.SetParamSimple(map, prefix + "ScanEndTime", this.ScanEndTime);
            this.SetParamSimple(map, prefix + "FoundRiskImageCount", this.FoundRiskImageCount);
            this.SetParamSimple(map, prefix + "FoundVulCount", this.FoundVulCount);
            this.SetParamSimple(map, prefix + "ScanProgress", this.ScanProgress);
            this.SetParamSimple(map, prefix + "RegistryImageScanCount", this.RegistryImageScanCount);
            this.SetParamSimple(map, prefix + "LocalTaskID", this.LocalTaskID);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RemainingTime", this.RemainingTime);
            this.SetParamSimple(map, prefix + "RegistryTaskID", this.RegistryTaskID);
            this.SetParamSimple(map, prefix + "RegistryFoundVulCount", this.RegistryFoundVulCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

