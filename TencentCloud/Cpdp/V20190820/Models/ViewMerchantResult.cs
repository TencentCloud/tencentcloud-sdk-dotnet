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

    public class ViewMerchantResult : AbstractModel
    {
        
        /// <summary>
        /// 城市
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// 税务登记证图片【私密区】
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaxCollectionPicture")]
        public string TaxCollectionPicture{ get; set; }

        /// <summary>
        /// 法人证件号码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BossIdNo")]
        public string BossIdNo{ get; set; }

        /// <summary>
        /// 法人亲属证件号码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountIdNo")]
        public string AccountIdNo{ get; set; }

        /// <summary>
        /// 其他资料3
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OtherPictureThree")]
        public string OtherPictureThree{ get; set; }

        /// <summary>
        /// 法人亲属证件类型（1居民身份证,2临时居民身份证,3居民户口簿,4护照,5港澳居民来往内地通行证,6回乡证,7军人证,8武警身份证,9其他法定文件）结算账户人身份为法人亲属时必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountIdType")]
        public string AccountIdType{ get; set; }

        /// <summary>
        /// 商户状态（0未审核，1已审核，2审核未通过，3待审核，4已删除，5初审通过）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 营业执照图片【私密区】（系统返回的图片路径）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BusinessLicensePicture")]
        public string BusinessLicensePicture{ get; set; }

        /// <summary>
        /// 品牌名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BrandName")]
        public string BrandName{ get; set; }

        /// <summary>
        /// 法人身份证正面【私密区】（系统返回的图片路径）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BossPositive")]
        public string BossPositive{ get; set; }

        /// <summary>
        /// 开通应用数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppCount")]
        public string AppCount{ get; set; }

        /// <summary>
        /// 法人身份证背面【私密区】（系统返回的图片路径）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BossBack")]
        public string BossBack{ get; set; }

        /// <summary>
        /// 组织机构代码证图片【私密区】
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrganizationCodePicture")]
        public string OrganizationCodePicture{ get; set; }

        /// <summary>
        /// 营业执照过期时间（yyyy-mm-dd）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BusinessLicenseEndDate")]
        public string BusinessLicenseEndDate{ get; set; }

        /// <summary>
        /// 组织机构代码证号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrganizationCodeNo")]
        public string OrganizationCodeNo{ get; set; }

        /// <summary>
        /// 机构编号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AgentNo")]
        public string AgentNo{ get; set; }

        /// <summary>
        /// 省份
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// 法人证件生效时间（yyyy-mm-dd）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BossStartDate")]
        public string BossStartDate{ get; set; }

        /// <summary>
        /// 更新时间（yyyy-mm-dd hh:ii:ss）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 清算联行号，开户行行号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BankNo")]
        public string BankNo{ get; set; }

        /// <summary>
        /// 税务登记证生效时间（yyyy-mm-dd）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaxCollectionStartDate")]
        public string TaxCollectionStartDate{ get; set; }

        /// <summary>
        /// 营业执照生效时间（yyyy-mm-dd）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BusinessLicenseStartDate")]
        public string BusinessLicenseStartDate{ get; set; }

        /// <summary>
        /// 客户经理用户编号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountManagerId")]
        public string AccountManagerId{ get; set; }

        /// <summary>
        /// 分类编号(多个以小写逗号分开)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClassificationIds")]
        public string ClassificationIds{ get; set; }

        /// <summary>
        /// 营业执照类型（1三证合一，2非三证合一）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BusinessLicenseType")]
        public string BusinessLicenseType{ get; set; }

        /// <summary>
        /// 法人证件过期时间（yyyy-mm-dd）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BossEndDate")]
        public string BossEndDate{ get; set; }

        /// <summary>
        /// 营业执照编号（系统有唯一性校验）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BusinessLicenseNo")]
        public string BusinessLicenseNo{ get; set; }

        /// <summary>
        /// 机构名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AgentName")]
        public string AgentName{ get; set; }

        /// <summary>
        /// 商户简介
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Intro")]
        public string Intro{ get; set; }

        /// <summary>
        /// 法人证件类型（1居民身份证,2临时居民身份证,3居民户口簿,4护照,5港澳居民来往内地通行证,6回乡证,7军人证,8武警身份证,9其他法定文件）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BossIdType")]
        public string BossIdType{ get; set; }

        /// <summary>
        /// 添加时间（yyyy-mm-dd hh:ii:ss）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// 门店数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShopCount")]
        public string ShopCount{ get; set; }

        /// <summary>
        /// 结算账户人身份（1法人，2法人亲属），结算帐户为对私时必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountBoss")]
        public string AccountBoss{ get; set; }

        /// <summary>
        /// 分类名称(多个以小写逗号分开)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClassificationNames")]
        public string ClassificationNames{ get; set; }

        /// <summary>
        /// 法人电话
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BossTelephone")]
        public string BossTelephone{ get; set; }

        /// <summary>
        /// 客户经理姓名，必须为系统后台的管理员真实姓名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountManagerName")]
        public string AccountManagerName{ get; set; }

        /// <summary>
        /// 终端数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TerminalCount")]
        public string TerminalCount{ get; set; }

        /// <summary>
        /// 审核备注
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 财务联系人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FinancialContact")]
        public string FinancialContact{ get; set; }

        /// <summary>
        /// 商户名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MerchantName")]
        public string MerchantName{ get; set; }

        /// <summary>
        /// 法人性别（1男，2女）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BossSex")]
        public string BossSex{ get; set; }

        /// <summary>
        /// 商户编号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MerchantNo")]
        public string MerchantNo{ get; set; }

        /// <summary>
        /// 法人住址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BossAddress")]
        public string BossAddress{ get; set; }

        /// <summary>
        /// 县/区
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }

        /// <summary>
        /// 详细地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 法人职业
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BossJob")]
        public string BossJob{ get; set; }

        /// <summary>
        /// 许可证图片【私密区】
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LicencePicture")]
        public string LicencePicture{ get; set; }

        /// <summary>
        /// 组织机构代码证过期时间（yyyy-mm-dd）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrganizationCodeEndDate")]
        public string OrganizationCodeEndDate{ get; set; }

        /// <summary>
        /// 营业时间，多个以小写逗号分开(9:00-12:00,13:00-18:00)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OpenHours")]
        public string OpenHours{ get; set; }

        /// <summary>
        /// 其他资料2
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OtherPictureTwo")]
        public string OtherPictureTwo{ get; set; }

        /// <summary>
        /// 其他资料1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OtherPictureOne")]
        public string OtherPictureOne{ get; set; }

        /// <summary>
        /// 银行户名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName{ get; set; }

        /// <summary>
        /// 合同数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContractCount")]
        public string ContractCount{ get; set; }

        /// <summary>
        /// 授权文件【私密区】（当结算帐户身份为法人亲属时必传）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LicencePictureTwo")]
        public string LicencePictureTwo{ get; set; }

        /// <summary>
        /// 银行账号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountNo")]
        public string AccountNo{ get; set; }

        /// <summary>
        /// 法人邮箱
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BossEmail")]
        public string BossEmail{ get; set; }

        /// <summary>
        /// 结算账户类型（2对私，1对公）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountType")]
        public string AccountType{ get; set; }

        /// <summary>
        /// 税务登记证过期时间（yyyy-mm-dd）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaxCollectionEndDate")]
        public string TaxCollectionEndDate{ get; set; }

        /// <summary>
        /// 开户行名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BankName")]
        public string BankName{ get; set; }

        /// <summary>
        /// 联系电话
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Telephone")]
        public string Telephone{ get; set; }

        /// <summary>
        /// 外部商户主键编号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutMerchantId")]
        public string OutMerchantId{ get; set; }

        /// <summary>
        /// 城市编码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CityId")]
        public string CityId{ get; set; }

        /// <summary>
        /// 法人证件国别/地区（中国CHN，香港HKG，澳门MAC，台湾CTN）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BossIdCount")]
        public string BossIdCount{ get; set; }

        /// <summary>
        /// 商户标记，自定义参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// 财务联系人电话
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FinancialTelephone")]
        public string FinancialTelephone{ get; set; }

        /// <summary>
        /// 法人姓名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BossName")]
        public string BossName{ get; set; }

        /// <summary>
        /// 组织机构代码证生效时间（yyyy-mm-dd）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrganizationCodeStartDate")]
        public string OrganizationCodeStartDate{ get; set; }

        /// <summary>
        /// 商户logo【公共区】
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Logo")]
        public string Logo{ get; set; }

        /// <summary>
        /// 其他资料4
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OtherPictureFour")]
        public string OtherPictureFour{ get; set; }

        /// <summary>
        /// 税务登记证号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaxCollectionNo")]
        public string TaxCollectionNo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "TaxCollectionPicture", this.TaxCollectionPicture);
            this.SetParamSimple(map, prefix + "BossIdNo", this.BossIdNo);
            this.SetParamSimple(map, prefix + "AccountIdNo", this.AccountIdNo);
            this.SetParamSimple(map, prefix + "OtherPictureThree", this.OtherPictureThree);
            this.SetParamSimple(map, prefix + "AccountIdType", this.AccountIdType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "BusinessLicensePicture", this.BusinessLicensePicture);
            this.SetParamSimple(map, prefix + "BrandName", this.BrandName);
            this.SetParamSimple(map, prefix + "BossPositive", this.BossPositive);
            this.SetParamSimple(map, prefix + "AppCount", this.AppCount);
            this.SetParamSimple(map, prefix + "BossBack", this.BossBack);
            this.SetParamSimple(map, prefix + "OrganizationCodePicture", this.OrganizationCodePicture);
            this.SetParamSimple(map, prefix + "BusinessLicenseEndDate", this.BusinessLicenseEndDate);
            this.SetParamSimple(map, prefix + "OrganizationCodeNo", this.OrganizationCodeNo);
            this.SetParamSimple(map, prefix + "AgentNo", this.AgentNo);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "BossStartDate", this.BossStartDate);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "BankNo", this.BankNo);
            this.SetParamSimple(map, prefix + "TaxCollectionStartDate", this.TaxCollectionStartDate);
            this.SetParamSimple(map, prefix + "BusinessLicenseStartDate", this.BusinessLicenseStartDate);
            this.SetParamSimple(map, prefix + "AccountManagerId", this.AccountManagerId);
            this.SetParamSimple(map, prefix + "ClassificationIds", this.ClassificationIds);
            this.SetParamSimple(map, prefix + "BusinessLicenseType", this.BusinessLicenseType);
            this.SetParamSimple(map, prefix + "BossEndDate", this.BossEndDate);
            this.SetParamSimple(map, prefix + "BusinessLicenseNo", this.BusinessLicenseNo);
            this.SetParamSimple(map, prefix + "AgentName", this.AgentName);
            this.SetParamSimple(map, prefix + "Intro", this.Intro);
            this.SetParamSimple(map, prefix + "BossIdType", this.BossIdType);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "ShopCount", this.ShopCount);
            this.SetParamSimple(map, prefix + "AccountBoss", this.AccountBoss);
            this.SetParamSimple(map, prefix + "ClassificationNames", this.ClassificationNames);
            this.SetParamSimple(map, prefix + "BossTelephone", this.BossTelephone);
            this.SetParamSimple(map, prefix + "AccountManagerName", this.AccountManagerName);
            this.SetParamSimple(map, prefix + "TerminalCount", this.TerminalCount);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "FinancialContact", this.FinancialContact);
            this.SetParamSimple(map, prefix + "MerchantName", this.MerchantName);
            this.SetParamSimple(map, prefix + "BossSex", this.BossSex);
            this.SetParamSimple(map, prefix + "MerchantNo", this.MerchantNo);
            this.SetParamSimple(map, prefix + "BossAddress", this.BossAddress);
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "BossJob", this.BossJob);
            this.SetParamSimple(map, prefix + "LicencePicture", this.LicencePicture);
            this.SetParamSimple(map, prefix + "OrganizationCodeEndDate", this.OrganizationCodeEndDate);
            this.SetParamSimple(map, prefix + "OpenHours", this.OpenHours);
            this.SetParamSimple(map, prefix + "OtherPictureTwo", this.OtherPictureTwo);
            this.SetParamSimple(map, prefix + "OtherPictureOne", this.OtherPictureOne);
            this.SetParamSimple(map, prefix + "AccountName", this.AccountName);
            this.SetParamSimple(map, prefix + "ContractCount", this.ContractCount);
            this.SetParamSimple(map, prefix + "LicencePictureTwo", this.LicencePictureTwo);
            this.SetParamSimple(map, prefix + "AccountNo", this.AccountNo);
            this.SetParamSimple(map, prefix + "BossEmail", this.BossEmail);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamSimple(map, prefix + "TaxCollectionEndDate", this.TaxCollectionEndDate);
            this.SetParamSimple(map, prefix + "BankName", this.BankName);
            this.SetParamSimple(map, prefix + "Telephone", this.Telephone);
            this.SetParamSimple(map, prefix + "OutMerchantId", this.OutMerchantId);
            this.SetParamSimple(map, prefix + "CityId", this.CityId);
            this.SetParamSimple(map, prefix + "BossIdCount", this.BossIdCount);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamSimple(map, prefix + "FinancialTelephone", this.FinancialTelephone);
            this.SetParamSimple(map, prefix + "BossName", this.BossName);
            this.SetParamSimple(map, prefix + "OrganizationCodeStartDate", this.OrganizationCodeStartDate);
            this.SetParamSimple(map, prefix + "Logo", this.Logo);
            this.SetParamSimple(map, prefix + "OtherPictureFour", this.OtherPictureFour);
            this.SetParamSimple(map, prefix + "TaxCollectionNo", this.TaxCollectionNo);
        }
    }
}

