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

    public class QueryOpenBankBankBranchListRequest : AbstractModel
    {
        
        /// <summary>
        /// 渠道商户ID。
        /// </summary>
        [JsonProperty("ChannelMerchantId")]
        public string ChannelMerchantId{ get; set; }

        /// <summary>
        /// 渠道名称。
        /// __TENPAY__: 商企付
        /// __WECHAT__: 微信支付
        /// __ALIPAY__: 支付宝
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 支付方式。
        /// __EBANK_PAYMENT__:ebank付款
        /// __OPENBANK_PAYMENT__: openbank付款
        /// </summary>
        [JsonProperty("PaymentMethod")]
        public string PaymentMethod{ get; set; }

        /// <summary>
        /// 支行名称。
        /// </summary>
        [JsonProperty("BankBranchName")]
        public string BankBranchName{ get; set; }

        /// <summary>
        /// 银行简称。
        /// </summary>
        [JsonProperty("BankAbbreviation")]
        public string BankAbbreviation{ get; set; }

        /// <summary>
        /// 页码。Index和Count必须大于等于1。Count建议不超过100。
        /// </summary>
        [JsonProperty("PageNumber")]
        public Paging PageNumber{ get; set; }

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
            this.SetParamSimple(map, prefix + "PaymentMethod", this.PaymentMethod);
            this.SetParamSimple(map, prefix + "BankBranchName", this.BankBranchName);
            this.SetParamSimple(map, prefix + "BankAbbreviation", this.BankAbbreviation);
            this.SetParamObj(map, prefix + "PageNumber.", this.PageNumber);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
        }
    }
}

