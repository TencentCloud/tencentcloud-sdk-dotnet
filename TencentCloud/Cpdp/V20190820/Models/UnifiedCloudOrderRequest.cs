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

    public class UnifiedCloudOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 米大师分配的支付主MidasAppId
        /// </summary>
        [JsonProperty("MidasAppId")]
        public string MidasAppId{ get; set; }

        /// <summary>
        /// 用户Id。
        /// 长度不小于5位，仅支持字母和数字的组合，长度限制以具体接入渠道为准
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 开发者主订单号。
        /// 支付订单号，仅支持数字、字母、下划线（_）、横杠字符（-）、点（.）的组合，长度供参考，部分渠道存在长度更短的情况接入时请联系开发咨询
        /// </summary>
        [JsonProperty("OutTradeNo")]
        public string OutTradeNo{ get; set; }

        /// <summary>
        /// 货币类型。
        /// ISO货币代码，CNY
        /// </summary>
        [JsonProperty("CurrencyType")]
        public string CurrencyType{ get; set; }

        /// <summary>
        /// 商品Id。
        /// 业务自定义的商品id，仅支持数字、字母、下划线（_）、横杠字符（-）、点（.）的组合。
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 商品名称。
        /// 业务自定义的商品名称，无需URL编码，长度限制以具体所接入渠道为准。
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 商品详情。
        /// 业务自定义的商品详情，无需URL编码，长度限制以具体所接入渠道为准。
        /// </summary>
        [JsonProperty("ProductDetail")]
        public string ProductDetail{ get; set; }

        /// <summary>
        /// 原始金额。
        /// 单位：分，需要注意的是，OriginalAmt>=TotalAmt
        /// </summary>
        [JsonProperty("OriginalAmt")]
        public long? OriginalAmt{ get; set; }

        /// <summary>
        /// 支付金额。
        /// 单位：分，需要注意的是，TotalAmt=TotalPlatformIncome+TotalMchIncome。
        /// </summary>
        [JsonProperty("TotalAmt")]
        public long? TotalAmt{ get; set; }

        /// <summary>
        /// 环境类型
        /// __release__:生产环境
        /// __sandbox__:沙箱环境
        /// _不填默认为生产环境_
        /// </summary>
        [JsonProperty("MidasEnvironment")]
        public string MidasEnvironment{ get; set; }

        /// <summary>
        /// 支付SubAppId。
        /// 米大师计费SubAppId，代表子商户。指定使用该商户的商户号下单时必传。
        /// </summary>
        [JsonProperty("SubAppId")]
        public string SubAppId{ get; set; }

        /// <summary>
        /// 顶层支付渠道。
        /// 银行收单:
        /// openbank_ccb: 建设银行
        /// openbank_icbc: 工商银行
        /// openbank_cmb: 招商银行
        /// openbank_ping: 平安银行
        /// openbank_icbc_jft：工商银行聚付通
        /// 非银行收单，可以为空
        /// </summary>
        [JsonProperty("RealChannel")]
        public string RealChannel{ get; set; }

        /// <summary>
        /// 支付渠道。
        /// wechat：微信支付
        /// wechat_ecommerce: 微信电商收付通
        /// open_alipay: 支付宝
        /// open_quickpass: 银联云闪付
        /// icbc_epay: 工银e支付
        /// foreign_cardpay: 外卡支付
        /// icbc_jft_wechat: 工行聚付通-微信
        /// icbc_jft_alipay: 工行聚付通-支付宝
        /// icbc_jft_epay: 工行聚付通-e支付
        /// 指定渠道下单时必传
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }

        /// <summary>
        /// 透传字段。
        /// 支付成功回调透传给应用，用于开发者透传自定义内容。
        /// </summary>
        [JsonProperty("Metadata")]
        public string Metadata{ get; set; }

        /// <summary>
        /// 数量。
        /// 购买数量,不传默认为1。
        /// </summary>
        [JsonProperty("Quantity")]
        public long? Quantity{ get; set; }

        /// <summary>
        /// Web端回调地址。
        /// Web端网页回调地址，仅当Web端SDK使用页面跳转方式时有效。
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 支付取消地址。
        /// </summary>
        [JsonProperty("CancelUrl")]
        public string CancelUrl{ get; set; }

        /// <summary>
        /// 微信AppId。
        /// wechat渠道或wchat_ecommerce渠道可以指定下单时的wxappid。
        /// </summary>
        [JsonProperty("WxAppId")]
        public string WxAppId{ get; set; }

        /// <summary>
        /// 微信SubAppId。
        /// wechat渠道可以指定下单时的sub_appid。
        /// </summary>
        [JsonProperty("WxSubAppId")]
        public string WxSubAppId{ get; set; }

        /// <summary>
        /// 微信公众号/小程序OpenId。
        /// 微信公众号/小程序支付时为必选，需要传微信下的openid。
        /// </summary>
        [JsonProperty("WxOpenId")]
        public string WxOpenId{ get; set; }

        /// <summary>
        /// 微信公众号/小程序SubOpenId。
        /// 在服务商模式下，微信公众号/小程序支付时wx_sub_openid和wx_openid二选一。
        /// </summary>
        [JsonProperty("WxSubOpenId")]
        public string WxSubOpenId{ get; set; }

        /// <summary>
        /// 平台应收金额。
        /// 单位：分，需要注意的是，TotalAmt=TotalPlatformIncome+TotalMchIncome
        /// </summary>
        [JsonProperty("TotalPlatformIncome")]
        public long? TotalPlatformIncome{ get; set; }

        /// <summary>
        /// 结算应收金额。
        /// 单位：分，需要注意的是，TotalAmt=TotalPlatformIncome+TotalMchIncome
        /// </summary>
        [JsonProperty("TotalMchIncome")]
        public long? TotalMchIncome{ get; set; }

        /// <summary>
        /// 子订单列表。
        /// 格式：子订单号、子应用Id、金额。压缩后最长不可超过32K字节(去除空格，换行，制表符等无意义字符)。
        /// </summary>
        [JsonProperty("SubOrderList")]
        public CloudSubOrder[] SubOrderList{ get; set; }

        /// <summary>
        /// 结算信息。
        /// 例如是否需要分账、是否需要支付确认等，
        /// 注意：如果子单列表中传入了SettleInfo，在主单中不可再传入SettleInfo字段。
        /// </summary>
        [JsonProperty("SettleInfo")]
        public CloudSettleInfo SettleInfo{ get; set; }

        /// <summary>
        /// 附加项信息列表。
        /// 例如溢价信息、抵扣信息、积分信息、补贴信息
        /// 通过该字段可以实现渠道方的优惠抵扣补贴等营销功能
        /// 注意：当传SubOrderList时，请在子单信息中传附加项信息，不要在主单中传该字段。
        /// </summary>
        [JsonProperty("AttachmentInfoList")]
        public CloudAttachmentInfo[] AttachmentInfoList{ get; set; }

        /// <summary>
        /// 支付通知地址。
        /// 调用方可通过该字段传入自定义支付通知地址。
        /// </summary>
        [JsonProperty("PaymentNotifyUrl")]
        public string PaymentNotifyUrl{ get; set; }

        /// <summary>
        /// 支付场景。
        /// 需要结合 RealChannel和Channel字段使用可选值:
        /// wechat-app 微信APP支付方式
        /// wechat-mini 微信小程序支付，示例：当 RealChannel=wechat Channel=wechat PayScene=wechat-mini时，内部会直接以小程序方式调用微信统一下单接口。
        /// </summary>
        [JsonProperty("PayScene")]
        public string PayScene{ get; set; }

        /// <summary>
        /// 语言代码。
        /// (BCP-47格式)，取值请参考https://mpay.pages.woa.com/zh/api/objectdefinitions/objects/#mpayapisordersapplicationcontextapplicationcontext
        /// </summary>
        [JsonProperty("LocaleCode")]
        public string LocaleCode{ get; set; }

        /// <summary>
        /// 地区代码。
        /// 取值请参考https://mpay.pages.woa.com/zh/api/objectdefinitions/objects/#mpayapisordersapplicationcontextapplicationcontext
        /// </summary>
        [JsonProperty("RegionCode")]
        public string RegionCode{ get; set; }

        /// <summary>
        /// 用户IP。
        /// 请求用户的IP地址，特定的渠道或特定的支付方式，此字段为必填
        /// wechat_ecommerce渠道 - h5支付方式，此字段必填。
        /// </summary>
        [JsonProperty("UserClientIp")]
        public string UserClientIp{ get; set; }

        /// <summary>
        /// 渠道订单号生成模式。
        /// 枚举值。决定请求渠道方时的订单号的生成模式，详情请联系米大师沟通。不指定时默认为由米大师自行生成。
        /// </summary>
        [JsonProperty("ChannelOrderIdMode")]
        public string ChannelOrderIdMode{ get; set; }

        /// <summary>
        /// 全局支付时间信息。
        /// </summary>
        [JsonProperty("GlobalPayTimeInfo")]
        public CloudGlobalPayTimeInfo GlobalPayTimeInfo{ get; set; }

        /// <summary>
        /// 渠道应用Id取用方式。
        /// USE_APPID 使用渠道应用Id;
        /// USE_SUB_APPID 使用子渠道应用Id;
        /// USE_APPID_AND_SUB_APPID 既使用渠道应用Id也使用子渠道应用ID。
        /// </summary>
        [JsonProperty("ChannelAppIdPolicy")]
        public string ChannelAppIdPolicy{ get; set; }

        /// <summary>
        /// 门店信息。
        /// 特定的渠道或特定的支付方式，此字段为必填
        /// wechat_ecommerce渠道 - h5支付方式，此字段必填
        /// </summary>
        [JsonProperty("StoreInfo")]
        public CloudStoreInfo StoreInfo{ get; set; }

        /// <summary>
        /// 客户端信息。
        /// 特定的渠道或特定的支付方式，此字段为必填
        /// wechat_ecommerce渠道 - h5支付方式，此字段必填
        /// </summary>
        [JsonProperty("ClientInfo")]
        public CloudClientInfo ClientInfo{ get; set; }

        /// <summary>
        /// 渠道扩展促销列表。
        /// 可将各个渠道的促销信息放于该列表。
        /// </summary>
        [JsonProperty("ExternalPromptGroupList")]
        public CloudExternalPromptGroup[] ExternalPromptGroupList{ get; set; }

        /// <summary>
        /// 收单模式。
        /// ORDER_RECEIVE_MODE_COMMON - 普通支付
        /// ORDER_RECEIVE_MODE_COMBINE - 合单支付
        /// ORDER_RECEIVE_MODE_V_COMBINE - 虚拟合单支付
        /// 若不传入该字段，则会根据是否传入子单来判断是 普通支付 还是 合单支付
        /// </summary>
        [JsonProperty("OrderReceiveMode")]
        public string OrderReceiveMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MidasAppId", this.MidasAppId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "OutTradeNo", this.OutTradeNo);
            this.SetParamSimple(map, prefix + "CurrencyType", this.CurrencyType);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "ProductDetail", this.ProductDetail);
            this.SetParamSimple(map, prefix + "OriginalAmt", this.OriginalAmt);
            this.SetParamSimple(map, prefix + "TotalAmt", this.TotalAmt);
            this.SetParamSimple(map, prefix + "MidasEnvironment", this.MidasEnvironment);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "RealChannel", this.RealChannel);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "Metadata", this.Metadata);
            this.SetParamSimple(map, prefix + "Quantity", this.Quantity);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "CancelUrl", this.CancelUrl);
            this.SetParamSimple(map, prefix + "WxAppId", this.WxAppId);
            this.SetParamSimple(map, prefix + "WxSubAppId", this.WxSubAppId);
            this.SetParamSimple(map, prefix + "WxOpenId", this.WxOpenId);
            this.SetParamSimple(map, prefix + "WxSubOpenId", this.WxSubOpenId);
            this.SetParamSimple(map, prefix + "TotalPlatformIncome", this.TotalPlatformIncome);
            this.SetParamSimple(map, prefix + "TotalMchIncome", this.TotalMchIncome);
            this.SetParamArrayObj(map, prefix + "SubOrderList.", this.SubOrderList);
            this.SetParamObj(map, prefix + "SettleInfo.", this.SettleInfo);
            this.SetParamArrayObj(map, prefix + "AttachmentInfoList.", this.AttachmentInfoList);
            this.SetParamSimple(map, prefix + "PaymentNotifyUrl", this.PaymentNotifyUrl);
            this.SetParamSimple(map, prefix + "PayScene", this.PayScene);
            this.SetParamSimple(map, prefix + "LocaleCode", this.LocaleCode);
            this.SetParamSimple(map, prefix + "RegionCode", this.RegionCode);
            this.SetParamSimple(map, prefix + "UserClientIp", this.UserClientIp);
            this.SetParamSimple(map, prefix + "ChannelOrderIdMode", this.ChannelOrderIdMode);
            this.SetParamObj(map, prefix + "GlobalPayTimeInfo.", this.GlobalPayTimeInfo);
            this.SetParamSimple(map, prefix + "ChannelAppIdPolicy", this.ChannelAppIdPolicy);
            this.SetParamObj(map, prefix + "StoreInfo.", this.StoreInfo);
            this.SetParamObj(map, prefix + "ClientInfo.", this.ClientInfo);
            this.SetParamArrayObj(map, prefix + "ExternalPromptGroupList.", this.ExternalPromptGroupList);
            this.SetParamSimple(map, prefix + "OrderReceiveMode", this.OrderReceiveMode);
        }
    }
}

