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

    public class MigrateOrderRefundRequest : AbstractModel
    {
        
        /// <summary>
        /// 商户代码
        /// </summary>
        [JsonProperty("MerchantId")]
        public string MerchantId{ get; set; }

        /// <summary>
        /// 支付渠道，ALIPAY对应支付宝渠道；UNIONPAY对应银联渠道
        /// </summary>
        [JsonProperty("PayChannel")]
        public string PayChannel{ get; set; }

        /// <summary>
        /// 正向支付商户订单号
        /// </summary>
        [JsonProperty("PayOrderId")]
        public string PayOrderId{ get; set; }

        /// <summary>
        /// 退款订单号，最长64位，仅支持数字、 字母
        /// </summary>
        [JsonProperty("RefundOrderId")]
        public string RefundOrderId{ get; set; }

        /// <summary>
        /// 退款金额，单位：分。备注：改字段必须大于0 和小于10000000000的整数。
        /// </summary>
        [JsonProperty("RefundAmt")]
        public ulong? RefundAmt{ get; set; }

        /// <summary>
        /// 第三方支付机构支付交易号
        /// </summary>
        [JsonProperty("ThirdChannelOrderId")]
        public string ThirdChannelOrderId{ get; set; }

        /// <summary>
        /// 原始支付金额，单位：分。备注：当该字段为空或者为0 时，系统会默认使用订单当 实付金额作为退款金额
        /// </summary>
        [JsonProperty("PayAmt")]
        public ulong? PayAmt{ get; set; }

        /// <summary>
        /// 接入环境。沙箱环境填 sandbox。
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [JsonProperty("RefundReason")]
        public string RefundReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MerchantId", this.MerchantId);
            this.SetParamSimple(map, prefix + "PayChannel", this.PayChannel);
            this.SetParamSimple(map, prefix + "PayOrderId", this.PayOrderId);
            this.SetParamSimple(map, prefix + "RefundOrderId", this.RefundOrderId);
            this.SetParamSimple(map, prefix + "RefundAmt", this.RefundAmt);
            this.SetParamSimple(map, prefix + "ThirdChannelOrderId", this.ThirdChannelOrderId);
            this.SetParamSimple(map, prefix + "PayAmt", this.PayAmt);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
            this.SetParamSimple(map, prefix + "RefundReason", this.RefundReason);
        }
    }
}

