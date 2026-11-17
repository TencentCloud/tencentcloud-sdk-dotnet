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

    public class HostVulScanStatus : AbstractModel
    {
        
        /// <summary>
        /// 是否发起过漏洞扫描
        /// 枚举值：
        /// true：已发起过漏洞扫描
        /// false：从未发起过漏洞扫描
        /// </summary>
        [JsonProperty("HasScanned")]
        public bool? HasScanned{ get; set; }

        /// <summary>
        /// 是否处于首次漏洞扫描判断场景
        /// 枚举值：
        /// true：处于首次漏洞扫描判断场景
        /// false：不处于首次漏洞扫描判断场景
        /// </summary>
        [JsonProperty("IsFirstScan")]
        public bool? IsFirstScan{ get; set; }

        /// <summary>
        /// 最近一次扫描任务状态
        /// 枚举值：
        /// SCANNING：扫描中
        /// SUCCESS：扫描成功
        /// PARTIAL_FAILED：部分扫描失败
        /// ALL_FAILED：全部扫描失败
        /// STOPPED：停止扫描
        /// </summary>
        [JsonProperty("ScanTaskStatus")]
        public string ScanTaskStatus{ get; set; }

        /// <summary>
        /// 页面业务状态
        /// 枚举值：
        /// NEVER_SCANNED：从未扫描过漏洞
        /// SCANNING：扫描中
        /// FIRST_SCAN_FAILED：首次漏洞扫描失败
        /// FIRST_SCAN_HAS_FIXABLE_VUL：首次扫描完成，存在可修复漏洞
        /// FIRST_SCAN_NO_FIXABLE_VUL：首次扫描完成，有漏洞但无可修复漏洞
        /// FIRST_SCAN_NO_VUL：首次扫描完成，没有漏洞
        /// SCANNED_HAS_FIXABLE_VUL：非首次扫描，存在可修复漏洞
        /// SCANNED_NO_FIXABLE_VUL：非首次扫描，有漏洞但无可修复漏洞
        /// SCANNED_NO_VUL：非首次扫描，没有漏洞
        /// </summary>
        [JsonProperty("ScanScene")]
        public string ScanScene{ get; set; }

        /// <summary>
        /// 最近扫描时间
        /// 参数格式：YYYY-MM-DDTHH:mm:ssZ（ISO8601格式）
        /// 从未扫描时返回空字符串。
        /// </summary>
        [JsonProperty("LatestScanTime")]
        public string LatestScanTime{ get; set; }

        /// <summary>
        /// 当前待处理漏洞总数
        /// 包含普通主机漏洞和最新 Windows KB 待处理风险。
        /// </summary>
        [JsonProperty("TotalVulCount")]
        public long? TotalVulCount{ get; set; }

        /// <summary>
        /// 当前可修复漏洞数
        /// 包含支持一键修复的普通主机漏洞和最新 Windows KB 待处理风险。
        /// </summary>
        [JsonProperty("FixableVulCount")]
        public long? FixableVulCount{ get; set; }

        /// <summary>
        /// 当前可修复应急漏洞数
        /// 应急漏洞优先归类：应急漏洞仅计入该字段，不再计入 Linux 软件漏洞数。
        /// </summary>
        [JsonProperty("FixableEmergencyCount")]
        public long? FixableEmergencyCount{ get; set; }

        /// <summary>
        /// 当前可修复 Linux 软件漏洞数
        /// 仅统计非应急 Linux 软件漏洞。
        /// </summary>
        [JsonProperty("FixableLinuxVulCount")]
        public long? FixableLinuxVulCount{ get; set; }

        /// <summary>
        /// 当前可修复 Windows 系统补丁数
        /// 统计最新 Windows KB 待处理风险。
        /// </summary>
        [JsonProperty("FixableWindowVulCount")]
        public long? FixableWindowVulCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HasScanned", this.HasScanned);
            this.SetParamSimple(map, prefix + "IsFirstScan", this.IsFirstScan);
            this.SetParamSimple(map, prefix + "ScanTaskStatus", this.ScanTaskStatus);
            this.SetParamSimple(map, prefix + "ScanScene", this.ScanScene);
            this.SetParamSimple(map, prefix + "LatestScanTime", this.LatestScanTime);
            this.SetParamSimple(map, prefix + "TotalVulCount", this.TotalVulCount);
            this.SetParamSimple(map, prefix + "FixableVulCount", this.FixableVulCount);
            this.SetParamSimple(map, prefix + "FixableEmergencyCount", this.FixableEmergencyCount);
            this.SetParamSimple(map, prefix + "FixableLinuxVulCount", this.FixableLinuxVulCount);
            this.SetParamSimple(map, prefix + "FixableWindowVulCount", this.FixableWindowVulCount);
        }
    }
}

