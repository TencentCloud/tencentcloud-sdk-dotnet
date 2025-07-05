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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IpField : AbstractModel
    {
        
        /// <summary>
        /// 国家字段信息
        /// </summary>
        [JsonProperty("Country")]
        public bool? Country{ get; set; }

        /// <summary>
        /// 省、州、郡一级行政区域字段信息
        /// </summary>
        [JsonProperty("Province")]
        public bool? Province{ get; set; }

        /// <summary>
        /// 市一级行政区域字段信息
        /// </summary>
        [JsonProperty("City")]
        public bool? City{ get; set; }

        /// <summary>
        /// 市内区域字段信息
        /// </summary>
        [JsonProperty("Region")]
        public bool? Region{ get; set; }

        /// <summary>
        /// 接入运营商字段信息
        /// </summary>
        [JsonProperty("Isp")]
        public bool? Isp{ get; set; }

        /// <summary>
        /// 骨干运营商字段信息
        /// </summary>
        [JsonProperty("AsName")]
        public bool? AsName{ get; set; }

        /// <summary>
        /// 骨干As号
        /// </summary>
        [JsonProperty("AsId")]
        public bool? AsId{ get; set; }

        /// <summary>
        /// 注释字段
        /// </summary>
        [JsonProperty("Comment")]
        public bool? Comment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Isp", this.Isp);
            this.SetParamSimple(map, prefix + "AsName", this.AsName);
            this.SetParamSimple(map, prefix + "AsId", this.AsId);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
        }
    }
}

