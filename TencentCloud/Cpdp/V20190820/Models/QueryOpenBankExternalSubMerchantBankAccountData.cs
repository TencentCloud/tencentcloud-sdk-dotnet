/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class QueryOpenBankExternalSubMerchantBankAccountData : AbstractModel
    {
        
        /// <summary>
        /// 开户银行。
        /// </summary>
        [JsonProperty("AccountBank")]
        public string AccountBank{ get; set; }

        /// <summary>
        /// 绑卡序列号。
        /// </summary>
        [JsonProperty("BindSerialNo")]
        public string BindSerialNo{ get; set; }

        /// <summary>
        /// 账号类型。
        /// __COLLECT_MONEY__: 收款卡
        /// __PAYMENT__: 付款卡
        /// </summary>
        [JsonProperty("AccountType")]
        public string AccountType{ get; set; }

        /// <summary>
        /// 支行号。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BankBranchId")]
        public string BankBranchId{ get; set; }

        /// <summary>
        /// 银行卡卡后四位。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountNumberLastFour")]
        public string AccountNumberLastFour{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccountBank", this.AccountBank);
            this.SetParamSimple(map, prefix + "BindSerialNo", this.BindSerialNo);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamSimple(map, prefix + "BankBranchId", this.BankBranchId);
            this.SetParamSimple(map, prefix + "AccountNumberLastFour", this.AccountNumberLastFour);
        }
    }
}

