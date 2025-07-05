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

    public class ScreenRegionMachines : AbstractModel
    {
        
        /// <summary>
        /// 所有区域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 区域中文描述
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// 主机列表
        /// </summary>
        [JsonProperty("Machines")]
        public ScreenMachine[] Machines{ get; set; }

        /// <summary>
        /// 此区域的主机总数
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

        /// <summary>
        /// 风险主机数量
        /// </summary>
        [JsonProperty("RiskCnt")]
        public ulong? RiskCnt{ get; set; }

        /// <summary>
        /// 潜在风险主机数
        /// </summary>
        [JsonProperty("AttackCnt")]
        public ulong? AttackCnt{ get; set; }

        /// <summary>
        /// 无风险主机数
        /// </summary>
        [JsonProperty("SafetyCnt")]
        public ulong? SafetyCnt{ get; set; }

        /// <summary>
        /// 离线/未安装主机数
        /// </summary>
        [JsonProperty("UnAgentOfflineCnt")]
        public ulong? UnAgentOfflineCnt{ get; set; }

        /// <summary>
        /// 省略展示多少主机，等于0时没有省略展示
        /// </summary>
        [JsonProperty("IgnoreCnt")]
        public ulong? IgnoreCnt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamArrayObj(map, prefix + "Machines.", this.Machines);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "RiskCnt", this.RiskCnt);
            this.SetParamSimple(map, prefix + "AttackCnt", this.AttackCnt);
            this.SetParamSimple(map, prefix + "SafetyCnt", this.SafetyCnt);
            this.SetParamSimple(map, prefix + "UnAgentOfflineCnt", this.UnAgentOfflineCnt);
            this.SetParamSimple(map, prefix + "IgnoreCnt", this.IgnoreCnt);
        }
    }
}

