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

    public class PaymentOrderResult : AbstractModel
    {
        
        /// <summary>
        /// 收入类型
        /// LABOR:劳务所得
        /// OCCASION:偶然所得
        /// </summary>
        [JsonProperty("IncomeType")]
        public string IncomeType{ get; set; }

        /// <summary>
        /// 税前金额
        /// </summary>
        [JsonProperty("AmountBeforeTax")]
        public string AmountBeforeTax{ get; set; }

        /// <summary>
        /// 税后金额
        /// </summary>
        [JsonProperty("AmountAfterTax")]
        public string AmountAfterTax{ get; set; }

        /// <summary>
        /// 税金
        /// </summary>
        [JsonProperty("Tax")]
        public string Tax{ get; set; }

        /// <summary>
        /// 外部订单ID
        /// </summary>
        [JsonProperty("OutOrderId")]
        public string OutOrderId{ get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 发起时间
        /// </summary>
        [JsonProperty("InitiateTime")]
        public string InitiateTime{ get; set; }

        /// <summary>
        /// 完成时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// 状态
        /// ACCEPTED:已受理
        /// ACCOUNTED:已记账
        /// PAYING:付款中
        /// PAYED:完成付款渠道调用
        /// SUCCEED:已成功
        /// FAILED:已失败
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// 提现备注
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 收款用户ID
        /// </summary>
        [JsonProperty("PayeeId")]
        public string PayeeId{ get; set; }

        /// <summary>
        /// 外部用户ID
        /// </summary>
        [JsonProperty("OutUserId")]
        public string OutUserId{ get; set; }

        /// <summary>
        /// 渠道支付订单号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelOrderId")]
        public string ChannelOrderId{ get; set; }

        /// <summary>
        /// 增值税
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Vat")]
        public string Vat{ get; set; }

        /// <summary>
        /// 个人所得税
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndividualIncomeTax")]
        public string IndividualIncomeTax{ get; set; }

        /// <summary>
        /// 附加税总税额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdditionalTaxSum")]
        public string AdditionalTaxSum{ get; set; }

        /// <summary>
        /// 附加税税项。格式为JSON格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdditionalTaxItem")]
        public string AdditionalTaxItem{ get; set; }

        /// <summary>
        /// 失败原因。当Status为FAILED时，改字段为失败的原因。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailReason")]
        public string FailReason{ get; set; }

        /// <summary>
        /// 资金账户字类型: WECHATPAY_ACCOUNT 微信零钱, BANK_ACCOUNT 银行卡
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FundingAccountSubType")]
        public string FundingAccountSubType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IncomeType", this.IncomeType);
            this.SetParamSimple(map, prefix + "AmountBeforeTax", this.AmountBeforeTax);
            this.SetParamSimple(map, prefix + "AmountAfterTax", this.AmountAfterTax);
            this.SetParamSimple(map, prefix + "Tax", this.Tax);
            this.SetParamSimple(map, prefix + "OutOrderId", this.OutOrderId);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "InitiateTime", this.InitiateTime);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "PayeeId", this.PayeeId);
            this.SetParamSimple(map, prefix + "OutUserId", this.OutUserId);
            this.SetParamSimple(map, prefix + "ChannelOrderId", this.ChannelOrderId);
            this.SetParamSimple(map, prefix + "Vat", this.Vat);
            this.SetParamSimple(map, prefix + "IndividualIncomeTax", this.IndividualIncomeTax);
            this.SetParamSimple(map, prefix + "AdditionalTaxSum", this.AdditionalTaxSum);
            this.SetParamSimple(map, prefix + "AdditionalTaxItem", this.AdditionalTaxItem);
            this.SetParamSimple(map, prefix + "FailReason", this.FailReason);
            this.SetParamSimple(map, prefix + "FundingAccountSubType", this.FundingAccountSubType);
        }
    }
}

