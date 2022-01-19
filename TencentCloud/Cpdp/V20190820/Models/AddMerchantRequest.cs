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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddMerchantRequest : AbstractModel
    {
        
        /// <summary>
        /// 法人姓名
        /// </summary>
        [JsonProperty("BossName")]
        public string BossName{ get; set; }

        /// <summary>
        /// 营业执照图片【私密区】（系统返回的图片路径），（小微商户不效验，随意传要有值，公司/个体户必传）
        /// </summary>
        [JsonProperty("BusinessLicensePicture")]
        public string BusinessLicensePicture{ get; set; }

        /// <summary>
        /// 招牌名称
        /// </summary>
        [JsonProperty("BrandName")]
        public string BrandName{ get; set; }

        /// <summary>
        /// 收单系统分配的密钥
        /// </summary>
        [JsonProperty("OpenKey")]
        public string OpenKey{ get; set; }

        /// <summary>
        /// 营业执照过期时间（yyyy-mm-dd），（小微商户不效验，随意传要有值，公司/个体户必传）
        /// </summary>
        [JsonProperty("BusinessLicenseEndDate")]
        public string BusinessLicenseEndDate{ get; set; }

        /// <summary>
        /// 法人证件生效时间（yyyy-mm-dd）
        /// </summary>
        [JsonProperty("BossStartDate")]
        public string BossStartDate{ get; set; }

        /// <summary>
        /// 清算联行号，开户行行号
        /// </summary>
        [JsonProperty("BankNo")]
        public string BankNo{ get; set; }

        /// <summary>
        /// 开户行名称
        /// </summary>
        [JsonProperty("BankName")]
        public string BankName{ get; set; }

        /// <summary>
        /// 营业执照类型（1三证合一，2非三证合一）
        /// </summary>
        [JsonProperty("BusinessLicenseType")]
        public string BusinessLicenseType{ get; set; }

        /// <summary>
        /// 法人证件过期时间（yyyy-mm-dd）
        /// </summary>
        [JsonProperty("BossEndDate")]
        public string BossEndDate{ get; set; }

        /// <summary>
        /// 营业执照编号（系统有唯一性校验），（小微商户不效验，随意传要有值，公司/个体户必传）
        /// </summary>
        [JsonProperty("BusinessLicenseNo")]
        public string BusinessLicenseNo{ get; set; }

        /// <summary>
        /// 营业执照生效时间（yyyy-mm-dd），（小微商户不效验，随意传要有值，公司/个体户必传）
        /// </summary>
        [JsonProperty("BusinessLicenseStartDate")]
        public string BusinessLicenseStartDate{ get; set; }

        /// <summary>
        /// 法人证件类型（1居民身份证,2临时居民身份证,3居民户口簿,4护照,5港澳居民来往内地通行证,6回乡证,7军人证,8武警身份证,9其他法定文件）
        /// </summary>
        [JsonProperty("BossIdType")]
        public string BossIdType{ get; set; }

        /// <summary>
        /// 详细地址，不含省市区县名称，长度需要大于5。
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 法人证件国别/地区（中国CHN，香港HKG，澳门MAC，台湾CTN）
        /// </summary>
        [JsonProperty("BossIdCountry")]
        public string BossIdCountry{ get; set; }

        /// <summary>
        /// 收单系统分配的开放ID
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 商户名称，小微商户命名要符合“”商户_名字” （例如：商户_张三）
        /// </summary>
        [JsonProperty("MerchantName")]
        public string MerchantName{ get; set; }

        /// <summary>
        /// 法人性别（1男，2女）
        /// </summary>
        [JsonProperty("BossSex")]
        public string BossSex{ get; set; }

        /// <summary>
        /// 行业分类编号列表（第一个分类编号为主分类，后面的为二级分类）
        /// </summary>
        [JsonProperty("ClassificationIds")]
        public string[] ClassificationIds{ get; set; }

        /// <summary>
        /// 法人证件号码
        /// </summary>
        [JsonProperty("BossIdNo")]
        public string BossIdNo{ get; set; }

        /// <summary>
        /// 许可证图片【私密区】，（小微商户不效验，随意传要有值，公司/个体户必传）
        /// </summary>
        [JsonProperty("LicencePicture")]
        public string LicencePicture{ get; set; }

        /// <summary>
        /// 营业时间，多个以小写逗号分开(9:00-12:00,13:00-18:00)
        /// </summary>
        [JsonProperty("OpenHours")]
        public string OpenHours{ get; set; }

        /// <summary>
        /// 银行户名
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName{ get; set; }

        /// <summary>
        /// 银行账号
        /// </summary>
        [JsonProperty("AccountNo")]
        public string AccountNo{ get; set; }

        /// <summary>
        /// 结算账户类型（2对私，1对公）
        /// </summary>
        [JsonProperty("AccountType")]
        public string AccountType{ get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [JsonProperty("Telephone")]
        public string Telephone{ get; set; }

        /// <summary>
        /// 法人身份证正面【私密区】（系统返回的图片路径）
        /// </summary>
        [JsonProperty("BossPositive")]
        public string BossPositive{ get; set; }

        /// <summary>
        /// 城市编号
        /// </summary>
        [JsonProperty("CityId")]
        public string CityId{ get; set; }

        /// <summary>
        /// 法人身份证背面【私密区】（系统返回的图片路径）
        /// </summary>
        [JsonProperty("BossBack")]
        public string BossBack{ get; set; }

        /// <summary>
        /// 机构商户主键（系统有唯一性校验），建议使用商户表的主键ID，防止重复添加商户
        /// </summary>
        [JsonProperty("OutMerchantId")]
        public string OutMerchantId{ get; set; }

        /// <summary>
        /// 组织机构代码证生效时间（yyyy-mm-dd）
        /// </summary>
        [JsonProperty("OrganizationStartDate")]
        public string OrganizationStartDate{ get; set; }

        /// <summary>
        /// 法人亲属证件号码
        /// </summary>
        [JsonProperty("AccountIdNo")]
        public string AccountIdNo{ get; set; }

        /// <summary>
        /// 财务联系人
        /// </summary>
        [JsonProperty("FinancialContact")]
        public string FinancialContact{ get; set; }

        /// <summary>
        /// 法人亲属证件类型（1居民身份证,2临时居民身份证,3居民户口簿,4护照,5港澳居民来往内地通行证,6回乡证,7军人证,8武警身份证,9其他法定文件）结算账户人身份为法人亲属时必填
        /// </summary>
        [JsonProperty("AccountIdType")]
        public string AccountIdType{ get; set; }

        /// <summary>
        /// 组织机构代码证号
        /// </summary>
        [JsonProperty("OrganizationNo")]
        public string OrganizationNo{ get; set; }

        /// <summary>
        /// 其他资料1
        /// </summary>
        [JsonProperty("OtherPictureOne")]
        public string OtherPictureOne{ get; set; }

        /// <summary>
        /// 财务联系人电话
        /// </summary>
        [JsonProperty("FinancialTelephone")]
        public string FinancialTelephone{ get; set; }

        /// <summary>
        /// 沙箱环境填sandbox，正式环境不填
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }

        /// <summary>
        /// 组织机构代码证图片【私密区】
        /// </summary>
        [JsonProperty("OrganizationPicture")]
        public string OrganizationPicture{ get; set; }

        /// <summary>
        /// 税务登记证生效时间（yyyy-mm-dd）
        /// </summary>
        [JsonProperty("TaxRegistrationStartDate")]
        public string TaxRegistrationStartDate{ get; set; }

        /// <summary>
        /// 商户标记，自定义参数
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// 结算账户人身份（1法人，2法人亲属），结算帐户为对私时必填
        /// </summary>
        [JsonProperty("AccountBoss")]
        public string AccountBoss{ get; set; }

        /// <summary>
        /// 法人电话
        /// </summary>
        [JsonProperty("BossTelephone")]
        public string BossTelephone{ get; set; }

        /// <summary>
        /// 税务登记证图片【私密区】
        /// </summary>
        [JsonProperty("TaxRegistrationPicture")]
        public string TaxRegistrationPicture{ get; set; }

        /// <summary>
        /// 组织机构代码证过期时间（yyyy-mm-dd）
        /// </summary>
        [JsonProperty("OrganizationEndDate")]
        public string OrganizationEndDate{ get; set; }

        /// <summary>
        /// 法人职业
        /// </summary>
        [JsonProperty("BossJob")]
        public string BossJob{ get; set; }

        /// <summary>
        /// 其他资料3
        /// </summary>
        [JsonProperty("OtherPictureThree")]
        public string OtherPictureThree{ get; set; }

        /// <summary>
        /// 授权文件【私密区】
        /// </summary>
        [JsonProperty("LicencePictureTwo")]
        public string LicencePictureTwo{ get; set; }

        /// <summary>
        /// 商户logo【公共区】
        /// </summary>
        [JsonProperty("Logo")]
        public string Logo{ get; set; }

        /// <summary>
        /// 法人住址
        /// </summary>
        [JsonProperty("BossAddress")]
        public string BossAddress{ get; set; }

        /// <summary>
        /// 法人邮箱
        /// </summary>
        [JsonProperty("BossEmail")]
        public string BossEmail{ get; set; }

        /// <summary>
        /// 其他资料2
        /// </summary>
        [JsonProperty("OtherPictureTwo")]
        public string OtherPictureTwo{ get; set; }

        /// <summary>
        /// 商户简介
        /// </summary>
        [JsonProperty("Intro")]
        public string Intro{ get; set; }

        /// <summary>
        /// 客户经理姓名，必须为系统后台的管理员真实姓名
        /// </summary>
        [JsonProperty("AccountManagerName")]
        public string AccountManagerName{ get; set; }

        /// <summary>
        /// 税务登记证过期时间（yyyy-mm-dd）
        /// </summary>
        [JsonProperty("TaxRegistrationEndDate")]
        public string TaxRegistrationEndDate{ get; set; }

        /// <summary>
        /// 其他资料4
        /// </summary>
        [JsonProperty("OtherPictureFour")]
        public string OtherPictureFour{ get; set; }

        /// <summary>
        /// 税务登记证号
        /// </summary>
        [JsonProperty("TaxRegistrationNo")]
        public string TaxRegistrationNo{ get; set; }

        /// <summary>
        /// 商户类型：1-个体，2-小微，3-企业。不传默认为2-小微商户。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BossName", this.BossName);
            this.SetParamSimple(map, prefix + "BusinessLicensePicture", this.BusinessLicensePicture);
            this.SetParamSimple(map, prefix + "BrandName", this.BrandName);
            this.SetParamSimple(map, prefix + "OpenKey", this.OpenKey);
            this.SetParamSimple(map, prefix + "BusinessLicenseEndDate", this.BusinessLicenseEndDate);
            this.SetParamSimple(map, prefix + "BossStartDate", this.BossStartDate);
            this.SetParamSimple(map, prefix + "BankNo", this.BankNo);
            this.SetParamSimple(map, prefix + "BankName", this.BankName);
            this.SetParamSimple(map, prefix + "BusinessLicenseType", this.BusinessLicenseType);
            this.SetParamSimple(map, prefix + "BossEndDate", this.BossEndDate);
            this.SetParamSimple(map, prefix + "BusinessLicenseNo", this.BusinessLicenseNo);
            this.SetParamSimple(map, prefix + "BusinessLicenseStartDate", this.BusinessLicenseStartDate);
            this.SetParamSimple(map, prefix + "BossIdType", this.BossIdType);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "BossIdCountry", this.BossIdCountry);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "MerchantName", this.MerchantName);
            this.SetParamSimple(map, prefix + "BossSex", this.BossSex);
            this.SetParamArraySimple(map, prefix + "ClassificationIds.", this.ClassificationIds);
            this.SetParamSimple(map, prefix + "BossIdNo", this.BossIdNo);
            this.SetParamSimple(map, prefix + "LicencePicture", this.LicencePicture);
            this.SetParamSimple(map, prefix + "OpenHours", this.OpenHours);
            this.SetParamSimple(map, prefix + "AccountName", this.AccountName);
            this.SetParamSimple(map, prefix + "AccountNo", this.AccountNo);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamSimple(map, prefix + "Telephone", this.Telephone);
            this.SetParamSimple(map, prefix + "BossPositive", this.BossPositive);
            this.SetParamSimple(map, prefix + "CityId", this.CityId);
            this.SetParamSimple(map, prefix + "BossBack", this.BossBack);
            this.SetParamSimple(map, prefix + "OutMerchantId", this.OutMerchantId);
            this.SetParamSimple(map, prefix + "OrganizationStartDate", this.OrganizationStartDate);
            this.SetParamSimple(map, prefix + "AccountIdNo", this.AccountIdNo);
            this.SetParamSimple(map, prefix + "FinancialContact", this.FinancialContact);
            this.SetParamSimple(map, prefix + "AccountIdType", this.AccountIdType);
            this.SetParamSimple(map, prefix + "OrganizationNo", this.OrganizationNo);
            this.SetParamSimple(map, prefix + "OtherPictureOne", this.OtherPictureOne);
            this.SetParamSimple(map, prefix + "FinancialTelephone", this.FinancialTelephone);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
            this.SetParamSimple(map, prefix + "OrganizationPicture", this.OrganizationPicture);
            this.SetParamSimple(map, prefix + "TaxRegistrationStartDate", this.TaxRegistrationStartDate);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamSimple(map, prefix + "AccountBoss", this.AccountBoss);
            this.SetParamSimple(map, prefix + "BossTelephone", this.BossTelephone);
            this.SetParamSimple(map, prefix + "TaxRegistrationPicture", this.TaxRegistrationPicture);
            this.SetParamSimple(map, prefix + "OrganizationEndDate", this.OrganizationEndDate);
            this.SetParamSimple(map, prefix + "BossJob", this.BossJob);
            this.SetParamSimple(map, prefix + "OtherPictureThree", this.OtherPictureThree);
            this.SetParamSimple(map, prefix + "LicencePictureTwo", this.LicencePictureTwo);
            this.SetParamSimple(map, prefix + "Logo", this.Logo);
            this.SetParamSimple(map, prefix + "BossAddress", this.BossAddress);
            this.SetParamSimple(map, prefix + "BossEmail", this.BossEmail);
            this.SetParamSimple(map, prefix + "OtherPictureTwo", this.OtherPictureTwo);
            this.SetParamSimple(map, prefix + "Intro", this.Intro);
            this.SetParamSimple(map, prefix + "AccountManagerName", this.AccountManagerName);
            this.SetParamSimple(map, prefix + "TaxRegistrationEndDate", this.TaxRegistrationEndDate);
            this.SetParamSimple(map, prefix + "OtherPictureFour", this.OtherPictureFour);
            this.SetParamSimple(map, prefix + "TaxRegistrationNo", this.TaxRegistrationNo);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

