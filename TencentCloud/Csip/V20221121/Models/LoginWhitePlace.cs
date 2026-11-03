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

    public class LoginWhitePlace : AbstractModel
    {
        
        /// <summary>
        /// <p>国家ID</p>
        /// </summary>
        [JsonProperty("CountryId")]
        public long? CountryId{ get; set; }

        /// <summary>
        /// <p>省份ID；99999 表示全部省份</p>
        /// </summary>
        [JsonProperty("ProvinceId")]
        public long? ProvinceId{ get; set; }

        /// <summary>
        /// <p>城市ID；99999 表示全部城市</p>
        /// </summary>
        [JsonProperty("CityId")]
        public long? CityId{ get; set; }

        /// <summary>
        /// <p>地点展示文案，服务端按 Language 生成，如 中国-广东-深圳</p>
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CountryId", this.CountryId);
            this.SetParamSimple(map, prefix + "ProvinceId", this.ProvinceId);
            this.SetParamSimple(map, prefix + "CityId", this.CityId);
            this.SetParamSimple(map, prefix + "Location", this.Location);
        }
    }
}

