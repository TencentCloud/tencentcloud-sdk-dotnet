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

    public class DescribeImageRegistryAssetOverviewResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>镜像总数</p>
        /// </summary>
        [JsonProperty("ImageCnt")]
        public ulong? ImageCnt{ get; set; }

        /// <summary>
        /// <p>已扫描镜像数</p>
        /// </summary>
        [JsonProperty("ImageScannedCnt")]
        public ulong? ImageScannedCnt{ get; set; }

        /// <summary>
        /// <p>组件数</p>
        /// </summary>
        [JsonProperty("ComponentCnt")]
        public ulong? ComponentCnt{ get; set; }

        /// <summary>
        /// <p>漏洞数</p>
        /// </summary>
        [JsonProperty("VulCnt")]
        public ulong? VulCnt{ get; set; }

        /// <summary>
        /// <p>木马数</p>
        /// </summary>
        [JsonProperty("VirusCnt")]
        public ulong? VirusCnt{ get; set; }

        /// <summary>
        /// <p>敏感信息数</p>
        /// </summary>
        [JsonProperty("SensitiveCnt")]
        public ulong? SensitiveCnt{ get; set; }

        /// <summary>
        /// <p>定时扫描配置数</p>
        /// </summary>
        [JsonProperty("TimedScanTaskConfigCnt")]
        public ulong? TimedScanTaskConfigCnt{ get; set; }

        /// <summary>
        /// <p>总配额</p>
        /// </summary>
        [JsonProperty("TotalQuota")]
        public ulong? TotalQuota{ get; set; }

        /// <summary>
        /// <p>已使用配额</p>
        /// </summary>
        [JsonProperty("UsedQuota")]
        public ulong? UsedQuota{ get; set; }

        /// <summary>
        /// <p>剩余配额</p>
        /// </summary>
        [JsonProperty("RemainingQuota")]
        public ulong? RemainingQuota{ get; set; }

        /// <summary>
        /// <p>试用配额</p>
        /// </summary>
        [JsonProperty("TrialQuota")]
        public ulong? TrialQuota{ get; set; }

        /// <summary>
        /// <p>有风险的镜像数</p>
        /// </summary>
        [JsonProperty("RiskImageCnt")]
        public ulong? RiskImageCnt{ get; set; }

        /// <summary>
        /// <p>CICD镜像数</p>
        /// </summary>
        [JsonProperty("CICDImageCnt")]
        public ulong? CICDImageCnt{ get; set; }

        /// <summary>
        /// <p>CICD已扫描镜数</p>
        /// </summary>
        [JsonProperty("CICDImageScannedCnt")]
        public ulong? CICDImageScannedCnt{ get; set; }

        /// <summary>
        /// <p>有风险的CICD镜像数</p>
        /// </summary>
        [JsonProperty("RiskCICDImageCnt")]
        public ulong? RiskCICDImageCnt{ get; set; }

        /// <summary>
        /// <p>敏感文件数</p>
        /// </summary>
        [JsonProperty("SecretFileCnt")]
        public ulong? SecretFileCnt{ get; set; }

        /// <summary>
        /// <p>构建风险数</p>
        /// </summary>
        [JsonProperty("BuildRiskCnt")]
        public ulong? BuildRiskCnt{ get; set; }

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
            this.SetParamSimple(map, prefix + "ImageScannedCnt", this.ImageScannedCnt);
            this.SetParamSimple(map, prefix + "ComponentCnt", this.ComponentCnt);
            this.SetParamSimple(map, prefix + "VulCnt", this.VulCnt);
            this.SetParamSimple(map, prefix + "VirusCnt", this.VirusCnt);
            this.SetParamSimple(map, prefix + "SensitiveCnt", this.SensitiveCnt);
            this.SetParamSimple(map, prefix + "TimedScanTaskConfigCnt", this.TimedScanTaskConfigCnt);
            this.SetParamSimple(map, prefix + "TotalQuota", this.TotalQuota);
            this.SetParamSimple(map, prefix + "UsedQuota", this.UsedQuota);
            this.SetParamSimple(map, prefix + "RemainingQuota", this.RemainingQuota);
            this.SetParamSimple(map, prefix + "TrialQuota", this.TrialQuota);
            this.SetParamSimple(map, prefix + "RiskImageCnt", this.RiskImageCnt);
            this.SetParamSimple(map, prefix + "CICDImageCnt", this.CICDImageCnt);
            this.SetParamSimple(map, prefix + "CICDImageScannedCnt", this.CICDImageScannedCnt);
            this.SetParamSimple(map, prefix + "RiskCICDImageCnt", this.RiskCICDImageCnt);
            this.SetParamSimple(map, prefix + "SecretFileCnt", this.SecretFileCnt);
            this.SetParamSimple(map, prefix + "BuildRiskCnt", this.BuildRiskCnt);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

