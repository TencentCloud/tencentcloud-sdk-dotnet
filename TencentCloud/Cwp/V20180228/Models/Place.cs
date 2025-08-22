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

    public class Place : AbstractModel
    {
        
        /// <summary>
        /// 城市 ID。
        /// </summary>
        [JsonProperty("CityId")]
        public ulong? CityId{ get; set; }

        /// <summary>
        /// 省份 ID。
        /// </summary>
        [JsonProperty("ProvinceId")]
        public ulong? ProvinceId{ get; set; }

        /// <summary>
        /// 国家ID，暂只支持境内：1。
        /// </summary>
        [JsonProperty("CountryId")]
        public ulong? CountryId{ get; set; }

        /// <summary>
        /// 位置名称
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CityId", this.CityId);
            this.SetParamSimple(map, prefix + "ProvinceId", this.ProvinceId);
            this.SetParamSimple(map, prefix + "CountryId", this.CountryId);
            this.SetParamSimple(map, prefix + "Location", this.Location);
        }
    }
}

