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

    public class ApplyCertificateRequest : AbstractModel
    {
        
        /// <summary>
        /// 验证方式：DNS_AUTO = 自动DNS验证，DNS = 手动DNS验证，FILE = 文件验证。
        /// </summary>
        [JsonProperty("DvAuthMethod")]
        public string DvAuthMethod{ get; set; }

        /// <summary>
        /// 域名。
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// 项目 ID。
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 证书类型，目前仅支持类型2。2 = TrustAsia TLS RSA CA。
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// 邮箱。
        /// </summary>
        [JsonProperty("ContactEmail")]
        public string ContactEmail{ get; set; }

        /// <summary>
        /// 手机。
        /// </summary>
        [JsonProperty("ContactPhone")]
        public string ContactPhone{ get; set; }

        /// <summary>
        /// 有效期，默认12个月，目前仅支持12个月。
        /// </summary>
        [JsonProperty("ValidityPeriod")]
        public string ValidityPeriod{ get; set; }

        /// <summary>
        /// 加密算法，支持 RSA及ECC。
        /// </summary>
        [JsonProperty("CsrEncryptAlgo")]
        public string CsrEncryptAlgo{ get; set; }

        /// <summary>
        /// 密钥对参数，RSA仅支持2048。ECC仅支持prime256v1。加密算法选择ECC时，此参数必填
        /// </summary>
        [JsonProperty("CsrKeyParameter")]
        public string CsrKeyParameter{ get; set; }

        /// <summary>
        /// CSR 的加密密码。
        /// </summary>
        [JsonProperty("CsrKeyPassword")]
        public string CsrKeyPassword{ get; set; }

        /// <summary>
        /// 备注名称。
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// 原证书 ID，用于重新申请。
        /// </summary>
        [JsonProperty("OldCertificateId")]
        public string OldCertificateId{ get; set; }

        /// <summary>
        /// 权益包ID，用于免费证书扩容包使用
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// 签发后是否删除自动域名验证记录， 默认为否；仅域名为DNS_AUTO验证类型支持传参
        /// </summary>
        [JsonProperty("DeleteDnsAutoRecord")]
        public bool? DeleteDnsAutoRecord{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DvAuthMethod", this.DvAuthMethod);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "ContactEmail", this.ContactEmail);
            this.SetParamSimple(map, prefix + "ContactPhone", this.ContactPhone);
            this.SetParamSimple(map, prefix + "ValidityPeriod", this.ValidityPeriod);
            this.SetParamSimple(map, prefix + "CsrEncryptAlgo", this.CsrEncryptAlgo);
            this.SetParamSimple(map, prefix + "CsrKeyParameter", this.CsrKeyParameter);
            this.SetParamSimple(map, prefix + "CsrKeyPassword", this.CsrKeyPassword);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "OldCertificateId", this.OldCertificateId);
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamSimple(map, prefix + "DeleteDnsAutoRecord", this.DeleteDnsAutoRecord);
        }
    }
}

