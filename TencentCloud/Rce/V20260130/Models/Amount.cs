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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Amount : AbstractModel
    {
        
        /// <summary>
        /// <p>原始货币类型</p><p>参数格式：符合ISO 4217标准</p>
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// <p>原始金额</p>
        /// </summary>
        [JsonProperty("OriginalAmount")]
        public float? OriginalAmount{ get; set; }

        /// <summary>
        /// <p>当前币种对美金的汇率</p>
        /// </summary>
        [JsonProperty("ExchangeRateUSD")]
        public float? ExchangeRateUSD{ get; set; }

        /// <summary>
        /// <p>当前币种对人民币的汇率</p>
        /// </summary>
        [JsonProperty("ExchangeRateCNY")]
        public float? ExchangeRateCNY{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
            this.SetParamSimple(map, prefix + "OriginalAmount", this.OriginalAmount);
            this.SetParamSimple(map, prefix + "ExchangeRateUSD", this.ExchangeRateUSD);
            this.SetParamSimple(map, prefix + "ExchangeRateCNY", this.ExchangeRateCNY);
        }
    }
}

