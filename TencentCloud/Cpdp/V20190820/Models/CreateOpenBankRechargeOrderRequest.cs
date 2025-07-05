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

    public class CreateOpenBankRechargeOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 云企付渠道商户号。外部接入平台入驻云企付平台后下发。
        /// </summary>
        [JsonProperty("ChannelMerchantId")]
        public string ChannelMerchantId{ get; set; }

        /// <summary>
        /// 外部订单号,只能是数字、大小写字母，且在同一个接入平台下唯一，限定长度40位。
        /// </summary>
        [JsonProperty("OutOrderId")]
        public string OutOrderId{ get; set; }

        /// <summary>
        /// 付款金额，单位分。
        /// </summary>
        [JsonProperty("TotalAmount")]
        public long? TotalAmount{ get; set; }

        /// <summary>
        /// 固定值CNY。
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// 订单过期时间，yyyy-MM-dd HH:mm:ss格式。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 渠道名称。
        /// __TENPAY__: 商企付
        /// __WECHAT__: 微信支付
        /// __ALIPAY__: 支付宝
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 渠道名称。
        /// __TENPAY__: 商企付
        /// __WECHAT__: 微信支付
        /// __ALIPAY__: 支付宝
        /// </summary>
        [JsonProperty("PaymentMethod")]
        public string PaymentMethod{ get; set; }

        /// <summary>
        /// 收款方信息。
        /// </summary>
        [JsonProperty("PayeeInfo")]
        public OpenBankRechargePayeeInfo PayeeInfo{ get; set; }

        /// <summary>
        /// 渠道子商户号
        /// </summary>
        [JsonProperty("ChannelSubMerchantId")]
        public string ChannelSubMerchantId{ get; set; }

        /// <summary>
        /// 通知地址，如www.test.com。
        /// </summary>
        [JsonProperty("NotifyUrl")]
        public string NotifyUrl{ get; set; }

        /// <summary>
        /// 备注信息。限制200个字符。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

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
            this.SetParamSimple(map, prefix + "OutOrderId", this.OutOrderId);
            this.SetParamSimple(map, prefix + "TotalAmount", this.TotalAmount);
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "PaymentMethod", this.PaymentMethod);
            this.SetParamObj(map, prefix + "PayeeInfo.", this.PayeeInfo);
            this.SetParamSimple(map, prefix + "ChannelSubMerchantId", this.ChannelSubMerchantId);
            this.SetParamSimple(map, prefix + "NotifyUrl", this.NotifyUrl);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
        }
    }
}

