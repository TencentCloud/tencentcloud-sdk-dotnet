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

    public class QueryOrderStatusResult : AbstractModel
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
        /// 开始交易时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TradeTime")]
        public string TradeTime{ get; set; }

        /// <summary>
        /// 折扣金额（以分为单位，没有小数点）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiscountAmount")]
        public string DiscountAmount{ get; set; }

        /// <summary>
        /// 商户号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MerchantNo")]
        public string MerchantNo{ get; set; }

        /// <summary>
        /// 订单备注
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 订单标题
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrderName")]
        public string OrderName{ get; set; }

        /// <summary>
        /// 原始金额（以分为单位，没有小数点）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginalAmount")]
        public string OriginalAmount{ get; set; }

        /// <summary>
        /// 门店编号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShopNo")]
        public string ShopNo{ get; set; }

        /// <summary>
        /// 收单机构原始交易数据，如果返回非标准json数据，请自行转换
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TradeResult")]
        public string TradeResult{ get; set; }

        /// <summary>
        /// 订单流水号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 订单类型（1消费，2辙单）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrderType")]
        public string OrderType{ get; set; }

        /// <summary>
        /// 收单机构交易号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TradeNo")]
        public string TradeNo{ get; set; }

        /// <summary>
        /// 原始订单号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginalOrderNo")]
        public string OriginalOrderNo{ get; set; }

        /// <summary>
        /// 订单标记，订单附加数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// 下单时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// 收银员编号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CashierId")]
        public string CashierId{ get; set; }

        /// <summary>
        /// 收银员名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CashierRealName")]
        public string CashierRealName{ get; set; }

        /// <summary>
        /// 店铺全称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShopFullName")]
        public string ShopFullName{ get; set; }

        /// <summary>
        /// 店铺名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShopName")]
        public string ShopName{ get; set; }


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
            this.SetParamSimple(map, prefix + "TradeTime", this.TradeTime);
            this.SetParamSimple(map, prefix + "DiscountAmount", this.DiscountAmount);
            this.SetParamSimple(map, prefix + "MerchantNo", this.MerchantNo);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "OrderName", this.OrderName);
            this.SetParamSimple(map, prefix + "OriginalAmount", this.OriginalAmount);
            this.SetParamSimple(map, prefix + "ShopNo", this.ShopNo);
            this.SetParamSimple(map, prefix + "TradeResult", this.TradeResult);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "TradeNo", this.TradeNo);
            this.SetParamSimple(map, prefix + "OriginalOrderNo", this.OriginalOrderNo);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "CashierId", this.CashierId);
            this.SetParamSimple(map, prefix + "CashierRealName", this.CashierRealName);
            this.SetParamSimple(map, prefix + "ShopFullName", this.ShopFullName);
            this.SetParamSimple(map, prefix + "ShopName", this.ShopName);
        }
    }
}

