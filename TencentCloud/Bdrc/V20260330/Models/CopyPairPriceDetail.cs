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

    public class CopyPairPriceDetail : AbstractModel
    {
        
        /// <summary>
        /// 计费项目标识名称。取值：InstanceCount（容灾CVM实例数）、InstanceDataCapacity（容灾CVM实例数据量）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PriceName")]
        public string PriceName{ get; set; }

        /// <summary>
        /// 计费项目展示名称（跟随语言环境翻译）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PriceTitle")]
        public string PriceTitle{ get; set; }

        /// <summary>
        /// 该计费项每小时原价，单位：元
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnitPrice")]
        public float? UnitPrice{ get; set; }

        /// <summary>
        /// 该计费项每小时折扣价，单位：元
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnitPriceDiscount")]
        public float? UnitPriceDiscount{ get; set; }

        /// <summary>
        /// 该计费项的折扣，100 表示无折扣
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Discount")]
        public long? Discount{ get; set; }

        /// <summary>
        /// 计价单元，固定为 HOUR
        /// </summary>
        [JsonProperty("ChargeUnit")]
        public string ChargeUnit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PriceName", this.PriceName);
            this.SetParamSimple(map, prefix + "PriceTitle", this.PriceTitle);
            this.SetParamSimple(map, prefix + "UnitPrice", this.UnitPrice);
            this.SetParamSimple(map, prefix + "UnitPriceDiscount", this.UnitPriceDiscount);
            this.SetParamSimple(map, prefix + "Discount", this.Discount);
            this.SetParamSimple(map, prefix + "ChargeUnit", this.ChargeUnit);
        }
    }
}

