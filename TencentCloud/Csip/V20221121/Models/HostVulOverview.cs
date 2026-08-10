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

    public class HostVulOverview : AbstractModel
    {
        
        /// <summary>
        /// <p>需立即修复漏洞数（VPR 评级为 URGENT 的漏洞数量）</p>
        /// </summary>
        [JsonProperty("UrgentRepairCount")]
        public ulong? UrgentRepairCount{ get; set; }

        /// <summary>
        /// <p>已开启漏洞防御的主机数</p>
        /// </summary>
        [JsonProperty("DefendHostCount")]
        public ulong? DefendHostCount{ get; set; }

        /// <summary>
        /// <p>主机总数</p>
        /// </summary>
        [JsonProperty("TotalHostCount")]
        public ulong? TotalHostCount{ get; set; }

        /// <summary>
        /// <p>已修复漏洞总次数</p>
        /// </summary>
        [JsonProperty("FixedVulCount")]
        public ulong? FixedVulCount{ get; set; }

        /// <summary>
        /// <p>Linux 软件漏洞数</p>
        /// </summary>
        [JsonProperty("LinuxVulCount")]
        public ulong? LinuxVulCount{ get; set; }

        /// <summary>
        /// <p>Windows 系统补丁数</p>
        /// </summary>
        [JsonProperty("WindowVulCount")]
        public ulong? WindowVulCount{ get; set; }

        /// <summary>
        /// <p>Web-CMS 漏洞数</p>
        /// </summary>
        [JsonProperty("WebCMSVulCount")]
        public ulong? WebCMSVulCount{ get; set; }

        /// <summary>
        /// <p>应用漏洞数</p>
        /// </summary>
        [JsonProperty("AppVulCount")]
        public ulong? AppVulCount{ get; set; }

        /// <summary>
        /// <p>应急漏洞数</p>
        /// </summary>
        [JsonProperty("EmergencyCount")]
        public ulong? EmergencyCount{ get; set; }

        /// <summary>
        /// <p>漏洞知识库总数</p>
        /// </summary>
        [JsonProperty("VulItemCount")]
        public ulong? VulItemCount{ get; set; }

        /// <summary>
        /// <p>最近扫描时间</p><p>参数格式：YYYY-MM-DDTHH:mm:ssZ</p>
        /// </summary>
        [JsonProperty("LatestScanTime")]
        public string LatestScanTime{ get; set; }

        /// <summary>
        /// <p>是否开启周期扫描</p><p>枚举值：</p><ul><li>1： 开启</li><li>0： 未开启</li></ul>
        /// </summary>
        [JsonProperty("EnableTimingScan")]
        public ulong? EnableTimingScan{ get; set; }

        /// <summary>
        /// <p>严重修复数</p>
        /// </summary>
        [JsonProperty("CriticalRepairCount")]
        public ulong? CriticalRepairCount{ get; set; }

        /// <summary>
        /// <p>严重修复Linux漏洞数</p>
        /// </summary>
        [JsonProperty("CriticalRepairLinuxVulCount")]
        public ulong? CriticalRepairLinuxVulCount{ get; set; }

        /// <summary>
        /// <p>严重修复应用漏洞数</p>
        /// </summary>
        [JsonProperty("CriticalRepairAppVulCount")]
        public ulong? CriticalRepairAppVulCount{ get; set; }

        /// <summary>
        /// <p>严重修复Web-CMS漏洞数</p>
        /// </summary>
        [JsonProperty("CriticalRepairWebCMSVulCount")]
        public ulong? CriticalRepairWebCMSVulCount{ get; set; }

        /// <summary>
        /// <p>严重修复紧急漏洞数</p>
        /// </summary>
        [JsonProperty("CriticalRepairEmergencyCount")]
        public ulong? CriticalRepairEmergencyCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UrgentRepairCount", this.UrgentRepairCount);
            this.SetParamSimple(map, prefix + "DefendHostCount", this.DefendHostCount);
            this.SetParamSimple(map, prefix + "TotalHostCount", this.TotalHostCount);
            this.SetParamSimple(map, prefix + "FixedVulCount", this.FixedVulCount);
            this.SetParamSimple(map, prefix + "LinuxVulCount", this.LinuxVulCount);
            this.SetParamSimple(map, prefix + "WindowVulCount", this.WindowVulCount);
            this.SetParamSimple(map, prefix + "WebCMSVulCount", this.WebCMSVulCount);
            this.SetParamSimple(map, prefix + "AppVulCount", this.AppVulCount);
            this.SetParamSimple(map, prefix + "EmergencyCount", this.EmergencyCount);
            this.SetParamSimple(map, prefix + "VulItemCount", this.VulItemCount);
            this.SetParamSimple(map, prefix + "LatestScanTime", this.LatestScanTime);
            this.SetParamSimple(map, prefix + "EnableTimingScan", this.EnableTimingScan);
            this.SetParamSimple(map, prefix + "CriticalRepairCount", this.CriticalRepairCount);
            this.SetParamSimple(map, prefix + "CriticalRepairLinuxVulCount", this.CriticalRepairLinuxVulCount);
            this.SetParamSimple(map, prefix + "CriticalRepairAppVulCount", this.CriticalRepairAppVulCount);
            this.SetParamSimple(map, prefix + "CriticalRepairWebCMSVulCount", this.CriticalRepairWebCMSVulCount);
            this.SetParamSimple(map, prefix + "CriticalRepairEmergencyCount", this.CriticalRepairEmergencyCount);
        }
    }
}

