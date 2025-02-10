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

    public class CertificateInfoSubmitRequest : AbstractModel
    {
        
        /// <summary>
        /// 证书 ID。
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// CSR 生成方式：online = 在线生成, upload = 手动上传。
        /// </summary>
        [JsonProperty("GenCsrType")]
        public string GenCsrType{ get; set; }

        /// <summary>
        /// 绑定证书的主域名。
        /// </summary>
        [JsonProperty("CertCommonName")]
        public string CertCommonName{ get; set; }

        /// <summary>
        /// 组织信息类型：1，个人； 2， 公司； 
        /// </summary>
        [JsonProperty("CompanyType")]
        public ulong? CompanyType{ get; set; }

        /// <summary>
        /// 公司证件类型（）
        /// </summary>
        [JsonProperty("OrgIdType")]
        public string OrgIdType{ get; set; }

        /// <summary>
        /// 公司证件号码
        /// </summary>
        [JsonProperty("OrgIdNumber")]
        public string OrgIdNumber{ get; set; }

        /// <summary>
        /// 管理人证件类型
        /// </summary>
        [JsonProperty("AdminIdType")]
        public string AdminIdType{ get; set; }

        /// <summary>
        /// 管理人证件号码
        /// </summary>
        [JsonProperty("AdminIdNumber")]
        public string AdminIdNumber{ get; set; }

        /// <summary>
        /// 联系人证件类型
        /// </summary>
        [JsonProperty("TechIdType")]
        public string TechIdType{ get; set; }

        /// <summary>
        /// 联系人证件号码
        /// </summary>
        [JsonProperty("TechIdNumber")]
        public string TechIdNumber{ get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        [JsonProperty("CompanyId")]
        public string CompanyId{ get; set; }

        /// <summary>
        /// 上传的 CSR 内容。如果GenCsrType为upload则该字段必传
        /// </summary>
        [JsonProperty("Csr")]
        public string Csr{ get; set; }

        /// <summary>
        /// 域名数组（多域名证书可以上传）。
        /// </summary>
        [JsonProperty("DnsNames")]
        public string[] DnsNames{ get; set; }

        /// <summary>
        /// 私钥密码（非必填）。
        /// </summary>
        [JsonProperty("KeyPass")]
        public string KeyPass{ get; set; }

        /// <summary>
        /// 公司名称。
        /// </summary>
        [JsonProperty("OrgOrganization")]
        public string OrgOrganization{ get; set; }

        /// <summary>
        /// 部门名称。
        /// </summary>
        [JsonProperty("OrgDivision")]
        public string OrgDivision{ get; set; }

        /// <summary>
        /// 公司详细地址。
        /// </summary>
        [JsonProperty("OrgAddress")]
        public string OrgAddress{ get; set; }

        /// <summary>
        /// 国家名称，如中国：CN 。
        /// </summary>
        [JsonProperty("OrgCountry")]
        public string OrgCountry{ get; set; }

        /// <summary>
        /// 公司所在城市。
        /// </summary>
        [JsonProperty("OrgCity")]
        public string OrgCity{ get; set; }

        /// <summary>
        /// 公司所在省份。
        /// </summary>
        [JsonProperty("OrgRegion")]
        public string OrgRegion{ get; set; }

        /// <summary>
        /// 公司座机区号。
        /// </summary>
        [JsonProperty("OrgPhoneArea")]
        public string OrgPhoneArea{ get; set; }

        /// <summary>
        /// 公司座机号码。
        /// </summary>
        [JsonProperty("OrgPhoneNumber")]
        public string OrgPhoneNumber{ get; set; }

        /// <summary>
        /// 证书验证方式。验证类型：DNS_AUTO = 自动DNS验证（仅支持在腾讯云解析且解析状态正常的域名使用该验证类型），DNS = 手动DNS验证，FILE = 文件验证。
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
        [JsonProperty("AdminPhone")]
        public string AdminPhone{ get; set; }

        /// <summary>
        /// 管理人邮箱地址。
        /// </summary>
        [JsonProperty("AdminEmail")]
        public string AdminEmail{ get; set; }

        /// <summary>
        /// 管理人职位。
        /// </summary>
        [JsonProperty("AdminTitle")]
        public string AdminTitle{ get; set; }

        /// <summary>
        /// 联系人名。
        /// </summary>
        [JsonProperty("TechFirstName")]
        public string TechFirstName{ get; set; }

        /// <summary>
        /// 联系人姓。
        /// </summary>
        [JsonProperty("TechLastName")]
        public string TechLastName{ get; set; }

        /// <summary>
        /// 联系人邮箱地址。
        /// </summary>
        [JsonProperty("ContactEmail")]
        public string ContactEmail{ get; set; }

        /// <summary>
        /// 是否开启自动续费： 0， 不开启；  1， 开启； 默认为0
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 证书加密参数
        /// </summary>
        [JsonProperty("CsrKeyParameter")]
        public string CsrKeyParameter{ get; set; }

        /// <summary>
        /// 证书加密方式
        /// </summary>
        [JsonProperty("CsrEncryptAlgo")]
        public string CsrEncryptAlgo{ get; set; }

        /// <summary>
        /// 管理人ID
        /// </summary>
        [JsonProperty("ManagerId")]
        public string ManagerId{ get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [JsonProperty("TechPhone")]
        public string TechPhone{ get; set; }

        /// <summary>
        /// 联系人邮箱
        /// </summary>
        [JsonProperty("TechEmail")]
        public string TechEmail{ get; set; }

        /// <summary>
        /// 联系人职位
        /// </summary>
        [JsonProperty("TechTitle")]
        public string TechTitle{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "GenCsrType", this.GenCsrType);
            this.SetParamSimple(map, prefix + "CertCommonName", this.CertCommonName);
            this.SetParamSimple(map, prefix + "CompanyType", this.CompanyType);
            this.SetParamSimple(map, prefix + "OrgIdType", this.OrgIdType);
            this.SetParamSimple(map, prefix + "OrgIdNumber", this.OrgIdNumber);
            this.SetParamSimple(map, prefix + "AdminIdType", this.AdminIdType);
            this.SetParamSimple(map, prefix + "AdminIdNumber", this.AdminIdNumber);
            this.SetParamSimple(map, prefix + "TechIdType", this.TechIdType);
            this.SetParamSimple(map, prefix + "TechIdNumber", this.TechIdNumber);
            this.SetParamSimple(map, prefix + "CompanyId", this.CompanyId);
            this.SetParamSimple(map, prefix + "Csr", this.Csr);
            this.SetParamArraySimple(map, prefix + "DnsNames.", this.DnsNames);
            this.SetParamSimple(map, prefix + "KeyPass", this.KeyPass);
            this.SetParamSimple(map, prefix + "OrgOrganization", this.OrgOrganization);
            this.SetParamSimple(map, prefix + "OrgDivision", this.OrgDivision);
            this.SetParamSimple(map, prefix + "OrgAddress", this.OrgAddress);
            this.SetParamSimple(map, prefix + "OrgCountry", this.OrgCountry);
            this.SetParamSimple(map, prefix + "OrgCity", this.OrgCity);
            this.SetParamSimple(map, prefix + "OrgRegion", this.OrgRegion);
            this.SetParamSimple(map, prefix + "OrgPhoneArea", this.OrgPhoneArea);
            this.SetParamSimple(map, prefix + "OrgPhoneNumber", this.OrgPhoneNumber);
            this.SetParamSimple(map, prefix + "VerifyType", this.VerifyType);
            this.SetParamSimple(map, prefix + "AdminFirstName", this.AdminFirstName);
            this.SetParamSimple(map, prefix + "AdminLastName", this.AdminLastName);
            this.SetParamSimple(map, prefix + "AdminPhone", this.AdminPhone);
            this.SetParamSimple(map, prefix + "AdminEmail", this.AdminEmail);
            this.SetParamSimple(map, prefix + "AdminTitle", this.AdminTitle);
            this.SetParamSimple(map, prefix + "TechFirstName", this.TechFirstName);
            this.SetParamSimple(map, prefix + "TechLastName", this.TechLastName);
            this.SetParamSimple(map, prefix + "ContactEmail", this.ContactEmail);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "CsrKeyParameter", this.CsrKeyParameter);
            this.SetParamSimple(map, prefix + "CsrEncryptAlgo", this.CsrEncryptAlgo);
            this.SetParamSimple(map, prefix + "ManagerId", this.ManagerId);
            this.SetParamSimple(map, prefix + "TechPhone", this.TechPhone);
            this.SetParamSimple(map, prefix + "TechEmail", this.TechEmail);
            this.SetParamSimple(map, prefix + "TechTitle", this.TechTitle);
        }
    }
}

