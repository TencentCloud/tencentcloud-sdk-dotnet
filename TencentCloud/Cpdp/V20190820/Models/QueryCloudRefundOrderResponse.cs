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

    public class QueryCloudRefundOrderResponse : AbstractModel
    {
        
        /// <summary>
        /// 该笔退款订单对应的UnifiedOrder下单时传入的OutTradeNo
        /// </summary>
        [JsonProperty("OutTradeNo")]
        public string OutTradeNo{ get; set; }

        /// <summary>
        /// 该笔退款订单对应的支付成功后支付机构返回的支付订单号
        /// </summary>
        [JsonProperty("ChannelExternalOrderId")]
        public string ChannelExternalOrderId{ get; set; }

        /// <summary>
        /// 该笔退款订单退款后支付机构返回的退款单号
        /// </summary>
        [JsonProperty("ChannelExternalRefundId")]
        public string ChannelExternalRefundId{ get; set; }

        /// <summary>
        /// 内部请求微信支付、银行等支付机构的订单号
        /// </summary>
        [JsonProperty("ChannelOrderId")]
        public string ChannelOrderId{ get; set; }

        /// <summary>
        /// 请求退款时传的退款ID后查询退款时传的RefundId
        /// </summary>
        [JsonProperty("RefundId")]
        public string RefundId{ get; set; }

        /// <summary>
        /// 被使用的RefundId，业务可忽略该字段
        /// </summary>
        [JsonProperty("UsedRefundId")]
        public string UsedRefundId{ get; set; }

        /// <summary>
        /// 退款总金额
        /// </summary>
        [JsonProperty("TotalRefundAmt")]
        public long? TotalRefundAmt{ get; set; }

        /// <summary>
        /// ISO货币代码
        /// </summary>
        [JsonProperty("CurrencyType")]
        public string CurrencyType{ get; set; }

        /// <summary>
        /// 退款状态码，退款提交成功后返回
        /// 1:退款中
        /// 2:退款成功
        /// 3:退款失败
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 子单退款信息列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubRefundList")]
        public CloudSubRefundItem[] SubRefundList{ get; set; }

        /// <summary>
        /// 透传字段，退款成功回调透传给应用，用于开发者透传自定义内容
        /// </summary>
        [JsonProperty("Metadata")]
        public string Metadata{ get; set; }

        /// <summary>
        /// 米大师分配的支付主MidasAppId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 该笔退款订单退款后内部返回的退款单号
        /// </summary>
        [JsonProperty("ChannelRefundId")]
        public string ChannelRefundId{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OutTradeNo", this.OutTradeNo);
            this.SetParamSimple(map, prefix + "ChannelExternalOrderId", this.ChannelExternalOrderId);
            this.SetParamSimple(map, prefix + "ChannelExternalRefundId", this.ChannelExternalRefundId);
            this.SetParamSimple(map, prefix + "ChannelOrderId", this.ChannelOrderId);
            this.SetParamSimple(map, prefix + "RefundId", this.RefundId);
            this.SetParamSimple(map, prefix + "UsedRefundId", this.UsedRefundId);
            this.SetParamSimple(map, prefix + "TotalRefundAmt", this.TotalRefundAmt);
            this.SetParamSimple(map, prefix + "CurrencyType", this.CurrencyType);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamArrayObj(map, prefix + "SubRefundList.", this.SubRefundList);
            this.SetParamSimple(map, prefix + "Metadata", this.Metadata);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "ChannelRefundId", this.ChannelRefundId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

