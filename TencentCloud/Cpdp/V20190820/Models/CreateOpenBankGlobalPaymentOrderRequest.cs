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

    public class CreateOpenBankGlobalPaymentOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 渠道商户号
        /// </summary>
        [JsonProperty("ChannelMerchantId")]
        public string ChannelMerchantId{ get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 付款方式
        /// </summary>
        [JsonProperty("PayType")]
        public string PayType{ get; set; }

        /// <summary>
        /// 外部商户订单号,只能是数字、大小写字母，且在同一个接入平台下唯一
        /// </summary>
        [JsonProperty("OutOrderId")]
        public string OutOrderId{ get; set; }

        /// <summary>
        /// 付款金额，单位分
        /// </summary>
        [JsonProperty("TotalAmount")]
        public long? TotalAmount{ get; set; }

        /// <summary>
        /// 支付币种，参考附录：货币代码
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// 渠道子商户号
        /// </summary>
        [JsonProperty("ChannelSubMerchantId")]
        public string ChannelSubMerchantId{ get; set; }

        /// <summary>
        /// 支付成功回调地址。
        /// </summary>
        [JsonProperty("NotifyUrl")]
        public string NotifyUrl{ get; set; }

        /// <summary>
        /// 前端跳转地址。通联支付成功后，支付网关跳回商户的地址
        /// </summary>
        [JsonProperty("FrontUrl")]
        public string FrontUrl{ get; set; }

        /// <summary>
        /// 网站语言。收银台显示语言，见附录网站语言
        /// </summary>
        [JsonProperty("FrontLanguage")]
        public string FrontLanguage{ get; set; }

        /// <summary>
        /// 付款备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 第三方拓展信息信息
        /// </summary>
        [JsonProperty("ExternalPaymentData")]
        public string ExternalPaymentData{ get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        [JsonProperty("GoodsInfos")]
        public OpenBankGoodsInfo[] GoodsInfos{ get; set; }

        /// <summary>
        /// 邮寄信息
        /// </summary>
        [JsonProperty("ShippingInfo")]
        public OpenBankShippingInfo ShippingInfo{ get; set; }

        /// <summary>
        /// 账单信息
        /// </summary>
        [JsonProperty("BillingInfo")]
        public OpenBankBillingInfo BillingInfo{ get; set; }


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
            this.SetParamSimple(map, prefix + "NotifyUrl", this.NotifyUrl);
            this.SetParamSimple(map, prefix + "FrontUrl", this.FrontUrl);
            this.SetParamSimple(map, prefix + "FrontLanguage", this.FrontLanguage);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ExternalPaymentData", this.ExternalPaymentData);
            this.SetParamArrayObj(map, prefix + "GoodsInfos.", this.GoodsInfos);
            this.SetParamObj(map, prefix + "ShippingInfo.", this.ShippingInfo);
            this.SetParamObj(map, prefix + "BillingInfo.", this.BillingInfo);
        }
    }
}

