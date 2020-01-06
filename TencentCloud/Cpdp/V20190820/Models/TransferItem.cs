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

    public class TransferItem : AbstractModel
    {
        
        /// <summary>
        /// STRING(10)，入账类型（02: 会员充值; 03: 资金挂账）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InAcctType")]
        public string InAcctType{ get; set; }

        /// <summary>
        /// STRING(32)，交易网会员代码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TranNetMemberCode")]
        public string TranNetMemberCode{ get; set; }

        /// <summary>
        /// STRING(50)，见证子帐户的帐号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubAcctNo")]
        public string SubAcctNo{ get; set; }

        /// <summary>
        /// STRING(20)，入金金额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TranAmt")]
        public string TranAmt{ get; set; }

        /// <summary>
        /// STRING(50)，入金账号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InAcctNo")]
        public string InAcctNo{ get; set; }

        /// <summary>
        /// STRING(150)，入金账户名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InAcctName")]
        public string InAcctName{ get; set; }

        /// <summary>
        /// STRING(3)，币种
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Ccy")]
        public string Ccy{ get; set; }

        /// <summary>
        /// STRING(8)，会计日期（即银行主机记账日期）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountingDate")]
        public string AccountingDate{ get; set; }

        /// <summary>
        /// STRING(150)，银行名称（付款账户银行名称）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BankName")]
        public string BankName{ get; set; }

        /// <summary>
        /// STRING(300)，转账备注
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// STRING(52)，见证系统流水号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrontSeqNo")]
        public string FrontSeqNo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InAcctType", this.InAcctType);
            this.SetParamSimple(map, prefix + "TranNetMemberCode", this.TranNetMemberCode);
            this.SetParamSimple(map, prefix + "SubAcctNo", this.SubAcctNo);
            this.SetParamSimple(map, prefix + "TranAmt", this.TranAmt);
            this.SetParamSimple(map, prefix + "InAcctNo", this.InAcctNo);
            this.SetParamSimple(map, prefix + "InAcctName", this.InAcctName);
            this.SetParamSimple(map, prefix + "Ccy", this.Ccy);
            this.SetParamSimple(map, prefix + "AccountingDate", this.AccountingDate);
            this.SetParamSimple(map, prefix + "BankName", this.BankName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "FrontSeqNo", this.FrontSeqNo);
        }
    }
}

