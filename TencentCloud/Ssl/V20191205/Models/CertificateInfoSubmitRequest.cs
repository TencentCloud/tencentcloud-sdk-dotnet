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

    public class CertificateInfoSubmitRequest : AbstractModel
    {
        
        /// <summary>
        /// 待提交资料的付费证书 ID。	
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// 此字段必传。 CSR 生成方式， 取值为：
        /// - online：腾讯云提交的填写的参数信息生成CSR和私钥，并由腾讯云加密存储
        /// - parse：自行生成CSR和私钥，并通过上传CSR申请证书
        /// </summary>
        [JsonProperty("GenCsrType")]
        public string GenCsrType{ get; set; }

        /// <summary>
        /// 证书绑定的通用名称， 若是上传的CSR，则该域名需与CSR解析的通用名称一致
        /// </summary>
        [JsonProperty("CertCommonName")]
        public string CertCommonName{ get; set; }

        /// <summary>
        /// 组织信息类型， 取值范围：
        /// 1（个人）：仅DV类型证书可设置为1， 个人类型证书组织信息字段可不传：Org开头，Admin开头，Tech开头
        /// 2（公司）：所有类型证书都可设置为2， 按需传组织信息字段
        /// </summary>
        [JsonProperty("CompanyType")]
        public ulong? CompanyType{ get; set; }

        /// <summary>
        /// 公司ID，在 [腾讯云控制台](https://console.cloud.tencent.com/ssl/info) 可进行查看，若无满足的公司信息， 则本参数传0 ； 若存在满足当前订单的公司信息， 可以根据 [DescribeCompanies](https://cloud.tencent.com/document/product/400/90375) 查看公司ID； 若传了公司ID，则Org开头的参数可不传
        /// 
        /// </summary>
        [JsonProperty("CompanyId")]
        public string CompanyId{ get; set; }

        /// <summary>
        /// 公司证件类型，取值范围：
        /// TYDMZ（统一社会信用代码 ）：仅CFCA类型证书需要使用本字段， 其他类型证书不需要使用本字段
        /// OTHERS（其他）
        /// </summary>
        [JsonProperty("OrgIdType")]
        public string OrgIdType{ get; set; }

        /// <summary>
        /// 公司证件号码，取值范围：
        /// TYDMZ（统一社会信用代码 ）：11532xxxxxxxx24820
        /// </summary>
        [JsonProperty("OrgIdNumber")]
        public string OrgIdNumber{ get; set; }

        /// <summary>
        /// 管理人证件类型，取值范围：
        /// SFZ（身份证）：仅CFCA类型证书需要使用本字段， 其他类型证书不需要使用本字段
        /// HZ（护照）：仅CFCA类型证书需要使用本字段， 其他类型证书不需要使用本字段
        /// </summary>
        [JsonProperty("AdminIdType")]
        public string AdminIdType{ get; set; }

        /// <summary>
        /// 管理人证件号码，仅CFCA类型证书需要使用本字段， 其他类型证书不需要使用本字段， 取值范围：
        /// SFZ（身份证）：110000xxxxxxxx1242
        /// HZ（护照）:EFxxxxxxx
        /// </summary>
        [JsonProperty("AdminIdNumber")]
        public string AdminIdNumber{ get; set; }

        /// <summary>
        /// 联系人证件类型，取值范围：
        /// SFZ（身份证）：仅CFCA类型证书需要使用本字段， 其他类型证书不需要使用本字段
        /// HZ（护照）：仅CFCA类型证书需要使用本字段， 其他类型证书不需要使用本字段
        /// </summary>
        [JsonProperty("TechIdType")]
        public string TechIdType{ get; set; }

        /// <summary>
        /// 联系人证件号码，仅CFCA类型证书需要使用本字段， 其他类型证书不需要使用本字段，取值范围：
        /// SFZ（身份证）：110000xxxxxxxx1242
        /// HZ（护照）:EFxxxxxxx
        /// </summary>
        [JsonProperty("TechIdNumber")]
        public string TechIdNumber{ get; set; }

        /// <summary>
        /// 上传的 CSR 内容。
        /// 若GenCsrType为parse， 则此字段必传。
        /// </summary>
        [JsonProperty("Csr")]
        public string Csr{ get; set; }

        /// <summary>
        /// 证书绑定的其他域名， 单域名、泛域名证书无需提供。 多域名、多泛域名必填
        /// </summary>
        [JsonProperty("DnsNames")]
        public string[] DnsNames{ get; set; }

        /// <summary>
        /// 私钥密码， 目前仅使用在生成jks、pfx格式证书时密码； 其他格式私钥证书未加密	
        /// </summary>
        [JsonProperty("KeyPass")]
        public string KeyPass{ get; set; }

        /// <summary>
        /// 公司名称。若没有传CompanyId或者ManagerId， 则此字段必传
        /// </summary>
        [JsonProperty("OrgOrganization")]
        public string OrgOrganization{ get; set; }

        /// <summary>
        /// 部门名称。若没有传CompanyId或者ManagerId， 则此字段必传
        /// </summary>
        [JsonProperty("OrgDivision")]
        public string OrgDivision{ get; set; }

        /// <summary>
        /// 公司详细地址。若没有传CompanyId或者ManagerId， 则此字段必传
        /// </summary>
        [JsonProperty("OrgAddress")]
        public string OrgAddress{ get; set; }

        /// <summary>
        /// 国家名称，如中国：CN 。若没有传CompanyId或者ManagerId， 则此字段必传
        /// </summary>
        [JsonProperty("OrgCountry")]
        public string OrgCountry{ get; set; }

        /// <summary>
        /// 公司所在城市。若没有传CompanyId或者ManagerId， 则此字段必传
        /// </summary>
        [JsonProperty("OrgCity")]
        public string OrgCity{ get; set; }

        /// <summary>
        /// 公司所在省份。若没有传CompanyId或者ManagerId， 则此字段必传
        /// </summary>
        [JsonProperty("OrgRegion")]
        public string OrgRegion{ get; set; }

        /// <summary>
        /// 公司所属区号。若没有传CompanyId或者ManagerId， 则此字段必传
        /// 如：021。  手机号码传 86
        /// </summary>
        [JsonProperty("OrgPhoneArea")]
        public string OrgPhoneArea{ get; set; }

        /// <summary>
        /// 公司所属号码。若没有传CompanyId或者ManagerId， 则此字段必传
        /// </summary>
        [JsonProperty("OrgPhoneNumber")]
        public string OrgPhoneNumber{ get; set; }

        /// <summary>
        /// 证书域名验证方式：
        /// DNS_AUTO： 自动添加域名DNS验证， 需用户域名解析托管在『[云解析DNS](https://console.cloud.tencent.com/cns)』，且与申请证书归属同一个腾讯云账号
        /// DNS：手动添加域名DNS验证，需用户手动去域名解析服务商添加验证值
        /// FILE：手动添加域名文件验证。 需要用户手动在域名站点根目录添加指定路径文件进行文件验证， http&https任一通过即可；且域名站点需海外CA机构能访问， 具体访问白名单为：64.78.193.238，216.168.247.9，216.168.249.9，54.189.196.217
        /// </summary>
        [JsonProperty("VerifyType")]
        public string VerifyType{ get; set; }

        /// <summary>
        /// 管理人名。若没有传ManagerId， 则此字段必传
        /// </summary>
        [JsonProperty("AdminFirstName")]
        public string AdminFirstName{ get; set; }

        /// <summary>
        /// 管理人姓。若没有传ManagerId， 则此字段必传
        /// </summary>
        [JsonProperty("AdminLastName")]
        public string AdminLastName{ get; set; }

        /// <summary>
        /// 管理人手机号码。若没有传ManagerId， 则此字段必传
        /// </summary>
        [JsonProperty("AdminPhone")]
        public string AdminPhone{ get; set; }

        /// <summary>
        /// 管理人邮箱地址。若没有传ManagerId， 则此字段必传
        /// </summary>
        [JsonProperty("AdminEmail")]
        public string AdminEmail{ get; set; }

        /// <summary>
        /// 管理人职位。若没有传ManagerId， 则此字段必传
        /// </summary>
        [JsonProperty("AdminTitle")]
        public string AdminTitle{ get; set; }

        /// <summary>
        /// 联系人名。若没有传ManagerId， 则此字段必传
        /// </summary>
        [JsonProperty("TechFirstName")]
        public string TechFirstName{ get; set; }

        /// <summary>
        /// 联系人姓。若没有传ManagerId， 则此字段必传
        /// </summary>
        [JsonProperty("TechLastName")]
        public string TechLastName{ get; set; }

        /// <summary>
        /// 联系人邮箱地址。CompanyType为1时， 此字段必传
        /// </summary>
        [JsonProperty("ContactEmail")]
        public string ContactEmail{ get; set; }

        /// <summary>
        /// 是否开启自动续费： 0， 不开启；  1， 开启； 默认为0
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 密钥对参数，RSA支持2048，4096。ECC仅支持prime256v1。当 CSR 生成方式为online的时候，此参数必填。
        /// </summary>
        [JsonProperty("CsrKeyParameter")]
        public string CsrKeyParameter{ get; set; }

        /// <summary>
        /// 加密算法，取值为ECC、RSA， 默认为RSA。当 CSR 生成方式为online的时候，此参数必填。
        /// </summary>
        [JsonProperty("CsrEncryptAlgo")]
        public string CsrEncryptAlgo{ get; set; }

        /// <summary>
        /// 管理人ID，在 [腾讯云控制台](https://console.cloud.tencent.com/ssl/info) 可进行查看，若无满足的管理人信息， 则本参数传0 ； 若存在满足当前订单的管理人信息， 可以根据 [DescribeManagers](https://cloud.tencent.com/document/product/400/52672) 查看管理人ID； 若传了管理人ID，则Org开头、Admin开头、Tech开头的参数可不传； 管理人ID会包含公司信息
        /// </summary>
        [JsonProperty("ManagerId")]
        public string ManagerId{ get; set; }

        /// <summary>
        /// 联系人电话。若没有传ManagerId， 则此字段必传
        /// </summary>
        [JsonProperty("TechPhone")]
        public string TechPhone{ get; set; }

        /// <summary>
        /// 联系人邮箱
        /// </summary>
        [JsonProperty("TechEmail")]
        public string TechEmail{ get; set; }

        /// <summary>
        /// 联系人职位。若没有传ManagerId， 则此字段必传
        /// </summary>
        [JsonProperty("TechTitle")]
        public string TechTitle{ get; set; }

        /// <summary>
        /// 证书类型
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 只针对Dnspod系列证书有效，ca机构类型可为sectigo和digicert
        /// </summary>
        [JsonProperty("CaType")]
        public string CaType{ get; set; }

        /// <summary>
        /// 签名算法
        /// </summary>
        [JsonProperty("SignAlgo")]
        public string SignAlgo{ get; set; }

        /// <summary>
        /// 是否使用交叉根证书
        /// </summary>
        [JsonProperty("UseCrossSignRoot")]
        public bool? UseCrossSignRoot{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "GenCsrType", this.GenCsrType);
            this.SetParamSimple(map, prefix + "CertCommonName", this.CertCommonName);
            this.SetParamSimple(map, prefix + "CompanyType", this.CompanyType);
            this.SetParamSimple(map, prefix + "CompanyId", this.CompanyId);
            this.SetParamSimple(map, prefix + "OrgIdType", this.OrgIdType);
            this.SetParamSimple(map, prefix + "OrgIdNumber", this.OrgIdNumber);
            this.SetParamSimple(map, prefix + "AdminIdType", this.AdminIdType);
            this.SetParamSimple(map, prefix + "AdminIdNumber", this.AdminIdNumber);
            this.SetParamSimple(map, prefix + "TechIdType", this.TechIdType);
            this.SetParamSimple(map, prefix + "TechIdNumber", this.TechIdNumber);
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
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CaType", this.CaType);
            this.SetParamSimple(map, prefix + "SignAlgo", this.SignAlgo);
            this.SetParamSimple(map, prefix + "UseCrossSignRoot", this.UseCrossSignRoot);
        }
    }
}

