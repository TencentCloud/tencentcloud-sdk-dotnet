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

    public class DescribeVulSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// 漏洞总数量
        /// </summary>
        [JsonProperty("VulTotalCount")]
        public long? VulTotalCount{ get; set; }

        /// <summary>
        /// 严重及高危漏洞数量
        /// </summary>
        [JsonProperty("SeriousVulCount")]
        public long? SeriousVulCount{ get; set; }

        /// <summary>
        /// 重点关注漏洞数量
        /// </summary>
        [JsonProperty("SuggestVulCount")]
        public long? SuggestVulCount{ get; set; }

        /// <summary>
        /// 有Poc或者Exp的漏洞数量
        /// </summary>
        [JsonProperty("PocExpLevelVulCount")]
        public long? PocExpLevelVulCount{ get; set; }

        /// <summary>
        /// 有远程Exp的漏洞数量
        /// </summary>
        [JsonProperty("RemoteExpLevelVulCount")]
        public long? RemoteExpLevelVulCount{ get; set; }

        /// <summary>
        /// 受严重或高危漏洞影响的最新版本镜像数
        /// </summary>
        [JsonProperty("SeriousVulNewestImageCount")]
        public long? SeriousVulNewestImageCount{ get; set; }

        /// <summary>
        /// 系统漏洞重点关注数
        /// </summary>
        [JsonProperty("SystemVulnerabilityFocusCount")]
        public long? SystemVulnerabilityFocusCount{ get; set; }

        /// <summary>
        /// web漏洞重点关注数
        /// </summary>
        [JsonProperty("WebVulnerabilityFocusCount")]
        public long? WebVulnerabilityFocusCount{ get; set; }

        /// <summary>
        /// 受影响本地镜像数
        /// </summary>
        [JsonProperty("SeriousVulnerabilityLocalImageCount")]
        public long? SeriousVulnerabilityLocalImageCount{ get; set; }

        /// <summary>
        /// 受影响仓库镜像数
        /// </summary>
        [JsonProperty("SeriousVulnerabilityRegistryImageCount")]
        public long? SeriousVulnerabilityRegistryImageCount{ get; set; }

        /// <summary>
        /// 应急漏洞数量
        /// </summary>
        [JsonProperty("EmergencyVulnerabilityCount")]
        public long? EmergencyVulnerabilityCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "VulTotalCount", this.VulTotalCount);
            this.SetParamSimple(map, prefix + "SeriousVulCount", this.SeriousVulCount);
            this.SetParamSimple(map, prefix + "SuggestVulCount", this.SuggestVulCount);
            this.SetParamSimple(map, prefix + "PocExpLevelVulCount", this.PocExpLevelVulCount);
            this.SetParamSimple(map, prefix + "RemoteExpLevelVulCount", this.RemoteExpLevelVulCount);
            this.SetParamSimple(map, prefix + "SeriousVulNewestImageCount", this.SeriousVulNewestImageCount);
            this.SetParamSimple(map, prefix + "SystemVulnerabilityFocusCount", this.SystemVulnerabilityFocusCount);
            this.SetParamSimple(map, prefix + "WebVulnerabilityFocusCount", this.WebVulnerabilityFocusCount);
            this.SetParamSimple(map, prefix + "SeriousVulnerabilityLocalImageCount", this.SeriousVulnerabilityLocalImageCount);
            this.SetParamSimple(map, prefix + "SeriousVulnerabilityRegistryImageCount", this.SeriousVulnerabilityRegistryImageCount);
            this.SetParamSimple(map, prefix + "EmergencyVulnerabilityCount", this.EmergencyVulnerabilityCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

