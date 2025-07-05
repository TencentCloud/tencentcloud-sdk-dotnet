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

    public class QueryOpenBankBillData : AbstractModel
    {
        
        /// <summary>
        /// 交易日期
        /// </summary>
        [JsonProperty("BillDate")]
        public string BillDate{ get; set; }

        /// <summary>
        /// 渠道编码
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }

        /// <summary>
        /// 二级渠道
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubChannel")]
        public string SubChannel{ get; set; }

        /// <summary>
        /// 系统父商户号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentMerchantId")]
        public string ParentMerchantId{ get; set; }

        /// <summary>
        /// 外部商户号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutMerchantId")]
        public string OutMerchantId{ get; set; }

        /// <summary>
        /// 系统商户号
        /// </summary>
        [JsonProperty("MerchantId")]
        public string MerchantId{ get; set; }

        /// <summary>
        /// 第三方商户号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndMerchantId")]
        public string EndMerchantId{ get; set; }

        /// <summary>
        /// 外部订单号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutTradeNo")]
        public string OutTradeNo{ get; set; }

        /// <summary>
        /// 系统订单号
        /// </summary>
        [JsonProperty("TradeNo")]
        public string TradeNo{ get; set; }

        /// <summary>
        /// 第三方订单号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTradeNo")]
        public string EndTradeNo{ get; set; }

        /// <summary>
        /// 收付类型，PAYMENT:付款，INCOME:收款
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaymentType")]
        public string PaymentType{ get; set; }

        /// <summary>
        /// 业务类型，WITHDRAW:提现，PAY:支付，RECHARGE:充值，TRANSFER:转账，REFUND:退款
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BusinessType")]
        public string BusinessType{ get; set; }

        /// <summary>
        /// 发起交易时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("TradeTime")]
        public string TradeTime{ get; set; }

        /// <summary>
        /// 交易完成时间，格式yyyy-MM-dd HH:mm:ss
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// 交易状态，0:未知，1:成功，2:失败
        /// </summary>
        [JsonProperty("TradeStatus")]
        public string TradeStatus{ get; set; }

        /// <summary>
        /// 对账状态，1:成功，2:失败 3:长账 4:短账
        /// </summary>
        [JsonProperty("CheckStatus")]
        public string CheckStatus{ get; set; }

        /// <summary>
        /// 对账失败原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckFailReason")]
        public string CheckFailReason{ get; set; }

        /// <summary>
        /// 交易金额（元）
        /// </summary>
        [JsonProperty("OrderAmount")]
        public string OrderAmount{ get; set; }

        /// <summary>
        /// 服务费（元）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceFee")]
        public string ServiceFee{ get; set; }

        /// <summary>
        /// 收款人账号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayeeAccount")]
        public string PayeeAccount{ get; set; }

        /// <summary>
        /// 收款人名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayeeName")]
        public string PayeeName{ get; set; }

        /// <summary>
        /// 付款人账号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayerAccount")]
        public string PayerAccount{ get; set; }

        /// <summary>
        /// 付款人名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayerName")]
        public string PayerName{ get; set; }

        /// <summary>
        /// 支付信息描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BillDate", this.BillDate);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "SubChannel", this.SubChannel);
            this.SetParamSimple(map, prefix + "ParentMerchantId", this.ParentMerchantId);
            this.SetParamSimple(map, prefix + "OutMerchantId", this.OutMerchantId);
            this.SetParamSimple(map, prefix + "MerchantId", this.MerchantId);
            this.SetParamSimple(map, prefix + "EndMerchantId", this.EndMerchantId);
            this.SetParamSimple(map, prefix + "OutTradeNo", this.OutTradeNo);
            this.SetParamSimple(map, prefix + "TradeNo", this.TradeNo);
            this.SetParamSimple(map, prefix + "EndTradeNo", this.EndTradeNo);
            this.SetParamSimple(map, prefix + "PaymentType", this.PaymentType);
            this.SetParamSimple(map, prefix + "BusinessType", this.BusinessType);
            this.SetParamSimple(map, prefix + "TradeTime", this.TradeTime);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
            this.SetParamSimple(map, prefix + "TradeStatus", this.TradeStatus);
            this.SetParamSimple(map, prefix + "CheckStatus", this.CheckStatus);
            this.SetParamSimple(map, prefix + "CheckFailReason", this.CheckFailReason);
            this.SetParamSimple(map, prefix + "OrderAmount", this.OrderAmount);
            this.SetParamSimple(map, prefix + "ServiceFee", this.ServiceFee);
            this.SetParamSimple(map, prefix + "PayeeAccount", this.PayeeAccount);
            this.SetParamSimple(map, prefix + "PayeeName", this.PayeeName);
            this.SetParamSimple(map, prefix + "PayerAccount", this.PayerAccount);
            this.SetParamSimple(map, prefix + "PayerName", this.PayerName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

