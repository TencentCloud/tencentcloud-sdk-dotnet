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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ItemPrice : AbstractModel
    {
        
        /// <summary>
        /// 后续合计费用的原价，后付费模式使用，单位：元。<br><li>如返回了其他时间区间项，如UnitPriceSecondStep，则本项代表时间区间在(0, 96)小时；若未返回其他时间区间项，则本项代表全时段，即(0, ∞)小时</li>
        /// </summary>
        [JsonProperty("UnitPrice")]
        public float? UnitPrice{ get; set; }

        /// <summary>
        /// 后续计价单元，后付费模式使用，可取值范围： <br><li>HOUR：表示计价单元是按每小时来计算。当前涉及该计价单元的场景有：实例按小时后付费（POSTPAID_BY_HOUR）、带宽按小时后付费（BANDWIDTH_POSTPAID_BY_HOUR）：</li><li>GB：表示计价单元是按每GB来计算。当前涉及该计价单元的场景有：流量按小时后付费（TRAFFIC_POSTPAID_BY_HOUR）。</li>
        /// </summary>
        [JsonProperty("ChargeUnit")]
        public string ChargeUnit{ get; set; }

        /// <summary>
        /// 预支合计费用的原价，预付费模式使用，单位：元。
        /// </summary>
        [JsonProperty("OriginalPrice")]
        public float? OriginalPrice{ get; set; }

        /// <summary>
        /// 预支合计费用的折扣价，预付费模式使用，单位：元。
        /// </summary>
        [JsonProperty("DiscountPrice")]
        public float? DiscountPrice{ get; set; }

        /// <summary>
        /// 折扣，如20.0代表2折。
        /// </summary>
        [JsonProperty("Discount")]
        public float? Discount{ get; set; }

        /// <summary>
        /// 后续合计费用的折扣价，后付费模式使用，单位：元<br><li>如返回了其他时间区间项，如UnitPriceDiscountSecondStep，则本项代表时间区间在(0, 96)小时；若未返回其他时间区间项，则本项代表全时段，即(0, ∞)小时</li>
        /// </summary>
        [JsonProperty("UnitPriceDiscount")]
        public float? UnitPriceDiscount{ get; set; }

        /// <summary>
        /// 使用时间区间在(96, 360)小时的后续合计费用的原价，后付费模式使用，单位：元。
        /// </summary>
        [JsonProperty("UnitPriceSecondStep")]
        public float? UnitPriceSecondStep{ get; set; }

        /// <summary>
        /// 使用时间区间在(96, 360)小时的后续合计费用的折扣价，后付费模式使用，单位：元
        /// </summary>
        [JsonProperty("UnitPriceDiscountSecondStep")]
        public float? UnitPriceDiscountSecondStep{ get; set; }

        /// <summary>
        /// 使用时间区间在(360, ∞)小时的后续合计费用的原价，后付费模式使用，单位：元。
        /// </summary>
        [JsonProperty("UnitPriceThirdStep")]
        public float? UnitPriceThirdStep{ get; set; }

        /// <summary>
        /// 使用时间区间在(360, ∞)小时的后续合计费用的折扣价，后付费模式使用，单位：元
        /// </summary>
        [JsonProperty("UnitPriceDiscountThirdStep")]
        public float? UnitPriceDiscountThirdStep{ get; set; }

        /// <summary>
        /// 预支三年合计费用的原价，预付费模式使用，单位：元。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginalPriceThreeYear")]
        public float? OriginalPriceThreeYear{ get; set; }

        /// <summary>
        /// 预支三年合计费用的折扣价，预付费模式使用，单位：元。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiscountPriceThreeYear")]
        public float? DiscountPriceThreeYear{ get; set; }

        /// <summary>
        /// 预支三年应用的折扣，如20.0代表2折。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiscountThreeYear")]
        public float? DiscountThreeYear{ get; set; }

        /// <summary>
        /// 预支五年合计费用的原价，预付费模式使用，单位：元。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginalPriceFiveYear")]
        public float? OriginalPriceFiveYear{ get; set; }

        /// <summary>
        /// 预支五年合计费用的折扣价，预付费模式使用，单位：元。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiscountPriceFiveYear")]
        public float? DiscountPriceFiveYear{ get; set; }

        /// <summary>
        /// 预支五年应用的折扣，如20.0代表2折。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiscountFiveYear")]
        public float? DiscountFiveYear{ get; set; }

        /// <summary>
        /// 预支一年合计费用的原价，预付费模式使用，单位：元。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginalPriceOneYear")]
        public float? OriginalPriceOneYear{ get; set; }

        /// <summary>
        /// 预支一年合计费用的折扣价，预付费模式使用，单位：元。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiscountPriceOneYear")]
        public float? DiscountPriceOneYear{ get; set; }

        /// <summary>
        /// 预支一年应用的折扣，如20.0代表2折。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiscountOneYear")]
        public float? DiscountOneYear{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UnitPrice", this.UnitPrice);
            this.SetParamSimple(map, prefix + "ChargeUnit", this.ChargeUnit);
            this.SetParamSimple(map, prefix + "OriginalPrice", this.OriginalPrice);
            this.SetParamSimple(map, prefix + "DiscountPrice", this.DiscountPrice);
            this.SetParamSimple(map, prefix + "Discount", this.Discount);
            this.SetParamSimple(map, prefix + "UnitPriceDiscount", this.UnitPriceDiscount);
            this.SetParamSimple(map, prefix + "UnitPriceSecondStep", this.UnitPriceSecondStep);
            this.SetParamSimple(map, prefix + "UnitPriceDiscountSecondStep", this.UnitPriceDiscountSecondStep);
            this.SetParamSimple(map, prefix + "UnitPriceThirdStep", this.UnitPriceThirdStep);
            this.SetParamSimple(map, prefix + "UnitPriceDiscountThirdStep", this.UnitPriceDiscountThirdStep);
            this.SetParamSimple(map, prefix + "OriginalPriceThreeYear", this.OriginalPriceThreeYear);
            this.SetParamSimple(map, prefix + "DiscountPriceThreeYear", this.DiscountPriceThreeYear);
            this.SetParamSimple(map, prefix + "DiscountThreeYear", this.DiscountThreeYear);
            this.SetParamSimple(map, prefix + "OriginalPriceFiveYear", this.OriginalPriceFiveYear);
            this.SetParamSimple(map, prefix + "DiscountPriceFiveYear", this.DiscountPriceFiveYear);
            this.SetParamSimple(map, prefix + "DiscountFiveYear", this.DiscountFiveYear);
            this.SetParamSimple(map, prefix + "OriginalPriceOneYear", this.OriginalPriceOneYear);
            this.SetParamSimple(map, prefix + "DiscountPriceOneYear", this.DiscountPriceOneYear);
            this.SetParamSimple(map, prefix + "DiscountOneYear", this.DiscountOneYear);
        }
    }
}

