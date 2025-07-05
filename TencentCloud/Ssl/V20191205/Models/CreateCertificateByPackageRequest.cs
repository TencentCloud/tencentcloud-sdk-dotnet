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

    public class CreateCertificateByPackageRequest : AbstractModel
    {
        
        /// <summary>
        /// 证书产品PID，以下是对每个PID及其对应的证书文字说明：
        /// 1. 1022451 - CFCA-增强型(EV)SSL证书
        /// 2. 1022449 - CFCA-企业型(OV) SSL证书(通配符)
        /// 3. 1022447 - CFCA-企业型(OV)SSL证书
        /// 4. 1014028 - DNSPod亚信国密-企业型(OV)通配符证书
        /// 5. 1014030 - DNSPod亚信国密-企业型(OV)多域名证书
        /// 6. 1014026 - DNSPod亚信国密-企业型(OV)证书
        /// 7. 1014022 - DNSPod亚信国密-域名型(DV)通配符证书
        /// 8. 1014024 - DNSPod亚信国密-域名型(DV)多域名证书
        /// 9. 1014020 - DNSPod亚信国密-域名型(DV)证书
        /// 10. 1013949 - DNSPod SSL 域名型SSL证书(C1)
        /// 11. 1013953 - DNSPod SSL域名型多域名SSL证书(C1)
        /// 12. 1013951 - DNSPod-SSL域名型DV（泛域名）
        /// 13. 1013955 - DNSPod 企业型SSL证书(C1)
        /// 14. 1013959 - DNSPod 企业型多域名SSL证书(C1)
        /// 15. 1013957 - DNSPod 企业型通配符SSL证书(C1)
        /// 16. 1013961 - DNSPod 增强型 SSL 证书(C1)
        /// 17. 1013963 - DNSPod 增强型多域名SSL证书(C1)
        /// 18. 1005919 - TrustAsia-域名型DV（通配符多域名）
        /// 19. 1013882 - SecureSite-增强型专业版EVPro（多域名）
        /// 20. 1018559 - SecureSite-增强型专业版EVPro（单域名）
        /// 21. 1013910 - GlobalSign-增强型EV（多域名）
        /// 22. 1013904 - GlobalSign-增强型EV（单域名）
        /// 23. 1013898 - TrustAsia-增强型EV（多域名）
        /// 24. 1013888 - TrustAsia-增强型EV（单域名）
        /// 25. 1013886 - GeoTrust-增强型EV（多域名）
        /// 26. 1018529 - GeoTrust-增强型EV（单域名）
        /// 27. 1013880 - SecureSite-增强型EV（多域名）
        /// 28. 1018557 - SecureSite-增强型EV（单域名）
        /// 29. 1018586 - TrustAsia-域名型DV（泛域名）
        /// 30. 1018584 - TrustAsia-域名型DV（多域名）
        /// 31. 1013878 - SecureSite-企业型专业版OV Pro（多域名）
        /// 32. 1018582 - SecureSite-企业型专业版OV Pro（单域名）
        /// 33. 1013908 - GlobalSign-企业型OV（通配符多域名）
        /// 34. 1013902 - GlobalSign-企业型OV（泛域名）
        /// 35. 1013906 - GlobalSign-企业型OV（多域名）
        /// 36. 1013900 - GlobalSign-企业型OV（单域名）
        /// 37. 1013896 - TrustAsia-企业型OV（通配符多域名）
        /// 38. 1013892 - TrustAsia-企业型OV（泛域名）
        /// 39. 1013894 - TrustAsia-企业型OV（多域名）
        /// 40. 1013890 - TrustAsia-企业型OV（单域名）
        /// 41. 1004360 - GeoTrust-企业型OV（泛域名）
        /// 42. 1013884 - GeoTrust-企业型OV（单域名）
        /// 43. 1013874 - SecureSite-企业型OV（泛域名）
        /// 44. 1013876 - SecureSite-企业型OV（多域名）
        /// 45. 1018580 - SecureSite-企业型OV（单域名）
        /// 46. 1004460 - DNSPod-国密增强型证书（多域名）
        /// 47. 1004458 - DNSPod-国密增强型证书
        /// 48. 1004370 - DNSPod-国密企业型证书（通配符）
        /// 49. 1004368 - DNSPod-国密企业型证书（多域名）
        /// 50. 1004366 - DNSPod-国密企业型证书
        /// 51. 1004362 - DNSPod-国密域名型证书（通配符）
        /// 52. 1004364 - DNSPod-国密域名型证书（多域名）
        /// 53. 1004358 - DNSPod-国密域名型证书
        /// 54. 1004456 - WoTrus-增强型证书（多域名）
        /// 55. 1004454 - WoTrus-增强型证书
        /// 56. 1004168 - WoTrus-企业型证书（通配符）
        /// 57. 1004166 - WoTrus-企业型证书（多域名）
        /// 58. 1004164 - WoTrus-企业型证书
        /// 59. 1004159 - WoTrus-域名型证书（通配符）
        /// 60. 1004161 - WoTrus-域名型证书（多域名）
        /// 61. 1004157 - WoTrus-域名型证书
        /// </summary>
        [JsonProperty("ProductPid")]
        public ulong? ProductPid{ get; set; }

        /// <summary>
        /// 要消耗的权益包ID。
        /// </summary>
        [JsonProperty("PackageIds")]
        public string[] PackageIds{ get; set; }

        /// <summary>
        /// 证书域名数量。
        /// </summary>
        [JsonProperty("DomainCount")]
        public string DomainCount{ get; set; }

        /// <summary>
        /// 多年期证书年限。
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// 要续费的原证书ID（续费时填写）。
        /// </summary>
        [JsonProperty("OldCertificateId")]
        public string OldCertificateId{ get; set; }

        /// <summary>
        /// 续费时CSR生成方式（original、upload、online）。
        /// </summary>
        [JsonProperty("RenewGenCsrMethod")]
        public string RenewGenCsrMethod{ get; set; }

        /// <summary>
        /// 续费时选择上传CSR时填写CSR。
        /// </summary>
        [JsonProperty("RenewCsr")]
        public string RenewCsr{ get; set; }

        /// <summary>
        /// 续费证书CSR的算法类型：RSA,ECC,SM2
        /// </summary>
        [JsonProperty("RenewAlgorithmType")]
        public string RenewAlgorithmType{ get; set; }

        /// <summary>
        /// 续费证书CSR的算法参数:2048,4096,prime256v1
        /// </summary>
        [JsonProperty("RenewAlgorithmParam")]
        public string RenewAlgorithmParam{ get; set; }

        /// <summary>
        /// 项目ID。
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 标签。
        /// </summary>
        [JsonProperty("Tags")]
        public Tags[] Tags{ get; set; }

        /// <summary>
        /// 续费证书的私钥密码。
        /// </summary>
        [JsonProperty("RenewKeyPass")]
        public string RenewKeyPass{ get; set; }

        /// <summary>
        /// 批量购买证书时预填写的域名。
        /// </summary>
        [JsonProperty("DomainNames")]
        public string DomainNames{ get; set; }

        /// <summary>
        /// 批量购买证书数量。
        /// </summary>
        [JsonProperty("CertificateCount")]
        public ulong? CertificateCount{ get; set; }

        /// <summary>
        /// 预填写的管理人ID。
        /// </summary>
        [JsonProperty("ManagerId")]
        public ulong? ManagerId{ get; set; }

        /// <summary>
        /// 预填写的公司ID。
        /// </summary>
        [JsonProperty("CompanyId")]
        public ulong? CompanyId{ get; set; }

        /// <summary>
        /// 验证方式
        /// </summary>
        [JsonProperty("VerifyType")]
        public string VerifyType{ get; set; }

        /// <summary>
        /// 询价参数，以下是对每个询价参数及其对应的证书文字说明：
        /// 1. sv_ssl_cost_cfca_ca_ev - CFCA-增强型(EV)SSL证书
        /// 2. sv_ssl_cost_cfca_ca_ovwildcard - CFCA-企业型(OV) SSL证书(通配符)
        /// 3. sv_ssl_cost_cfca_ca_ov - CFCA-企业型(OV)SSL证书
        /// 4. sv_ssl_cost_dnspod_ca_sm2_ovwildcard - DNSPod亚信国密-企业型(OV)通配符证书
        /// 5. sv_ssl_cost_dnspod_ca_sm2_ovmultidomain - DNSPod亚信国密-企业型(OV)多域名证书
        /// 6. sv_ssl_cost_dnspod_ca_sm2_ov - DNSPod亚信国密-企业型(OV)证书
        /// 7. sv_ssl_cost_dnspod_ca_sm2_dvwildcard - DNSPod亚信国密-域名型(DV)通配符证书
        /// 8. sv_ssl_cost_dnspod_ca_sm2_dvmultidomain - DNSPod亚信国密-域名型(DV)多域名证书
        /// 9. sv_ssl_cost_dnspod_ca_sm2_dv - DNSPod亚信国密-域名型(DV)证书
        /// 10. sv_ssl_cost_dnspod_ca_dv - DNSPod SSL 域名型SSL证书(C1)
        /// 11. sv_ssl_cost_dnspod_ca_dvmultidomain - DNSPod SSL域名型多域名SSL证书(C1)
        /// 12. sv_ssl_cost_dnspod_ca_dvwildcard - DNSPod-SSL域名型DV（泛域名）
        /// 13. sv_ssl_cost_dnspod_ca_ov - DNSPod 企业型SSL证书(C1)
        /// 14. sv_ssl_cost_dnspod_ca_ovmultidomain - DNSPod 企业型多域名SSL证书(C1)
        /// 15. sv_ssl_cost_dnspod_ca_ovwildcard - DNSPod 企业型通配符SSL证书(C1)
        /// 16. sv_ssl_cost_dnspod_ca_ev - DNSPod 增强型 SSL 证书(C1)
        /// 17. sv_ssl_cost_dnspod_ca_evmultidomain - DNSPod 增强型多域名SSL证书(C1)
        /// 18. sv_ssl_cost_trustasia_dvwildcardmulti - TrustAsia-域名型DV（通配符多域名）
        /// 19. sv_ssl_cost_securesiteevpromul_sh - SecureSite-增强型专业版EVPro（多域名）
        /// 20. sv_ssl_cost_symantec_evpro - SecureSite-增强型专业版EVPro（单域名）
        /// 21. sv_ssl_cost_globalsign_ev_mul_sh - GlobalSign-增强型EV（多域名）
        /// 22. sv_ssl_cost_globalsign_ev - GlobalSign-增强型EV（单域名）
        /// 23. sv_ssl_cost_trustasia_evmultidomain - TrustAsia-增强型EV（多域名）
        /// 24. sv_ssl_cost_trustasia_ev - TrustAsia-增强型EV（单域名）
        /// 25. sv_ssl_cost_geotrust_evmultidomain - GeoTrust-增强型EV（多域名）
        /// 26. sv_ssl_cost_geotrust_ev - GeoTrust-增强型EV（单域名）
        /// 27. sv_ssl_cost_symantec_evmultidomain - SecureSite-增强型EV（多域名）
        /// 28. sv_ssl_cost_symantec_ev - SecureSite-增强型EV（单域名）
        /// 29. sv_ssl_cost_trustasia_dvwildcard - TrustAsia-域名型DV（泛域名）
        /// 30. sv_ssl_cost_trustasia_dvmultidomain - TrustAsia-域名型DV（多域名）
        /// 31. sv_ssl_cost_symantec_ovpromultidomain - SecureSite-企业型专业版OV Pro（多域名）
        /// 32. sv_ssl_cost_symantec_ovpro - SecureSite-企业型专业版OV Pro（单域名）
        /// 33. sv_ssl_cost_globalsign_ovwildcardmulti - GlobalSign-企业型OV（通配符多域名）
        /// 34. sv_ssl_cost_globalsign_ovwildcard - GlobalSign-企业型OV（泛域名）
        /// 35. sv_ssl_cost_globalsign_ovmultidomain - GlobalSign-企业型OV（多域名）
        /// 36. sv_ssl_cost_globalsign_ov - GlobalSign-企业型OV（单域名）
        /// 37. sv_ssl_cost_trustasia_ovwildcardmulti - TrustAsia-企业型OV（通配符多域名）
        /// 38. sv_ssl_cost_trustasia_ovwildcard - TrustAsia-企业型OV（泛域名）
        /// 39. sv_ssl_cost_trustasia_ovmultidomain - TrustAsia-企业型OV（多域名）
        /// 40. sv_ssl_cost_trustasia_ov - TrustAsia-企业型OV（单域名）
        /// 41. sv_ssl_cost_geotrust_ovwildcard - GeoTrust-企业型OV（泛域名）
        /// 42. sv_ssl_cost_geotrust_ov - GeoTrust-企业型OV（单域名）
        /// 43. sv_ssl_cost_symantec_ovwildcard - SecureSite-企业型OV（泛域名）
        /// 44. sv_ssl_cost_symantec_ovmultidomain - SecureSite-企业型OV（多域名）
        /// 45. sv_ssl_cost_symantec_ov - SecureSite-企业型OV（单域名）
        /// 46. sv_ssl_cost_dnspod_evmultidomain - DNSPod-国密增强型证书（多域名）
        /// 47. sv_ssl_cost_dnspod_ev - DNSPod-国密增强型证书
        /// 48. sv_ssl_cost_dnspod_ovwildcard - DNSPod-国密企业型证书（通配符）
        /// 49. sv_ssl_cost_dnspod_ovmultidomain - DNSPod-国密企业型证书（多域名）
        /// 50. sv_ssl_cost_dnspod_ov - DNSPod-国密企业型证书
        /// 51. sv_ssl_cost_dnspod_dvwildcard - DNSPod-国密域名型证书（通配符）
        /// 52. sv_ssl_cost_dnspod_dvmultidomain - DNSPod-国密域名型证书（多域名）
        /// 53. sv_ssl_cost_dnspod_dv - DNSPod-国密域名型证书
        /// 54. sv_ssl_cost_wotrus_evmultidomain - WoTrus-增强型证书（多域名）
        /// 55. sv_ssl_cost_wotrus_ev - WoTrus-增强型证书
        /// 56. sv_ssl_cost_wotrus_ovwildcard - WoTrus-企业型证书（通配符）
        /// 57. sv_ssl_cost_wotrus_ovmultidomain - WoTrus-企业型证书（多域名）
        /// 58. sv_ssl_cost_wotrus_ov - WoTrus-企业型证书
        /// 59. sv_ssl_cost_wotrus_dvwildcard - WoTrus-域名型证书（通配符）
        /// 60. sv_ssl_cost_wotrus_dvmultidomain - WoTrus-域名型证书（多域名）
        /// 61. sv_ssl_cost_wotrus_dv - WoTrus-域名型证书
        /// </summary>
        [JsonProperty("PriceKey")]
        public string PriceKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductPid", this.ProductPid);
            this.SetParamArraySimple(map, prefix + "PackageIds.", this.PackageIds);
            this.SetParamSimple(map, prefix + "DomainCount", this.DomainCount);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "OldCertificateId", this.OldCertificateId);
            this.SetParamSimple(map, prefix + "RenewGenCsrMethod", this.RenewGenCsrMethod);
            this.SetParamSimple(map, prefix + "RenewCsr", this.RenewCsr);
            this.SetParamSimple(map, prefix + "RenewAlgorithmType", this.RenewAlgorithmType);
            this.SetParamSimple(map, prefix + "RenewAlgorithmParam", this.RenewAlgorithmParam);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "RenewKeyPass", this.RenewKeyPass);
            this.SetParamSimple(map, prefix + "DomainNames", this.DomainNames);
            this.SetParamSimple(map, prefix + "CertificateCount", this.CertificateCount);
            this.SetParamSimple(map, prefix + "ManagerId", this.ManagerId);
            this.SetParamSimple(map, prefix + "CompanyId", this.CompanyId);
            this.SetParamSimple(map, prefix + "VerifyType", this.VerifyType);
            this.SetParamSimple(map, prefix + "PriceKey", this.PriceKey);
        }
    }
}

