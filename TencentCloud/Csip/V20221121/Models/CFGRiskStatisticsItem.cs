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

    public class CFGRiskStatisticsItem : AbstractModel
    {
        
        /// <summary>
        /// <p>风险总数</p>
        /// </summary>
        [JsonProperty("TotalRiskCount")]
        public ulong? TotalRiskCount{ get; set; }

        /// <summary>
        /// <p>近7天新增风险数量</p>
        /// </summary>
        [JsonProperty("RiskAddCount")]
        public ulong? RiskAddCount{ get; set; }

        /// <summary>
        /// <p>全部云资源配置风险的待修复项</p>
        /// </summary>
        [JsonProperty("CheckViewCount")]
        public ulong? CheckViewCount{ get; set; }

        /// <summary>
        /// <p>高优待修复风险</p>
        /// </summary>
        [JsonProperty("HighPriorityRiskCount")]
        public ulong? HighPriorityRiskCount{ get; set; }

        /// <summary>
        /// <p>近7天新增的待修复项</p>
        /// </summary>
        [JsonProperty("CheckViewAddCount")]
        public ulong? CheckViewAddCount{ get; set; }

        /// <summary>
        /// <p>全部云资源配置风险的待修复项，高优待修复</p>
        /// </summary>
        [JsonProperty("HighPriorityCheckViewCount")]
        public ulong? HighPriorityCheckViewCount{ get; set; }

        /// <summary>
        /// <p>资产视角下的展示条数</p>
        /// </summary>
        [JsonProperty("AssetViewCount")]
        public ulong? AssetViewCount{ get; set; }

        /// <summary>
        /// <p>近7天新增的待修复资产条数</p>
        /// </summary>
        [JsonProperty("AssetViewAddCount")]
        public ulong? AssetViewAddCount{ get; set; }

        /// <summary>
        /// <p>资产视角下的展示条数，高优待修复量</p>
        /// </summary>
        [JsonProperty("HighPriorityAssetViewCount")]
        public ulong? HighPriorityAssetViewCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalRiskCount", this.TotalRiskCount);
            this.SetParamSimple(map, prefix + "RiskAddCount", this.RiskAddCount);
            this.SetParamSimple(map, prefix + "CheckViewCount", this.CheckViewCount);
            this.SetParamSimple(map, prefix + "HighPriorityRiskCount", this.HighPriorityRiskCount);
            this.SetParamSimple(map, prefix + "CheckViewAddCount", this.CheckViewAddCount);
            this.SetParamSimple(map, prefix + "HighPriorityCheckViewCount", this.HighPriorityCheckViewCount);
            this.SetParamSimple(map, prefix + "AssetViewCount", this.AssetViewCount);
            this.SetParamSimple(map, prefix + "AssetViewAddCount", this.AssetViewAddCount);
            this.SetParamSimple(map, prefix + "HighPriorityAssetViewCount", this.HighPriorityAssetViewCount);
        }
    }
}

