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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DuplexBilling : AbstractModel
    {
        
        /// <summary>
        /// <table><tbody><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>UNKNOW</td><td>0</td><td></td></tr><tr><td>TOKEN</td><td>1</td><td>按token</td></tr><tr><td>PAGE_COUNT</td><td>2</td><td>按页数</td></tr><tr><td>TIMES</td><td>3</td><td>按次数</td></tr><tr><td>TIMES_THOUSAND</td><td>4</td><td>按千次数</td></tr><tr><td>SECOND</td><td>5</td><td>按时长</td></tr><tr><td>CHARACTER</td><td>6</td><td>按字符数</td></tr><tr><td>CHARACTER_THOUSAND</td><td>7</td><td>按千字符数</td></tr><tr><td>SHEET</td><td>8</td><td>按张</td></tr><tr><td>NUMBER</td><td>9</td><td>按个数</td></tr></tbody></table>
        /// </summary>
        [JsonProperty("BillingUnit")]
        public long? BillingUnit{ get; set; }

        /// <summary>
        /// <p>输入现金价格</p><p>单位：元</p>
        /// </summary>
        [JsonProperty("InputCashPrice")]
        public float? InputCashPrice{ get; set; }

        /// <summary>
        /// <p>输入pu价格</p><p>单位：pu</p>
        /// </summary>
        [JsonProperty("InputPuPrice")]
        public float? InputPuPrice{ get; set; }

        /// <summary>
        /// <p>输出现金价格</p><p>单位：元</p>
        /// </summary>
        [JsonProperty("OutputCashPrice")]
        public float? OutputCashPrice{ get; set; }

        /// <summary>
        /// <p>输出pu价格</p><p>单位：pu</p>
        /// </summary>
        [JsonProperty("OutputPuPrice")]
        public float? OutputPuPrice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BillingUnit", this.BillingUnit);
            this.SetParamSimple(map, prefix + "InputCashPrice", this.InputCashPrice);
            this.SetParamSimple(map, prefix + "InputPuPrice", this.InputPuPrice);
            this.SetParamSimple(map, prefix + "OutputCashPrice", this.OutputCashPrice);
            this.SetParamSimple(map, prefix + "OutputPuPrice", this.OutputPuPrice);
        }
    }
}

