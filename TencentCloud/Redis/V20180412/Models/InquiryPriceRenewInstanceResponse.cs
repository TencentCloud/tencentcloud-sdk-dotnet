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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquiryPriceRenewInstanceResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>折扣后价格</p>
        /// </summary>
        [JsonProperty("Price")]
        public float? Price{ get; set; }

        /// <summary>
        /// <p>高精度折扣后价格</p>
        /// </summary>
        [JsonProperty("HighPrecisionPrice")]
        public float? HighPrecisionPrice{ get; set; }

        /// <summary>
        /// <p>原价</p>
        /// </summary>
        [JsonProperty("OriginalPrice")]
        public float? OriginalPrice{ get; set; }

        /// <summary>
        /// <p>高精度原价</p>
        /// </summary>
        [JsonProperty("HighPrecisionOriginalPrice")]
        public float? HighPrecisionOriginalPrice{ get; set; }

        /// <summary>
        /// <p>币种</p>
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// <p>价格金额单位</p><ul><li>pent: 分</li><li>microPent: 微分</li></ul>
        /// </summary>
        [JsonProperty("AmountUnit")]
        public string AmountUnit{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "HighPrecisionPrice", this.HighPrecisionPrice);
            this.SetParamSimple(map, prefix + "OriginalPrice", this.OriginalPrice);
            this.SetParamSimple(map, prefix + "HighPrecisionOriginalPrice", this.HighPrecisionOriginalPrice);
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
            this.SetParamSimple(map, prefix + "AmountUnit", this.AmountUnit);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

