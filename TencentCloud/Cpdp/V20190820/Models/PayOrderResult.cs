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

    public class PayOrderResult : AbstractModel
    {
        
        /// <summary>
        /// 付款订单号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrderNo")]
        public string OrderNo{ get; set; }

        /// <summary>
        /// 开发者流水号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeveloperNo")]
        public string DeveloperNo{ get; set; }

        /// <summary>
        /// 交易优惠金额（免充值券）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TradeDiscountAmount")]
        public string TradeDiscountAmount{ get; set; }

        /// <summary>
        /// 付款方式名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayName")]
        public string PayName{ get; set; }

        /// <summary>
        /// 商户流水号（从1开始自增长不重复）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrderMerchantId")]
        public string OrderMerchantId{ get; set; }

        /// <summary>
        /// 交易帐号（银行卡号、支付宝帐号、微信帐号等，某些收单机构没有此数据）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TradeAccount")]
        public string TradeAccount{ get; set; }

        /// <summary>
        /// 实际交易金额（以分为单位，没有小数点）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TradeAmount")]
        public string TradeAmount{ get; set; }

        /// <summary>
        /// 币种签名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurrencySign")]
        public string CurrencySign{ get; set; }

        /// <summary>
        /// 付款完成时间（以收单机构为准）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TradePayTime")]
        public string TradePayTime{ get; set; }

        /// <summary>
        /// 门店流水号（从1开始自增长不重复）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShopOrderId")]
        public string ShopOrderId{ get; set; }

        /// <summary>
        /// 支付标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayTag")]
        public string PayTag{ get; set; }

        /// <summary>
        /// 订单状态（1交易成功，2待支付，4已取消，9等待用户输入密码确认
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 币种代码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrderCurrency")]
        public string OrderCurrency{ get; set; }

        /// <summary>
        /// 二维码字符串
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TradeQrcode")]
        public string TradeQrcode{ get; set; }

        /// <summary>
        /// 微信返回调起小程序/原生JS支付的appid参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WechatAppId")]
        public string WechatAppId{ get; set; }

        /// <summary>
        /// 微信返回调起小程序/原生JS支付的timeStamp参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WechatTimeStamp")]
        public string WechatTimeStamp{ get; set; }

        /// <summary>
        /// 微信返回调起小程序/原生JS支付的nonceStr参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WechatNonceStr")]
        public string WechatNonceStr{ get; set; }

        /// <summary>
        /// 微信返回调起小程序/原生JS支付的signType参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WechatSignType")]
        public string WechatSignType{ get; set; }

        /// <summary>
        /// 微信返回调起小程序/原生JS支付的package参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WechatPackage")]
        public string WechatPackage{ get; set; }

        /// <summary>
        /// 微信返回调起小程序/原生JS支付的paySign参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WechatPaySign")]
        public string WechatPaySign{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrderNo", this.OrderNo);
            this.SetParamSimple(map, prefix + "DeveloperNo", this.DeveloperNo);
            this.SetParamSimple(map, prefix + "TradeDiscountAmount", this.TradeDiscountAmount);
            this.SetParamSimple(map, prefix + "PayName", this.PayName);
            this.SetParamSimple(map, prefix + "OrderMerchantId", this.OrderMerchantId);
            this.SetParamSimple(map, prefix + "TradeAccount", this.TradeAccount);
            this.SetParamSimple(map, prefix + "TradeAmount", this.TradeAmount);
            this.SetParamSimple(map, prefix + "CurrencySign", this.CurrencySign);
            this.SetParamSimple(map, prefix + "TradePayTime", this.TradePayTime);
            this.SetParamSimple(map, prefix + "ShopOrderId", this.ShopOrderId);
            this.SetParamSimple(map, prefix + "PayTag", this.PayTag);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "OrderCurrency", this.OrderCurrency);
            this.SetParamSimple(map, prefix + "TradeQrcode", this.TradeQrcode);
            this.SetParamSimple(map, prefix + "WechatAppId", this.WechatAppId);
            this.SetParamSimple(map, prefix + "WechatTimeStamp", this.WechatTimeStamp);
            this.SetParamSimple(map, prefix + "WechatNonceStr", this.WechatNonceStr);
            this.SetParamSimple(map, prefix + "WechatSignType", this.WechatSignType);
            this.SetParamSimple(map, prefix + "WechatPackage", this.WechatPackage);
            this.SetParamSimple(map, prefix + "WechatPaySign", this.WechatPaySign);
        }
    }
}

