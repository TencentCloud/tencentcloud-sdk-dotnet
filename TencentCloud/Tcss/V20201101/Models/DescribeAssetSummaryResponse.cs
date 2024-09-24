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

    public class DescribeAssetSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// 应用个数
        /// </summary>
        [JsonProperty("AppCnt")]
        public ulong? AppCnt{ get; set; }

        /// <summary>
        /// 容器个数
        /// </summary>
        [JsonProperty("ContainerCnt")]
        public ulong? ContainerCnt{ get; set; }

        /// <summary>
        /// 暂停的容器个数
        /// </summary>
        [JsonProperty("ContainerPause")]
        public ulong? ContainerPause{ get; set; }

        /// <summary>
        /// 运行的容器个数
        /// </summary>
        [JsonProperty("ContainerRunning")]
        public ulong? ContainerRunning{ get; set; }

        /// <summary>
        /// 停止运行的容器个数
        /// </summary>
        [JsonProperty("ContainerStop")]
        public ulong? ContainerStop{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 数据库个数
        /// </summary>
        [JsonProperty("DbCnt")]
        public ulong? DbCnt{ get; set; }

        /// <summary>
        /// 镜像个数
        /// </summary>
        [JsonProperty("ImageCnt")]
        public ulong? ImageCnt{ get; set; }

        /// <summary>
        /// 主机在线个数
        /// </summary>
        [JsonProperty("HostOnline")]
        public ulong? HostOnline{ get; set; }

        /// <summary>
        /// 主机个数
        /// </summary>
        [JsonProperty("HostCnt")]
        public ulong? HostCnt{ get; set; }

        /// <summary>
        /// 有风险的镜像个数
        /// </summary>
        [JsonProperty("ImageHasRiskInfoCnt")]
        public ulong? ImageHasRiskInfoCnt{ get; set; }

        /// <summary>
        /// 有病毒的镜像个数
        /// </summary>
        [JsonProperty("ImageHasVirusCnt")]
        public ulong? ImageHasVirusCnt{ get; set; }

        /// <summary>
        /// 有漏洞的镜像个数
        /// </summary>
        [JsonProperty("ImageHasVulsCnt")]
        public ulong? ImageHasVulsCnt{ get; set; }

        /// <summary>
        /// 不受信任的镜像个数
        /// </summary>
        [JsonProperty("ImageUntrustCnt")]
        public ulong? ImageUntrustCnt{ get; set; }

        /// <summary>
        /// 监听的端口个数
        /// </summary>
        [JsonProperty("ListenPortCnt")]
        public ulong? ListenPortCnt{ get; set; }

        /// <summary>
        /// 进程个数
        /// </summary>
        [JsonProperty("ProcessCnt")]
        public ulong? ProcessCnt{ get; set; }

        /// <summary>
        /// web服务个数
        /// </summary>
        [JsonProperty("WebServiceCnt")]
        public ulong? WebServiceCnt{ get; set; }

        /// <summary>
        /// 最近镜像扫描时间
        /// </summary>
        [JsonProperty("LatestImageScanTime")]
        public string LatestImageScanTime{ get; set; }

        /// <summary>
        /// 风险镜像个数
        /// </summary>
        [JsonProperty("ImageUnsafeCnt")]
        public ulong? ImageUnsafeCnt{ get; set; }

        /// <summary>
        /// 主机未安装agent数量
        /// </summary>
        [JsonProperty("HostUnInstallCnt")]
        public ulong? HostUnInstallCnt{ get; set; }

        /// <summary>
        /// 超级节点个数
        /// </summary>
        [JsonProperty("SuperNodeCnt")]
        public ulong? SuperNodeCnt{ get; set; }

        /// <summary>
        /// 超级节点运行个数
        /// </summary>
        [JsonProperty("SuperNodeRunningCnt")]
        public ulong? SuperNodeRunningCnt{ get; set; }

        /// <summary>
        /// 今日新增镜像个数
        /// </summary>
        [JsonProperty("TodayNewImageCnt")]
        public ulong? TodayNewImageCnt{ get; set; }

        /// <summary>
        /// 今日新增风险镜像个数
        /// </summary>
        [JsonProperty("TodayUnsafeImageCnt")]
        public ulong? TodayUnsafeImageCnt{ get; set; }

        /// <summary>
        /// 推荐处置镜像个数
        /// </summary>
        [JsonProperty("RecommendedFixImageCnt")]
        public ulong? RecommendedFixImageCnt{ get; set; }

        /// <summary>
        /// 已扫描镜像个数
        /// </summary>
        [JsonProperty("ScannedImageCnt")]
        public ulong? ScannedImageCnt{ get; set; }

        /// <summary>
        /// 待扫描镜像个数
        /// </summary>
        [JsonProperty("UnScannedImageCnt")]
        public ulong? UnScannedImageCnt{ get; set; }

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
            this.SetParamSimple(map, prefix + "AppCnt", this.AppCnt);
            this.SetParamSimple(map, prefix + "ContainerCnt", this.ContainerCnt);
            this.SetParamSimple(map, prefix + "ContainerPause", this.ContainerPause);
            this.SetParamSimple(map, prefix + "ContainerRunning", this.ContainerRunning);
            this.SetParamSimple(map, prefix + "ContainerStop", this.ContainerStop);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DbCnt", this.DbCnt);
            this.SetParamSimple(map, prefix + "ImageCnt", this.ImageCnt);
            this.SetParamSimple(map, prefix + "HostOnline", this.HostOnline);
            this.SetParamSimple(map, prefix + "HostCnt", this.HostCnt);
            this.SetParamSimple(map, prefix + "ImageHasRiskInfoCnt", this.ImageHasRiskInfoCnt);
            this.SetParamSimple(map, prefix + "ImageHasVirusCnt", this.ImageHasVirusCnt);
            this.SetParamSimple(map, prefix + "ImageHasVulsCnt", this.ImageHasVulsCnt);
            this.SetParamSimple(map, prefix + "ImageUntrustCnt", this.ImageUntrustCnt);
            this.SetParamSimple(map, prefix + "ListenPortCnt", this.ListenPortCnt);
            this.SetParamSimple(map, prefix + "ProcessCnt", this.ProcessCnt);
            this.SetParamSimple(map, prefix + "WebServiceCnt", this.WebServiceCnt);
            this.SetParamSimple(map, prefix + "LatestImageScanTime", this.LatestImageScanTime);
            this.SetParamSimple(map, prefix + "ImageUnsafeCnt", this.ImageUnsafeCnt);
            this.SetParamSimple(map, prefix + "HostUnInstallCnt", this.HostUnInstallCnt);
            this.SetParamSimple(map, prefix + "SuperNodeCnt", this.SuperNodeCnt);
            this.SetParamSimple(map, prefix + "SuperNodeRunningCnt", this.SuperNodeRunningCnt);
            this.SetParamSimple(map, prefix + "TodayNewImageCnt", this.TodayNewImageCnt);
            this.SetParamSimple(map, prefix + "TodayUnsafeImageCnt", this.TodayUnsafeImageCnt);
            this.SetParamSimple(map, prefix + "RecommendedFixImageCnt", this.RecommendedFixImageCnt);
            this.SetParamSimple(map, prefix + "ScannedImageCnt", this.ScannedImageCnt);
            this.SetParamSimple(map, prefix + "UnScannedImageCnt", this.UnScannedImageCnt);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

