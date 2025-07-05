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

    public class DescribeAssetImageDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 镜像ID
        /// </summary>
        [JsonProperty("ImageID")]
        public string ImageID{ get; set; }

        /// <summary>
        /// 镜像名称
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// 镜像摘要
        /// </summary>
        [JsonProperty("ImageDigest")]
        public string ImageDigest{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 镜像大小
        /// </summary>
        [JsonProperty("Size")]
        public ulong? Size{ get; set; }

        /// <summary>
        /// 关联主机个数(包含普通节点数和超级节点数)
        /// </summary>
        [JsonProperty("HostCnt")]
        public ulong? HostCnt{ get; set; }

        /// <summary>
        /// 关联容器个数
        /// </summary>
        [JsonProperty("ContainerCnt")]
        public ulong? ContainerCnt{ get; set; }

        /// <summary>
        /// 超级节点数
        /// </summary>
        [JsonProperty("SuperNodeCnt")]
        public ulong? SuperNodeCnt{ get; set; }

        /// <summary>
        /// 最近扫描时间
        /// </summary>
        [JsonProperty("ScanTime")]
        public string ScanTime{ get; set; }

        /// <summary>
        /// 漏洞个数
        /// </summary>
        [JsonProperty("VulCnt")]
        public ulong? VulCnt{ get; set; }

        /// <summary>
        /// 风险行为数
        /// </summary>
        [JsonProperty("RiskCnt")]
        public ulong? RiskCnt{ get; set; }

        /// <summary>
        /// 敏感信息数
        /// </summary>
        [JsonProperty("SensitiveInfoCnt")]
        public ulong? SensitiveInfoCnt{ get; set; }

        /// <summary>
        /// 是否信任镜像
        /// </summary>
        [JsonProperty("IsTrustImage")]
        public bool? IsTrustImage{ get; set; }

        /// <summary>
        /// 镜像系统
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// agent镜像扫描错误
        /// </summary>
        [JsonProperty("AgentError")]
        public string AgentError{ get; set; }

        /// <summary>
        /// 后端镜像扫描错误
        /// </summary>
        [JsonProperty("ScanError")]
        public string ScanError{ get; set; }

        /// <summary>
        /// 系统架构
        /// </summary>
        [JsonProperty("Architecture")]
        public string Architecture{ get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        [JsonProperty("Author")]
        public string Author{ get; set; }

        /// <summary>
        /// 构建历史
        /// </summary>
        [JsonProperty("BuildHistory")]
        public string BuildHistory{ get; set; }

        /// <summary>
        /// 木马扫描进度
        /// </summary>
        [JsonProperty("ScanVirusProgress")]
        public ulong? ScanVirusProgress{ get; set; }

        /// <summary>
        /// 漏洞扫进度
        /// </summary>
        [JsonProperty("ScanVulProgress")]
        public ulong? ScanVulProgress{ get; set; }

        /// <summary>
        /// 敏感信息扫描进度
        /// </summary>
        [JsonProperty("ScanRiskProgress")]
        public ulong? ScanRiskProgress{ get; set; }

        /// <summary>
        /// 木马扫描错误
        /// </summary>
        [JsonProperty("ScanVirusError")]
        public string ScanVirusError{ get; set; }

        /// <summary>
        /// 漏洞扫描错误
        /// </summary>
        [JsonProperty("ScanVulError")]
        public string ScanVulError{ get; set; }

        /// <summary>
        /// 敏感信息错误
        /// </summary>
        [JsonProperty("ScanRiskError")]
        public string ScanRiskError{ get; set; }

        /// <summary>
        /// 镜像扫描状态
        /// </summary>
        [JsonProperty("ScanStatus")]
        public string ScanStatus{ get; set; }

        /// <summary>
        /// 木马病毒数
        /// </summary>
        [JsonProperty("VirusCnt")]
        public ulong? VirusCnt{ get; set; }

        /// <summary>
        /// 镜像扫描状态
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 剩余扫描时间
        /// </summary>
        [JsonProperty("RemainScanTime")]
        public ulong? RemainScanTime{ get; set; }

        /// <summary>
        /// 授权为：1，未授权为：0
        /// </summary>
        [JsonProperty("IsAuthorized")]
        public long? IsAuthorized{ get; set; }

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
            this.SetParamSimple(map, prefix + "ImageID", this.ImageID);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageDigest", this.ImageDigest);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "HostCnt", this.HostCnt);
            this.SetParamSimple(map, prefix + "ContainerCnt", this.ContainerCnt);
            this.SetParamSimple(map, prefix + "SuperNodeCnt", this.SuperNodeCnt);
            this.SetParamSimple(map, prefix + "ScanTime", this.ScanTime);
            this.SetParamSimple(map, prefix + "VulCnt", this.VulCnt);
            this.SetParamSimple(map, prefix + "RiskCnt", this.RiskCnt);
            this.SetParamSimple(map, prefix + "SensitiveInfoCnt", this.SensitiveInfoCnt);
            this.SetParamSimple(map, prefix + "IsTrustImage", this.IsTrustImage);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "AgentError", this.AgentError);
            this.SetParamSimple(map, prefix + "ScanError", this.ScanError);
            this.SetParamSimple(map, prefix + "Architecture", this.Architecture);
            this.SetParamSimple(map, prefix + "Author", this.Author);
            this.SetParamSimple(map, prefix + "BuildHistory", this.BuildHistory);
            this.SetParamSimple(map, prefix + "ScanVirusProgress", this.ScanVirusProgress);
            this.SetParamSimple(map, prefix + "ScanVulProgress", this.ScanVulProgress);
            this.SetParamSimple(map, prefix + "ScanRiskProgress", this.ScanRiskProgress);
            this.SetParamSimple(map, prefix + "ScanVirusError", this.ScanVirusError);
            this.SetParamSimple(map, prefix + "ScanVulError", this.ScanVulError);
            this.SetParamSimple(map, prefix + "ScanRiskError", this.ScanRiskError);
            this.SetParamSimple(map, prefix + "ScanStatus", this.ScanStatus);
            this.SetParamSimple(map, prefix + "VirusCnt", this.VirusCnt);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RemainScanTime", this.RemainScanTime);
            this.SetParamSimple(map, prefix + "IsAuthorized", this.IsAuthorized);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

