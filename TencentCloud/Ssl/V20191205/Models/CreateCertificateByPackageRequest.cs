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

    public class CreateCertificateByPackageRequest : AbstractModel
    {
        
        /// <summary>
        /// 证书产品PID。
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
        /// 续费证书CSR的算法类型。
        /// </summary>
        [JsonProperty("RenewAlgorithmType")]
        public string RenewAlgorithmType{ get; set; }

        /// <summary>
        /// 续费证书CSR的算法参数。
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
        /// 询价参数
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

