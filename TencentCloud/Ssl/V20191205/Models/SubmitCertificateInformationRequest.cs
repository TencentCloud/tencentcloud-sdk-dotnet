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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitCertificateInformationRequest : AbstractModel
    {
        
        /// <summary>
        /// 待提交资料的付费证书 ID。
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// 此字段必传。 CSR 生成方式， 取值为：
        /// online：腾讯云提交的填写的参数信息生成CSR和私钥， 并由腾讯云加密存储
        /// parse：自行生成CSR和私钥， 并通过上传CSR申请证书
        /// </summary>
        [JsonProperty("CsrType")]
        public string CsrType{ get; set; }

        /// <summary>
        /// 上传的 CSR 内容。
        /// 若CstType为parse， 则此字段必传。
        /// </summary>
        [JsonProperty("CsrContent")]
        public string CsrContent{ get; set; }

        /// <summary>
        /// 证书绑定的通用名称， 若是上传的CSR，则该域名需与CSR解析的通用名称一致
        /// </summary>
        [JsonProperty("CertificateDomain")]
        public string CertificateDomain{ get; set; }

        /// <summary>
        /// 证书绑定的其他域名， 单域名、泛域名证书无需提供。 多域名、多泛域名必填
        /// </summary>
        [JsonProperty("DomainList")]
        public string[] DomainList{ get; set; }

        /// <summary>
        /// 私钥密码， 目前仅使用在生成jks、pfx格式证书时密码； 其他格式私钥证书未加密	
        /// </summary>
        [JsonProperty("KeyPassword")]
        public string KeyPassword{ get; set; }

        /// <summary>
        /// 字段必传， 公司名称。
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 字段必传， 部门名称。
        /// </summary>
        [JsonProperty("OrganizationDivision")]
        public string OrganizationDivision{ get; set; }

        /// <summary>
        /// 字段必传， 公司详细地址。
        /// </summary>
        [JsonProperty("OrganizationAddress")]
        public string OrganizationAddress{ get; set; }

        /// <summary>
        /// 字段必传， 国家名称，传CN即可
        /// </summary>
        [JsonProperty("OrganizationCountry")]
        public string OrganizationCountry{ get; set; }

        /// <summary>
        /// 字段必传， 公司所在城市。
        /// </summary>
        [JsonProperty("OrganizationCity")]
        public string OrganizationCity{ get; set; }

        /// <summary>
        /// 字段必传， 公司所在省份。
        /// </summary>
        [JsonProperty("OrganizationRegion")]
        public string OrganizationRegion{ get; set; }

        /// <summary>
        /// 公司邮编。
        /// </summary>
        [JsonProperty("PostalCode")]
        public string PostalCode{ get; set; }

        /// <summary>
        /// 字段必传， 公司座机区号。
        /// </summary>
        [JsonProperty("PhoneAreaCode")]
        public string PhoneAreaCode{ get; set; }

        /// <summary>
        /// 字段必传， 公司座机号码。
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// 证书验证方式。验证类型：DNS_AUTO = 自动DNS验证（仅支持在腾讯云解析且解析状态正常的域名使用该验证类型），DNS = 手动DNS验证，FILE = 文件验证。
        /// </summary>
        [JsonProperty("VerifyType")]
        public string VerifyType{ get; set; }

        /// <summary>
        /// 字段必传，管理人名。
        /// </summary>
        [JsonProperty("AdminFirstName")]
        public string AdminFirstName{ get; set; }

        /// <summary>
        /// 字段必传，管理人姓。
        /// </summary>
        [JsonProperty("AdminLastName")]
        public string AdminLastName{ get; set; }

        /// <summary>
        /// 字段必传，管理人手机号码。
        /// </summary>
        [JsonProperty("AdminPhoneNum")]
        public string AdminPhoneNum{ get; set; }

        /// <summary>
        /// 字段必传，管理人邮箱地址。
        /// </summary>
        [JsonProperty("AdminEmail")]
        public string AdminEmail{ get; set; }

        /// <summary>
        /// 字段必传，管理人职位。
        /// </summary>
        [JsonProperty("AdminPosition")]
        public string AdminPosition{ get; set; }

        /// <summary>
        /// 字段必传，联系人名。
        /// </summary>
        [JsonProperty("ContactFirstName")]
        public string ContactFirstName{ get; set; }

        /// <summary>
        /// 字段必传，联系人姓。
        /// </summary>
        [JsonProperty("ContactLastName")]
        public string ContactLastName{ get; set; }

        /// <summary>
        /// 字段必传，联系人邮箱地址。
        /// </summary>
        [JsonProperty("ContactEmail")]
        public string ContactEmail{ get; set; }

        /// <summary>
        /// 字段必传，联系人手机号码。
        /// </summary>
        [JsonProperty("ContactNumber")]
        public string ContactNumber{ get; set; }

        /// <summary>
        /// 字段必传，联系人职位。
        /// </summary>
        [JsonProperty("ContactPosition")]
        public string ContactPosition{ get; set; }

        /// <summary>
        /// 是否DV证书。默认false
        /// </summary>
        [JsonProperty("IsDV")]
        public bool? IsDV{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamSimple(map, prefix + "CsrType", this.CsrType);
            this.SetParamSimple(map, prefix + "CsrContent", this.CsrContent);
            this.SetParamSimple(map, prefix + "CertificateDomain", this.CertificateDomain);
            this.SetParamArraySimple(map, prefix + "DomainList.", this.DomainList);
            this.SetParamSimple(map, prefix + "KeyPassword", this.KeyPassword);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "OrganizationDivision", this.OrganizationDivision);
            this.SetParamSimple(map, prefix + "OrganizationAddress", this.OrganizationAddress);
            this.SetParamSimple(map, prefix + "OrganizationCountry", this.OrganizationCountry);
            this.SetParamSimple(map, prefix + "OrganizationCity", this.OrganizationCity);
            this.SetParamSimple(map, prefix + "OrganizationRegion", this.OrganizationRegion);
            this.SetParamSimple(map, prefix + "PostalCode", this.PostalCode);
            this.SetParamSimple(map, prefix + "PhoneAreaCode", this.PhoneAreaCode);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "VerifyType", this.VerifyType);
            this.SetParamSimple(map, prefix + "AdminFirstName", this.AdminFirstName);
            this.SetParamSimple(map, prefix + "AdminLastName", this.AdminLastName);
            this.SetParamSimple(map, prefix + "AdminPhoneNum", this.AdminPhoneNum);
            this.SetParamSimple(map, prefix + "AdminEmail", this.AdminEmail);
            this.SetParamSimple(map, prefix + "AdminPosition", this.AdminPosition);
            this.SetParamSimple(map, prefix + "ContactFirstName", this.ContactFirstName);
            this.SetParamSimple(map, prefix + "ContactLastName", this.ContactLastName);
            this.SetParamSimple(map, prefix + "ContactEmail", this.ContactEmail);
            this.SetParamSimple(map, prefix + "ContactNumber", this.ContactNumber);
            this.SetParamSimple(map, prefix + "ContactPosition", this.ContactPosition);
            this.SetParamSimple(map, prefix + "IsDV", this.IsDV);
        }
    }
}

