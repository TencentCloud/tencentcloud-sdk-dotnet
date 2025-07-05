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

    public class CreateOpenBankAggregatedSubMerchantRegistrationRequest : AbstractModel
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
        /// 外部子商户ID。
        /// </summary>
        [JsonProperty("OutSubMerchantId")]
        public string OutSubMerchantId{ get; set; }

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
        /// 外部子商户类型。
        /// ENTERPRISE：企业商户 
        /// INSTITUTION：事业单位商户 
        /// INDIVIDUALBISS：个体工商户 
        /// PERSON：个人商户(小微商户) 
        /// SUBJECT_TYPE_OTHERS：其他组织
        /// </summary>
        [JsonProperty("OutSubMerchantType")]
        public string OutSubMerchantType{ get; set; }

        /// <summary>
        /// 外部子商户名称。
        /// HELIPAY渠道(长度不能小于5大于150)。
        /// </summary>
        [JsonProperty("OutSubMerchantName")]
        public string OutSubMerchantName{ get; set; }

        /// <summary>
        /// 商户法人代表信息。
        /// </summary>
        [JsonProperty("LegalPersonInfo")]
        public LegalPersonInfo LegalPersonInfo{ get; set; }

        /// <summary>
        /// 营业证件信息。
        /// </summary>
        [JsonProperty("BusinessLicenseInfo")]
        public BusinessLicenseInfo BusinessLicenseInfo{ get; set; }

        /// <summary>
        /// 支付渠道子商户进件信息。
        /// json字符串，详情见附录-复杂类型-InterConnectionSubMerchantData。
        /// </summary>
        [JsonProperty("InterConnectionSubMerchantData")]
        public string InterConnectionSubMerchantData{ get; set; }

        /// <summary>
        /// 支付方式。详见附录-云企付枚举类说明-PaymentMethod。
        /// 合利宝渠道不需要传。
        /// </summary>
        [JsonProperty("PaymentMethod")]
        public string PaymentMethod{ get; set; }

        /// <summary>
        /// 外部子商户简称。
        /// HELIPAY渠道必传(长度不能小于2大于20)。
        /// </summary>
        [JsonProperty("OutSubMerchantShortName")]
        public string OutSubMerchantShortName{ get; set; }

        /// <summary>
        /// 外部子商户描述。
        /// </summary>
        [JsonProperty("OutSubMerchantDescription")]
        public string OutSubMerchantDescription{ get; set; }

        /// <summary>
        /// 通知地址。
        /// </summary>
        [JsonProperty("NotifyUrl")]
        public string NotifyUrl{ get; set; }

        /// <summary>
        /// 相关自然人信息列表。
        /// HELIPAY渠道必传业务联系人。
        /// </summary>
        [JsonProperty("NaturalPersonList")]
        public NaturalPersonInfo[] NaturalPersonList{ get; set; }

        /// <summary>
        /// 商户结算信息。
        /// HELIPAY渠道必传。
        /// </summary>
        [JsonProperty("SettleInfo")]
        public SettleInfo SettleInfo{ get; set; }

        /// <summary>
        /// 外部子商户其他公用扩展信息。
        /// HELIPAY渠道必传。
        /// </summary>
        [JsonProperty("OutSubMerchantExtensionInfo")]
        public OutSubMerchantExtensionInfo OutSubMerchantExtensionInfo{ get; set; }

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
            this.SetParamSimple(map, prefix + "OutSubMerchantType", this.OutSubMerchantType);
            this.SetParamSimple(map, prefix + "OutSubMerchantName", this.OutSubMerchantName);
            this.SetParamObj(map, prefix + "LegalPersonInfo.", this.LegalPersonInfo);
            this.SetParamObj(map, prefix + "BusinessLicenseInfo.", this.BusinessLicenseInfo);
            this.SetParamSimple(map, prefix + "InterConnectionSubMerchantData", this.InterConnectionSubMerchantData);
            this.SetParamSimple(map, prefix + "PaymentMethod", this.PaymentMethod);
            this.SetParamSimple(map, prefix + "OutSubMerchantShortName", this.OutSubMerchantShortName);
            this.SetParamSimple(map, prefix + "OutSubMerchantDescription", this.OutSubMerchantDescription);
            this.SetParamSimple(map, prefix + "NotifyUrl", this.NotifyUrl);
            this.SetParamArrayObj(map, prefix + "NaturalPersonList.", this.NaturalPersonList);
            this.SetParamObj(map, prefix + "SettleInfo.", this.SettleInfo);
            this.SetParamObj(map, prefix + "OutSubMerchantExtensionInfo.", this.OutSubMerchantExtensionInfo);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
        }
    }
}

