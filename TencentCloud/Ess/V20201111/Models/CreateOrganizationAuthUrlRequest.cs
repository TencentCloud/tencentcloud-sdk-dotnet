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
        /// 
        /// <ul>
        /// <li><strong>2</strong>: 法人授权方式</li>
        /// <li><strong>5</strong>: 授权书+对公打款方式</li>
        /// </ul>
        /// </summary>
        [JsonProperty("AuthorizationTypes")]
        public ulong?[] AuthorizationTypes{ get; set; }

        /// <summary>
        /// 认证企业名称，请确认该名称与企业营业执照中注册的名称一致。
        /// 
        /// 注：
        /// 
        /// 1. `如果名称中包含英文括号()，请使用中文括号（）代替。`
        /// 
        /// 2. `EndPointType=“H5”或者"SHORT_H5"时，该参数必填`
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 企业统一社会信用代码
        /// </summary>
        [JsonProperty("UniformSocialCreditCode")]
        public string UniformSocialCreditCode{ get; set; }

        /// <summary>
        /// 企业法人的姓名
        /// </summary>
        [JsonProperty("LegalName")]
        public string LegalName{ get; set; }

        /// <summary>
        /// <font color="red">即将废弃</font>，入参请使用JumpEvents。
        /// 认证完成跳回的链接，最长500个字符。
        /// </summary>
        [JsonProperty("AutoJumpUrl")]
        public string AutoJumpUrl{ get; set; }

        /// <summary>
        /// 营业执照企业地址
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
        /// 认证人证件类型， 支持以下类型
        /// <ul><li><b>ID_CARD</b> : 中国大陆居民身份证  (默认值)</li>
        /// <li><b>HONGKONG_AND_MACAO</b>  : 中国港澳居民来往内地通行证</li>
        /// <li><b>HONGKONG_MACAO_AND_TAIWAN</b>  : 中国港澳台居民居住证(格式同中国大陆居民身份证)</li></ul>
        /// </summary>
        [JsonProperty("AdminIdCardType")]
        public string AdminIdCardType{ get; set; }

        /// <summary>
        /// 对方打开链接认证时，对方填写的营业执照的社会信用代码是否与接口上传上来的要保持一致。<ul><li><b>false（默认值）</b>：关闭状态，实际认证时允许与接口传递的信息存在不一致。</li><li><b>true</b>：启用状态，实际认证时必须与接口传递的信息完全相符。</li></ul>
        /// </summary>
        [JsonProperty("UniformSocialCreditCodeSame")]
        public bool? UniformSocialCreditCodeSame{ get; set; }

        /// <summary>
        /// 对方打开链接认证时，法人姓名是否要与接口传递上来的保持一致。<ul><li><b>false（默认值）</b>：关闭状态，实际认证时允许与接口传递的信息存在不一致。</li><li><b>true</b>：启用状态，实际认证时必须与接口传递的信息完全相符。</li></ul>
        /// 
        /// p.s. 仅在法人姓名不为空时有效
        /// </summary>
        [JsonProperty("LegalNameSame")]
        public bool? LegalNameSame{ get; set; }

        /// <summary>
        /// 对方打开链接认证时，认证人姓名是否要与接口传递上来的保持一致。<ul><li><b>false（默认值）</b>：关闭状态，实际认证时允许与接口传递的信息存在不一致。</li><li><b>true</b>：启用状态，实际认证时必须与接口传递的信息完全相符。</li></ul>
        /// 
        /// p.s. 仅在认证人姓名不为空时有效
        /// </summary>
        [JsonProperty("AdminNameSame")]
        public bool? AdminNameSame{ get; set; }

        /// <summary>
        /// 对方打开链接认证时，认证人居民身份证件号是否要与接口传递上来的保持一致。<ul><li><b>false（默认值）</b>：关闭状态，实际认证时允许与接口传递的信息存在不一致。</li><li><b>true</b>：启用状态，实际认证时必须与接口传递的信息完全相符。</li></ul>
        /// 
        /// p.s. 仅在认证人身份证号不为空时有效
        /// </summary>
        [JsonProperty("AdminIdCardNumberSame")]
        public bool? AdminIdCardNumberSame{ get; set; }

        /// <summary>
        /// 对方打开链接认证时，认证人手机号是否要与接口传递上来的保持一致。<ul>
        /// <li><b>false（默认值）</b>：关闭状态，实际认证时允许与接口传递的信息存在不一致。</li>
        /// <li><b>true</b>：启用状态，实际认证时必须与接口传递的信息完全相符。</li>
        /// </ul>
        /// 
        /// p.s. 仅在认证人手机号不为空时有效
        /// </summary>
        [JsonProperty("AdminMobileSame")]
        public bool? AdminMobileSame{ get; set; }

        /// <summary>
        /// 对方打开链接认证时，企业名称是否要与接口传递上来的保持一致。<ul><li><b>false（默认值）</b>：关闭状态，实际认证时允许与接口传递的信息存在不一致。</li><li><b>true</b>：启用状态，实际认证时必须与接口传递的信息完全相符。</li></ul>
        /// 
        /// 
        /// p.s. 仅在企业名称不为空时有效
        /// </summary>
        [JsonProperty("OrganizationNameSame")]
        public bool? OrganizationNameSame{ get; set; }

        /// <summary>
        /// 营业执照正面照（支持PNG或JPG格式）需以base64格式提供，且文件大小不得超过5MB。
        /// </summary>
        [JsonProperty("BusinessLicense")]
        public string BusinessLicense{ get; set; }

        /// <summary>
        /// 跳转链接类型：
        /// 
        /// <ul>
        /// <li><b>PC</b>：适用于PC端的认证链接</li>
        /// <li><b>APP</b>：用于全屏或半屏跳转的小程序链接</li>
        /// <li><b>SHORT_URL</b>：跳转小程序的链接的短链形式</li>
        /// <li><b>H5</b>：适用于H5页面的认证链接</li>
        /// <li><b>SHORT_H5</b>：H5认证链接的短链形式</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }

        /// <summary>
        /// 指定企业初始化引导，现在可以配置如下的选项：
        /// 
        /// <b>1</b>: 启用此选项后，在企业认证的最终步骤将添加创建印章的引导。如下图的位置
        /// ![image](https://qcloudimg.tencent-cloud.cn/raw/88e0b45095a5c589de8995462ad755dc.jpg)
        /// </summary>
        [JsonProperty("Initialization")]
        public ulong?[] Initialization{ get; set; }

        /// <summary>
        /// 授权书(PNG或JPG或PDF) base64格式, 大小不超过8M 。 
        /// 授权书可以通过接口[生成企业授权书](https://qian.tencent.com/developers/companyApis/organizations/CreateOrganizationAuthFile) 来获得。
        /// p.s. 如果上传授权书 ，需遵循以下条件 
        /// 1.  超管的信息（超管姓名，超管手机号）必须为必填参数。
        /// 2.  认证方式AuthorizationTypes必须只能是上传授权书方式 
        /// </summary>
        [JsonProperty("PowerOfAttorneys")]
        public string[] PowerOfAttorneys{ get; set; }

        /// <summary>
        /// 调用方自定义的个性化字段(可自定义此名称)，并以base64方式编码，支持的最大数据大小为 4096长度。
        /// 
        /// 在. 企业引导企业实名认证后回调中，该字段的信息将原封不动地透传给贵方。回调的相关说明可参考开发者中心的<a href="https://qian.tencent.com/developers/company/callback_types_staffs" target="_blank">回调通知</a>模块。
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }

        /// <summary>
        /// 组织机构对公打款账号，账户名跟企业名称一致。
        /// 
        /// p.s.
        /// 只有认证方式是授权书+对公打款时才生效。
        /// </summary>
        [JsonProperty("BankAccountNumber")]
        public string BankAccountNumber{ get; set; }

        /// <summary>
        /// 对方打开链接认证时，对公打款账号是否要与接口传递上来的保持一致。<ul><li><b>false（默认值）</b>：关闭状态，实际认证时允许与接口传递的信息存在不一致。</li><li><b>true</b>：启用状态，实际认证时必须与接口传递的信息完全相符。</li></ul>
        /// 
        /// 
        /// p.s. 仅在对公打款不为空时有效
        /// </summary>
        [JsonProperty("BankAccountNumberSame")]
        public bool? BankAccountNumberSame{ get; set; }

        /// <summary>
        /// 跳转事件，其中包括认证期间收录，授权书审核，企业认证的回跳事件。
        /// p.s.
        /// Endpoint如果是APP 类型，请传递JumpUrl为<font color="red">"true" </font>
        /// 如果 Endpoint 是 H5 类型，请参考文档跳转电子签H5 
        /// 
        /// p.s. 如果Endpoint是 APP，传递的跳转地址无效，不会进行跳转，仅会进行回跳。
        /// </summary>
        [JsonProperty("JumpEvents")]
        public JumpEvent[] JumpEvents{ get; set; }

        /// <summary>
        /// 企业证照类型：<ul><li> **USCC** :(默认)工商组织营业执照</li><li> **PRACTICELICENSEOFMEDICALINSTITUTION** :医疗机构执业许可证</li></ul>
        /// 
        /// 注意 ：
        /// 如果企业证照类型是医疗机构，则参数设置企业授权方式(AuthorizationTypes)和企业认证方式(AuthorizationMethods)都无效.
        /// 医疗机构的企业授权方式  仅有授权书的方式。企业认证仅有上传营业执照的方式。
        /// </summary>
        [JsonProperty("OrganizationIdCardType")]
        public string OrganizationIdCardType{ get; set; }

        /// <summary>
        /// 是否允许编辑企业注册时的证照类型
        /// 
        /// true:不允许编辑。
        /// 
        /// false:允许编辑（默认值）。
        /// 
        /// 
        /// 注意：
        /// 入参中的OrganizationIdCardType值不为空的时候，才可设置为不可编辑。
        /// </summary>
        [JsonProperty("OrganizationIdCardTypeSame")]
        public bool? OrganizationIdCardTypeSame{ get; set; }

        /// <summary>
        /// 指定企业认证的授权方式 支持多选:
        /// 
        /// <ul>
        /// <li><strong>1</strong>: 上传营业执照</li>
        /// <li><strong>2</strong>: 腾讯云快速认证</li>
        /// <li><strong>3</strong>: 腾讯商户号授权<font color="red">（仅支持小程序端）</font></li>
        /// </ul>
        /// 
        /// 注意：
        /// 1.如果没有指定，则默认是1,仅有上传营业执照。
        /// 2.H5 仅支持上传营业执照。
        /// </summary>
        [JsonProperty("AuthorizationMethod")]
        public ulong?[] AuthorizationMethod{ get; set; }


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
            this.SetParamArraySimple(map, prefix + "Initialization.", this.Initialization);
            this.SetParamArraySimple(map, prefix + "PowerOfAttorneys.", this.PowerOfAttorneys);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
            this.SetParamSimple(map, prefix + "BankAccountNumber", this.BankAccountNumber);
            this.SetParamSimple(map, prefix + "BankAccountNumberSame", this.BankAccountNumberSame);
            this.SetParamArrayObj(map, prefix + "JumpEvents.", this.JumpEvents);
            this.SetParamSimple(map, prefix + "OrganizationIdCardType", this.OrganizationIdCardType);
            this.SetParamSimple(map, prefix + "OrganizationIdCardTypeSame", this.OrganizationIdCardTypeSame);
            this.SetParamArraySimple(map, prefix + "AuthorizationMethod.", this.AuthorizationMethod);
        }
    }
}

