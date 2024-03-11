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

    public class DescribeSecurityEventStatResponse : AbstractModel
    {
        
        /// <summary>
        /// 木马事件统计
        /// </summary>
        [JsonProperty("MalwareStat")]
        public EventStat MalwareStat{ get; set; }

        /// <summary>
        /// 异地事件统计
        /// </summary>
        [JsonProperty("HostLoginStat")]
        public EventStat HostLoginStat{ get; set; }

        /// <summary>
        /// 爆破事件统计
        /// </summary>
        [JsonProperty("BruteAttackStat")]
        public EventStat BruteAttackStat{ get; set; }

        /// <summary>
        /// 恶意请求事件统计
        /// </summary>
        [JsonProperty("MaliciousRequestStat")]
        public EventStat MaliciousRequestStat{ get; set; }

        /// <summary>
        /// 本地提权事件统计
        /// </summary>
        [JsonProperty("PrivilegeStat")]
        public EventStat PrivilegeStat{ get; set; }

        /// <summary>
        /// 反弹Shell事件统计
        /// </summary>
        [JsonProperty("ReverseShellStat")]
        public EventStat ReverseShellStat{ get; set; }

        /// <summary>
        /// 高危命令事件统计
        /// </summary>
        [JsonProperty("HighRiskBashStat")]
        public EventStat HighRiskBashStat{ get; set; }

        /// <summary>
        /// 网络攻击事件统计
        /// </summary>
        [JsonProperty("AttackLogsStat")]
        public EventStat AttackLogsStat{ get; set; }

        /// <summary>
        /// 高危漏洞事件统计
        /// </summary>
        [JsonProperty("VulHighStat")]
        public EventStat VulHighStat{ get; set; }

        /// <summary>
        /// 中危漏洞事件统计
        /// </summary>
        [JsonProperty("VulNormalStat")]
        public EventStat VulNormalStat{ get; set; }

        /// <summary>
        /// 低危漏洞事件统计
        /// </summary>
        [JsonProperty("VulLowStat")]
        public EventStat VulLowStat{ get; set; }

        /// <summary>
        /// 高危基线漏洞事件统计
        /// </summary>
        [JsonProperty("BaselineHighStat")]
        public EventStat BaselineHighStat{ get; set; }

        /// <summary>
        /// 中危基线漏事件统计
        /// </summary>
        [JsonProperty("BaselineNormalStat")]
        public EventStat BaselineNormalStat{ get; set; }

        /// <summary>
        /// 低危基线漏事件统计
        /// </summary>
        [JsonProperty("BaselineLowStat")]
        public EventStat BaselineLowStat{ get; set; }

        /// <summary>
        /// 有未处理安全事件的机器总数
        /// </summary>
        [JsonProperty("MachineTotalAffectNum")]
        public ulong? MachineTotalAffectNum{ get; set; }

        /// <summary>
        /// 有未处理入侵安全事件的机器总数
        /// </summary>
        [JsonProperty("InvasionTotalAffectNum")]
        public ulong? InvasionTotalAffectNum{ get; set; }

        /// <summary>
        /// 有未处理漏洞安全事件的机器总数
        /// </summary>
        [JsonProperty("VulTotalAffectNum")]
        public ulong? VulTotalAffectNum{ get; set; }

        /// <summary>
        /// 有未处理基线安全事件的机器总数
        /// </summary>
        [JsonProperty("BaseLineTotalAffectNum")]
        public ulong? BaseLineTotalAffectNum{ get; set; }

        /// <summary>
        /// 有未处理网络攻击安全事件的机器总数
        /// </summary>
        [JsonProperty("CyberAttackTotalAffectNum")]
        public ulong? CyberAttackTotalAffectNum{ get; set; }

        /// <summary>
        /// 严重漏洞事件统计
        /// </summary>
        [JsonProperty("VulRiskStat")]
        public EventStat VulRiskStat{ get; set; }

        /// <summary>
        /// 严重基线漏洞事件统计
        /// </summary>
        [JsonProperty("BaselineRiskStat")]
        public EventStat BaselineRiskStat{ get; set; }

        /// <summary>
        /// 漏洞数统计
        /// </summary>
        [JsonProperty("VulStat")]
        public EventStat VulStat{ get; set; }

        /// <summary>
        /// 安全得分
        /// </summary>
        [JsonProperty("Score")]
        public ulong? Score{ get; set; }

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
            this.SetParamObj(map, prefix + "MalwareStat.", this.MalwareStat);
            this.SetParamObj(map, prefix + "HostLoginStat.", this.HostLoginStat);
            this.SetParamObj(map, prefix + "BruteAttackStat.", this.BruteAttackStat);
            this.SetParamObj(map, prefix + "MaliciousRequestStat.", this.MaliciousRequestStat);
            this.SetParamObj(map, prefix + "PrivilegeStat.", this.PrivilegeStat);
            this.SetParamObj(map, prefix + "ReverseShellStat.", this.ReverseShellStat);
            this.SetParamObj(map, prefix + "HighRiskBashStat.", this.HighRiskBashStat);
            this.SetParamObj(map, prefix + "AttackLogsStat.", this.AttackLogsStat);
            this.SetParamObj(map, prefix + "VulHighStat.", this.VulHighStat);
            this.SetParamObj(map, prefix + "VulNormalStat.", this.VulNormalStat);
            this.SetParamObj(map, prefix + "VulLowStat.", this.VulLowStat);
            this.SetParamObj(map, prefix + "BaselineHighStat.", this.BaselineHighStat);
            this.SetParamObj(map, prefix + "BaselineNormalStat.", this.BaselineNormalStat);
            this.SetParamObj(map, prefix + "BaselineLowStat.", this.BaselineLowStat);
            this.SetParamSimple(map, prefix + "MachineTotalAffectNum", this.MachineTotalAffectNum);
            this.SetParamSimple(map, prefix + "InvasionTotalAffectNum", this.InvasionTotalAffectNum);
            this.SetParamSimple(map, prefix + "VulTotalAffectNum", this.VulTotalAffectNum);
            this.SetParamSimple(map, prefix + "BaseLineTotalAffectNum", this.BaseLineTotalAffectNum);
            this.SetParamSimple(map, prefix + "CyberAttackTotalAffectNum", this.CyberAttackTotalAffectNum);
            this.SetParamObj(map, prefix + "VulRiskStat.", this.VulRiskStat);
            this.SetParamObj(map, prefix + "BaselineRiskStat.", this.BaselineRiskStat);
            this.SetParamObj(map, prefix + "VulStat.", this.VulStat);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

