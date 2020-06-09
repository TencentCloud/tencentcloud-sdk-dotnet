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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitCertificateInformationRequest : AbstractModel
    {
        
        /// <summary>
        /// 证书 ID。
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// CSR 生成方式：online = 在线生成, parse = 手动上传。
        /// </summary>
        [JsonProperty("CsrType")]
        public string CsrType{ get; set; }

        /// <summary>
        /// 上传的 CSR 内容。
        /// </summary>
        [JsonProperty("CsrContent")]
        public string CsrContent{ get; set; }

        /// <summary>
        /// 绑定证书的域名。
        /// </summary>
        [JsonProperty("CertificateDomain")]
        public string CertificateDomain{ get; set; }

        /// <summary>
        /// 上传的域名数组（多域名证书可以上传）。
        /// </summary>
        [JsonProperty("DomainList")]
        public string[] DomainList{ get; set; }

        /// <summary>
        /// 私钥密码。
        /// </summary>
        [JsonProperty("KeyPassword")]
        public string KeyPassword{ get; set; }

        /// <summary>
        /// 公司名称。
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 部门名称。
        /// </summary>
        [JsonProperty("OrganizationDivision")]
        public string OrganizationDivision{ get; set; }

        /// <summary>
        /// 公司详细地址。
        /// </summary>
        [JsonProperty("OrganizationAddress")]
        public string OrganizationAddress{ get; set; }

        /// <summary>
        /// 国家名称，如中国：CN 。
        /// </summary>
        [JsonProperty("OrganizationCountry")]
        public string OrganizationCountry{ get; set; }

        /// <summary>
        /// 公司所在城市。
        /// </summary>
        [JsonProperty("OrganizationCity")]
        public string OrganizationCity{ get; set; }

        /// <summary>
        /// 公司所在省份。
        /// </summary>
        [JsonProperty("OrganizationRegion")]
        public string OrganizationRegion{ get; set; }

        /// <summary>
        /// 公司邮编。
        /// </summary>
        [JsonProperty("PostalCode")]
        public string PostalCode{ get; set; }

        /// <summary>
        /// 公司座机区号。
        /// </summary>
        [JsonProperty("PhoneAreaCode")]
        public string PhoneAreaCode{ get; set; }

        /// <summary>
        /// 公司座机号码。
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// 证书验证方式。
        /// </summary>
        [JsonProperty("VerifyType")]
        public string VerifyType{ get; set; }

        /// <summary>
        /// 管理人名。
        /// </summary>
        [JsonProperty("AdminFirstName")]
        public string AdminFirstName{ get; set; }

        /// <summary>
        /// 管理人姓。
        /// </summary>
        [JsonProperty("AdminLastName")]
        public string AdminLastName{ get; set; }

        /// <summary>
        /// 管理人手机号码。
        /// </summary>
        [JsonProperty("AdminPhoneNum")]
        public string AdminPhoneNum{ get; set; }

        /// <summary>
        /// 管理人邮箱地址。
        /// </summary>
        [JsonProperty("AdminEmail")]
        public string AdminEmail{ get; set; }

        /// <summary>
        /// 管理人职位。
        /// </summary>
        [JsonProperty("AdminPosition")]
        public string AdminPosition{ get; set; }

        /// <summary>
        /// 联系人名。
        /// </summary>
        [JsonProperty("ContactFirstName")]
        public string ContactFirstName{ get; set; }

        /// <summary>
        /// 联系人姓。
        /// </summary>
        [JsonProperty("ContactLastName")]
        public string ContactLastName{ get; set; }

        /// <summary>
        /// 联系人邮箱地址。
        /// </summary>
        [JsonProperty("ContactEmail")]
        public string ContactEmail{ get; set; }

        /// <summary>
        /// 联系人手机号码。
        /// </summary>
        [JsonProperty("ContactNumber")]
        public string ContactNumber{ get; set; }

        /// <summary>
        /// 联系人职位。
        /// </summary>
        [JsonProperty("ContactPosition")]
        public string ContactPosition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
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
        }
    }
}

