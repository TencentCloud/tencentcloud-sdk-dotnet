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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSecurityProtectionStatResponse : AbstractModel
    {
        
        /// <summary>
        /// 0 ：0付费资产情况， 1：存在未安装agent情况 ，2：部分资产已是专业版/旗舰版， 3：全部资产已是专业版/旗舰版
        /// </summary>
        [JsonProperty("AssetManageStat")]
        public ulong? AssetManageStat{ get; set; }

        /// <summary>
        /// 0:从未检测过，或0资产付费情况, 1:存在漏洞风险, 2:无风险
        /// </summary>
        [JsonProperty("VulManageStat")]
        public ulong? VulManageStat{ get; set; }

        /// <summary>
        /// 0:从未检测过，或0资产付费情况, 1:存在基线风险,2:无风险
        /// </summary>
        [JsonProperty("SecureBasicLineStat")]
        public ulong? SecureBasicLineStat{ get; set; }

        /// <summary>
        /// 0:从未检测过，或0资产付费情况, 1:已检测，存在恶意文件, 2:已检测，未开启隔离防护, 3:已检测且已开启防护且无风险
        /// </summary>
        [JsonProperty("MalwareScanStat")]
        public ulong? MalwareScanStat{ get; set; }

        /// <summary>
        /// 密码破解是否开启防护 0:未开启防护或0付费资产情况 1:已开启防护 2:存在带处理事件
        /// </summary>
        [JsonProperty("DefenseBruteAttackStat")]
        public ulong? DefenseBruteAttackStat{ get; set; }

        /// <summary>
        /// 核心文件监控 0:未开启防护（0付费资产情况）,1: 已开通
        /// </summary>
        [JsonProperty("FileTamperStat")]
        public ulong? FileTamperStat{ get; set; }

        /// <summary>
        /// 网页防篡改  0:未开通, 1:已开通
        /// </summary>
        [JsonProperty("WebPageStat")]
        public ulong? WebPageStat{ get; set; }

        /// <summary>
        /// 异常登录 0:存在未处理风险,1:无风险，未配置白名单,2:无风险，已配置
        /// </summary>
        [JsonProperty("LoginLogStat")]
        public ulong? LoginLogStat{ get; set; }

        /// <summary>
        /// 检测--密码破解有无存在风险  0:存在未处理风险, 1：无风险，正常检测
        /// </summary>
        [JsonProperty("DiscoverBruteAttackStat")]
        public ulong? DiscoverBruteAttackStat{ get; set; }

        /// <summary>
        /// 恶意请求 0 : 0台开通专业版/旗舰版, 1: 恶意请求 存在未处理风险, 2:已有付费资产，无风险
        /// </summary>
        [JsonProperty("MaliciousRequestStat")]
        public ulong? MaliciousRequestStat{ get; set; }

        /// <summary>
        /// 本地提权 0:0台开通专业版/旗舰版, 1:存在未处理风险 2:已有付费资产，无风险
        /// </summary>
        [JsonProperty("PrivilegeStat")]
        public ulong? PrivilegeStat{ get; set; }

        /// <summary>
        /// 反弹shell 0:0台开通专业版/旗舰版, 1:存在未处理风险 2:已有付费资产，无风险
        /// </summary>
        [JsonProperty("ReverseShellStat")]
        public ulong? ReverseShellStat{ get; set; }

        /// <summary>
        /// 专家服务 0:未开通服务, 1:已开通
        /// </summary>
        [JsonProperty("ExpertServiceStat")]
        public ulong? ExpertServiceStat{ get; set; }

        /// <summary>
        /// 日志分析 0:未开通服务, 1:已开通
        /// </summary>
        [JsonProperty("LogAnalysisStat")]
        public ulong? LogAnalysisStat{ get; set; }

        /// <summary>
        /// 安全告警 0:未开通设置（全部关闭） 1:已开通（只要开启1个就算）
        /// </summary>
        [JsonProperty("WarningSetStat")]
        public ulong? WarningSetStat{ get; set; }

        /// <summary>
        /// 高危命令，0：0台开通专业版/旗舰版， 1：存在未处理风险， 2：已有付费资产，无风险
        /// </summary>
        [JsonProperty("EventBashStat")]
        public ulong? EventBashStat{ get; set; }

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
            this.SetParamSimple(map, prefix + "AssetManageStat", this.AssetManageStat);
            this.SetParamSimple(map, prefix + "VulManageStat", this.VulManageStat);
            this.SetParamSimple(map, prefix + "SecureBasicLineStat", this.SecureBasicLineStat);
            this.SetParamSimple(map, prefix + "MalwareScanStat", this.MalwareScanStat);
            this.SetParamSimple(map, prefix + "DefenseBruteAttackStat", this.DefenseBruteAttackStat);
            this.SetParamSimple(map, prefix + "FileTamperStat", this.FileTamperStat);
            this.SetParamSimple(map, prefix + "WebPageStat", this.WebPageStat);
            this.SetParamSimple(map, prefix + "LoginLogStat", this.LoginLogStat);
            this.SetParamSimple(map, prefix + "DiscoverBruteAttackStat", this.DiscoverBruteAttackStat);
            this.SetParamSimple(map, prefix + "MaliciousRequestStat", this.MaliciousRequestStat);
            this.SetParamSimple(map, prefix + "PrivilegeStat", this.PrivilegeStat);
            this.SetParamSimple(map, prefix + "ReverseShellStat", this.ReverseShellStat);
            this.SetParamSimple(map, prefix + "ExpertServiceStat", this.ExpertServiceStat);
            this.SetParamSimple(map, prefix + "LogAnalysisStat", this.LogAnalysisStat);
            this.SetParamSimple(map, prefix + "WarningSetStat", this.WarningSetStat);
            this.SetParamSimple(map, prefix + "EventBashStat", this.EventBashStat);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

