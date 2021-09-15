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

namespace TencentCloud.Essbasic.V20201222.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSubOrganizationAndSealRequest : AbstractModel
    {
        
        /// <summary>
        /// 调用方信息
        /// </summary>
        [JsonProperty("Caller")]
        public Caller Caller{ get; set; }

        /// <summary>
        /// 机构名称全称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 机构证件号码类型可选值：
        /// 1. USCC - 统一社会信用代码
        /// 2. BIZREGISTNO - 营业执照注册号
        /// </summary>
        [JsonProperty("IdCardType")]
        public string IdCardType{ get; set; }

        /// <summary>
        /// 机构证件号码
        /// </summary>
        [JsonProperty("IdCardNumber")]
        public string IdCardNumber{ get; set; }

        /// <summary>
        /// 机构类型可选值：
        /// 1. ENTERPRISE - 企业
        /// 2. INDIVIDUALBIZ - 个体工商户
        /// 3. PUBLICINSTITUTION - 政府/事业单位
        /// 4. OTHERS - 其他组织
        /// </summary>
        [JsonProperty("OrganizationType")]
        public string OrganizationType{ get; set; }

        /// <summary>
        /// 机构法人/经营者姓名
        /// </summary>
        [JsonProperty("LegalName")]
        public string LegalName{ get; set; }

        /// <summary>
        /// 机构法人/经营者证件类型可选值：
        /// 1. ID_CARD - 居民身份证
        /// 2. PASSPORT - 护照
        /// 3. MAINLAND_TRAVEL_PERMIT_FOR_HONGKONG_AND_MACAO_RESIDENTS - 港澳居民来往内地通行证
        /// 4. MAINLAND_TRAVEL_PERMIT_FOR_TAIWAN_RESIDENTS - 台湾居民来往大陆通行证
        /// 5. HOUSEHOLD_REGISTER - 户口本
        /// 6. TEMP_ID_CARD - 临时居民身份证
        /// </summary>
        [JsonProperty("LegalIdCardType")]
        public string LegalIdCardType{ get; set; }

        /// <summary>
        /// 机构法人/经营者证件号码；
        /// OrganizationType 为 ENTERPRISE时，INDIVIDUALBIZ 时必填，其他情况选填
        /// </summary>
        [JsonProperty("LegalIdCardNumber")]
        public string LegalIdCardNumber{ get; set; }

        /// <summary>
        /// 实名认证的客户端IP/请求生成企业印章的客户端Ip
        /// </summary>
        [JsonProperty("VerifyClientIp")]
        public string VerifyClientIp{ get; set; }

        /// <summary>
        /// 机构电子邮箱
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 机构证件文件类型可选值：
        /// 1. USCCFILE - 统一社会信用代码证书
        /// 2. LICENSEFILE - 营业执照
        /// </summary>
        [JsonProperty("IdCardFileType")]
        public string IdCardFileType{ get; set; }

        /// <summary>
        /// 机构证件照片文件，base64编码，支持jpg、jpeg、png格式
        /// </summary>
        [JsonProperty("BizLicenseFile")]
        public string BizLicenseFile{ get; set; }

        /// <summary>
        /// 机构证件照片文件名
        /// </summary>
        [JsonProperty("BizLicenseFileName")]
        public string BizLicenseFileName{ get; set; }

        /// <summary>
        /// 机构法人/经营者/联系人手机号码
        /// </summary>
        [JsonProperty("LegalMobile")]
        public string LegalMobile{ get; set; }

        /// <summary>
        /// 组织联系人姓名
        /// </summary>
        [JsonProperty("ContactName")]
        public string ContactName{ get; set; }

        /// <summary>
        /// 实名认证的服务器IP
        /// </summary>
        [JsonProperty("VerifyServerIp")]
        public string VerifyServerIp{ get; set; }

        /// <summary>
        /// 企业联系地址
        /// </summary>
        [JsonProperty("ContactAddress")]
        public Address ContactAddress{ get; set; }

        /// <summary>
        /// 电子印章名称
        /// </summary>
        [JsonProperty("SealName")]
        public string SealName{ get; set; }

        /// <summary>
        /// 印章类型：默认: CONTRACT
        /// 1. OFFICIAL-公章
        /// 2. SPECIAL_FINANCIAL-财务专用章
        /// 3. CONTRACT-合同专用章
        /// 4. LEGAL_REPRESENTATIVE-法定代表人章
        /// 5. SPECIAL_NATIONWIDE_INVOICE-发票专用章
        /// 6. OTHER-其他
        /// </summary>
        [JsonProperty("SealType")]
        public string SealType{ get; set; }

        /// <summary>
        /// 企业印章横向文字，最多可填8个汉字（可为空，默认为"电子签名专用章"）
        /// </summary>
        [JsonProperty("SealHorizontalText")]
        public string SealHorizontalText{ get; set; }

        /// <summary>
        /// 机构在第三方的唯一标识，32位以内标识符
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 是否使用OpenId作为数据主键，如果为true，请确保OpenId在当前应用号唯一
        /// </summary>
        [JsonProperty("UseOpenId")]
        public bool? UseOpenId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Caller.", this.Caller);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IdCardType", this.IdCardType);
            this.SetParamSimple(map, prefix + "IdCardNumber", this.IdCardNumber);
            this.SetParamSimple(map, prefix + "OrganizationType", this.OrganizationType);
            this.SetParamSimple(map, prefix + "LegalName", this.LegalName);
            this.SetParamSimple(map, prefix + "LegalIdCardType", this.LegalIdCardType);
            this.SetParamSimple(map, prefix + "LegalIdCardNumber", this.LegalIdCardNumber);
            this.SetParamSimple(map, prefix + "VerifyClientIp", this.VerifyClientIp);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "IdCardFileType", this.IdCardFileType);
            this.SetParamSimple(map, prefix + "BizLicenseFile", this.BizLicenseFile);
            this.SetParamSimple(map, prefix + "BizLicenseFileName", this.BizLicenseFileName);
            this.SetParamSimple(map, prefix + "LegalMobile", this.LegalMobile);
            this.SetParamSimple(map, prefix + "ContactName", this.ContactName);
            this.SetParamSimple(map, prefix + "VerifyServerIp", this.VerifyServerIp);
            this.SetParamObj(map, prefix + "ContactAddress.", this.ContactAddress);
            this.SetParamSimple(map, prefix + "SealName", this.SealName);
            this.SetParamSimple(map, prefix + "SealType", this.SealType);
            this.SetParamSimple(map, prefix + "SealHorizontalText", this.SealHorizontalText);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "UseOpenId", this.UseOpenId);
        }
    }
}

