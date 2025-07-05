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

    public class ImageProgress : AbstractModel
    {
        
        /// <summary>
        /// 镜像id
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// 仓库类型
        /// </summary>
        [JsonProperty("RegistryType")]
        public string RegistryType{ get; set; }

        /// <summary>
        /// 镜像仓库地址
        /// </summary>
        [JsonProperty("ImageRepoAddress")]
        public string ImageRepoAddress{ get; set; }

        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// 镜像tag
        /// </summary>
        [JsonProperty("ImageTag")]
        public string ImageTag{ get; set; }

        /// <summary>
        /// 镜像扫描状态
        /// </summary>
        [JsonProperty("ScanStatus")]
        public string ScanStatus{ get; set; }

        /// <summary>
        /// 镜像cve扫描进度
        /// </summary>
        [JsonProperty("CveProgress")]
        public ulong? CveProgress{ get; set; }

        /// <summary>
        /// 镜像敏感扫描进度
        /// </summary>
        [JsonProperty("RiskProgress")]
        public ulong? RiskProgress{ get; set; }

        /// <summary>
        /// 镜像木马扫描进度
        /// </summary>
        [JsonProperty("VirusProgress")]
        public ulong? VirusProgress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "RegistryType", this.RegistryType);
            this.SetParamSimple(map, prefix + "ImageRepoAddress", this.ImageRepoAddress);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageTag", this.ImageTag);
            this.SetParamSimple(map, prefix + "ScanStatus", this.ScanStatus);
            this.SetParamSimple(map, prefix + "CveProgress", this.CveProgress);
            this.SetParamSimple(map, prefix + "RiskProgress", this.RiskProgress);
            this.SetParamSimple(map, prefix + "VirusProgress", this.VirusProgress);
        }
    }
}

