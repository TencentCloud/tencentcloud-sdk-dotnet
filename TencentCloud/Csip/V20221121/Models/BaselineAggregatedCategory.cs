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

    public class BaselineAggregatedCategory : AbstractModel
    {
        
        /// <summary>
        /// <p>基线子分类基础信息（含分类 ID、名称、描述）。</p>
        /// </summary>
        [JsonProperty("Category")]
        public BaselineCategory Category{ get; set; }

        /// <summary>
        /// <p>该子分类下未通过检测项按风险等级的分布统计。</p>
        /// </summary>
        [JsonProperty("NotPassItemRiskLevelStatistic")]
        public BaselineRiskLevelStatistic[] NotPassItemRiskLevelStatistic{ get; set; }

        /// <summary>
        /// <p>该子分类下结果为 PASS 的检测项数量。</p>
        /// </summary>
        [JsonProperty("PassItemCount")]
        public ulong? PassItemCount{ get; set; }

        /// <summary>
        /// <p>该子分类下结果为 NOT_PASS 的检测项数量。</p>
        /// </summary>
        [JsonProperty("NotPassItemCount")]
        public ulong? NotPassItemCount{ get; set; }

        /// <summary>
        /// <p>该子分类下检测项通过率，单位为百分比（0~100），保留两位小数。</p>
        /// </summary>
        [JsonProperty("PassRate")]
        public float? PassRate{ get; set; }

        /// <summary>
        /// <p>该基线类别是否被扫描过</p>
        /// </summary>
        [JsonProperty("Scanned")]
        public bool? Scanned{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Category.", this.Category);
            this.SetParamArrayObj(map, prefix + "NotPassItemRiskLevelStatistic.", this.NotPassItemRiskLevelStatistic);
            this.SetParamSimple(map, prefix + "PassItemCount", this.PassItemCount);
            this.SetParamSimple(map, prefix + "NotPassItemCount", this.NotPassItemCount);
            this.SetParamSimple(map, prefix + "PassRate", this.PassRate);
            this.SetParamSimple(map, prefix + "Scanned", this.Scanned);
        }
    }
}

