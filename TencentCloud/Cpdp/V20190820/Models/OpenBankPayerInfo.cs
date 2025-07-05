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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OpenBankPayerInfo : AbstractModel
    {
        
        /// <summary>
        /// 付款方唯一标识。当TENPAY时，必填上送
        /// 付款方入驻云企付商户ID。
        /// </summary>
        [JsonProperty("PayerId")]
        public string PayerId{ get; set; }

        /// <summary>
        /// 付款方名称。当TENPAY上送付款方入驻云企付的商户名称。
        /// </summary>
        [JsonProperty("PayerName")]
        public string PayerName{ get; set; }

        /// <summary>
        /// 付款方付款账户标识。
        /// 当付款方式为OPENBANK_PAYMENT时，必输表示企业账户ID；当付款方式为SAFT_ISV时，必须上送付款方的渠道电子记账本ID；当付款方式为ONLINEBANK，上送付款方银行编号BankId。
        /// </summary>
        [JsonProperty("BindSerialNo")]
        public string BindSerialNo{ get; set; }

        /// <summary>
        /// 付款账户标识类型
        /// BANK_ACCOUNT：绑定银行账户
        /// ACCOUNT_BOOK_ID：电子记账本ID。
        /// 当付款方式为SAFT_ISV时，必须上送类型为ACCOUNT_BOOK_ID。
        /// </summary>
        [JsonProperty("AccountType")]
        public string AccountType{ get; set; }

        /// <summary>
        /// 付款卡类型。汇付渠道必填。
        /// DEBIT_CARD：借记卡
        /// CREDIT_CARD：信用卡
        /// </summary>
        [JsonProperty("BankCardType")]
        public string BankCardType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayerId", this.PayerId);
            this.SetParamSimple(map, prefix + "PayerName", this.PayerName);
            this.SetParamSimple(map, prefix + "BindSerialNo", this.BindSerialNo);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamSimple(map, prefix + "BankCardType", this.BankCardType);
        }
    }
}

