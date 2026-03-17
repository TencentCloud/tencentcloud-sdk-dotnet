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

    public class RaspEventOverview : AbstractModel
    {
        
        /// <summary>
        /// 可防御漏洞数
        /// </summary>
        [JsonProperty("DefenceVuls")]
        public long? DefenceVuls{ get; set; }

        /// <summary>
        /// 可精准防御漏洞数
        /// </summary>
        [JsonProperty("PreciseDefenseVuls")]
        public long? PreciseDefenseVuls{ get; set; }

        /// <summary>
        /// 未处理的应用防御事件数
        /// </summary>
        [JsonProperty("UnhandledRaspEvents")]
        public long? UnhandledRaspEvents{ get; set; }

        /// <summary>
        /// 未处理的内存马扫描事件数
        /// </summary>
        [JsonProperty("UnhandledMemShellScanEvents")]
        public long? UnhandledMemShellScanEvents{ get; set; }

        /// <summary>
        /// 未处理的内存马注入事件数
        /// </summary>
        [JsonProperty("UnhandledMemShellInjectEvents")]
        public long? UnhandledMemShellInjectEvents{ get; set; }

        /// <summary>
        /// 每日未处理事件趋势
        /// </summary>
        [JsonProperty("UnHandledEvents")]
        public long?[] UnHandledEvents{ get; set; }

        /// <summary>
        /// 每日漏洞检测事件趋势
        /// </summary>
        [JsonProperty("RaspAttackCounts")]
        public long?[] RaspAttackCounts{ get; set; }

        /// <summary>
        /// 每日漏洞防御事件趋势
        /// </summary>
        [JsonProperty("RaspDefendCounts")]
        public long?[] RaspDefendCounts{ get; set; }

        /// <summary>
        /// 每日内存马检测事件趋势
        /// </summary>
        [JsonProperty("MemShellAttackCounts")]
        public long?[] MemShellAttackCounts{ get; set; }

        /// <summary>
        /// 每日内存马防御事件趋势
        /// </summary>
        [JsonProperty("MemShellDefendCounts")]
        public long?[] MemShellDefendCounts{ get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [JsonProperty("Date")]
        public string[] Date{ get; set; }

        /// <summary>
        /// 开通RASP防护开关资产数
        /// </summary>
        [JsonProperty("ProtectAssetOpenCount")]
        public ulong? ProtectAssetOpenCount{ get; set; }

        /// <summary>
        /// 全部资产数
        /// </summary>
        [JsonProperty("ProtectAssetCount")]
        public ulong? ProtectAssetCount{ get; set; }

        /// <summary>
        /// 绑定了旗舰版的资产防护数
        /// </summary>
        [JsonProperty("UltimateAssetCount")]
        public ulong? UltimateAssetCount{ get; set; }

        /// <summary>
        /// 绑定了重保防护包的资产数
        /// </summary>
        [JsonProperty("RaspAssetCount")]
        public ulong? RaspAssetCount{ get; set; }

        /// <summary>
        /// 未授权的资产数
        /// </summary>
        [JsonProperty("NotProtectAssetCount")]
        public ulong? NotProtectAssetCount{ get; set; }

        /// <summary>
        /// 近7天未处理事件数
        /// </summary>
        [JsonProperty("RecentUnhandledEvents")]
        public long? RecentUnhandledEvents{ get; set; }

        /// <summary>
        /// 防御成功的总次数
        /// </summary>
        [JsonProperty("RaspDefendCount")]
        public long? RaspDefendCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DefenceVuls", this.DefenceVuls);
            this.SetParamSimple(map, prefix + "PreciseDefenseVuls", this.PreciseDefenseVuls);
            this.SetParamSimple(map, prefix + "UnhandledRaspEvents", this.UnhandledRaspEvents);
            this.SetParamSimple(map, prefix + "UnhandledMemShellScanEvents", this.UnhandledMemShellScanEvents);
            this.SetParamSimple(map, prefix + "UnhandledMemShellInjectEvents", this.UnhandledMemShellInjectEvents);
            this.SetParamArraySimple(map, prefix + "UnHandledEvents.", this.UnHandledEvents);
            this.SetParamArraySimple(map, prefix + "RaspAttackCounts.", this.RaspAttackCounts);
            this.SetParamArraySimple(map, prefix + "RaspDefendCounts.", this.RaspDefendCounts);
            this.SetParamArraySimple(map, prefix + "MemShellAttackCounts.", this.MemShellAttackCounts);
            this.SetParamArraySimple(map, prefix + "MemShellDefendCounts.", this.MemShellDefendCounts);
            this.SetParamArraySimple(map, prefix + "Date.", this.Date);
            this.SetParamSimple(map, prefix + "ProtectAssetOpenCount", this.ProtectAssetOpenCount);
            this.SetParamSimple(map, prefix + "ProtectAssetCount", this.ProtectAssetCount);
            this.SetParamSimple(map, prefix + "UltimateAssetCount", this.UltimateAssetCount);
            this.SetParamSimple(map, prefix + "RaspAssetCount", this.RaspAssetCount);
            this.SetParamSimple(map, prefix + "NotProtectAssetCount", this.NotProtectAssetCount);
            this.SetParamSimple(map, prefix + "RecentUnhandledEvents", this.RecentUnhandledEvents);
            this.SetParamSimple(map, prefix + "RaspDefendCount", this.RaspDefendCount);
        }
    }
}

