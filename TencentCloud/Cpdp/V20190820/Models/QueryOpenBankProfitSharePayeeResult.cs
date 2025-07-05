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

    public class QueryOpenBankProfitSharePayeeResult : AbstractModel
    {
        
        /// <summary>
        /// 账户ID（受益ID）
        /// </summary>
        [JsonProperty("AccountId")]
        public string AccountId{ get; set; }

        /// <summary>
        /// 账户号。通联国际指客户银行账户号
        /// </summary>
        [JsonProperty("AccountNo")]
        public string AccountNo{ get; set; }

        /// <summary>
        /// 账户货币。参考附录“币种类型”。
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// 收款人账户名称
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName{ get; set; }

        /// <summary>
        /// 银行名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BankName")]
        public string BankName{ get; set; }

        /// <summary>
        /// 账户类型。
        /// 00:借记卡
        /// 01:存折 
        /// 02:信用卡 
        /// 03:准贷记卡 
        /// 04:预付卡费 
        /// 05:境外卡
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Nature")]
        public string Nature{ get; set; }

        /// <summary>
        /// 状态
        /// 0-待审核；1-审核通过；2-审核不通过 3-关联实体未审核
        /// </summary>
        [JsonProperty("BindState")]
        public string BindState{ get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        [JsonProperty("StateExplain")]
        public string StateExplain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccountId", this.AccountId);
            this.SetParamSimple(map, prefix + "AccountNo", this.AccountNo);
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
            this.SetParamSimple(map, prefix + "AccountName", this.AccountName);
            this.SetParamSimple(map, prefix + "BankName", this.BankName);
            this.SetParamSimple(map, prefix + "Nature", this.Nature);
            this.SetParamSimple(map, prefix + "BindState", this.BindState);
            this.SetParamSimple(map, prefix + "StateExplain", this.StateExplain);
        }
    }
}

