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

    public class UnifiedTlinxOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 使用门店OpenId
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 使用门店OpenKey
        /// </summary>
        [JsonProperty("OpenKey")]
        public string OpenKey{ get; set; }

        /// <summary>
        /// 开发者流水号
        /// </summary>
        [JsonProperty("DeveloperNo")]
        public string DeveloperNo{ get; set; }

        /// <summary>
        /// 支付标签
        /// </summary>
        [JsonProperty("PayTag")]
        public string PayTag{ get; set; }

        /// <summary>
        /// 实际交易金额（以分为单位，没有小数点）
        /// </summary>
        [JsonProperty("TradeAmount")]
        public string TradeAmount{ get; set; }

        /// <summary>
        /// 交易结果异步通知url地址
        /// </summary>
        [JsonProperty("NotifyUrl")]
        public string NotifyUrl{ get; set; }

        /// <summary>
        /// 付款方式名称(当PayTag为Diy时，PayName不能为空)
        /// </summary>
        [JsonProperty("PayName")]
        public string PayName{ get; set; }

        /// <summary>
        /// 公众号支付时，支付成功后跳转url地址
        /// </summary>
        [JsonProperty("JumpUrl")]
        public string JumpUrl{ get; set; }

        /// <summary>
        /// 订单名称（描述）
        /// </summary>
        [JsonProperty("OrderName")]
        public string OrderName{ get; set; }

        /// <summary>
        /// 原始交易金额（以分为单位，没有小数点）
        /// </summary>
        [JsonProperty("OriginalAmount")]
        public string OriginalAmount{ get; set; }

        /// <summary>
        /// 抹零金额（以分为单位，没有小数点）
        /// </summary>
        [JsonProperty("IgnoreAmount")]
        public string IgnoreAmount{ get; set; }

        /// <summary>
        /// 折扣金额（以分为单位，没有小数点）
        /// </summary>
        [JsonProperty("DiscountAmount")]
        public string DiscountAmount{ get; set; }

        /// <summary>
        /// 交易帐号（银行卡号）
        /// </summary>
        [JsonProperty("TradeAccount")]
        public string TradeAccount{ get; set; }

        /// <summary>
        /// 交易号（收单机构交易号）
        /// </summary>
        [JsonProperty("TradeNo")]
        public string TradeNo{ get; set; }

        /// <summary>
        /// 条码支付的授权码（条码抢扫手机扫到的一串数字）
        /// </summary>
        [JsonProperty("AuthCode")]
        public string AuthCode{ get; set; }

        /// <summary>
        /// 订单标记，订单附加数据。
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 收单机构原始交易报文，请转换为json
        /// </summary>
        [JsonProperty("TradeResult")]
        public string TradeResult{ get; set; }

        /// <summary>
        /// 0-不分账，1-需分账。为1时标记为待分账订单，待分账订单不会进行清算。不传默认为不分账。
        /// </summary>
        [JsonProperty("Royalty")]
        public string Royalty{ get; set; }

        /// <summary>
        /// 小程序支付参数：填默认值 1
        /// </summary>
        [JsonProperty("Jsapi")]
        public string Jsapi{ get; set; }

        /// <summary>
        /// 小程序支付参数：
        /// 当前调起支付的小程序APPID
        /// </summary>
        [JsonProperty("SubAppId")]
        public string SubAppId{ get; set; }

        /// <summary>
        /// 小程序支付参数:
        /// 用户在子商户appid下的唯一标识。
        /// </summary>
        [JsonProperty("SubOpenId")]
        public string SubOpenId{ get; set; }

        /// <summary>
        /// 沙箱环境填sandbox，正式环境不填
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "OpenKey", this.OpenKey);
            this.SetParamSimple(map, prefix + "DeveloperNo", this.DeveloperNo);
            this.SetParamSimple(map, prefix + "PayTag", this.PayTag);
            this.SetParamSimple(map, prefix + "TradeAmount", this.TradeAmount);
            this.SetParamSimple(map, prefix + "NotifyUrl", this.NotifyUrl);
            this.SetParamSimple(map, prefix + "PayName", this.PayName);
            this.SetParamSimple(map, prefix + "JumpUrl", this.JumpUrl);
            this.SetParamSimple(map, prefix + "OrderName", this.OrderName);
            this.SetParamSimple(map, prefix + "OriginalAmount", this.OriginalAmount);
            this.SetParamSimple(map, prefix + "IgnoreAmount", this.IgnoreAmount);
            this.SetParamSimple(map, prefix + "DiscountAmount", this.DiscountAmount);
            this.SetParamSimple(map, prefix + "TradeAccount", this.TradeAccount);
            this.SetParamSimple(map, prefix + "TradeNo", this.TradeNo);
            this.SetParamSimple(map, prefix + "AuthCode", this.AuthCode);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "TradeResult", this.TradeResult);
            this.SetParamSimple(map, prefix + "Royalty", this.Royalty);
            this.SetParamSimple(map, prefix + "Jsapi", this.Jsapi);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "SubOpenId", this.SubOpenId);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
        }
    }
}

