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

    public class QueryOpenBankPaymentOrderResult : AbstractModel
    {
        
        /// <summary>
        /// 渠道商户号。外部接入平台入驻云企付平台下发
        /// </summary>
        [JsonProperty("ChannelMerchantId")]
        public string ChannelMerchantId{ get; set; }

        /// <summary>
        /// 外部商户订单号
        /// </summary>
        [JsonProperty("OutOrderId")]
        public string OutOrderId{ get; set; }

        /// <summary>
        /// 云企付平台订单号
        /// </summary>
        [JsonProperty("ChannelOrderId")]
        public string ChannelOrderId{ get; set; }

        /// <summary>
        /// 第三方支付平台订单号
        /// </summary>
        [JsonProperty("ThirdPayOrderId")]
        public string ThirdPayOrderId{ get; set; }

        /// <summary>
        /// 订单状态。
        /// INIT：初始化
        /// PAYING：支付中
        /// ACCEPTED：支付受理成功
        /// SUCCESS：支付成功
        /// CLOSED：关单
        /// PAY_FAIL：支付失败
        /// REVOKE：退票
        /// PART_REFUND：部分退款
        /// FULL_REFUND：全部退款
        /// </summary>
        [JsonProperty("OrderStatus")]
        public string OrderStatus{ get; set; }

        /// <summary>
        /// 支付渠道名称，如TENPAY
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 付款方式。如EBANK_PAYMENT
        /// OPENBANK_PAYMENT
        /// </summary>
        [JsonProperty("PaymentMethod")]
        public string PaymentMethod{ get; set; }

        /// <summary>
        /// 订单金额。单位分
        /// </summary>
        [JsonProperty("TotalAmount")]
        public long? TotalAmount{ get; set; }

        /// <summary>
        /// 实际支付金额。单位分，支付成功时返回
        /// </summary>
        [JsonProperty("PayAmount")]
        public long? PayAmount{ get; set; }

        /// <summary>
        /// 失败原因，若失败的返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailReason")]
        public string FailReason{ get; set; }

        /// <summary>
        /// 附加信息，查询时原样透传
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Attachment")]
        public string Attachment{ get; set; }

        /// <summary>
        /// 重定向参数，用于客户端跳转，订单未支付时返回该参数
        /// 渠道为TENPAY，付款方式为EBANK_PAYMENT时返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RedirectInfo")]
        public OpenBankRedirectInfo RedirectInfo{ get; set; }

        /// <summary>
        /// 第三方渠道返回信息，见渠道特殊说明,详情见附录-复杂类型。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalReturnData")]
        public string ExternalReturnData{ get; set; }

        /// <summary>
        /// 银行复核指引。当TENPAY下OPENBANT_PAYMENT时，下单受理成功是返回。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BankApprovalGuideInfo")]
        public OpenBankApprovalGuideInfo BankApprovalGuideInfo{ get; set; }

        /// <summary>
        /// 手续费金额
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FeeAmount")]
        public long? FeeAmount{ get; set; }

        /// <summary>
        /// 手续费费率
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FeeRate")]
        public long? FeeRate{ get; set; }

        /// <summary>
        /// 分账信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProfitShareRespInfoList")]
        public OpenBankProfitShareRespInfo[] ProfitShareRespInfoList{ get; set; }

        /// <summary>
        /// 支付完成时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeFinish")]
        public string TimeFinish{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelMerchantId", this.ChannelMerchantId);
            this.SetParamSimple(map, prefix + "OutOrderId", this.OutOrderId);
            this.SetParamSimple(map, prefix + "ChannelOrderId", this.ChannelOrderId);
            this.SetParamSimple(map, prefix + "ThirdPayOrderId", this.ThirdPayOrderId);
            this.SetParamSimple(map, prefix + "OrderStatus", this.OrderStatus);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "PaymentMethod", this.PaymentMethod);
            this.SetParamSimple(map, prefix + "TotalAmount", this.TotalAmount);
            this.SetParamSimple(map, prefix + "PayAmount", this.PayAmount);
            this.SetParamSimple(map, prefix + "FailReason", this.FailReason);
            this.SetParamSimple(map, prefix + "Attachment", this.Attachment);
            this.SetParamObj(map, prefix + "RedirectInfo.", this.RedirectInfo);
            this.SetParamSimple(map, prefix + "ExternalReturnData", this.ExternalReturnData);
            this.SetParamObj(map, prefix + "BankApprovalGuideInfo.", this.BankApprovalGuideInfo);
            this.SetParamSimple(map, prefix + "FeeAmount", this.FeeAmount);
            this.SetParamSimple(map, prefix + "FeeRate", this.FeeRate);
            this.SetParamArrayObj(map, prefix + "ProfitShareRespInfoList.", this.ProfitShareRespInfoList);
            this.SetParamSimple(map, prefix + "TimeFinish", this.TimeFinish);
        }
    }
}

