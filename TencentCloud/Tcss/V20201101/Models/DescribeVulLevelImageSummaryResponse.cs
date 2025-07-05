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

    public class DescribeVulLevelImageSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// 高危漏洞最新本地镜像占比
        /// </summary>
        [JsonProperty("HighLevelVulLocalImagePercent")]
        public float? HighLevelVulLocalImagePercent{ get; set; }

        /// <summary>
        /// 中危漏洞最新本地镜像占比
        /// </summary>
        [JsonProperty("MediumLevelVulLocalImagePercent")]
        public float? MediumLevelVulLocalImagePercent{ get; set; }

        /// <summary>
        /// 低危漏洞最新本地镜像占比
        /// </summary>
        [JsonProperty("LowLevelVulLocalImagePercent")]
        public float? LowLevelVulLocalImagePercent{ get; set; }

        /// <summary>
        /// 严重漏洞最新本地镜像占比
        /// </summary>
        [JsonProperty("CriticalLevelVulLocalImagePercent")]
        public float? CriticalLevelVulLocalImagePercent{ get; set; }

        /// <summary>
        /// 影响的最新版本本地镜像数
        /// </summary>
        [JsonProperty("LocalNewestImageCount")]
        public long? LocalNewestImageCount{ get; set; }

        /// <summary>
        /// 影响的最新版本仓库镜像数
        /// </summary>
        [JsonProperty("RegistryNewestImageCount")]
        public long? RegistryNewestImageCount{ get; set; }

        /// <summary>
        /// 高危漏洞最新仓库镜像占比
        /// </summary>
        [JsonProperty("HighLevelVulRegistryImagePercent")]
        public float? HighLevelVulRegistryImagePercent{ get; set; }

        /// <summary>
        /// 中危漏洞最新仓库镜像占比
        /// </summary>
        [JsonProperty("MediumLevelVulRegistryImagePercent")]
        public float? MediumLevelVulRegistryImagePercent{ get; set; }

        /// <summary>
        /// 低危漏洞最新仓库镜像占比
        /// </summary>
        [JsonProperty("LowLevelVulRegistryImagePercent")]
        public float? LowLevelVulRegistryImagePercent{ get; set; }

        /// <summary>
        /// 严重漏洞最新仓库镜像占比
        /// </summary>
        [JsonProperty("CriticalLevelVulRegistryImagePercent")]
        public float? CriticalLevelVulRegistryImagePercent{ get; set; }

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
            this.SetParamSimple(map, prefix + "HighLevelVulLocalImagePercent", this.HighLevelVulLocalImagePercent);
            this.SetParamSimple(map, prefix + "MediumLevelVulLocalImagePercent", this.MediumLevelVulLocalImagePercent);
            this.SetParamSimple(map, prefix + "LowLevelVulLocalImagePercent", this.LowLevelVulLocalImagePercent);
            this.SetParamSimple(map, prefix + "CriticalLevelVulLocalImagePercent", this.CriticalLevelVulLocalImagePercent);
            this.SetParamSimple(map, prefix + "LocalNewestImageCount", this.LocalNewestImageCount);
            this.SetParamSimple(map, prefix + "RegistryNewestImageCount", this.RegistryNewestImageCount);
            this.SetParamSimple(map, prefix + "HighLevelVulRegistryImagePercent", this.HighLevelVulRegistryImagePercent);
            this.SetParamSimple(map, prefix + "MediumLevelVulRegistryImagePercent", this.MediumLevelVulRegistryImagePercent);
            this.SetParamSimple(map, prefix + "LowLevelVulRegistryImagePercent", this.LowLevelVulRegistryImagePercent);
            this.SetParamSimple(map, prefix + "CriticalLevelVulRegistryImagePercent", this.CriticalLevelVulRegistryImagePercent);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

