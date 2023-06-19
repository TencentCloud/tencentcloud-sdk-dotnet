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

    public class PayeeAccountBalanceResult : AbstractModel
    {
        
        /// <summary>
        /// 账户ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountId")]
        public string AccountId{ get; set; }

        /// <summary>
        /// 收入类型
        /// LABOR:劳务所得
        /// OCCASION:偶然所得
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IncomeType")]
        public long? IncomeType{ get; set; }

        /// <summary>
        /// 总余额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Balance")]
        public string Balance{ get; set; }

        /// <summary>
        /// 系统冻结余额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SystemFreezeBalance")]
        public string SystemFreezeBalance{ get; set; }

        /// <summary>
        /// 人工冻结余额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ManualFreezeBalance")]
        public string ManualFreezeBalance{ get; set; }

        /// <summary>
        /// 可提现余额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayableBalance")]
        public string PayableBalance{ get; set; }

        /// <summary>
        /// 已提现余额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaidBalance")]
        public string PaidBalance{ get; set; }

        /// <summary>
        /// 提现中余额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InPayBalance")]
        public string InPayBalance{ get; set; }

        /// <summary>
        /// 累计结算金额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SumSettlementAmount")]
        public string SumSettlementAmount{ get; set; }

        /// <summary>
        /// 已缴个税
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaidIncomeTax")]
        public string PaidIncomeTax{ get; set; }

        /// <summary>
        /// 提现中个税
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InPayIncomeTax")]
        public string InPayIncomeTax{ get; set; }

        /// <summary>
        /// 已缴增值税
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaidValueAddedTax")]
        public string PaidValueAddedTax{ get; set; }

        /// <summary>
        /// 提现中增值税
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InPayValueAddedTax")]
        public string InPayValueAddedTax{ get; set; }

        /// <summary>
        /// 已缴附加税
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaidAttachTax")]
        public string PaidAttachTax{ get; set; }

        /// <summary>
        /// 提现中附加税
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InPayAttachTax")]
        public string InPayAttachTax{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccountId", this.AccountId);
            this.SetParamSimple(map, prefix + "IncomeType", this.IncomeType);
            this.SetParamSimple(map, prefix + "Balance", this.Balance);
            this.SetParamSimple(map, prefix + "SystemFreezeBalance", this.SystemFreezeBalance);
            this.SetParamSimple(map, prefix + "ManualFreezeBalance", this.ManualFreezeBalance);
            this.SetParamSimple(map, prefix + "PayableBalance", this.PayableBalance);
            this.SetParamSimple(map, prefix + "PaidBalance", this.PaidBalance);
            this.SetParamSimple(map, prefix + "InPayBalance", this.InPayBalance);
            this.SetParamSimple(map, prefix + "SumSettlementAmount", this.SumSettlementAmount);
            this.SetParamSimple(map, prefix + "PaidIncomeTax", this.PaidIncomeTax);
            this.SetParamSimple(map, prefix + "InPayIncomeTax", this.InPayIncomeTax);
            this.SetParamSimple(map, prefix + "PaidValueAddedTax", this.PaidValueAddedTax);
            this.SetParamSimple(map, prefix + "InPayValueAddedTax", this.InPayValueAddedTax);
            this.SetParamSimple(map, prefix + "PaidAttachTax", this.PaidAttachTax);
            this.SetParamSimple(map, prefix + "InPayAttachTax", this.InPayAttachTax);
        }
    }
}

