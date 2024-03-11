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

    public class DescribeVulImageSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// 受严重或高危漏洞影响的镜像数
        /// </summary>
        [JsonProperty("SeriousVulImageCount")]
        public long? SeriousVulImageCount{ get; set; }

        /// <summary>
        /// 已扫描的镜像数
        /// </summary>
        [JsonProperty("ScannedImageCount")]
        public long? ScannedImageCount{ get; set; }

        /// <summary>
        /// 漏洞总数量
        /// </summary>
        [JsonProperty("VulTotalCount")]
        public long? VulTotalCount{ get; set; }

        /// <summary>
        /// 系统漏洞数
        /// </summary>
        [JsonProperty("SysTemVulCount")]
        public long? SysTemVulCount{ get; set; }

        /// <summary>
        /// web应用漏洞数
        /// </summary>
        [JsonProperty("WebVulCount")]
        public long? WebVulCount{ get; set; }

        /// <summary>
        /// 已授权镜像数
        /// </summary>
        [JsonProperty("AllAuthorizedImageCount")]
        public long? AllAuthorizedImageCount{ get; set; }

        /// <summary>
        /// 应急漏洞数
        /// </summary>
        [JsonProperty("EmergencyVulCount")]
        public long? EmergencyVulCount{ get; set; }

        /// <summary>
        /// 支持扫描的漏洞总数量
        /// </summary>
        [JsonProperty("SupportVulTotalCount")]
        public long? SupportVulTotalCount{ get; set; }

        /// <summary>
        /// 漏洞库更新时间
        /// </summary>
        [JsonProperty("VulLibraryUpdateTime")]
        public string VulLibraryUpdateTime{ get; set; }

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
            this.SetParamSimple(map, prefix + "SeriousVulImageCount", this.SeriousVulImageCount);
            this.SetParamSimple(map, prefix + "ScannedImageCount", this.ScannedImageCount);
            this.SetParamSimple(map, prefix + "VulTotalCount", this.VulTotalCount);
            this.SetParamSimple(map, prefix + "SysTemVulCount", this.SysTemVulCount);
            this.SetParamSimple(map, prefix + "WebVulCount", this.WebVulCount);
            this.SetParamSimple(map, prefix + "AllAuthorizedImageCount", this.AllAuthorizedImageCount);
            this.SetParamSimple(map, prefix + "EmergencyVulCount", this.EmergencyVulCount);
            this.SetParamSimple(map, prefix + "SupportVulTotalCount", this.SupportVulTotalCount);
            this.SetParamSimple(map, prefix + "VulLibraryUpdateTime", this.VulLibraryUpdateTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

