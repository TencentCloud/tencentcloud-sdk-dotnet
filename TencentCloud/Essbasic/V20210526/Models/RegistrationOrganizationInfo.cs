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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegistrationOrganizationInfo : AbstractModel
    {
        
        /// <summary>
        /// 组织机构名称。
        /// 请确认该名称与企业营业执照中注册的名称一致。
        /// 如果名称中包含英文括号()，请使用中文括号（）代替。
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 机构在贵司业务系统中的唯一标识，用于与腾讯电子签企业账号进行映射，确保在同一应用内不会出现重复。
        /// 该标识最大长度为64位字符串，仅支持包含26个英文字母和数字0-9的字符。
        /// </summary>
        [JsonProperty("OrganizationOpenId")]
        public string OrganizationOpenId{ get; set; }

        /// <summary>
        /// 员工在贵司业务系统中的唯一身份标识，用于与腾讯电子签账号进行映射，确保在同一应用内不会出现重复。
        /// 该标识最大长度为64位字符串，仅支持包含26个英文字母和数字0-9的字符。
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 组织机构企业统一社会信用代码。
        /// 请确认该企业统一社会信用代码与企业营业执照中注册的统一社会信用代码一致。
        /// </summary>
        [JsonProperty("UniformSocialCreditCode")]
        public string UniformSocialCreditCode{ get; set; }

        /// <summary>
        /// 组织机构法人的姓名。
        /// 请确认该企业统一社会信用代码与企业营业执照中注册的法人姓名一致。
        /// </summary>
        [JsonProperty("LegalName")]
        public string LegalName{ get; set; }

        /// <summary>
        /// 组织机构企业注册地址。
        /// 请确认该企业注册地址与企业营业执照中注册的地址一致。
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 组织机构超管姓名。
        /// 在注册流程中，必须是超管本人进行操作。
        /// 如果法人作为超管管理组织机构,超管姓名就是法人姓名
        /// </summary>
        [JsonProperty("AdminName")]
        public string AdminName{ get; set; }

        /// <summary>
        /// 组织机构超管手机号。
        /// 在注册流程中，这个手机号必须跟操作人在电子签注册的个人手机号一致。
        /// </summary>
        [JsonProperty("AdminMobile")]
        public string AdminMobile{ get; set; }

        /// <summary>
        /// 可选的此企业允许的授权方式, 可以设置的方式有:
        /// 1：上传授权书
        /// 2：法人授权超管
        /// 5：授权书+对公打款
        /// 
        /// 
        /// 注:
        /// `1. 当前仅支持一种认证方式`
        /// `2. 如果当前的企业类型是政府/事业单位, 则只支持上传授权书+对公打款`
        /// `3. 如果当前操作人是法人,则是法人认证`
        /// </summary>
        [JsonProperty("AuthorizationTypes")]
        public ulong?[] AuthorizationTypes{ get; set; }

        /// <summary>
        /// 经办人的证件类型，支持以下类型
        /// <ul><li>ID_CARD : 中国大陆居民身份证  (默认值)</li>
        /// <li>HONGKONG_AND_MACAO : 中国港澳居民来往内地通行证</li>
        /// <li>HONGKONG_MACAO_AND_TAIWAN : 中国港澳台居民居住证(格式同中国大陆居民身份证)</li></ul>
        /// </summary>
        [JsonProperty("AdminIdCardType")]
        public string AdminIdCardType{ get; set; }

        /// <summary>
        /// 经办人的证件号
        /// </summary>
        [JsonProperty("AdminIdCardNumber")]
        public string AdminIdCardNumber{ get; set; }

        /// <summary>
        /// 营业执照正面照(PNG或JPG) base64格式, 大小不超过5M
        /// </summary>
        [JsonProperty("BusinessLicense")]
        public string BusinessLicense{ get; set; }

        /// <summary>
        /// 授权书(PNG或JPG或PDF) base64格式, 大小不超过8M 。
        /// p.s. 如果上传授权书 ，需遵循以下条件
        /// 1. 超管的信息（超管姓名，超管身份证，超管手机号）必须为必填参数。
        /// 2. 超管的个人身份必须在电子签已经实名。
        /// 2. 认证方式AuthorizationTypes必须只能是上传授权书方式 
        /// </summary>
        [JsonProperty("PowerOfAttorneys")]
        public string[] PowerOfAttorneys{ get; set; }

        /// <summary>
        /// 认证完之后的H5页面的跳转链接，最大长度1000个字符。链接类型请参考 [跳转电子签H5](https://qian.tencent.com/developers/company/openqianh5/)
        /// </summary>
        [JsonProperty("AutoJumpUrl")]
        public string AutoJumpUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "OrganizationOpenId", this.OrganizationOpenId);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "UniformSocialCreditCode", this.UniformSocialCreditCode);
            this.SetParamSimple(map, prefix + "LegalName", this.LegalName);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "AdminName", this.AdminName);
            this.SetParamSimple(map, prefix + "AdminMobile", this.AdminMobile);
            this.SetParamArraySimple(map, prefix + "AuthorizationTypes.", this.AuthorizationTypes);
            this.SetParamSimple(map, prefix + "AdminIdCardType", this.AdminIdCardType);
            this.SetParamSimple(map, prefix + "AdminIdCardNumber", this.AdminIdCardNumber);
            this.SetParamSimple(map, prefix + "BusinessLicense", this.BusinessLicense);
            this.SetParamArraySimple(map, prefix + "PowerOfAttorneys.", this.PowerOfAttorneys);
            this.SetParamSimple(map, prefix + "AutoJumpUrl", this.AutoJumpUrl);
        }
    }
}

