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

    public class HostVulRiskEventItem : AbstractModel
    {
        
        /// <summary>
        /// 漏洞风险记录唯一标识
        /// </summary>
        [JsonProperty("UUID")]
        public string UUID{ get; set; }

        /// <summary>
        /// 风险记录 ID
        /// </summary>
        [JsonProperty("RiskID")]
        public ulong? RiskID{ get; set; }

        /// <summary>
        /// 漏洞 ID
        /// </summary>
        [JsonProperty("VulID")]
        public ulong? VulID{ get; set; }

        /// <summary>
        /// 漏洞名称
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// CVE 编号
        /// 参数格式：形如 CVE-2024-12345
        /// </summary>
        [JsonProperty("CVEID")]
        public string CVEID{ get; set; }

        /// <summary>
        /// 漏洞分类
        /// 枚举值：
        /// LINUX：Linux 软件漏洞
        /// WINDOWS：Windows 系统补丁
        /// WEB_CMS：Web-CMS 漏洞
        /// APPLICATION：应用漏洞
        /// EMERGENCY：应急漏洞
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// 漏洞危害等级
        /// 枚举值：
        /// UNKNOWN：无效
        /// LOW：低危
        /// MEDIUM：中危
        /// HIGH：高危
        /// CRITICAL：严重
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// VPR 修复优先级
        /// 枚举值：
        /// DEFERRABLE：可暂缓修复
        /// PLANNED：计划修复
        /// SOON：尽快修复
        /// URGENT：紧急修复
        /// </summary>
        [JsonProperty("VPRLevel")]
        public string VPRLevel{ get; set; }

        /// <summary>
        /// 检测方式
        /// 枚举值：
        /// VersionCompare：版本比对
        /// POC：POC 检测
        /// VersionComparePOC：版本比对 + POC
        /// </summary>
        [JsonProperty("CheckMethod")]
        public string CheckMethod{ get; set; }

        /// <summary>
        /// 风险状态
        /// 枚举值：
        /// PENDING：待处理
        /// HANDLED：已处置
        /// FIXED：已修复
        /// SCANNING：重新检测中
        /// IGNORED：已忽略
        /// NOT_REQUIRED：无需处理
        /// DELETED：已删除
        /// FIXING：修复中
        /// NEED_REBOOT：已修复待重启
        /// FIX_FAILED：修复失败
        /// </summary>
        [JsonProperty("RiskStatus")]
        public string RiskStatus{ get; set; }

        /// <summary>
        /// 是否支持一键修复
        /// </summary>
        [JsonProperty("SupportFix")]
        public bool? SupportFix{ get; set; }

        /// <summary>
        /// 最近扫描时间
        /// 参数格式：YYYY-MM-DDTHH:mm:ssZ（ISO8601格式）
        /// </summary>
        [JsonProperty("LatestScanTime")]
        public string LatestScanTime{ get; set; }

        /// <summary>
        /// 云主机实例 ID
        /// 参数格式：形如 ins-xxxxxxxx
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// 所属账号 AppID
        /// </summary>
        [JsonProperty("AppID")]
        public ulong? AppID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UUID", this.UUID);
            this.SetParamSimple(map, prefix + "RiskID", this.RiskID);
            this.SetParamSimple(map, prefix + "VulID", this.VulID);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "CVEID", this.CVEID);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "VPRLevel", this.VPRLevel);
            this.SetParamSimple(map, prefix + "CheckMethod", this.CheckMethod);
            this.SetParamSimple(map, prefix + "RiskStatus", this.RiskStatus);
            this.SetParamSimple(map, prefix + "SupportFix", this.SupportFix);
            this.SetParamSimple(map, prefix + "LatestScanTime", this.LatestScanTime);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
        }
    }
}

