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

    public class CreateOpenBankUnifiedOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 渠道商户号。
        /// </summary>
        [JsonProperty("ChannelMerchantId")]
        public string ChannelMerchantId{ get; set; }

        /// <summary>
        /// 渠道名称。
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 支付产品类型。
        /// 被扫（扫码）：SWIPE, 主扫（刷卡）：SCAN, 
        /// H5：WAP, 公众号：PUBLIC, 
        /// APP-SDK：SDK, 小程序：MINI_PROGRAM, 
        /// 快捷支付：QUICK, 网银支付：ONLINE_BANK。
        /// </summary>
        [JsonProperty("PayType")]
        public string PayType{ get; set; }

        /// <summary>
        /// 外部商户订单号。
        /// 只能是数字、大小写字母，且在同一个接入平台下唯一。
        /// </summary>
        [JsonProperty("OutOrderId")]
        public string OutOrderId{ get; set; }

        /// <summary>
        /// 交易金额，单位分。
        /// </summary>
        [JsonProperty("TotalAmount")]
        public long? TotalAmount{ get; set; }

        /// <summary>
        /// 币种。固定：CNY。
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// 渠道子商户号。
        /// </summary>
        [JsonProperty("ChannelSubMerchantId")]
        public string ChannelSubMerchantId{ get; set; }

        /// <summary>
        /// 实际支付渠道。没有则无需填写。如
        /// 支付宝 ALIPAY
        /// 微信支付 WXPAY
        /// 银联 UNIONPAY
        /// 一般在间连模式下使用。
        /// </summary>
        [JsonProperty("PayChannel")]
        public string PayChannel{ get; set; }

        /// <summary>
        /// 设备信息。
        /// </summary>
        [JsonProperty("SceneInfo")]
        public OpenBankSceneInfo SceneInfo{ get; set; }

        /// <summary>
        /// 分账信息列表。
        /// </summary>
        [JsonProperty("ProfitShareInfoList")]
        public OpenBankProfitShareInfo[] ProfitShareInfoList{ get; set; }

        /// <summary>
        /// 订单标题。
        /// </summary>
        [JsonProperty("OrderSubject")]
        public string OrderSubject{ get; set; }

        /// <summary>
        /// 商品信息。
        /// </summary>
        [JsonProperty("GoodsDetail")]
        public string GoodsDetail{ get; set; }

        /// <summary>
        /// 超时时间。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 支付成功回调地址。
        /// </summary>
        [JsonProperty("NotifyUrl")]
        public string NotifyUrl{ get; set; }

        /// <summary>
        /// 支付成功前端跳转URL。
        /// </summary>
        [JsonProperty("FrontUrl")]
        public string FrontUrl{ get; set; }

        /// <summary>
        /// 订单附加信息，查询或者回调的时候原样返回。
        /// </summary>
        [JsonProperty("Attachment")]
        public string Attachment{ get; set; }

        /// <summary>
        /// 第三方渠道扩展字段。见附录-复杂类型。
        /// 未作特殊说明，则无需传入。
        /// </summary>
        [JsonProperty("ExternalPaymentData")]
        public string ExternalPaymentData{ get; set; }

        /// <summary>
        /// 备注。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 门店信息。
        /// </summary>
        [JsonProperty("StoreInfo")]
        public OpenBankStoreInfo StoreInfo{ get; set; }

        /// <summary>
        /// 支付限制。
        /// </summary>
        [JsonProperty("PayLimitInfo")]
        public OpenBankPayLimitInfo PayLimitInfo{ get; set; }

        /// <summary>
        /// 环境类型。
        /// __release__:生产环境
        /// __sandbox__:沙箱环境
        /// _不填默认为生产环境_
        /// </summary>
        [JsonProperty("Environment")]
        public string Environment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelMerchantId", this.ChannelMerchantId);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "OutOrderId", this.OutOrderId);
            this.SetParamSimple(map, prefix + "TotalAmount", this.TotalAmount);
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
            this.SetParamSimple(map, prefix + "ChannelSubMerchantId", this.ChannelSubMerchantId);
            this.SetParamSimple(map, prefix + "PayChannel", this.PayChannel);
            this.SetParamObj(map, prefix + "SceneInfo.", this.SceneInfo);
            this.SetParamArrayObj(map, prefix + "ProfitShareInfoList.", this.ProfitShareInfoList);
            this.SetParamSimple(map, prefix + "OrderSubject", this.OrderSubject);
            this.SetParamSimple(map, prefix + "GoodsDetail", this.GoodsDetail);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "NotifyUrl", this.NotifyUrl);
            this.SetParamSimple(map, prefix + "FrontUrl", this.FrontUrl);
            this.SetParamSimple(map, prefix + "Attachment", this.Attachment);
            this.SetParamSimple(map, prefix + "ExternalPaymentData", this.ExternalPaymentData);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamObj(map, prefix + "StoreInfo.", this.StoreInfo);
            this.SetParamObj(map, prefix + "PayLimitInfo.", this.PayLimitInfo);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
        }
    }
}

