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
        /// <p>证书所属用户主账号 UIN。</p>
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// <p>项目 ID。</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>证书来源：<br>trustasia：亚洲诚信，<br>upload：用户上传。<br>wosign：沃通<br>sheca：上海CA</p>
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// <p>证书类型：CA = 客户端证书，SVR = 服务器证书。</p>
        /// </summary>
        [JsonProperty("CertificateType")]
        public string CertificateType{ get; set; }

        /// <summary>
        /// <p>证书套餐类型：<br>null：用户上传证书（没有套餐类型），<br>2：TrustAsia TLS RSA CA，<br>3：SecureSite 增强型企业版（EV Pro），<br>4：SecureSite 增强型（EV），<br>5：SecureSite 企业型专业版（OV Pro），<br>6：SecureSite 企业型（OV），<br>7：SecureSite 企业型（OV）通配符，<br>8：Geotrust 增强型（EV），<br>9：Geotrust 企业型（OV），<br>10：Geotrust 企业型（OV）通配符，<br>11：TrustAsia 域名型多域名 SSL 证书，<br>12：TrustAsia 域名型（DV）通配符，<br>13：TrustAsia 企业型通配符（OV）SSL 证书（D3），<br>14：TrustAsia 企业型（OV）SSL 证书（D3），<br>15：TrustAsia 企业型多域名 （OV）SSL 证书（D3），<br>16：TrustAsia 增强型 （EV）SSL 证书（D3），<br>17：TrustAsia 增强型多域名（EV）SSL 证书（D3），<br>18：GlobalSign 企业型（OV）SSL 证书，<br>19：GlobalSign 企业型通配符 （OV）SSL 证书，<br>20：GlobalSign 增强型 （EV）SSL 证书，<br>21：TrustAsia 企业型通配符多域名（OV）SSL 证书（D3），<br>22：GlobalSign 企业型多域名（OV）SSL 证书，<br>23：GlobalSign 企业型通配符多域名（OV）SSL 证书，<br>24：GlobalSign 增强型多域名（EV）SSL 证书，<br>25：Wotrus 域名型证书，<br>26：Wotrus 域名型多域名证书，<br>27：Wotrus 域名型通配符证书，<br>28：Wotrus 企业型证书，<br>29：Wotrus 企业型多域名证书，<br>30：Wotrus 企业型通配符证书，<br>31：Wotrus 增强型证书，<br>32：Wotrus 增强型多域名证书，<br>33：WoTrus-国密域名型证书，<br>34：WoTrus-国密域名型证书（多域名），<br>35：WoTrus-国密域名型证书（通配符），<br>37：WoTrus-国密企业型证书，<br>38：WoTrus-国密企业型证书（多域名），<br>39：WoTrus-国密企业型证书（通配符），<br>40：WoTrus-国密增强型证书，<br>41：WoTrus-国密增强型证书（多域名），<br>42：TrustAsia-域名型证书（通配符多域名），<br>43：DNSPod-企业型(OV)SSL证书<br>44：DNSPod-企业型(OV)通配符SSL证书<br>45：DNSPod-企业型(OV)多域名SSL证书<br>46：DNSPod-增强型(EV)SSL证书<br>47：DNSPod-增强型(EV)多域名SSL证书<br>48：DNSPod-域名型(DV)SSL证书<br>49：DNSPod-域名型(DV)通配符SSL证书<br>50：DNSPod-域名型(DV)多域名SSL证书<br>51：DNSPod（国密）-企业型(OV)SSL证书<br>52：DNSPod（国密）-企业型(OV)通配符SSL证书<br>53：DNSPod（国密）-企业型(OV)多域名SSL证书<br>54：DNSPod（国密）-域名型(DV)SSL证书<br>55：DNSPod（国密）-域名型(DV)通配符SSL证书<br>56：DNSPod（国密）-域名型(DV)多域名SSL证书<br>57：SecureSite 企业型专业版多域名(OV Pro)<br>58：SecureSite 企业型多域名(OV)<br>59：SecureSite 增强型专业版多域名(EV Pro)<br>60：SecureSite 增强型多域名(EV)<br>61：Geotrust 增强型多域名(EV)<br>75：SecureSite 企业型(OV)<br>76：SecureSite 企业型(OV)通配符<br>77：SecureSite 增强型(EV)<br>78：Geotrust 企业型(OV)<br>79：Geotrust 企业型(OV)通配符<br>80：Geotrust 增强型(EV)<br>81：GlobalSign 企业型（OV）SSL证书<br>82：GlobalSign 企业型通配符 （OV）SSL证书<br>83：TrustAsia C1 DV Free<br>85：GlobalSign 增强型 （EV）SSL证书<br>88：GlobalSign 企业型通配符多域名 （OV）SSL证书<br>89：GlobalSign 企业型多域名 （OV）SSL证书<br>90：GlobalSign 增强型多域名（EV） SSL证书<br>91：Geotrust 增强型多域名(EV)<br>92：SecureSite 企业型专业版多域名(OV Pro)<br>93：SecureSite 企业型多域名(OV)<br>94：SecureSite 增强型专业版多域名(EV Pro)<br>95：SecureSite 增强型多域名(EV)<br>96：SecureSite 增强型专业版(EV Pro)<br>97：SecureSite 企业型专业版(OV Pro)<br>98：CFCA 企业型(OV)SSL证书<br>99：CFCA 企业型多域名(OV)SSL证书<br>100：CFCA 企业型通配符(OV)SSL证书<br>101：CFCA 增强型(EV)SSL证书</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// <p>证书产品名称</p>
        /// </summary>
        [JsonProperty("ProductZhName")]
        public string ProductZhName{ get; set; }

        /// <summary>
        /// <p>证书绑定通用名称域名。</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>备注名称。</p>
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// <p>证书状态：0 = 审核中，1 = 已通过，2 = 审核失败，3 = 已过期，4 = 自动添加DNS记录，5 = 企业证书，待提交资料，6 = 订单取消中，7 = 已取消，8 = 已提交资料， 待上传确认函，9 = 证书吊销中，10 = 已吊销，11 = 重颁发中，12 = 待上传吊销确认函，13 = 免费证书待提交资料。14 = 证书已退款。 15 = 证书迁移中</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>状态信息。 取值范围：<br>//通用状态信息<br>1、PRE-REVIEWING：预审核中<br>2、LEGAL-REVIEWING：法务审核中<br>3、CA-REVIEWING：CA审核中<br>4、PENDING-DCV：域名验证中<br>5、WAIT-ISSUE：等待签发（域名验证已通过）<br>//证书审核失败状态信息<br>1、订单审核失败<br>2、CA审核失败，域名未通过安全审查<br>3、域名验证超时，订单自动关闭，请您重新进行证书申请<br>4、证书资料未通过证书CA机构审核，审核人员会致电您证书预留的联系方式，请您留意来电。后续可通过“修改资料”重新提交资料<br>待持续完善</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatusMsg")]
        public string StatusMsg{ get; set; }

        /// <summary>
        /// <p>验证类型：DNS_AUTO = 自动DNS验证，DNS = 手动DNS验证，FILE = 文件验证，EMAIL = 邮件验证。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VerifyType")]
        public string VerifyType{ get; set; }

        /// <summary>
        /// <p>漏洞扫描状态。</p>
        /// </summary>
        [JsonProperty("VulnerabilityStatus")]
        public string VulnerabilityStatus{ get; set; }

        /// <summary>
        /// <p>证书生效时间。时区为GMT+8:00</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertBeginTime")]
        public string CertBeginTime{ get; set; }

        /// <summary>
        /// <p>证书失效时间。时区为GMT+8:00</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertEndTime")]
        public string CertEndTime{ get; set; }

        /// <summary>
        /// <p>证书有效期：单位（月）。</p>
        /// </summary>
        [JsonProperty("ValidityPeriod")]
        public string ValidityPeriod{ get; set; }

        /// <summary>
        /// <p>证书申请时间。时区为GMT+8:00</p>
        /// </summary>
        [JsonProperty("InsertTime")]
        public string InsertTime{ get; set; }

        /// <summary>
        /// <p>CA订单 ID。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// <p>证书扩展信息。</p>
        /// </summary>
        [JsonProperty("CertificateExtra")]
        public CertificateExtra CertificateExtra{ get; set; }

        /// <summary>
        /// <p>私钥证书， 国密证书则为签名证书中的私钥证书</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertificatePrivateKey")]
        public string CertificatePrivateKey{ get; set; }

        /// <summary>
        /// <p>公钥证书， 国密则为签名证书中的公钥证书</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertificatePublicKey")]
        public string CertificatePublicKey{ get; set; }

        /// <summary>
        /// <p>证书域名验证信息。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DvAuthDetail")]
        public DvAuthDetail DvAuthDetail{ get; set; }

        /// <summary>
        /// <p>漏洞扫描评估报告。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VulnerabilityReport")]
        public string VulnerabilityReport{ get; set; }

        /// <summary>
        /// <p>证书 ID。</p>
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// <p>证书类型名称。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TypeName")]
        public string TypeName{ get; set; }

        /// <summary>
        /// <p>状态描述。</p>
        /// </summary>
        [JsonProperty("StatusName")]
        public string StatusName{ get; set; }

        /// <summary>
        /// <p>证书包含的多个域名（不包含主域名，主域名使用Domain字段）</p>
        /// </summary>
        [JsonProperty("SubjectAltName")]
        public string[] SubjectAltName{ get; set; }

        /// <summary>
        /// <p>是否为付费证书。</p>
        /// </summary>
        [JsonProperty("IsVip")]
        public bool? IsVip{ get; set; }

        /// <summary>
        /// <p>是否为泛域名证书。</p>
        /// </summary>
        [JsonProperty("IsWildcard")]
        public bool? IsWildcard{ get; set; }

        /// <summary>
        /// <p>是否为 DV 版证书。</p>
        /// </summary>
        [JsonProperty("IsDv")]
        public bool? IsDv{ get; set; }

        /// <summary>
        /// <p>是否启用了漏洞扫描功能。</p>
        /// </summary>
        [JsonProperty("IsVulnerability")]
        public bool? IsVulnerability{ get; set; }

        /// <summary>
        /// <p>付费证书提交的资料信息。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubmittedData")]
        public SubmittedData SubmittedData{ get; set; }

        /// <summary>
        /// <p>是否可续费。</p>
        /// </summary>
        [JsonProperty("RenewAble")]
        public bool? RenewAble{ get; set; }

        /// <summary>
        /// <p>是否可部署。</p>
        /// </summary>
        [JsonProperty("Deployable")]
        public bool? Deployable{ get; set; }

        /// <summary>
        /// <p>关联标签列表。</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tags[] Tags{ get; set; }

        /// <summary>
        /// <p>根证书。</p>
        /// </summary>
        [JsonProperty("RootCert")]
        public RootCertificates RootCert{ get; set; }

        /// <summary>
        /// <p>国密加密证书公钥， 仅国密证书有值</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EncryptCert")]
        public string EncryptCert{ get; set; }

        /// <summary>
        /// <p>国密加密私钥证书， 仅国密证书有值</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EncryptPrivateKey")]
        public string EncryptPrivateKey{ get; set; }

        /// <summary>
        /// <p>签名证书 SHA1指纹</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertFingerprint")]
        public string CertFingerprint{ get; set; }

        /// <summary>
        /// <p>加密证书 SHA1指纹 （国密证书特有）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EncryptCertFingerprint")]
        public string EncryptCertFingerprint{ get; set; }

        /// <summary>
        /// <p>证书加密算法（国密证书特有）</p>
        /// </summary>
        [JsonProperty("EncryptAlgorithm")]
        public string EncryptAlgorithm{ get; set; }

        /// <summary>
        /// <p>DV证书吊销验证值</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DvRevokeAuthDetail")]
        public DvAuths[] DvRevokeAuthDetail{ get; set; }

        /// <summary>
        /// <p>证书链信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertChainInfo")]
        public CertBasicInfo[] CertChainInfo{ get; set; }

        /// <summary>
        /// <p>证书域名类型， 1（单域名）；2（多域名）；3（泛域名）；4（多泛域名）</p>
        /// </summary>
        [JsonProperty("DomainType")]
        public ulong? DomainType{ get; set; }

        /// <summary>
        /// <p>证书类型，DV（域名型）；OV（企业型）；EV（增强型）</p>
        /// </summary>
        [JsonProperty("CertType")]
        public string CertType{ get; set; }

        /// <summary>
        /// <p>是否使用交叉根</p>
        /// </summary>
        [JsonProperty("UseCrossSignRoot")]
        public bool? UseCrossSignRoot{ get; set; }

        /// <summary>
        /// <p>托管状态，0代表托管中，5代表资源替换中， 10代表托管完成， -1代表未托管</p>
        /// </summary>
        [JsonProperty("HostingStatus")]
        public long? HostingStatus{ get; set; }

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
            this.SetParamSimple(map, prefix + "UseCrossSignRoot", this.UseCrossSignRoot);
            this.SetParamSimple(map, prefix + "HostingStatus", this.HostingStatus);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

