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

    public class WithdrawEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>提现金额</p>
        /// </summary>
        [JsonProperty("Amount")]
        public Amount Amount{ get; set; }

        /// <summary>
        /// <p>提现方式</p><p>枚举值：</p><ul><li>card： 银行卡</li><li>wallet： 电子钱包</li></ul>
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// <p>提现银行卡，当提现方式是card时必填</p>
        /// </summary>
        [JsonProperty("Card")]
        public Card Card{ get; set; }

        /// <summary>
        /// <p>提现数字钱包，当提现方式是wallet时必填</p>
        /// </summary>
        [JsonProperty("Wallet")]
        public Wallet Wallet{ get; set; }

        /// <summary>
        /// <p>提现结果</p>
        /// </summary>
        [JsonProperty("Result")]
        public Result Result{ get; set; }

        /// <summary>
        /// <p>与RCE约定的定制化信息，为K:V 格式的对象数组，示例：[{&quot;Key&quot;: &quot;ApproverName&quot;, &quot;Value&quot;: &quot;bob&quot;},{&quot;Key&quot;:&quot;ApproverPhone&quot;,&quot;Value&quot;: &quot;+86131****5678&quot;}]</p>
        /// </summary>
        [JsonProperty("Cust")]
        public Cust[] Cust{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Amount.", this.Amount);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamObj(map, prefix + "Card.", this.Card);
            this.SetParamObj(map, prefix + "Wallet.", this.Wallet);
            this.SetParamObj(map, prefix + "Result.", this.Result);
            this.SetParamArrayObj(map, prefix + "Cust.", this.Cust);
        }
    }
}

