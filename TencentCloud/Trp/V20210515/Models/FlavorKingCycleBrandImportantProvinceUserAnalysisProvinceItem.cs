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

    public class FlavorKingCycleBrandImportantProvinceUserAnalysisProvinceItem : AbstractModel
    {
        
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
        [JsonProperty("Cities")]
        public FlavorKingCycleBrandImportantProvinceUserAnalysisCityItem[] Cities{ get; set; }

        /// <summary>
        /// <p>省份</p>
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MarketShare", this.MarketShare);
            this.SetParamSimple(map, prefix + "OtherMarketShare", this.OtherMarketShare);
            this.SetParamSimple(map, prefix + "GrowRatio", this.GrowRatio);
            this.SetParamSimple(map, prefix + "OtherGrowRatio", this.OtherGrowRatio);
            this.SetParamArrayObj(map, prefix + "Cities.", this.Cities);
            this.SetParamSimple(map, prefix + "Province", this.Province);
        }
    }
}

