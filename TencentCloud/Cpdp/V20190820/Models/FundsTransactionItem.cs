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

    public class FundsTransactionItem : AbstractModel
    {
        
        /// <summary>
        /// 资金交易类型。
        /// __1__：提现/退款
        /// __2__：清分/充值
        /// </summary>
        [JsonProperty("TransType")]
        public string TransType{ get; set; }

        /// <summary>
        /// 银行记账说明。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BankBookingMessage")]
        public string BankBookingMessage{ get; set; }

        /// <summary>
        /// 交易状态。
        /// __0__：成功
        /// </summary>
        [JsonProperty("TranStatus")]
        public string TranStatus{ get; set; }

        /// <summary>
        /// 业务方会员标识。
        /// _平安渠道为交易网会员代码_
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TransNetMemberCode")]
        public string TransNetMemberCode{ get; set; }

        /// <summary>
        /// 子账户账号。
        /// _平安渠道为见证子账户的账号_
        /// </summary>
        [JsonProperty("SubAccountNumber")]
        public string SubAccountNumber{ get; set; }

        /// <summary>
        /// 子账户名称。
        /// _平安渠道为见证子账户的户名_
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubAccountName")]
        public string SubAccountName{ get; set; }

        /// <summary>
        /// 交易金额。
        /// </summary>
        [JsonProperty("TransAmount")]
        public string TransAmount{ get; set; }

        /// <summary>
        /// 交易手续费。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TransFee")]
        public string TransFee{ get; set; }

        /// <summary>
        /// 交易日期，格式：yyyyMMdd。
        /// </summary>
        [JsonProperty("TransDate")]
        public string TransDate{ get; set; }

        /// <summary>
        /// 交易时间，格式：HHmmss。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TransTime")]
        public string TransTime{ get; set; }

        /// <summary>
        /// 银行系统流水号。
        /// _平安渠道为见证系统流水号_
        /// </summary>
        [JsonProperty("BankSequenceNumber")]
        public string BankSequenceNumber{ get; set; }

        /// <summary>
        /// 备注。
        /// _平安渠道，如果是见证+收单的交易，返回交易订单号_
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TransType", this.TransType);
            this.SetParamSimple(map, prefix + "BankBookingMessage", this.BankBookingMessage);
            this.SetParamSimple(map, prefix + "TranStatus", this.TranStatus);
            this.SetParamSimple(map, prefix + "TransNetMemberCode", this.TransNetMemberCode);
            this.SetParamSimple(map, prefix + "SubAccountNumber", this.SubAccountNumber);
            this.SetParamSimple(map, prefix + "SubAccountName", this.SubAccountName);
            this.SetParamSimple(map, prefix + "TransAmount", this.TransAmount);
            this.SetParamSimple(map, prefix + "TransFee", this.TransFee);
            this.SetParamSimple(map, prefix + "TransDate", this.TransDate);
            this.SetParamSimple(map, prefix + "TransTime", this.TransTime);
            this.SetParamSimple(map, prefix + "BankSequenceNumber", this.BankSequenceNumber);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

