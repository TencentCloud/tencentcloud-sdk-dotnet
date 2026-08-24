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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CopyPairPrice : AbstractModel
    {
        
        /// <summary>
        /// 后付费每小时原价，单位：元
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnitPrice")]
        public float? UnitPrice{ get; set; }

        /// <summary>
        /// 高精度后付费每小时原价，单位：元（字符串形式，避免精度丢失）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnitPriceHigh")]
        public string UnitPriceHigh{ get; set; }

        /// <summary>
        /// 后付费每小时折扣价，单位：元
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnitPriceDiscount")]
        public float? UnitPriceDiscount{ get; set; }

        /// <summary>
        /// 高精度后付费每小时折扣价，单位：元（字符串形式，避免精度丢失）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnitPriceDiscountHigh")]
        public string UnitPriceDiscountHigh{ get; set; }

        /// <summary>
        /// 折扣，100 表示无折扣，80 表示 8 折
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Discount")]
        public long? Discount{ get; set; }

        /// <summary>
        /// 计价单元，固定为 HOUR（按小时计费）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChargeUnit")]
        public string ChargeUnit{ get; set; }

        /// <summary>
        /// 计费项目明细列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetailPrices")]
        public CopyPairPriceDetail[] DetailPrices{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UnitPrice", this.UnitPrice);
            this.SetParamSimple(map, prefix + "UnitPriceHigh", this.UnitPriceHigh);
            this.SetParamSimple(map, prefix + "UnitPriceDiscount", this.UnitPriceDiscount);
            this.SetParamSimple(map, prefix + "UnitPriceDiscountHigh", this.UnitPriceDiscountHigh);
            this.SetParamSimple(map, prefix + "Discount", this.Discount);
            this.SetParamSimple(map, prefix + "ChargeUnit", this.ChargeUnit);
            this.SetParamArrayObj(map, prefix + "DetailPrices.", this.DetailPrices);
        }
    }
}

