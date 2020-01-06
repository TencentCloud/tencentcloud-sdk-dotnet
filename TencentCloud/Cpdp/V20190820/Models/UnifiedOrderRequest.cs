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

    public class UnifiedOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// ISO 货币代码，CNY
        /// </summary>
        [JsonProperty("CurrencyType")]
        public string CurrencyType{ get; set; }

        /// <summary>
        /// 聚鑫分配的支付主MidasAppid
        /// </summary>
        [JsonProperty("MidasAppId")]
        public string MidasAppId{ get; set; }

        /// <summary>
        /// 支付订单号，仅支持数字、字母、下划线（_）、横杠字符（-）、点（.）的组合
        /// </summary>
        [JsonProperty("OutTradeNo")]
        public string OutTradeNo{ get; set; }

        /// <summary>
        /// 商品详情，需要URL编码
        /// </summary>
        [JsonProperty("ProductDetail")]
        public string ProductDetail{ get; set; }

        /// <summary>
        /// 商品id，仅支持数字、字母、下划线（_）、横杠字符（-）、点（.）的组合
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 商品名称，需要URL编码
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 支付金额，单位： 分
        /// </summary>
        [JsonProperty("TotalAmt")]
        public long? TotalAmt{ get; set; }

        /// <summary>
        /// 用户Id，长度不小于5位，仅支持字母和数字的组合
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 银行真实渠道.如:bank_ccb
        /// </summary>
        [JsonProperty("RealChannel")]
        public string RealChannel{ get; set; }

        /// <summary>
        /// 子订单信息列表，格式：子订单号、子应用Id、金额。 压缩后最长不可超过65535字节(去除空格，换行，制表符等无意义字符)
        /// </summary>
        [JsonProperty("SubOrderList")]
        public UnifiedOrderInSubOrderList[] SubOrderList{ get; set; }

        /// <summary>
        /// 原始金额
        /// </summary>
        [JsonProperty("OriginalAmt")]
        public long? OriginalAmt{ get; set; }

        /// <summary>
        /// 聚鑫分配的安全ID
        /// </summary>
        [JsonProperty("MidasSecretId")]
        public string MidasSecretId{ get; set; }

        /// <summary>
        /// 按照聚鑫安全密钥计算的签名
        /// </summary>
        [JsonProperty("MidasSignature")]
        public string MidasSignature{ get; set; }

        /// <summary>
        /// Web端回调地址
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 指定支付渠道：  wechat：微信支付  qqwallet：QQ钱包 
        ///  bank：网银支付  只有一个渠道时需要指定
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }

        /// <summary>
        /// 透传字段，支付成功回调透传给应用，用于业务透传自定义内容
        /// </summary>
        [JsonProperty("Metadata")]
        public string Metadata{ get; set; }

        /// <summary>
        /// 购买数量，不传默认为1
        /// </summary>
        [JsonProperty("Quantity")]
        public long? Quantity{ get; set; }

        /// <summary>
        /// 聚鑫计费SubAppId，代表子商户
        /// </summary>
        [JsonProperty("SubAppId")]
        public string SubAppId{ get; set; }

        /// <summary>
        /// 结算应收金额，单位：分
        /// </summary>
        [JsonProperty("TotalMchIncome")]
        public long? TotalMchIncome{ get; set; }

        /// <summary>
        /// 平台应收金额，单位：分
        /// </summary>
        [JsonProperty("TotalPlatformIncome")]
        public long? TotalPlatformIncome{ get; set; }

        /// <summary>
        /// 微信公众号/小程序支付时为必选，需要传微信下的openid
        /// </summary>
        [JsonProperty("WxOpenId")]
        public string WxOpenId{ get; set; }

        /// <summary>
        /// 在服务商模式下，微信公众号/小程序支付时wx_sub_openid和wx_openid二选一
        /// </summary>
        [JsonProperty("WxSubOpenId")]
        public string WxSubOpenId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CurrencyType", this.CurrencyType);
            this.SetParamSimple(map, prefix + "MidasAppId", this.MidasAppId);
            this.SetParamSimple(map, prefix + "OutTradeNo", this.OutTradeNo);
            this.SetParamSimple(map, prefix + "ProductDetail", this.ProductDetail);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "TotalAmt", this.TotalAmt);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "RealChannel", this.RealChannel);
            this.SetParamArrayObj(map, prefix + "SubOrderList.", this.SubOrderList);
            this.SetParamSimple(map, prefix + "OriginalAmt", this.OriginalAmt);
            this.SetParamSimple(map, prefix + "MidasSecretId", this.MidasSecretId);
            this.SetParamSimple(map, prefix + "MidasSignature", this.MidasSignature);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "Metadata", this.Metadata);
            this.SetParamSimple(map, prefix + "Quantity", this.Quantity);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "TotalMchIncome", this.TotalMchIncome);
            this.SetParamSimple(map, prefix + "TotalPlatformIncome", this.TotalPlatformIncome);
            this.SetParamSimple(map, prefix + "WxOpenId", this.WxOpenId);
            this.SetParamSimple(map, prefix + "WxSubOpenId", this.WxSubOpenId);
        }
    }
}

