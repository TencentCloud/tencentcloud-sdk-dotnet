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

namespace TencentCloud.Aca.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IndicationsDrug : AbstractModel
    {
        
        /// <summary>
        /// 药品名称
        /// </summary>
        [JsonProperty("DrugName")]
        public string DrugName{ get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [JsonProperty("Specifications")]
        public string Specifications{ get; set; }

        /// <summary>
        /// 批准文号
        /// </summary>
        [JsonProperty("ApprovalNumber")]
        public string ApprovalNumber{ get; set; }

        /// <summary>
        /// 生产厂家
        /// </summary>
        [JsonProperty("Manufacturer")]
        public string Manufacturer{ get; set; }

        /// <summary>
        /// 药品ID
        /// </summary>
        [JsonProperty("DrugId")]
        public string DrugId{ get; set; }

        /// <summary>
        /// 商品名
        /// </summary>
        [JsonProperty("TradeName")]
        public string TradeName{ get; set; }

        /// <summary>
        /// 类型 默认0 0-西药 2-中药
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DrugName", this.DrugName);
            this.SetParamSimple(map, prefix + "Specifications", this.Specifications);
            this.SetParamSimple(map, prefix + "ApprovalNumber", this.ApprovalNumber);
            this.SetParamSimple(map, prefix + "Manufacturer", this.Manufacturer);
            this.SetParamSimple(map, prefix + "DrugId", this.DrugId);
            this.SetParamSimple(map, prefix + "TradeName", this.TradeName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

