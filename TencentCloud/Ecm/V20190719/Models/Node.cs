/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Node : AbstractModel
    {
        
        /// <summary>
        /// zone信息。
        /// </summary>
        [JsonProperty("ZoneInfo")]
        public ZoneInfo ZoneInfo{ get; set; }

        /// <summary>
        /// 国家信息。
        /// </summary>
        [JsonProperty("Country")]
        public Country Country{ get; set; }

        /// <summary>
        /// 区域信息。
        /// </summary>
        [JsonProperty("Area")]
        public Area Area{ get; set; }

        /// <summary>
        /// 省份信息。
        /// </summary>
        [JsonProperty("Province")]
        public Province Province{ get; set; }

        /// <summary>
        /// 城市信息。
        /// </summary>
        [JsonProperty("City")]
        public City City{ get; set; }

        /// <summary>
        /// Region信息。
        /// </summary>
        [JsonProperty("RegionInfo")]
        public RegionInfo RegionInfo{ get; set; }

        /// <summary>
        /// 运营商列表。
        /// </summary>
        [JsonProperty("ISPSet")]
        public ISP[] ISPSet{ get; set; }

        /// <summary>
        /// 运营商数量。
        /// </summary>
        [JsonProperty("ISPNum")]
        public long? ISPNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ZoneInfo.", this.ZoneInfo);
            this.SetParamObj(map, prefix + "Country.", this.Country);
            this.SetParamObj(map, prefix + "Area.", this.Area);
            this.SetParamObj(map, prefix + "Province.", this.Province);
            this.SetParamObj(map, prefix + "City.", this.City);
            this.SetParamObj(map, prefix + "RegionInfo.", this.RegionInfo);
            this.SetParamArrayObj(map, prefix + "ISPSet.", this.ISPSet);
            this.SetParamSimple(map, prefix + "ISPNum", this.ISPNum);
        }
    }
}

