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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDeviceSecurityInfoData : AbstractModel
    {
        
        /// <summary>
        /// <p>防火墙状态</p><p>枚举值：</p><ul><li>0：未开启</li><li>1：已开启</li></ul>
        /// </summary>
        [JsonProperty("FirewallStatus")]
        public long? FirewallStatus{ get; set; }

        /// <summary>
        /// <p>实时防护状态</p><p>枚举值：</p><ul><li>0：未开启</li><li>1：部分开启</li><li>2：已开启</li><li>-1：未知</li></ul>
        /// </summary>
        [JsonProperty("RealTimeProtectionStatus")]
        public long? RealTimeProtectionStatus{ get; set; }

        /// <summary>
        /// <p>系统修复引擎版本</p>
        /// </summary>
        [JsonProperty("SysRepVersion")]
        public string SysRepVersion{ get; set; }

        /// <summary>
        /// <p>病毒库版本</p>
        /// </summary>
        [JsonProperty("VirusVer")]
        public string VirusVer{ get; set; }

        /// <summary>
        /// <p>漏洞库版本</p>
        /// </summary>
        [JsonProperty("VulVersion")]
        public string VulVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FirewallStatus", this.FirewallStatus);
            this.SetParamSimple(map, prefix + "RealTimeProtectionStatus", this.RealTimeProtectionStatus);
            this.SetParamSimple(map, prefix + "SysRepVersion", this.SysRepVersion);
            this.SetParamSimple(map, prefix + "VirusVer", this.VirusVer);
            this.SetParamSimple(map, prefix + "VulVersion", this.VulVersion);
        }
    }
}

