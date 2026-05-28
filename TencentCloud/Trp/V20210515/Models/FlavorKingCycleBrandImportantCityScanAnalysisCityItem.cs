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

namespace TencentCloud.Trp.V20210515.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlavorKingCycleBrandImportantCityScanAnalysisCityItem : AbstractModel
    {
        
        /// <summary>
        /// <p>口味王分布</p>
        /// </summary>
        [JsonProperty("Ratio")]
        public float? Ratio{ get; set; }

        /// <summary>
        /// <p>口味王市场份额</p>
        /// </summary>
        [JsonProperty("MarketShare")]
        public float? MarketShare{ get; set; }

        /// <summary>
        /// <p>其他品牌市场份额</p>
        /// </summary>
        [JsonProperty("OtherMarketShare")]
        public float? OtherMarketShare{ get; set; }

        /// <summary>
        /// <p>上周期口味王分布</p>
        /// </summary>
        [JsonProperty("LastCycleRatio")]
        public float? LastCycleRatio{ get; set; }

        /// <summary>
        /// <p>上周期口味王品牌市场份额</p>
        /// </summary>
        [JsonProperty("LastCycleMarketShare")]
        public float? LastCycleMarketShare{ get; set; }

        /// <summary>
        /// <p>上周期其他品牌市场份额</p>
        /// </summary>
        [JsonProperty("LastCycleOtherMarketShare")]
        public float? LastCycleOtherMarketShare{ get; set; }

        /// <summary>
        /// <p>口味王增长率</p>
        /// </summary>
        [JsonProperty("GrowRatio")]
        public float? GrowRatio{ get; set; }

        /// <summary>
        /// <p>其他品牌增长率</p>
        /// </summary>
        [JsonProperty("OtherGrowRatio")]
        public float? OtherGrowRatio{ get; set; }

        /// <summary>
        /// <p>下属城市明细</p>
        /// </summary>
        [JsonProperty("Regions")]
        public FlavorKingCycleBrandImportantCityScanAnalysisRegionItem[] Regions{ get; set; }

        /// <summary>
        /// <p>城市</p>
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ratio", this.Ratio);
            this.SetParamSimple(map, prefix + "MarketShare", this.MarketShare);
            this.SetParamSimple(map, prefix + "OtherMarketShare", this.OtherMarketShare);
            this.SetParamSimple(map, prefix + "LastCycleRatio", this.LastCycleRatio);
            this.SetParamSimple(map, prefix + "LastCycleMarketShare", this.LastCycleMarketShare);
            this.SetParamSimple(map, prefix + "LastCycleOtherMarketShare", this.LastCycleOtherMarketShare);
            this.SetParamSimple(map, prefix + "GrowRatio", this.GrowRatio);
            this.SetParamSimple(map, prefix + "OtherGrowRatio", this.OtherGrowRatio);
            this.SetParamArrayObj(map, prefix + "Regions.", this.Regions);
            this.SetParamSimple(map, prefix + "City", this.City);
        }
    }
}

