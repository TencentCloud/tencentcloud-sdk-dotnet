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

namespace TencentCloud.Partners.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubProductPriceDetail : AbstractModel
    {
        
        /// <summary>
        /// 子产品名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 折扣值，=100时表示无折扣，=85时表示8.5折
        /// </summary>
        [JsonProperty("DiscountValue")]
        public float? DiscountValue{ get; set; }

        /// <summary>
        /// 原价，折扣前价格，单位：分
        /// </summary>
        [JsonProperty("TotalCost")]
        public long? TotalCost{ get; set; }

        /// <summary>
        /// 折后价，单位：分
        /// </summary>
        [JsonProperty("RealTotalCost")]
        public long? RealTotalCost{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DiscountValue", this.DiscountValue);
            this.SetParamSimple(map, prefix + "TotalCost", this.TotalCost);
            this.SetParamSimple(map, prefix + "RealTotalCost", this.RealTotalCost);
        }
    }
}

