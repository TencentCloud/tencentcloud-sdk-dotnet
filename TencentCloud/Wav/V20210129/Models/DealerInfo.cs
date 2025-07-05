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

namespace TencentCloud.Wav.V20210129.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DealerInfo : AbstractModel
    {
        
        /// <summary>
        /// 企微SaaS平台经销商id
        /// </summary>
        [JsonProperty("DealerId")]
        public ulong? DealerId{ get; set; }

        /// <summary>
        /// 经销商名称
        /// </summary>
        [JsonProperty("DealerName")]
        public string DealerName{ get; set; }

        /// <summary>
        /// 所属省份编号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProvinceCode")]
        public string ProvinceCode{ get; set; }

        /// <summary>
        /// 所属城市编号列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CityCodeList")]
        public string[] CityCodeList{ get; set; }

        /// <summary>
        /// 业务覆盖品牌id列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BrandIdList")]
        public string[] BrandIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DealerId", this.DealerId);
            this.SetParamSimple(map, prefix + "DealerName", this.DealerName);
            this.SetParamSimple(map, prefix + "ProvinceCode", this.ProvinceCode);
            this.SetParamArraySimple(map, prefix + "CityCodeList.", this.CityCodeList);
            this.SetParamArraySimple(map, prefix + "BrandIdList.", this.BrandIdList);
        }
    }
}

