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

namespace TencentCloud.Wav.V20210129.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VehicleInfo : AbstractModel
    {
        
        /// <summary>
        /// 品牌id
        /// </summary>
        [JsonProperty("BrandId")]
        public ulong? BrandId{ get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [JsonProperty("BrandName")]
        public string BrandName{ get; set; }

        /// <summary>
        /// 车系id
        /// </summary>
        [JsonProperty("SeriesId")]
        public ulong? SeriesId{ get; set; }

        /// <summary>
        /// 车系名称
        /// </summary>
        [JsonProperty("SeriesName")]
        public string SeriesName{ get; set; }

        /// <summary>
        /// 车型id
        /// </summary>
        [JsonProperty("ModelId")]
        public ulong? ModelId{ get; set; }

        /// <summary>
        /// 车型名称
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BrandId", this.BrandId);
            this.SetParamSimple(map, prefix + "BrandName", this.BrandName);
            this.SetParamSimple(map, prefix + "SeriesId", this.SeriesId);
            this.SetParamSimple(map, prefix + "SeriesName", this.SeriesName);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
        }
    }
}

