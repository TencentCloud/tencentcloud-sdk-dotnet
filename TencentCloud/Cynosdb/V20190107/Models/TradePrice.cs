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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TradePrice : AbstractModel
    {
        
        /// <summary>
        /// 预付费模式下资源总价，不包含优惠，单位:分
        /// </summary>
        [JsonProperty("TotalPrice")]
        public long? TotalPrice{ get; set; }

        /// <summary>
        /// 总的折扣，100表示100%不打折
        /// </summary>
        [JsonProperty("Discount")]
        public float? Discount{ get; set; }

        /// <summary>
        /// 预付费模式下的优惠后总价, 单位: 分,例如用户享有折扣 =TotalPrice × Discount
        /// </summary>
        [JsonProperty("TotalPriceDiscount")]
        public long? TotalPriceDiscount{ get; set; }

        /// <summary>
        /// 后付费模式下的单位资源价格，不包含优惠，单位:分
        /// </summary>
        [JsonProperty("UnitPrice")]
        public long? UnitPrice{ get; set; }

        /// <summary>
        /// 优惠后后付费模式下的单位资源价格, 单位: 分,例如用户享有折扣=UnitPricet × Discount
        /// </summary>
        [JsonProperty("UnitPriceDiscount")]
        public long? UnitPriceDiscount{ get; set; }

        /// <summary>
        /// 计费价格单位
        /// </summary>
        [JsonProperty("ChargeUnit")]
        public string ChargeUnit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalPrice", this.TotalPrice);
            this.SetParamSimple(map, prefix + "Discount", this.Discount);
            this.SetParamSimple(map, prefix + "TotalPriceDiscount", this.TotalPriceDiscount);
            this.SetParamSimple(map, prefix + "UnitPrice", this.UnitPrice);
            this.SetParamSimple(map, prefix + "UnitPriceDiscount", this.UnitPriceDiscount);
            this.SetParamSimple(map, prefix + "ChargeUnit", this.ChargeUnit);
        }
    }
}

