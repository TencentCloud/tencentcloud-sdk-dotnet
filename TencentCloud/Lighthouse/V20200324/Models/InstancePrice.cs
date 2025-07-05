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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstancePrice : AbstractModel
    {
        
        /// <summary>
        /// 套餐单价原价。
        /// </summary>
        [JsonProperty("OriginalBundlePrice")]
        public float? OriginalBundlePrice{ get; set; }

        /// <summary>
        /// 原价。
        /// </summary>
        [JsonProperty("OriginalPrice")]
        public float? OriginalPrice{ get; set; }

        /// <summary>
        /// 折扣。
        /// </summary>
        [JsonProperty("Discount")]
        public float? Discount{ get; set; }

        /// <summary>
        /// 折后价。
        /// </summary>
        [JsonProperty("DiscountPrice")]
        public float? DiscountPrice{ get; set; }

        /// <summary>
        /// 价格货币单位。取值范围CNY:人民币。USD:美元。
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OriginalBundlePrice", this.OriginalBundlePrice);
            this.SetParamSimple(map, prefix + "OriginalPrice", this.OriginalPrice);
            this.SetParamSimple(map, prefix + "Discount", this.Discount);
            this.SetParamSimple(map, prefix + "DiscountPrice", this.DiscountPrice);
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
        }
    }
}

