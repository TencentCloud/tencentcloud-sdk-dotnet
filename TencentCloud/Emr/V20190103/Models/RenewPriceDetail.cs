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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RenewPriceDetail : AbstractModel
    {
        
        /// <summary>
        /// 计费项名称
        /// </summary>
        [JsonProperty("BillingName")]
        public string BillingName{ get; set; }

        /// <summary>
        /// 折扣
        /// </summary>
        [JsonProperty("Policy")]
        public float? Policy{ get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty("Quantity")]
        public long? Quantity{ get; set; }

        /// <summary>
        /// 原价
        /// </summary>
        [JsonProperty("OriginalCost")]
        public float? OriginalCost{ get; set; }

        /// <summary>
        /// 折扣价
        /// </summary>
        [JsonProperty("DiscountCost")]
        public float? DiscountCost{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BillingName", this.BillingName);
            this.SetParamSimple(map, prefix + "Policy", this.Policy);
            this.SetParamSimple(map, prefix + "Quantity", this.Quantity);
            this.SetParamSimple(map, prefix + "OriginalCost", this.OriginalCost);
            this.SetParamSimple(map, prefix + "DiscountCost", this.DiscountCost);
        }
    }
}

