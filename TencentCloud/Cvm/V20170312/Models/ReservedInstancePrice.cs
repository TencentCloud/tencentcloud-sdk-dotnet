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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReservedInstancePrice : AbstractModel
    {
        
        /// <summary>
        /// 预支合计费用的原价，单位：元。
        /// </summary>
        [JsonProperty("OriginalFixedPrice")]
        public float? OriginalFixedPrice{ get; set; }

        /// <summary>
        /// 预支合计费用的折扣价，单位：元。
        /// </summary>
        [JsonProperty("DiscountFixedPrice")]
        public float? DiscountFixedPrice{ get; set; }

        /// <summary>
        /// 后续合计费用的原价，单位：元/小时
        /// </summary>
        [JsonProperty("OriginalUsagePrice")]
        public float? OriginalUsagePrice{ get; set; }

        /// <summary>
        /// 后续合计费用的折扣价，单位：元/小时
        /// </summary>
        [JsonProperty("DiscountUsagePrice")]
        public float? DiscountUsagePrice{ get; set; }

        /// <summary>
        /// 预支费用的折扣，如20.0代表2折。 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FixedPriceDiscount")]
        public float? FixedPriceDiscount{ get; set; }

        /// <summary>
        /// 后续费用的折扣，如20.0代表2折。 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsagePriceDiscount")]
        public float? UsagePriceDiscount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OriginalFixedPrice", this.OriginalFixedPrice);
            this.SetParamSimple(map, prefix + "DiscountFixedPrice", this.DiscountFixedPrice);
            this.SetParamSimple(map, prefix + "OriginalUsagePrice", this.OriginalUsagePrice);
            this.SetParamSimple(map, prefix + "DiscountUsagePrice", this.DiscountUsagePrice);
            this.SetParamSimple(map, prefix + "FixedPriceDiscount", this.FixedPriceDiscount);
            this.SetParamSimple(map, prefix + "UsagePriceDiscount", this.UsagePriceDiscount);
        }
    }
}

