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

namespace TencentCloud.Thpc.V20230321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ItemPrice : AbstractModel
    {
        
        /// <summary>
        /// 预支合计费用的原价，预付费模式使用，单位：元。	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginalPrice")]
        public float? OriginalPrice{ get; set; }

        /// <summary>
        /// 预支合计费用的折扣价，预付费模式使用，单位：元。	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiscountPrice")]
        public float? DiscountPrice{ get; set; }

        /// <summary>
        /// 折扣，如20.0代表2折。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Discount")]
        public float? Discount{ get; set; }

        /// <summary>
        /// 后续合计费用的原价，后付费模式使用，单位：元。
        /// 
        /// 如返回了其他时间区间项，如UnitPriceSecondStep，则本项代表时间区间在(0, 96)小时；若未返回其他时间区间项，则本项代表全时段，即(0, ∞)小时
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnitPrice")]
        public float? UnitPrice{ get; set; }

        /// <summary>
        /// 后续合计费用的折扣价，后付费模式使用，单位：元
        /// 
        /// 如返回了其他时间区间项，如DiscountUnitPriceSecondStep，则本项代表时间区间在(0, 96)小时；若未返回其他时间区间项，则本项代表全时段，即(0, ∞)小时
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiscountUnitPrice")]
        public float? DiscountUnitPrice{ get; set; }

        /// <summary>
        /// 后续计价单元，后付费模式使用，可取值范围：
        /// 
        /// HOUR：表示计价单元是按每小时来计算。当前涉及该计价单元的场景有：实例按小时后付费（POSTPAID_BY_HOUR）、带宽按小时后付费（BANDWIDTH_POSTPAID_BY_HOUR）：
        /// GB：表示计价单元是按每GB来计算。当前涉及该计价单元的场景有：流量按小时后付费（TRAFFIC_POSTPAID_BY_HOUR）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChargeUnit")]
        public string ChargeUnit{ get; set; }

        /// <summary>
        /// 后续合计费用的折扣价，后付费模式使用，单位：元
        /// 
        /// 如返回了其他时间区间项，如UnitPriceDiscount
        /// float，则本项代表时间区间在(0, 96)小时；若未返回其他时间区间项，则本项代表全时段，即(0, ∞)小时
        /// </summary>
        [JsonProperty("UnitPriceDiscount")]
        public float? UnitPriceDiscount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OriginalPrice", this.OriginalPrice);
            this.SetParamSimple(map, prefix + "DiscountPrice", this.DiscountPrice);
            this.SetParamSimple(map, prefix + "Discount", this.Discount);
            this.SetParamSimple(map, prefix + "UnitPrice", this.UnitPrice);
            this.SetParamSimple(map, prefix + "DiscountUnitPrice", this.DiscountUnitPrice);
            this.SetParamSimple(map, prefix + "ChargeUnit", this.ChargeUnit);
            this.SetParamSimple(map, prefix + "UnitPriceDiscount", this.UnitPriceDiscount);
        }
    }
}

