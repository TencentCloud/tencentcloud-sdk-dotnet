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

    public class DescribeSecurityTrendsResponse : AbstractModel
    {
        
        /// <summary>
        /// 木马事件统计数据数组。
        /// </summary>
        [JsonProperty("Malwares")]
        public SecurityTrend[] Malwares{ get; set; }

        /// <summary>
        /// 异地登录事件统计数据数组。
        /// </summary>
        [JsonProperty("NonLocalLoginPlaces")]
        public SecurityTrend[] NonLocalLoginPlaces{ get; set; }

        /// <summary>
        /// 密码破解事件统计数据数组。
        /// </summary>
        [JsonProperty("BruteAttacks")]
        public SecurityTrend[] BruteAttacks{ get; set; }

        /// <summary>
        /// 漏洞统计数据数组。
        /// </summary>
        [JsonProperty("Vuls")]
        public SecurityTrend[] Vuls{ get; set; }

        /// <summary>
        /// 基线统计数据数组。
        /// </summary>
        [JsonProperty("BaseLines")]
        public SecurityTrend[] BaseLines{ get; set; }

        /// <summary>
        /// 恶意请求统计数据数组。
        /// </summary>
        [JsonProperty("MaliciousRequests")]
        public SecurityTrend[] MaliciousRequests{ get; set; }

        /// <summary>
        /// 高危命令统计数据数组。
        /// </summary>
        [JsonProperty("HighRiskBashs")]
        public SecurityTrend[] HighRiskBashs{ get; set; }

        /// <summary>
        /// 反弹shell统计数据数组。
        /// </summary>
        [JsonProperty("ReverseShells")]
        public SecurityTrend[] ReverseShells{ get; set; }

        /// <summary>
        /// 本地提权统计数据数组。
        /// </summary>
        [JsonProperty("PrivilegeEscalations")]
        public SecurityTrend[] PrivilegeEscalations{ get; set; }

        /// <summary>
        /// 网络攻击统计数据数组。
        /// </summary>
        [JsonProperty("CyberAttacks")]
        public SecurityTrend[] CyberAttacks{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "Malwares.", this.Malwares);
            this.SetParamArrayObj(map, prefix + "NonLocalLoginPlaces.", this.NonLocalLoginPlaces);
            this.SetParamArrayObj(map, prefix + "BruteAttacks.", this.BruteAttacks);
            this.SetParamArrayObj(map, prefix + "Vuls.", this.Vuls);
            this.SetParamArrayObj(map, prefix + "BaseLines.", this.BaseLines);
            this.SetParamArrayObj(map, prefix + "MaliciousRequests.", this.MaliciousRequests);
            this.SetParamArrayObj(map, prefix + "HighRiskBashs.", this.HighRiskBashs);
            this.SetParamArrayObj(map, prefix + "ReverseShells.", this.ReverseShells);
            this.SetParamArrayObj(map, prefix + "PrivilegeEscalations.", this.PrivilegeEscalations);
            this.SetParamArrayObj(map, prefix + "CyberAttacks.", this.CyberAttacks);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

