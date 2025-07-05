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

    public class DescribeTcssSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// 镜像总数
        /// </summary>
        [JsonProperty("ImageCnt")]
        public ulong? ImageCnt{ get; set; }

        /// <summary>
        /// 已扫描镜像数
        /// </summary>
        [JsonProperty("ScannedImageCnt")]
        public ulong? ScannedImageCnt{ get; set; }

        /// <summary>
        /// 待扫描镜像个数
        /// </summary>
        [JsonProperty("UnScannedImageCnt")]
        public ulong? UnScannedImageCnt{ get; set; }

        /// <summary>
        /// 本地镜像个数
        /// </summary>
        [JsonProperty("LocalImageCnt")]
        public ulong? LocalImageCnt{ get; set; }

        /// <summary>
        /// 仓库镜像个数
        /// </summary>
        [JsonProperty("RepositoryImageCnt")]
        public ulong? RepositoryImageCnt{ get; set; }

        /// <summary>
        /// 风险本地镜像个数
        /// </summary>
        [JsonProperty("RiskLocalImageCnt")]
        public ulong? RiskLocalImageCnt{ get; set; }

        /// <summary>
        /// 风险仓库镜像个数
        /// </summary>
        [JsonProperty("RiskRepositoryImageCnt")]
        public ulong? RiskRepositoryImageCnt{ get; set; }

        /// <summary>
        /// 容器个数
        /// </summary>
        [JsonProperty("ContainerCnt")]
        public ulong? ContainerCnt{ get; set; }

        /// <summary>
        /// 风险容器个数
        /// </summary>
        [JsonProperty("RiskContainerCnt")]
        public ulong? RiskContainerCnt{ get; set; }

        /// <summary>
        /// 集群个数
        /// </summary>
        [JsonProperty("ClusterCnt")]
        public ulong? ClusterCnt{ get; set; }

        /// <summary>
        /// 风险集群个数
        /// </summary>
        [JsonProperty("RiskClusterCnt")]
        public ulong? RiskClusterCnt{ get; set; }

        /// <summary>
        /// 待扫描漏洞个数
        /// </summary>
        [JsonProperty("UnScannedVulCnt")]
        public ulong? UnScannedVulCnt{ get; set; }

        /// <summary>
        /// 风险漏洞个数
        /// </summary>
        [JsonProperty("RiskVulCnt")]
        public ulong? RiskVulCnt{ get; set; }

        /// <summary>
        /// 安全基线待扫描项个数
        /// </summary>
        [JsonProperty("UnScannedBaseLineCnt")]
        public ulong? UnScannedBaseLineCnt{ get; set; }

        /// <summary>
        /// 安全基线风险个数
        /// </summary>
        [JsonProperty("RiskBaseLineCnt")]
        public ulong? RiskBaseLineCnt{ get; set; }

        /// <summary>
        /// 运行时(高危)待处理事件个数
        /// </summary>
        [JsonProperty("RuntimeUnhandleEventCnt")]
        public ulong? RuntimeUnhandleEventCnt{ get; set; }

        /// <summary>
        /// 待扫描集群个数
        /// </summary>
        [JsonProperty("UnScannedClusterCnt")]
        public ulong? UnScannedClusterCnt{ get; set; }

        /// <summary>
        /// 是否已扫描镜像
        /// </summary>
        [JsonProperty("ScanImageStatus")]
        public bool? ScanImageStatus{ get; set; }

        /// <summary>
        /// 是否已扫描集群
        /// </summary>
        [JsonProperty("ScanClusterStatus")]
        public bool? ScanClusterStatus{ get; set; }

        /// <summary>
        /// 是否已扫描基线
        /// </summary>
        [JsonProperty("ScanBaseLineStatus")]
        public bool? ScanBaseLineStatus{ get; set; }

        /// <summary>
        /// 是否已扫描漏洞
        /// </summary>
        [JsonProperty("ScanVulStatus")]
        public bool? ScanVulStatus{ get; set; }

        /// <summary>
        /// 漏洞影响镜像数
        /// </summary>
        [JsonProperty("VulRiskImageCnt")]
        public ulong? VulRiskImageCnt{ get; set; }

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
            this.SetParamSimple(map, prefix + "ImageCnt", this.ImageCnt);
            this.SetParamSimple(map, prefix + "ScannedImageCnt", this.ScannedImageCnt);
            this.SetParamSimple(map, prefix + "UnScannedImageCnt", this.UnScannedImageCnt);
            this.SetParamSimple(map, prefix + "LocalImageCnt", this.LocalImageCnt);
            this.SetParamSimple(map, prefix + "RepositoryImageCnt", this.RepositoryImageCnt);
            this.SetParamSimple(map, prefix + "RiskLocalImageCnt", this.RiskLocalImageCnt);
            this.SetParamSimple(map, prefix + "RiskRepositoryImageCnt", this.RiskRepositoryImageCnt);
            this.SetParamSimple(map, prefix + "ContainerCnt", this.ContainerCnt);
            this.SetParamSimple(map, prefix + "RiskContainerCnt", this.RiskContainerCnt);
            this.SetParamSimple(map, prefix + "ClusterCnt", this.ClusterCnt);
            this.SetParamSimple(map, prefix + "RiskClusterCnt", this.RiskClusterCnt);
            this.SetParamSimple(map, prefix + "UnScannedVulCnt", this.UnScannedVulCnt);
            this.SetParamSimple(map, prefix + "RiskVulCnt", this.RiskVulCnt);
            this.SetParamSimple(map, prefix + "UnScannedBaseLineCnt", this.UnScannedBaseLineCnt);
            this.SetParamSimple(map, prefix + "RiskBaseLineCnt", this.RiskBaseLineCnt);
            this.SetParamSimple(map, prefix + "RuntimeUnhandleEventCnt", this.RuntimeUnhandleEventCnt);
            this.SetParamSimple(map, prefix + "UnScannedClusterCnt", this.UnScannedClusterCnt);
            this.SetParamSimple(map, prefix + "ScanImageStatus", this.ScanImageStatus);
            this.SetParamSimple(map, prefix + "ScanClusterStatus", this.ScanClusterStatus);
            this.SetParamSimple(map, prefix + "ScanBaseLineStatus", this.ScanBaseLineStatus);
            this.SetParamSimple(map, prefix + "ScanVulStatus", this.ScanVulStatus);
            this.SetParamSimple(map, prefix + "VulRiskImageCnt", this.VulRiskImageCnt);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

