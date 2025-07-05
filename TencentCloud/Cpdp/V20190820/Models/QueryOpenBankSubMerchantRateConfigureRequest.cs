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

    public class QueryOpenBankSubMerchantRateConfigureRequest : AbstractModel
    {
        
        /// <summary>
        /// 渠道进件序列号。
        /// </summary>
        [JsonProperty("ChannelRegistrationNo")]
        public string ChannelRegistrationNo{ get; set; }

        /// <summary>
        /// 渠道商户ID。
        /// </summary>
        [JsonProperty("ChannelMerchantId")]
        public string ChannelMerchantId{ get; set; }

        /// <summary>
        /// 渠道子商户ID。
        /// </summary>
        [JsonProperty("ChannelSubMerchantId")]
        public string ChannelSubMerchantId{ get; set; }

        /// <summary>
        /// 渠道名称。详见附录-云企付枚举类说明-ChannelName。
        /// TENPAY: 商企付
        /// WECHAT: 微信支付
        /// ALIPAY: 支付宝
        /// HELIPAY:合利宝
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 渠道产品费率序列号。与外部产品费率序列号二者选填其一。
        /// </summary>
        [JsonProperty("ChannelProductFeeNo")]
        public string ChannelProductFeeNo{ get; set; }

        /// <summary>
        /// 外部产品费率序列号。与渠道产品费率序列号二者选填其一。
        /// </summary>
        [JsonProperty("OutProductFeeNo")]
        public string OutProductFeeNo{ get; set; }

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
            this.SetParamSimple(map, prefix + "ChannelRegistrationNo", this.ChannelRegistrationNo);
            this.SetParamSimple(map, prefix + "ChannelMerchantId", this.ChannelMerchantId);
            this.SetParamSimple(map, prefix + "ChannelSubMerchantId", this.ChannelSubMerchantId);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "ChannelProductFeeNo", this.ChannelProductFeeNo);
            this.SetParamSimple(map, prefix + "OutProductFeeNo", this.OutProductFeeNo);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
        }
    }
}

