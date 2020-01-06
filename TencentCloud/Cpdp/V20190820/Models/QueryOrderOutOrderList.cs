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

    public class QueryOrderOutOrderList : AbstractModel
    {
        
        /// <summary>
        /// 聚鑫分配的支付主MidasAppId
        /// </summary>
        [JsonProperty("MidasAppId")]
        public string MidasAppId{ get; set; }

        /// <summary>
        /// 支付金额，单位：分
        /// </summary>
        [JsonProperty("Amt")]
        public long? Amt{ get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 现金支付金额
        /// </summary>
        [JsonProperty("CashAmt")]
        public string CashAmt{ get; set; }

        /// <summary>
        /// 发货标识，由业务在调用聚鑫下单 接口的时候下发
        /// </summary>
        [JsonProperty("Metadata")]
        public string Metadata{ get; set; }

        /// <summary>
        /// 支付时间unix时间戳
        /// </summary>
        [JsonProperty("PayTime")]
        public string PayTime{ get; set; }

        /// <summary>
        /// 抵扣券金额
        /// </summary>
        [JsonProperty("CouponAmt")]
        public string CouponAmt{ get; set; }

        /// <summary>
        /// 下单时间unix时间戳
        /// </summary>
        [JsonProperty("OrderTime")]
        public string OrderTime{ get; set; }

        /// <summary>
        /// 物品id
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 高速场景信息
        /// </summary>
        [JsonProperty("SceneInfo")]
        public string SceneInfo{ get; set; }

        /// <summary>
        /// 当前订单的订单状态 
        /// 0：初始状态，获取聚鑫交易订单成功；  
        /// 1：拉起聚鑫支付页面成功，用户未 支付；
        /// 2：用户支付成功，正在发货；
        /// 3：用户支付成功，发货失败；
        /// 4：用户支付成功，发货成功；
        /// 5：聚鑫支付页面正在失效中；
        /// 6：聚鑫支付页面已经失效；
        /// </summary>
        [JsonProperty("OrderState")]
        public string OrderState{ get; set; }

        /// <summary>
        /// 支付渠道：wechat：微信支付;
        /// qqwallet：QQ钱包;
        /// bank：网银
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }

        /// <summary>
        /// 是否曾退款
        /// </summary>
        [JsonProperty("RefundFlag")]
        public string RefundFlag{ get; set; }

        /// <summary>
        /// 务支付订单号
        /// </summary>
        [JsonProperty("OutTradeNo")]
        public string OutTradeNo{ get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 支付回调时间，unix时间戳
        /// </summary>
        [JsonProperty("CallBackTime")]
        public string CallBackTime{ get; set; }

        /// <summary>
        /// ISO 货币代码，CNY
        /// </summary>
        [JsonProperty("CurrencyType")]
        public string CurrencyType{ get; set; }

        /// <summary>
        /// 微校场景账户Id
        /// </summary>
        [JsonProperty("AcctSubAppId")]
        public string AcctSubAppId{ get; set; }

        /// <summary>
        /// 调用下单接口获取的聚鑫交易订单
        /// </summary>
        [JsonProperty("TransactionId")]
        public string TransactionId{ get; set; }

        /// <summary>
        /// 聚鑫内部渠道订单号
        /// </summary>
        [JsonProperty("ChannelOrderId")]
        public string ChannelOrderId{ get; set; }

        /// <summary>
        /// 调用下单接口传进来的 SubOutTradeNoList
        /// </summary>
        [JsonProperty("SubOrderList")]
        public QueryOrderOutSubOrderList[] SubOrderList{ get; set; }

        /// <summary>
        /// 支付机构订单号
        /// </summary>
        [JsonProperty("ChannelExternalOrderId")]
        public string ChannelExternalOrderId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MidasAppId", this.MidasAppId);
            this.SetParamSimple(map, prefix + "Amt", this.Amt);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "CashAmt", this.CashAmt);
            this.SetParamSimple(map, prefix + "Metadata", this.Metadata);
            this.SetParamSimple(map, prefix + "PayTime", this.PayTime);
            this.SetParamSimple(map, prefix + "CouponAmt", this.CouponAmt);
            this.SetParamSimple(map, prefix + "OrderTime", this.OrderTime);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "SceneInfo", this.SceneInfo);
            this.SetParamSimple(map, prefix + "OrderState", this.OrderState);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "RefundFlag", this.RefundFlag);
            this.SetParamSimple(map, prefix + "OutTradeNo", this.OutTradeNo);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "CallBackTime", this.CallBackTime);
            this.SetParamSimple(map, prefix + "CurrencyType", this.CurrencyType);
            this.SetParamSimple(map, prefix + "AcctSubAppId", this.AcctSubAppId);
            this.SetParamSimple(map, prefix + "TransactionId", this.TransactionId);
            this.SetParamSimple(map, prefix + "ChannelOrderId", this.ChannelOrderId);
            this.SetParamArrayObj(map, prefix + "SubOrderList.", this.SubOrderList);
            this.SetParamSimple(map, prefix + "ChannelExternalOrderId", this.ChannelExternalOrderId);
        }
    }
}

