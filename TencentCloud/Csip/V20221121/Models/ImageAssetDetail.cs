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

    public class ImageAssetDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>镜像摘要</p>
        /// </summary>
        [JsonProperty("ImageDigest")]
        public string ImageDigest{ get; set; }

        /// <summary>
        /// <p>仓库地址</p>
        /// </summary>
        [JsonProperty("ImageRepoAddress")]
        public string ImageRepoAddress{ get; set; }

        /// <summary>
        /// <p>仓库类型</p>
        /// </summary>
        [JsonProperty("RegistryType")]
        public string RegistryType{ get; set; }

        /// <summary>
        /// <p>镜像名</p>
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// <p>镜像tag</p>
        /// </summary>
        [JsonProperty("ImageTag")]
        public string ImageTag{ get; set; }

        /// <summary>
        /// <p>最后扫描时间</p><p>参数格式：YYYY-MM-DD hh:mm:ss</p>
        /// </summary>
        [JsonProperty("LatestScanTime")]
        public string LatestScanTime{ get; set; }

        /// <summary>
        /// <p>扫描状态</p><p>枚举值：</p><ul><li>0： 初始状态</li><li>1： 已下发</li><li>2： 扫描中</li><li>3： 扫描完成</li><li>4： 扫描超时</li><li>5： 扫描失败</li></ul>
        /// </summary>
        [JsonProperty("ScanStatus")]
        public ulong? ScanStatus{ get; set; }

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
        /// <p>仓库实例id</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>镜像仓库名</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>命名空间</p>
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// <p>是否授权</p>
        /// </summary>
        [JsonProperty("IsAuthorized")]
        public ulong? IsAuthorized{ get; set; }

        /// <summary>
        /// <p>镜像大小</p>
        /// </summary>
        [JsonProperty("ImageSize")]
        public ulong? ImageSize{ get; set; }

        /// <summary>
        /// <p>镜像id</p>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// <p>仓库所在地域</p>
        /// </summary>
        [JsonProperty("RegistryRegion")]
        public string RegistryRegion{ get; set; }

        /// <summary>
        /// <p>镜像创建时间</p><p>参数格式：YYYY-MM-DD hh:mm:ss</p>
        /// </summary>
        [JsonProperty("ImageCreateTime")]
        public string ImageCreateTime{ get; set; }

        /// <summary>
        /// <p>id</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>镜像所属账号名</p>
        /// </summary>
        [JsonProperty("OwnerAccountName")]
        public string OwnerAccountName{ get; set; }

        /// <summary>
        /// <p>镜像所属账号uin</p>
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// <p>镜像所属账号appid</p>
        /// </summary>
        [JsonProperty("OwnerAppId")]
        public ulong? OwnerAppId{ get; set; }

        /// <summary>
        /// <p>低风险漏洞数</p>
        /// </summary>
        [JsonProperty("LowLevelVulCnt")]
        public ulong? LowLevelVulCnt{ get; set; }

        /// <summary>
        /// <p>中风险漏洞数</p>
        /// </summary>
        [JsonProperty("MediumLevelVulCnt")]
        public ulong? MediumLevelVulCnt{ get; set; }

        /// <summary>
        /// <p>高风险漏洞数</p>
        /// </summary>
        [JsonProperty("HighLevelVulCnt")]
        public ulong? HighLevelVulCnt{ get; set; }

        /// <summary>
        /// <p>严重风险漏洞数</p>
        /// </summary>
        [JsonProperty("CriticalLevelVulCnt")]
        public ulong? CriticalLevelVulCnt{ get; set; }

        /// <summary>
        /// <p>低危木马数</p>
        /// </summary>
        [JsonProperty("LowLevelVirusCnt")]
        public ulong? LowLevelVirusCnt{ get; set; }

        /// <summary>
        /// <p>中危木马数</p>
        /// </summary>
        [JsonProperty("MediumLevelVirusCnt")]
        public ulong? MediumLevelVirusCnt{ get; set; }

        /// <summary>
        /// <p>高危木马数</p>
        /// </summary>
        [JsonProperty("HighLevelVirusCnt")]
        public ulong? HighLevelVirusCnt{ get; set; }

        /// <summary>
        /// <p>严重木马数</p>
        /// </summary>
        [JsonProperty("CriticalLevelVirusCnt")]
        public ulong? CriticalLevelVirusCnt{ get; set; }

        /// <summary>
        /// <p>应急漏洞数</p>
        /// </summary>
        [JsonProperty("EmergencyVulCnt")]
        public ulong? EmergencyVulCnt{ get; set; }

        /// <summary>
        /// <p>低危敏感信息数</p>
        /// </summary>
        [JsonProperty("LowLevelSensitiveCnt")]
        public ulong? LowLevelSensitiveCnt{ get; set; }

        /// <summary>
        /// <p>中危敏感信息数</p>
        /// </summary>
        [JsonProperty("MediumLevelSensitiveCnt")]
        public ulong? MediumLevelSensitiveCnt{ get; set; }

        /// <summary>
        /// <p>高危敏感信息数</p>
        /// </summary>
        [JsonProperty("HighLevelSensitiveCnt")]
        public ulong? HighLevelSensitiveCnt{ get; set; }

        /// <summary>
        /// <p>严重敏感信息数</p>
        /// </summary>
        [JsonProperty("CriticalLevelSensitiveCnt")]
        public ulong? CriticalLevelSensitiveCnt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageDigest", this.ImageDigest);
            this.SetParamSimple(map, prefix + "ImageRepoAddress", this.ImageRepoAddress);
            this.SetParamSimple(map, prefix + "RegistryType", this.RegistryType);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageTag", this.ImageTag);
            this.SetParamSimple(map, prefix + "LatestScanTime", this.LatestScanTime);
            this.SetParamSimple(map, prefix + "ScanStatus", this.ScanStatus);
            this.SetParamSimple(map, prefix + "VulCnt", this.VulCnt);
            this.SetParamSimple(map, prefix + "VirusCnt", this.VirusCnt);
            this.SetParamSimple(map, prefix + "SensitiveCnt", this.SensitiveCnt);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "IsAuthorized", this.IsAuthorized);
            this.SetParamSimple(map, prefix + "ImageSize", this.ImageSize);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "RegistryRegion", this.RegistryRegion);
            this.SetParamSimple(map, prefix + "ImageCreateTime", this.ImageCreateTime);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "OwnerAccountName", this.OwnerAccountName);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "OwnerAppId", this.OwnerAppId);
            this.SetParamSimple(map, prefix + "LowLevelVulCnt", this.LowLevelVulCnt);
            this.SetParamSimple(map, prefix + "MediumLevelVulCnt", this.MediumLevelVulCnt);
            this.SetParamSimple(map, prefix + "HighLevelVulCnt", this.HighLevelVulCnt);
            this.SetParamSimple(map, prefix + "CriticalLevelVulCnt", this.CriticalLevelVulCnt);
            this.SetParamSimple(map, prefix + "LowLevelVirusCnt", this.LowLevelVirusCnt);
            this.SetParamSimple(map, prefix + "MediumLevelVirusCnt", this.MediumLevelVirusCnt);
            this.SetParamSimple(map, prefix + "HighLevelVirusCnt", this.HighLevelVirusCnt);
            this.SetParamSimple(map, prefix + "CriticalLevelVirusCnt", this.CriticalLevelVirusCnt);
            this.SetParamSimple(map, prefix + "EmergencyVulCnt", this.EmergencyVulCnt);
            this.SetParamSimple(map, prefix + "LowLevelSensitiveCnt", this.LowLevelSensitiveCnt);
            this.SetParamSimple(map, prefix + "MediumLevelSensitiveCnt", this.MediumLevelSensitiveCnt);
            this.SetParamSimple(map, prefix + "HighLevelSensitiveCnt", this.HighLevelSensitiveCnt);
            this.SetParamSimple(map, prefix + "CriticalLevelSensitiveCnt", this.CriticalLevelSensitiveCnt);
        }
    }
}

