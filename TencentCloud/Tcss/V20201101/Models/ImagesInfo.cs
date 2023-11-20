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

    public class ImagesInfo : AbstractModel
    {
        
        /// <summary>
        /// 镜像id
        /// </summary>
        [JsonProperty("ImageID")]
        public string ImageID{ get; set; }

        /// <summary>
        /// 镜像名称
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

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
        /// 主机个数
        /// </summary>
        [JsonProperty("HostCnt")]
        public ulong? HostCnt{ get; set; }

        /// <summary>
        /// 容器个数
        /// </summary>
        [JsonProperty("ContainerCnt")]
        public ulong? ContainerCnt{ get; set; }

        /// <summary>
        /// 扫描时间
        /// </summary>
        [JsonProperty("ScanTime")]
        public string ScanTime{ get; set; }

        /// <summary>
        /// 漏洞个数
        /// </summary>
        [JsonProperty("VulCnt")]
        public ulong? VulCnt{ get; set; }

        /// <summary>
        /// 病毒个数
        /// </summary>
        [JsonProperty("VirusCnt")]
        public ulong? VirusCnt{ get; set; }

        /// <summary>
        /// 敏感信息个数
        /// </summary>
        [JsonProperty("RiskCnt")]
        public ulong? RiskCnt{ get; set; }

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
        /// 扫描状态
        /// </summary>
        [JsonProperty("ScanStatus")]
        public string ScanStatus{ get; set; }

        /// <summary>
        /// 木马扫描错误信息
        /// </summary>
        [JsonProperty("ScanVirusError")]
        public string ScanVirusError{ get; set; }

        /// <summary>
        /// 漏洞扫描错误信息
        /// </summary>
        [JsonProperty("ScanVulError")]
        public string ScanVulError{ get; set; }

        /// <summary>
        /// 风险扫描错误信息
        /// </summary>
        [JsonProperty("ScanRiskError")]
        public string ScanRiskError{ get; set; }

        /// <summary>
        /// 是否是重点关注镜像，为0不是，非0是
        /// </summary>
        [JsonProperty("IsSuggest")]
        public ulong? IsSuggest{ get; set; }

        /// <summary>
        /// 是否授权，1是0否
        /// </summary>
        [JsonProperty("IsAuthorized")]
        public ulong? IsAuthorized{ get; set; }

        /// <summary>
        /// 组件个数
        /// </summary>
        [JsonProperty("ComponentCnt")]
        public ulong? ComponentCnt{ get; set; }

        /// <summary>
        /// 严重漏洞数
        /// </summary>
        [JsonProperty("CriticalLevelVulCnt")]
        public ulong? CriticalLevelVulCnt{ get; set; }

        /// <summary>
        /// 高危漏洞数
        /// </summary>
        [JsonProperty("HighLevelVulCnt")]
        public ulong? HighLevelVulCnt{ get; set; }

        /// <summary>
        /// 中危漏洞数
        /// </summary>
        [JsonProperty("MediumLevelVulCnt")]
        public ulong? MediumLevelVulCnt{ get; set; }

        /// <summary>
        /// 低危漏洞数
        /// </summary>
        [JsonProperty("LowLevelVulCnt")]
        public ulong? LowLevelVulCnt{ get; set; }

        /// <summary>
        /// 是否最新版本镜像
        /// </summary>
        [JsonProperty("IsLatestImage")]
        public bool? IsLatestImage{ get; set; }

        /// <summary>
        /// 是否推荐处置
        /// </summary>
        [JsonProperty("RecommendedFix")]
        public bool? RecommendedFix{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageID", this.ImageID);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "HostCnt", this.HostCnt);
            this.SetParamSimple(map, prefix + "ContainerCnt", this.ContainerCnt);
            this.SetParamSimple(map, prefix + "ScanTime", this.ScanTime);
            this.SetParamSimple(map, prefix + "VulCnt", this.VulCnt);
            this.SetParamSimple(map, prefix + "VirusCnt", this.VirusCnt);
            this.SetParamSimple(map, prefix + "RiskCnt", this.RiskCnt);
            this.SetParamSimple(map, prefix + "IsTrustImage", this.IsTrustImage);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "AgentError", this.AgentError);
            this.SetParamSimple(map, prefix + "ScanError", this.ScanError);
            this.SetParamSimple(map, prefix + "ScanStatus", this.ScanStatus);
            this.SetParamSimple(map, prefix + "ScanVirusError", this.ScanVirusError);
            this.SetParamSimple(map, prefix + "ScanVulError", this.ScanVulError);
            this.SetParamSimple(map, prefix + "ScanRiskError", this.ScanRiskError);
            this.SetParamSimple(map, prefix + "IsSuggest", this.IsSuggest);
            this.SetParamSimple(map, prefix + "IsAuthorized", this.IsAuthorized);
            this.SetParamSimple(map, prefix + "ComponentCnt", this.ComponentCnt);
            this.SetParamSimple(map, prefix + "CriticalLevelVulCnt", this.CriticalLevelVulCnt);
            this.SetParamSimple(map, prefix + "HighLevelVulCnt", this.HighLevelVulCnt);
            this.SetParamSimple(map, prefix + "MediumLevelVulCnt", this.MediumLevelVulCnt);
            this.SetParamSimple(map, prefix + "LowLevelVulCnt", this.LowLevelVulCnt);
            this.SetParamSimple(map, prefix + "IsLatestImage", this.IsLatestImage);
            this.SetParamSimple(map, prefix + "RecommendedFix", this.RecommendedFix);
        }
    }
}

