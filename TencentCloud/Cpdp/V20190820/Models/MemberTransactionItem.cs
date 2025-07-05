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

    public class MemberTransactionItem : AbstractModel
    {
        
        /// <summary>
        /// 交易类型。
        /// __1__：转出
        /// __2__：转入
        /// </summary>
        [JsonProperty("TransType")]
        public string TransType{ get; set; }

        /// <summary>
        /// 交易状态。
        /// __0__：成功
        /// </summary>
        [JsonProperty("TranStatus")]
        public string TranStatus{ get; set; }

        /// <summary>
        /// 交易金额。
        /// </summary>
        [JsonProperty("TransAmount")]
        public string TransAmount{ get; set; }

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
        /// 银行记账类型。
        /// _平安渠道为：_
        /// _1：会员支付_
        /// _2：会员冻结_
        /// _3：会员解冻_
        /// _4：登记挂账_
        /// _6：下单预支付_
        /// _7：确认并付款_
        /// _8：会员退款_
        /// _22：见证+收单平台调账_
        /// _23：见证+收单资金冻结_
        /// _24：见证+收单资金解冻_
        /// _25：会员间交易退款_
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BankBookingType")]
        public string BankBookingType{ get; set; }

        /// <summary>
        /// 转入方子账户账号。
        /// _平安渠道为转入见证子账户的账号_
        /// </summary>
        [JsonProperty("InSubAccountNumber")]
        public string InSubAccountNumber{ get; set; }

        /// <summary>
        /// 转出方子账户账号。
        /// _平安渠道为转出见证子账户的账号_
        /// </summary>
        [JsonProperty("OutSubAccountNumber")]
        public string OutSubAccountNumber{ get; set; }

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
            this.SetParamSimple(map, prefix + "TranStatus", this.TranStatus);
            this.SetParamSimple(map, prefix + "TransAmount", this.TransAmount);
            this.SetParamSimple(map, prefix + "TransDate", this.TransDate);
            this.SetParamSimple(map, prefix + "TransTime", this.TransTime);
            this.SetParamSimple(map, prefix + "BankSequenceNumber", this.BankSequenceNumber);
            this.SetParamSimple(map, prefix + "BankBookingType", this.BankBookingType);
            this.SetParamSimple(map, prefix + "InSubAccountNumber", this.InSubAccountNumber);
            this.SetParamSimple(map, prefix + "OutSubAccountNumber", this.OutSubAccountNumber);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

