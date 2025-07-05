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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSecurityEventsCntResponse : AbstractModel
    {
        
        /// <summary>
        /// 木马文件相关风险事件
        /// </summary>
        [JsonProperty("Malware")]
        public SecurityEventInfo Malware{ get; set; }

        /// <summary>
        /// 登录审计相关风险事件
        /// </summary>
        [JsonProperty("HostLogin")]
        public SecurityEventInfo HostLogin{ get; set; }

        /// <summary>
        /// 密码破解相关风险事件
        /// </summary>
        [JsonProperty("BruteAttack")]
        public SecurityEventInfo BruteAttack{ get; set; }

        /// <summary>
        /// 恶意请求相关风险事件
        /// </summary>
        [JsonProperty("RiskDns")]
        public SecurityEventInfo RiskDns{ get; set; }

        /// <summary>
        /// 高危命令相关风险事件
        /// </summary>
        [JsonProperty("Bash")]
        public SecurityEventInfo Bash{ get; set; }

        /// <summary>
        /// 本地提权相关风险事件
        /// </summary>
        [JsonProperty("PrivilegeRules")]
        public SecurityEventInfo PrivilegeRules{ get; set; }

        /// <summary>
        /// 反弹Shell相关风险事件
        /// </summary>
        [JsonProperty("ReverseShell")]
        public SecurityEventInfo ReverseShell{ get; set; }

        /// <summary>
        /// 应用漏洞风险事件
        /// </summary>
        [JsonProperty("SysVul")]
        public SecurityEventInfo SysVul{ get; set; }

        /// <summary>
        /// Web应用漏洞相关风险事件
        /// </summary>
        [JsonProperty("WebVul")]
        public SecurityEventInfo WebVul{ get; set; }

        /// <summary>
        /// 应急漏洞相关风险事件
        /// </summary>
        [JsonProperty("EmergencyVul")]
        public SecurityEventInfo EmergencyVul{ get; set; }

        /// <summary>
        /// 安全基线相关风险事件
        /// </summary>
        [JsonProperty("BaseLine")]
        public SecurityEventInfo BaseLine{ get; set; }

        /// <summary>
        /// 攻击检测相关风险事件
        /// </summary>
        [JsonProperty("AttackLogs")]
        public SecurityEventInfo AttackLogs{ get; set; }

        /// <summary>
        /// 受影响机器数
        /// </summary>
        [JsonProperty("EffectMachineCount")]
        public ulong? EffectMachineCount{ get; set; }

        /// <summary>
        /// 所有事件总数
        /// </summary>
        [JsonProperty("EventsCount")]
        public ulong? EventsCount{ get; set; }

        /// <summary>
        /// window 系统漏洞事件总数
        /// </summary>
        [JsonProperty("WindowVul")]
        public SecurityEventInfo WindowVul{ get; set; }

        /// <summary>
        /// linux系统漏洞事件总数
        /// </summary>
        [JsonProperty("LinuxVul")]
        public SecurityEventInfo LinuxVul{ get; set; }

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
            this.SetParamObj(map, prefix + "Malware.", this.Malware);
            this.SetParamObj(map, prefix + "HostLogin.", this.HostLogin);
            this.SetParamObj(map, prefix + "BruteAttack.", this.BruteAttack);
            this.SetParamObj(map, prefix + "RiskDns.", this.RiskDns);
            this.SetParamObj(map, prefix + "Bash.", this.Bash);
            this.SetParamObj(map, prefix + "PrivilegeRules.", this.PrivilegeRules);
            this.SetParamObj(map, prefix + "ReverseShell.", this.ReverseShell);
            this.SetParamObj(map, prefix + "SysVul.", this.SysVul);
            this.SetParamObj(map, prefix + "WebVul.", this.WebVul);
            this.SetParamObj(map, prefix + "EmergencyVul.", this.EmergencyVul);
            this.SetParamObj(map, prefix + "BaseLine.", this.BaseLine);
            this.SetParamObj(map, prefix + "AttackLogs.", this.AttackLogs);
            this.SetParamSimple(map, prefix + "EffectMachineCount", this.EffectMachineCount);
            this.SetParamSimple(map, prefix + "EventsCount", this.EventsCount);
            this.SetParamObj(map, prefix + "WindowVul.", this.WindowVul);
            this.SetParamObj(map, prefix + "LinuxVul.", this.LinuxVul);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

