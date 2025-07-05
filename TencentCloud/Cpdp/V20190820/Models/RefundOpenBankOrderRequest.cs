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

    public class RefundOpenBankOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 外部商户退款单号。
        /// </summary>
        [JsonProperty("OutRefundId")]
        public string OutRefundId{ get; set; }

        /// <summary>
        /// 退款金额。单位分。
        /// </summary>
        [JsonProperty("RefundAmount")]
        public long? RefundAmount{ get; set; }

        /// <summary>
        /// 渠道商户号。外部平台接入云企付平台下发。必填。
        /// </summary>
        [JsonProperty("ChannelMerchantId")]
        public string ChannelMerchantId{ get; set; }

        /// <summary>
        /// 外部商户订单号，与云企付渠道订单号二者不能同时为空。
        /// </summary>
        [JsonProperty("OutOrderId")]
        public string OutOrderId{ get; set; }

        /// <summary>
        /// 云企付渠道订单号，与外部订单号二者不能同时为空。
        /// </summary>
        [JsonProperty("ChannelOrderId")]
        public string ChannelOrderId{ get; set; }

        /// <summary>
        /// 退款通知地址。
        /// </summary>
        [JsonProperty("NotifyUrl")]
        public string NotifyUrl{ get; set; }

        /// <summary>
        /// 退款原因。
        /// 当EBANK_PAYMENT担保支付订单退款时，此字段必传。
        /// </summary>
        [JsonProperty("RefundReason")]
        public string RefundReason{ get; set; }

        /// <summary>
        /// 第三方渠道退款附加信息。详见附录-复杂类型。
        /// 若未作特殊说明，则无需传入。
        /// </summary>
        [JsonProperty("ExternalRefundData")]
        public string ExternalRefundData{ get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 环境类型。
        /// __release__:生产环境
        /// __sandbox__:沙箱环境
        /// _不填默认为生产环境_
        /// </summary>
        [JsonProperty("Environment")]
        public string Environment{ get; set; }

        /// <summary>
        /// 分账信息列表。
        /// </summary>
        [JsonProperty("ProfitShareInfoList")]
        public OpenBankProfitShareInfo[] ProfitShareInfoList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OutRefundId", this.OutRefundId);
            this.SetParamSimple(map, prefix + "RefundAmount", this.RefundAmount);
            this.SetParamSimple(map, prefix + "ChannelMerchantId", this.ChannelMerchantId);
            this.SetParamSimple(map, prefix + "OutOrderId", this.OutOrderId);
            this.SetParamSimple(map, prefix + "ChannelOrderId", this.ChannelOrderId);
            this.SetParamSimple(map, prefix + "NotifyUrl", this.NotifyUrl);
            this.SetParamSimple(map, prefix + "RefundReason", this.RefundReason);
            this.SetParamSimple(map, prefix + "ExternalRefundData", this.ExternalRefundData);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
            this.SetParamArrayObj(map, prefix + "ProfitShareInfoList.", this.ProfitShareInfoList);
        }
    }
}

