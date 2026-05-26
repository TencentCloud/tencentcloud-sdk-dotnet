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

    public class FlavorKingCycleBrandProvinceScanAnalysisResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>口味王全国份额</p>
        /// </summary>
        [JsonProperty("MarketShare")]
        public float? MarketShare{ get; set; }

        /// <summary>
        /// <p>上周期口味王市场份额</p>
        /// </summary>
        [JsonProperty("LastCycleMarketShare")]
        public float? LastCycleMarketShare{ get; set; }

        /// <summary>
        /// <p>口味王全国周环比</p>
        /// </summary>
        [JsonProperty("Provinces")]
        public FlavorKingCycleBrandProvinceScanAnalysisDataItem[] Provinces{ get; set; }

        /// <summary>
        /// <p>口味王环比</p>
        /// </summary>
        [JsonProperty("GrowRatio")]
        public float? GrowRatio{ get; set; }

        /// <summary>
        /// <p>其他品牌环比</p>
        /// </summary>
        [JsonProperty("OtherGrowRatio")]
        public float? OtherGrowRatio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MarketShare", this.MarketShare);
            this.SetParamSimple(map, prefix + "LastCycleMarketShare", this.LastCycleMarketShare);
            this.SetParamArrayObj(map, prefix + "Provinces.", this.Provinces);
            this.SetParamSimple(map, prefix + "GrowRatio", this.GrowRatio);
            this.SetParamSimple(map, prefix + "OtherGrowRatio", this.OtherGrowRatio);
        }
    }
}

