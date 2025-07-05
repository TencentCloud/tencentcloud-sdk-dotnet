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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Medicine : AbstractModel
    {
        
        /// <summary>
        /// 药品名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 商品名
        /// </summary>
        [JsonProperty("TradeName")]
        public string TradeName{ get; set; }

        /// <summary>
        /// 厂商
        /// </summary>
        [JsonProperty("Firm")]
        public string Firm{ get; set; }

        /// <summary>
        /// 医保类型
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [JsonProperty("Specification")]
        public string Specification{ get; set; }

        /// <summary>
        /// 最小包装数量
        /// </summary>
        [JsonProperty("MinQuantity")]
        public string MinQuantity{ get; set; }

        /// <summary>
        /// 最小制剂单位
        /// </summary>
        [JsonProperty("DosageUnit")]
        public string DosageUnit{ get; set; }

        /// <summary>
        /// 最小包装单位
        /// </summary>
        [JsonProperty("PackingUnit")]
        public string PackingUnit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TradeName", this.TradeName);
            this.SetParamSimple(map, prefix + "Firm", this.Firm);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "Specification", this.Specification);
            this.SetParamSimple(map, prefix + "MinQuantity", this.MinQuantity);
            this.SetParamSimple(map, prefix + "DosageUnit", this.DosageUnit);
            this.SetParamSimple(map, prefix + "PackingUnit", this.PackingUnit);
        }
    }
}

