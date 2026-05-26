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

    public class FlavorKingCycleBrandProvinceCityScanAnalysisCityItem : AbstractModel
    {
        
        /// <summary>
        /// <p>口味王分布</p>
        /// </summary>
        [JsonProperty("Ratio")]
        public float?[] Ratio{ get; set; }

        /// <summary>
        /// <p>分区域数据</p>
        /// </summary>
        [JsonProperty("Regions")]
        public FlavorKingCycleBrandProvinceCityScanAnalysisRegionItem[] Regions{ get; set; }

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
            this.SetParamArraySimple(map, prefix + "Ratio.", this.Ratio);
            this.SetParamArrayObj(map, prefix + "Regions.", this.Regions);
            this.SetParamSimple(map, prefix + "City", this.City);
        }
    }
}

