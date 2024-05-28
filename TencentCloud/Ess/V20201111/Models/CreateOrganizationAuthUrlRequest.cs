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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateOrganizationAuthUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 指定授权方式 支持多选:
        /// 1-上传授权书方式
        /// 2- 法人授权方式
        /// 3- 法人身份认证方式
        /// </summary>
        [JsonProperty("AuthorizationTypes")]
        public ulong?[] AuthorizationTypes{ get; set; }

        /// <summary>
        /// 企业名称
        /// EndPointType=“H5”或者"SHORT_H5"时，该参数必填
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 企业统一社会信用代码
        /// </summary>
        [JsonProperty("UniformSocialCreditCode")]
        public string UniformSocialCreditCode{ get; set; }

        /// <summary>
        /// 法人姓名
        /// </summary>
        [JsonProperty("LegalName")]
        public string LegalName{ get; set; }

        /// <summary>
        /// 认证完成跳转链接
        /// </summary>
        [JsonProperty("AutoJumpUrl")]
        public string AutoJumpUrl{ get; set; }

        /// <summary>
        /// 营业执照企业地址
        /// 示例：xx省xx市xx县/区xx街道
        /// </summary>
        [JsonProperty("OrganizationAddress")]
        public string OrganizationAddress{ get; set; }

        /// <summary>
        /// 认证人姓名
        /// </summary>
        [JsonProperty("AdminName")]
        public string AdminName{ get; set; }

        /// <summary>
        /// 认证人手机号
        /// </summary>
        [JsonProperty("AdminMobile")]
        public string AdminMobile{ get; set; }

        /// <summary>
        /// 认证人身份证号
        /// </summary>
        [JsonProperty("AdminIdCardNumber")]
        public string AdminIdCardNumber{ get; set; }

        /// <summary>
        /// 认证人证件类型
        /// 支持以下类型
        /// <ul><li>ID_CARD : 中国大陆居民身份证  (默认值)</li>
        /// <li>HONGKONG_AND_MACAO : 港澳居民来往内地通行证</li>
        /// <li>HONGKONG_MACAO_AND_TAIWAN : 港澳台居民居住证(格式同居民身份证)</li></ul>
        /// </summary>
        [JsonProperty("AdminIdCardType")]
        public string AdminIdCardType{ get; set; }

        /// <summary>
        /// 营业执照的社会信用代码保持一致
        /// false 关闭-默认
        /// true 开启
        /// </summary>
        [JsonProperty("UniformSocialCreditCodeSame")]
        public bool? UniformSocialCreditCodeSame{ get; set; }

        /// <summary>
        /// 法人姓名保持一致
        /// false 关闭-默认
        /// true 开启
        /// </summary>
        [JsonProperty("LegalNameSame")]
        public bool? LegalNameSame{ get; set; }

        /// <summary>
        /// 认证人姓名一致
        /// false 关闭-默认
        /// true 开启
        /// 注意：
        /// 开启后在认证过程前会校验拦截
        /// </summary>
        [JsonProperty("AdminNameSame")]
        public bool? AdminNameSame{ get; set; }

        /// <summary>
        /// 认证人居民身份证件号一致
        /// false 关闭-默认
        /// true 开启
        /// 注意：
        /// 开启后在认证过程前会校验拦截
        /// </summary>
        [JsonProperty("AdminIdCardNumberSame")]
        public bool? AdminIdCardNumberSame{ get; set; }

        /// <summary>
        /// 认证人手机号一致
        /// false 关闭-默认
        /// true 开启
        /// 注意：
        /// 开启后在认证过程前会校验拦截
        /// </summary>
        [JsonProperty("AdminMobileSame")]
        public bool? AdminMobileSame{ get; set; }

        /// <summary>
        /// 企业名称保持一致
        /// false 关闭-默认
        /// true 开启
        /// </summary>
        [JsonProperty("OrganizationNameSame")]
        public bool? OrganizationNameSame{ get; set; }

        /// <summary>
        /// 营业执照正面照(PNG或JPG) base64格式, 大小不超过5M
        /// </summary>
        [JsonProperty("BusinessLicense")]
        public string BusinessLicense{ get; set; }

        /// <summary>
        /// 跳转链接类型：
        /// "PC"-PC端认证链接 
        /// "APP"-全屏或半屏跳转小程序链接
        /// “H5”-H5页面认证链接 "SHORT_H5"- H5认证短链
        /// "SHORT_URL"- 跳转小程序短链	
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamArraySimple(map, prefix + "AuthorizationTypes.", this.AuthorizationTypes);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "UniformSocialCreditCode", this.UniformSocialCreditCode);
            this.SetParamSimple(map, prefix + "LegalName", this.LegalName);
            this.SetParamSimple(map, prefix + "AutoJumpUrl", this.AutoJumpUrl);
            this.SetParamSimple(map, prefix + "OrganizationAddress", this.OrganizationAddress);
            this.SetParamSimple(map, prefix + "AdminName", this.AdminName);
            this.SetParamSimple(map, prefix + "AdminMobile", this.AdminMobile);
            this.SetParamSimple(map, prefix + "AdminIdCardNumber", this.AdminIdCardNumber);
            this.SetParamSimple(map, prefix + "AdminIdCardType", this.AdminIdCardType);
            this.SetParamSimple(map, prefix + "UniformSocialCreditCodeSame", this.UniformSocialCreditCodeSame);
            this.SetParamSimple(map, prefix + "LegalNameSame", this.LegalNameSame);
            this.SetParamSimple(map, prefix + "AdminNameSame", this.AdminNameSame);
            this.SetParamSimple(map, prefix + "AdminIdCardNumberSame", this.AdminIdCardNumberSame);
            this.SetParamSimple(map, prefix + "AdminMobileSame", this.AdminMobileSame);
            this.SetParamSimple(map, prefix + "OrganizationNameSame", this.OrganizationNameSame);
            this.SetParamSimple(map, prefix + "BusinessLicense", this.BusinessLicense);
            this.SetParamSimple(map, prefix + "Endpoint", this.Endpoint);
        }
    }
}

