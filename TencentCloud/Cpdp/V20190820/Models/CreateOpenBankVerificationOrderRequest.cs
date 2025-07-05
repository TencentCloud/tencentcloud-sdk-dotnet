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

    public class CreateOpenBankVerificationOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 云企付渠道商户号。外部接入平台入驻云企付平台后下发。
        /// </summary>
        [JsonProperty("ChannelMerchantId")]
        public string ChannelMerchantId{ get; set; }

        /// <summary>
        /// 外部核销申请订单号
        /// </summary>
        [JsonProperty("OutVerificationId")]
        public string OutVerificationId{ get; set; }

        /// <summary>
        /// 核销金额，单位分
        /// </summary>
        [JsonProperty("VerificationAmount")]
        public long? VerificationAmount{ get; set; }

        /// <summary>
        /// 外部支付订单号。调用创建支付订单时，下单支付时的外部订单号。与ChannelOrderId不能同时为空。
        /// </summary>
        [JsonProperty("OutOrderId")]
        public string OutOrderId{ get; set; }

        /// <summary>
        /// 云企付渠道订单号。调用创建支付订单时，下单支付时的云企付渠道订单号。与OutOrderId不能同时为空。
        /// </summary>
        [JsonProperty("ChannelOrderId")]
        public string ChannelOrderId{ get; set; }

        /// <summary>
        /// 核销成功回调地址。若不上送，则不回调通知。
        /// </summary>
        [JsonProperty("NotifyUrl")]
        public string NotifyUrl{ get; set; }

        /// <summary>
        /// 备注。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 第三方支付渠道需要额外上送字段。详情见附录描述。
        /// </summary>
        [JsonProperty("ExternalVerificationData")]
        public string ExternalVerificationData{ get; set; }

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
            this.SetParamSimple(map, prefix + "OutVerificationId", this.OutVerificationId);
            this.SetParamSimple(map, prefix + "VerificationAmount", this.VerificationAmount);
            this.SetParamSimple(map, prefix + "OutOrderId", this.OutOrderId);
            this.SetParamSimple(map, prefix + "ChannelOrderId", this.ChannelOrderId);
            this.SetParamSimple(map, prefix + "NotifyUrl", this.NotifyUrl);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ExternalVerificationData", this.ExternalVerificationData);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
        }
    }
}

