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

    public class CreateOpenBankExternalSubMerchantRegistrationRequest : AbstractModel
    {
        
        /// <summary>
        /// 外部进件序列号。
        /// </summary>
        [JsonProperty("OutRegistrationNo")]
        public string OutRegistrationNo{ get; set; }

        /// <summary>
        /// 渠道商户ID。
        /// </summary>
        [JsonProperty("ChannelMerchantId")]
        public string ChannelMerchantId{ get; set; }

        /// <summary>
        /// 外部子商户ID,平台侧商户唯一ID。
        /// </summary>
        [JsonProperty("OutSubMerchantId")]
        public string OutSubMerchantId{ get; set; }

        /// <summary>
        /// 渠道名称。详见附录-云企付枚举类说明-ChannelName。
        /// __TENPAY__: 商企付
        /// __WECHAT__: 微信支付
        /// __ALIPAY__: 支付宝
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 支付方式。详见附录-云企付枚举类说明-PaymentMethod。
        /// __EBANK_PAYMENT__: ebank支付
        /// __OPENBANK_PAYMENT__: openbank支付
        /// </summary>
        [JsonProperty("PaymentMethod")]
        public string PaymentMethod{ get; set; }

        /// <summary>
        /// 社会信用代码。
        /// </summary>
        [JsonProperty("BusinessLicenseNumber")]
        public string BusinessLicenseNumber{ get; set; }

        /// <summary>
        /// 外部子商户名称。
        /// </summary>
        [JsonProperty("OutSubMerchantName")]
        public string OutSubMerchantName{ get; set; }

        /// <summary>
        /// 法人姓名。
        /// </summary>
        [JsonProperty("LegalName")]
        public string LegalName{ get; set; }

        /// <summary>
        /// 外部子商户简称。
        /// </summary>
        [JsonProperty("OutSubMerchantShortName")]
        public string OutSubMerchantShortName{ get; set; }

        /// <summary>
        /// 外部子商户描述。
        /// </summary>
        [JsonProperty("OutSubMerchantDescription")]
        public string OutSubMerchantDescription{ get; set; }

        /// <summary>
        /// 第三方子商户进件信息，为JSON格式字符串。详情见附录-复杂类型。
        /// </summary>
        [JsonProperty("ExternalSubMerchantRegistrationData")]
        public string ExternalSubMerchantRegistrationData{ get; set; }

        /// <summary>
        /// 通知地址。
        /// </summary>
        [JsonProperty("NotifyUrl")]
        public string NotifyUrl{ get; set; }

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
            this.SetParamSimple(map, prefix + "OutRegistrationNo", this.OutRegistrationNo);
            this.SetParamSimple(map, prefix + "ChannelMerchantId", this.ChannelMerchantId);
            this.SetParamSimple(map, prefix + "OutSubMerchantId", this.OutSubMerchantId);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "PaymentMethod", this.PaymentMethod);
            this.SetParamSimple(map, prefix + "BusinessLicenseNumber", this.BusinessLicenseNumber);
            this.SetParamSimple(map, prefix + "OutSubMerchantName", this.OutSubMerchantName);
            this.SetParamSimple(map, prefix + "LegalName", this.LegalName);
            this.SetParamSimple(map, prefix + "OutSubMerchantShortName", this.OutSubMerchantShortName);
            this.SetParamSimple(map, prefix + "OutSubMerchantDescription", this.OutSubMerchantDescription);
            this.SetParamSimple(map, prefix + "ExternalSubMerchantRegistrationData", this.ExternalSubMerchantRegistrationData);
            this.SetParamSimple(map, prefix + "NotifyUrl", this.NotifyUrl);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
        }
    }
}

