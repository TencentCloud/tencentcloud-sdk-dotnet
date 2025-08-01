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

    public class DescribeCertificateDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 证书所属用户主账号 UIN。
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// 项目 ID。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 证书来源：
        /// trustasia：亚洲诚信，
        /// upload：用户上传。
        /// wosign：沃通
        /// sheca：上海CA
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// 证书类型：CA = 客户端证书，SVR = 服务器证书。
        /// </summary>
        [JsonProperty("CertificateType")]
        public string CertificateType{ get; set; }

        /// <summary>
        /// 证书套餐类型：
        /// null：用户上传证书（没有套餐类型），
        /// 2：TrustAsia TLS RSA CA， 
        /// 3：SecureSite 增强型企业版（EV Pro）， 
        /// 4：SecureSite 增强型（EV）， 
        /// 5：SecureSite 企业型专业版（OV Pro），
        /// 6：SecureSite 企业型（OV）， 
        /// 7：SecureSite 企业型（OV）通配符， 
        /// 8：Geotrust 增强型（EV）， 
        /// 9：Geotrust 企业型（OV）， 
        /// 10：Geotrust 企业型（OV）通配符， 
        /// 11：TrustAsia 域名型多域名 SSL 证书， 
        /// 12：TrustAsia 域名型（DV）通配符， 
        /// 13：TrustAsia 企业型通配符（OV）SSL 证书（D3）， 
        /// 14：TrustAsia 企业型（OV）SSL 证书（D3）， 
        /// 15：TrustAsia 企业型多域名 （OV）SSL 证书（D3）， 
        /// 16：TrustAsia 增强型 （EV）SSL 证书（D3）， 
        /// 17：TrustAsia 增强型多域名（EV）SSL 证书（D3）， 
        /// 18：GlobalSign 企业型（OV）SSL 证书， 
        /// 19：GlobalSign 企业型通配符 （OV）SSL 证书， 
        /// 20：GlobalSign 增强型 （EV）SSL 证书， 
        /// 21：TrustAsia 企业型通配符多域名（OV）SSL 证书（D3）， 
        /// 22：GlobalSign 企业型多域名（OV）SSL 证书， 
        /// 23：GlobalSign 企业型通配符多域名（OV）SSL 证书，
        /// 24：GlobalSign 增强型多域名（EV）SSL 证书，
        /// 25：Wotrus 域名型证书，
        /// 26：Wotrus 域名型多域名证书，
        /// 27：Wotrus 域名型通配符证书，
        /// 28：Wotrus 企业型证书，
        /// 29：Wotrus 企业型多域名证书，
        /// 30：Wotrus 企业型通配符证书，
        /// 31：Wotrus 增强型证书，
        /// 32：Wotrus 增强型多域名证书，
        /// 33：WoTrus-国密域名型证书，
        /// 34：WoTrus-国密域名型证书（多域名），
        /// 35：WoTrus-国密域名型证书（通配符），
        /// 37：WoTrus-国密企业型证书，
        /// 38：WoTrus-国密企业型证书（多域名），
        /// 39：WoTrus-国密企业型证书（通配符），
        /// 40：WoTrus-国密增强型证书，
        /// 41：WoTrus-国密增强型证书（多域名），
        /// 42：TrustAsia-域名型证书（通配符多域名），
        /// 43：DNSPod-企业型(OV)SSL证书
        /// 44：DNSPod-企业型(OV)通配符SSL证书
        /// 45：DNSPod-企业型(OV)多域名SSL证书
        /// 46：DNSPod-增强型(EV)SSL证书
        /// 47：DNSPod-增强型(EV)多域名SSL证书
        /// 48：DNSPod-域名型(DV)SSL证书
        /// 49：DNSPod-域名型(DV)通配符SSL证书
        /// 50：DNSPod-域名型(DV)多域名SSL证书
        /// 51：DNSPod（国密）-企业型(OV)SSL证书
        /// 52：DNSPod（国密）-企业型(OV)通配符SSL证书
        /// 53：DNSPod（国密）-企业型(OV)多域名SSL证书
        /// 54：DNSPod（国密）-域名型(DV)SSL证书
        /// 55：DNSPod（国密）-域名型(DV)通配符SSL证书
        /// 56：DNSPod（国密）-域名型(DV)多域名SSL证书
        /// 57：SecureSite 企业型专业版多域名(OV Pro)
        /// 58：SecureSite 企业型多域名(OV)
        /// 59：SecureSite 增强型专业版多域名(EV Pro)
        /// 60：SecureSite 增强型多域名(EV)
        /// 61：Geotrust 增强型多域名(EV)
        /// 75：SecureSite 企业型(OV)
        /// 76：SecureSite 企业型(OV)通配符
        /// 77：SecureSite 增强型(EV)
        /// 78：Geotrust 企业型(OV)
        /// 79：Geotrust 企业型(OV)通配符
        /// 80：Geotrust 增强型(EV)
        /// 81：GlobalSign 企业型（OV）SSL证书
        /// 82：GlobalSign 企业型通配符 （OV）SSL证书
        /// 83：TrustAsia C1 DV Free
        /// 85：GlobalSign 增强型 （EV）SSL证书
        /// 88：GlobalSign 企业型通配符多域名 （OV）SSL证书
        /// 89：GlobalSign 企业型多域名 （OV）SSL证书
        /// 90：GlobalSign 增强型多域名（EV） SSL证书
        /// 91：Geotrust 增强型多域名(EV)
        /// 92：SecureSite 企业型专业版多域名(OV Pro)
        /// 93：SecureSite 企业型多域名(OV)
        /// 94：SecureSite 增强型专业版多域名(EV Pro)
        /// 95：SecureSite 增强型多域名(EV)
        /// 96：SecureSite 增强型专业版(EV Pro)
        /// 97：SecureSite 企业型专业版(OV Pro)
        /// 98：CFCA 企业型(OV)SSL证书
        /// 99：CFCA 企业型多域名(OV)SSL证书
        /// 100：CFCA 企业型通配符(OV)SSL证书
        /// 101：CFCA 增强型(EV)SSL证书
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// 证书产品名称
        /// </summary>
        [JsonProperty("ProductZhName")]
        public string ProductZhName{ get; set; }

        /// <summary>
        /// 证书绑定通用名称域名。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 备注名称。
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// 证书状态：0 = 审核中，1 = 已通过，2 = 审核失败，3 = 已过期，4 = 自动添加DNS记录，5 = 企业证书，待提交资料，6 = 订单取消中，7 = 已取消，8 = 已提交资料， 待上传确认函，9 = 证书吊销中，10 = 已吊销，11 = 重颁发中，12 = 待上传吊销确认函，13 = 免费证书待提交资料。14 = 证书已退款。 15 = 证书迁移中
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 状态信息。 取值范围：
        /// //通用状态信息
        /// 1、PRE-REVIEWING：预审核中
        /// 2、LEGAL-REVIEWING：法务审核中
        /// 3、CA-REVIEWING：CA审核中
        /// 4、PENDING-DCV：域名验证中
        /// 5、WAIT-ISSUE：等待签发（域名验证已通过）
        /// //证书审核失败状态信息
        /// 1、订单审核失败
        /// 2、CA审核失败，域名未通过安全审查
        /// 3、域名验证超时，订单自动关闭，请您重新进行证书申请
        /// 4、证书资料未通过证书CA机构审核，审核人员会致电您证书预留的联系方式，请您留意来电。后续可通过“修改资料”重新提交资料
        /// 待持续完善
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatusMsg")]
        public string StatusMsg{ get; set; }

        /// <summary>
        /// 验证类型：DNS_AUTO = 自动DNS验证，DNS = 手动DNS验证，FILE = 文件验证，EMAIL = 邮件验证。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VerifyType")]
        public string VerifyType{ get; set; }

        /// <summary>
        /// 漏洞扫描状态。
        /// </summary>
        [JsonProperty("VulnerabilityStatus")]
        public string VulnerabilityStatus{ get; set; }

        /// <summary>
        /// 证书生效时间。时区为GMT+8:00
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertBeginTime")]
        public string CertBeginTime{ get; set; }

        /// <summary>
        /// 证书失效时间。时区为GMT+8:00
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertEndTime")]
        public string CertEndTime{ get; set; }

        /// <summary>
        /// 证书有效期：单位（月）。
        /// </summary>
        [JsonProperty("ValidityPeriod")]
        public string ValidityPeriod{ get; set; }

        /// <summary>
        /// 证书申请时间。时区为GMT+8:00
        /// </summary>
        [JsonProperty("InsertTime")]
        public string InsertTime{ get; set; }

        /// <summary>
        /// CA订单 ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 证书扩展信息。
        /// </summary>
        [JsonProperty("CertificateExtra")]
        public CertificateExtra CertificateExtra{ get; set; }

        /// <summary>
        /// 私钥证书， 国密证书则为签名证书中的私钥证书
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertificatePrivateKey")]
        public string CertificatePrivateKey{ get; set; }

        /// <summary>
        /// 公钥证书， 国密则为签名证书中的公钥证书
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertificatePublicKey")]
        public string CertificatePublicKey{ get; set; }

        /// <summary>
        /// 证书域名验证信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DvAuthDetail")]
        public DvAuthDetail DvAuthDetail{ get; set; }

        /// <summary>
        /// 漏洞扫描评估报告。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VulnerabilityReport")]
        public string VulnerabilityReport{ get; set; }

        /// <summary>
        /// 证书 ID。
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// 证书类型名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TypeName")]
        public string TypeName{ get; set; }

        /// <summary>
        /// 状态描述。
        /// </summary>
        [JsonProperty("StatusName")]
        public string StatusName{ get; set; }

        /// <summary>
        /// 证书包含的多个域名（不包含主域名，主域名使用Domain字段）
        /// </summary>
        [JsonProperty("SubjectAltName")]
        public string[] SubjectAltName{ get; set; }

        /// <summary>
        /// 是否为付费证书。
        /// </summary>
        [JsonProperty("IsVip")]
        public bool? IsVip{ get; set; }

        /// <summary>
        /// 是否为泛域名证书。
        /// </summary>
        [JsonProperty("IsWildcard")]
        public bool? IsWildcard{ get; set; }

        /// <summary>
        /// 是否为 DV 版证书。
        /// </summary>
        [JsonProperty("IsDv")]
        public bool? IsDv{ get; set; }

        /// <summary>
        /// 是否启用了漏洞扫描功能。
        /// </summary>
        [JsonProperty("IsVulnerability")]
        public bool? IsVulnerability{ get; set; }

        /// <summary>
        /// 付费证书提交的资料信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubmittedData")]
        public SubmittedData SubmittedData{ get; set; }

        /// <summary>
        /// 是否可续费。
        /// </summary>
        [JsonProperty("RenewAble")]
        public bool? RenewAble{ get; set; }

        /// <summary>
        /// 是否可部署。
        /// </summary>
        [JsonProperty("Deployable")]
        public bool? Deployable{ get; set; }

        /// <summary>
        /// 关联标签列表。
        /// </summary>
        [JsonProperty("Tags")]
        public Tags[] Tags{ get; set; }

        /// <summary>
        /// 根证书。
        /// </summary>
        [JsonProperty("RootCert")]
        public RootCertificates RootCert{ get; set; }

        /// <summary>
        /// 国密加密证书公钥， 仅国密证书有值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EncryptCert")]
        public string EncryptCert{ get; set; }

        /// <summary>
        /// 国密加密私钥证书， 仅国密证书有值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EncryptPrivateKey")]
        public string EncryptPrivateKey{ get; set; }

        /// <summary>
        /// 签名证书 SHA1指纹
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertFingerprint")]
        public string CertFingerprint{ get; set; }

        /// <summary>
        /// 加密证书 SHA1指纹 （国密证书特有）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EncryptCertFingerprint")]
        public string EncryptCertFingerprint{ get; set; }

        /// <summary>
        /// 证书加密算法（国密证书特有）
        /// </summary>
        [JsonProperty("EncryptAlgorithm")]
        public string EncryptAlgorithm{ get; set; }

        /// <summary>
        /// DV证书吊销验证值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DvRevokeAuthDetail")]
        public DvAuths[] DvRevokeAuthDetail{ get; set; }

        /// <summary>
        /// 证书链信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertChainInfo")]
        public CertBasicInfo[] CertChainInfo{ get; set; }

        /// <summary>
        /// 证书域名类型， 1（单域名）；2（多域名）；3（泛域名）；4（多泛域名）
        /// </summary>
        [JsonProperty("DomainType")]
        public ulong? DomainType{ get; set; }

        /// <summary>
        /// 证书类型，DV（域名型）；OV（企业型）；EV（增强型）
        /// </summary>
        [JsonProperty("CertType")]
        public string CertType{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "CertificateType", this.CertificateType);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "ProductZhName", this.ProductZhName);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusMsg", this.StatusMsg);
            this.SetParamSimple(map, prefix + "VerifyType", this.VerifyType);
            this.SetParamSimple(map, prefix + "VulnerabilityStatus", this.VulnerabilityStatus);
            this.SetParamSimple(map, prefix + "CertBeginTime", this.CertBeginTime);
            this.SetParamSimple(map, prefix + "CertEndTime", this.CertEndTime);
            this.SetParamSimple(map, prefix + "ValidityPeriod", this.ValidityPeriod);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamObj(map, prefix + "CertificateExtra.", this.CertificateExtra);
            this.SetParamSimple(map, prefix + "CertificatePrivateKey", this.CertificatePrivateKey);
            this.SetParamSimple(map, prefix + "CertificatePublicKey", this.CertificatePublicKey);
            this.SetParamObj(map, prefix + "DvAuthDetail.", this.DvAuthDetail);
            this.SetParamSimple(map, prefix + "VulnerabilityReport", this.VulnerabilityReport);
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamSimple(map, prefix + "TypeName", this.TypeName);
            this.SetParamSimple(map, prefix + "StatusName", this.StatusName);
            this.SetParamArraySimple(map, prefix + "SubjectAltName.", this.SubjectAltName);
            this.SetParamSimple(map, prefix + "IsVip", this.IsVip);
            this.SetParamSimple(map, prefix + "IsWildcard", this.IsWildcard);
            this.SetParamSimple(map, prefix + "IsDv", this.IsDv);
            this.SetParamSimple(map, prefix + "IsVulnerability", this.IsVulnerability);
            this.SetParamObj(map, prefix + "SubmittedData.", this.SubmittedData);
            this.SetParamSimple(map, prefix + "RenewAble", this.RenewAble);
            this.SetParamSimple(map, prefix + "Deployable", this.Deployable);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "RootCert.", this.RootCert);
            this.SetParamSimple(map, prefix + "EncryptCert", this.EncryptCert);
            this.SetParamSimple(map, prefix + "EncryptPrivateKey", this.EncryptPrivateKey);
            this.SetParamSimple(map, prefix + "CertFingerprint", this.CertFingerprint);
            this.SetParamSimple(map, prefix + "EncryptCertFingerprint", this.EncryptCertFingerprint);
            this.SetParamSimple(map, prefix + "EncryptAlgorithm", this.EncryptAlgorithm);
            this.SetParamArrayObj(map, prefix + "DvRevokeAuthDetail.", this.DvRevokeAuthDetail);
            this.SetParamArrayObj(map, prefix + "CertChainInfo.", this.CertChainInfo);
            this.SetParamSimple(map, prefix + "DomainType", this.DomainType);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

