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

    public class CloudOrderReturn : AbstractModel
    {
        
        /// <summary>
        /// 米大师分配的支付主MidasAppId
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 开发者支付订单号
        /// </summary>
        [JsonProperty("OutTradeNo")]
        public string OutTradeNo{ get; set; }

        /// <summary>
        /// 调用下单接口传进来的子单列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubOrderList")]
        public CloudSubOrderReturn[] SubOrderList{ get; set; }

        /// <summary>
        /// 调用下单接口获取的米大师交易订单号
        /// </summary>
        [JsonProperty("TransactionId")]
        public string TransactionId{ get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 支付渠道
        /// wechat:微信支付
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }

        /// <summary>
        /// 物品Id
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 发货标识，由开发者在调用下单接口的时候传入
        /// </summary>
        [JsonProperty("Metadata")]
        public string Metadata{ get; set; }

        /// <summary>
        /// ISO货币代码
        /// </summary>
        [JsonProperty("CurrencyType")]
        public string CurrencyType{ get; set; }

        /// <summary>
        /// 支付金额，单位：分
        /// </summary>
        [JsonProperty("Amt")]
        public long? Amt{ get; set; }

        /// <summary>
        /// 订单状态
        /// 0:初始状态，获取米大师交易订单成功
        /// 1:拉起米大师支付页面成功，用户未支付
        /// 2:用户支付成功，正在发货
        /// 3:用户支付成功，发货失败
        /// 4:用户支付成功，发货成功
        /// 5:关单中
        /// 6:已关单
        /// </summary>
        [JsonProperty("OrderState")]
        public string OrderState{ get; set; }

        /// <summary>
        /// 下单时间，unix时间戳
        /// </summary>
        [JsonProperty("OrderTime")]
        public string OrderTime{ get; set; }

        /// <summary>
        /// 支付时间，unix时间戳
        /// </summary>
        [JsonProperty("PayTime")]
        public string PayTime{ get; set; }

        /// <summary>
        /// 支付回调时间，unix时间戳
        /// </summary>
        [JsonProperty("CallBackTime")]
        public string CallBackTime{ get; set; }

        /// <summary>
        /// 支付机构订单号
        /// </summary>
        [JsonProperty("ChannelExternalOrderId")]
        public string ChannelExternalOrderId{ get; set; }

        /// <summary>
        /// 米大师内部渠道订单号
        /// </summary>
        [JsonProperty("ChannelOrderId")]
        public string ChannelOrderId{ get; set; }

        /// <summary>
        /// 是否曾退款
        /// </summary>
        [JsonProperty("RefundFlag")]
        public string RefundFlag{ get; set; }

        /// <summary>
        /// 用户支付金额
        /// </summary>
        [JsonProperty("CashAmt")]
        public string CashAmt{ get; set; }

        /// <summary>
        /// 抵扣券金额
        /// </summary>
        [JsonProperty("CouponAmt")]
        public string CouponAmt{ get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 结算信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SettleInfo")]
        public CloudSettleInfo SettleInfo{ get; set; }

        /// <summary>
        /// 附加项信息列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttachmentInfoList")]
        public CloudAttachmentInfo[] AttachmentInfoList{ get; set; }

        /// <summary>
        /// 渠道方返回的用户信息列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelExternalUserInfoList")]
        public CloudChannelExternalUserInfo[] ChannelExternalUserInfoList{ get; set; }

        /// <summary>
        /// 渠道扩展促销列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalReturnPromptGroupList")]
        public CloudExternalPromptGroup[] ExternalReturnPromptGroupList{ get; set; }

        /// <summary>
        /// 场景扩展信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SceneInfo")]
        public string SceneInfo{ get; set; }

        /// <summary>
        /// 子应用ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubAppId")]
        public string SubAppId{ get; set; }

        /// <summary>
        /// 支付场景
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayScene")]
        public string PayScene{ get; set; }

        /// <summary>
        /// 支付方式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaymentMethod")]
        public string PaymentMethod{ get; set; }

        /// <summary>
        /// 平台应收金额
        /// 单位：分，需要注意的是，TotalAmt=TotalPlatformIncome+TotalMchIncome
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalPlatformIncome")]
        public long? TotalPlatformIncome{ get; set; }

        /// <summary>
        /// 商户应收金额
        /// 单位：分，需要注意的是，TotalAmt=TotalPlatformIncome+TotalMchIncome
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalMchIncome")]
        public long? TotalMchIncome{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "OutTradeNo", this.OutTradeNo);
            this.SetParamArrayObj(map, prefix + "SubOrderList.", this.SubOrderList);
            this.SetParamSimple(map, prefix + "TransactionId", this.TransactionId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "Metadata", this.Metadata);
            this.SetParamSimple(map, prefix + "CurrencyType", this.CurrencyType);
            this.SetParamSimple(map, prefix + "Amt", this.Amt);
            this.SetParamSimple(map, prefix + "OrderState", this.OrderState);
            this.SetParamSimple(map, prefix + "OrderTime", this.OrderTime);
            this.SetParamSimple(map, prefix + "PayTime", this.PayTime);
            this.SetParamSimple(map, prefix + "CallBackTime", this.CallBackTime);
            this.SetParamSimple(map, prefix + "ChannelExternalOrderId", this.ChannelExternalOrderId);
            this.SetParamSimple(map, prefix + "ChannelOrderId", this.ChannelOrderId);
            this.SetParamSimple(map, prefix + "RefundFlag", this.RefundFlag);
            this.SetParamSimple(map, prefix + "CashAmt", this.CashAmt);
            this.SetParamSimple(map, prefix + "CouponAmt", this.CouponAmt);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamObj(map, prefix + "SettleInfo.", this.SettleInfo);
            this.SetParamArrayObj(map, prefix + "AttachmentInfoList.", this.AttachmentInfoList);
            this.SetParamArrayObj(map, prefix + "ChannelExternalUserInfoList.", this.ChannelExternalUserInfoList);
            this.SetParamArrayObj(map, prefix + "ExternalReturnPromptGroupList.", this.ExternalReturnPromptGroupList);
            this.SetParamSimple(map, prefix + "SceneInfo", this.SceneInfo);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "PayScene", this.PayScene);
            this.SetParamSimple(map, prefix + "PaymentMethod", this.PaymentMethod);
            this.SetParamSimple(map, prefix + "TotalPlatformIncome", this.TotalPlatformIncome);
            this.SetParamSimple(map, prefix + "TotalMchIncome", this.TotalMchIncome);
        }
    }
}

