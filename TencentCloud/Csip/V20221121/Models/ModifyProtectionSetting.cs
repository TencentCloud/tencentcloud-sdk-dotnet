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

    public class ModifyProtectionSetting : AbstractModel
    {
        
        /// <summary>
        /// 资产唯一ID
        /// </summary>
        [JsonProperty("QUUID")]
        public string QUUID{ get; set; }

        /// <summary>
        /// 总开关 0关闭 1开启
        /// </summary>
        [JsonProperty("Enable")]
        public ulong? Enable{ get; set; }

        /// <summary>
        /// 漏洞防护开关 0: 关闭 1:开启
        /// </summary>
        [JsonProperty("VulDefEnable")]
        public ulong? VulDefEnable{ get; set; }

        /// <summary>
        /// 漏洞防护模式 0: 标准 1: 重保
        /// </summary>
        [JsonProperty("VulDefMode")]
        public ulong? VulDefMode{ get; set; }

        /// <summary>
        /// 漏洞防护动作 0: 仅检测 1: 检测+防御
        /// </summary>
        [JsonProperty("VulDefAction")]
        public ulong? VulDefAction{ get; set; }

        /// <summary>
        /// 内存马防御开关 0: 关闭 1:开启
        /// </summary>
        [JsonProperty("MemShellDefEnable")]
        public ulong? MemShellDefEnable{ get; set; }

        /// <summary>
        /// 性能限制开关 0: 关闭 1:开启
        /// </summary>
        [JsonProperty("PerformanceLimit")]
        public ulong? PerformanceLimit{ get; set; }

        /// <summary>
        /// CPU阈值 取值1-99
        /// </summary>
        [JsonProperty("PerformanceLimitCpu")]
        public ulong? PerformanceLimitCpu{ get; set; }

        /// <summary>
        /// 内存阈值 取值1-99
        /// </summary>
        [JsonProperty("PerformanceLimitMem")]
        public ulong? PerformanceLimitMem{ get; set; }

        /// <summary>
        /// 内存剩余阈值
        /// </summary>
        [JsonProperty("PerformanceLimitMemAmount")]
        public ulong? PerformanceLimitMemAmount{ get; set; }

        /// <summary>
        /// 更多防护, 0: 不注入会重启的进程 1: 注入会重启的进程
        /// </summary>
        [JsonProperty("SafeInject")]
        public ulong? SafeInject{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QUUID", this.QUUID);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "VulDefEnable", this.VulDefEnable);
            this.SetParamSimple(map, prefix + "VulDefMode", this.VulDefMode);
            this.SetParamSimple(map, prefix + "VulDefAction", this.VulDefAction);
            this.SetParamSimple(map, prefix + "MemShellDefEnable", this.MemShellDefEnable);
            this.SetParamSimple(map, prefix + "PerformanceLimit", this.PerformanceLimit);
            this.SetParamSimple(map, prefix + "PerformanceLimitCpu", this.PerformanceLimitCpu);
            this.SetParamSimple(map, prefix + "PerformanceLimitMem", this.PerformanceLimitMem);
            this.SetParamSimple(map, prefix + "PerformanceLimitMemAmount", this.PerformanceLimitMemAmount);
            this.SetParamSimple(map, prefix + "SafeInject", this.SafeInject);
        }
    }
}

