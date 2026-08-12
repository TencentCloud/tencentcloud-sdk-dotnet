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

    public class PaymentMethod : AbstractModel
    {
        
        /// <summary>
        /// <p>支付方式</p><p>枚举值：</p><ul><li>cash： 现金</li><li>check： 支票</li><li>credit_card： 信用卡</li><li>debit_card： 借记卡</li><li>crypto_currency： 加密货币</li><li>digital_wallet： 数字钱包</li><li>gift_card： 礼品卡</li><li>points： 积分</li><li>in_app_purchase： APP内购买</li><li>electronic_fund_transfer： 电子资金转账</li><li>financing： 融资</li><li>invoice： 发票</li><li>prepaid_card： 预付卡</li><li>sepa_credit： SEPA信用转账</li></ul>
        /// </summary>
        [JsonProperty("PaymentType")]
        public string PaymentType{ get; set; }

        /// <summary>
        /// <p>支付渠道</p>
        /// </summary>
        [JsonProperty("PaymentChannel")]
        public string PaymentChannel{ get; set; }

        /// <summary>
        /// <p>银行卡信息，当用支付方式是credit_card、debit_card时必填</p>
        /// </summary>
        [JsonProperty("Card")]
        public Card Card{ get; set; }

        /// <summary>
        /// <p>SEPA直接借记授权</p><p>枚举值：</p><ul><li>true： 是</li><li>false： 否</li></ul>
        /// </summary>
        [JsonProperty("SEPADirectDebitMandate")]
        public bool? SEPADirectDebitMandate{ get; set; }

        /// <summary>
        /// <p>数字钱包</p>
        /// </summary>
        [JsonProperty("DigitalWallet")]
        public Wallet DigitalWallet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PaymentType", this.PaymentType);
            this.SetParamSimple(map, prefix + "PaymentChannel", this.PaymentChannel);
            this.SetParamObj(map, prefix + "Card.", this.Card);
            this.SetParamSimple(map, prefix + "SEPADirectDebitMandate", this.SEPADirectDebitMandate);
            this.SetParamObj(map, prefix + "DigitalWallet.", this.DigitalWallet);
        }
    }
}

