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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SAMLIdPCertificate : AbstractModel
    {
        
        /// <summary>
        /// 证书序列号。
        /// </summary>
        [JsonProperty("SerialNumber")]
        public string SerialNumber{ get; set; }

        /// <summary>
        /// 证书颁发者。
        /// </summary>
        [JsonProperty("Issuer")]
        public string Issuer{ get; set; }

        /// <summary>
        /// 证书版本。
        /// </summary>
        [JsonProperty("Version")]
        public long? Version{ get; set; }

        /// <summary>
        /// 证书ID。
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// PEM 格式的公钥证书（Base64 编码）。
        /// </summary>
        [JsonProperty("PublicKey")]
        public string PublicKey{ get; set; }

        /// <summary>
        /// 证书的签名算法。
        /// </summary>
        [JsonProperty("SignatureAlgorithm")]
        public string SignatureAlgorithm{ get; set; }

        /// <summary>
        /// 证书的过期时间。
        /// </summary>
        [JsonProperty("NotAfter")]
        public string NotAfter{ get; set; }

        /// <summary>
        /// 证书的创建时间。
        /// </summary>
        [JsonProperty("NotBefore")]
        public string NotBefore{ get; set; }

        /// <summary>
        /// 证书的主体。
        /// </summary>
        [JsonProperty("Subject")]
        public string Subject{ get; set; }

        /// <summary>
        /// PEM 格式的 X509 证书。
        /// </summary>
        [JsonProperty("X509Certificate")]
        public string X509Certificate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SerialNumber", this.SerialNumber);
            this.SetParamSimple(map, prefix + "Issuer", this.Issuer);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamSimple(map, prefix + "PublicKey", this.PublicKey);
            this.SetParamSimple(map, prefix + "SignatureAlgorithm", this.SignatureAlgorithm);
            this.SetParamSimple(map, prefix + "NotAfter", this.NotAfter);
            this.SetParamSimple(map, prefix + "NotBefore", this.NotBefore);
            this.SetParamSimple(map, prefix + "Subject", this.Subject);
            this.SetParamSimple(map, prefix + "X509Certificate", this.X509Certificate);
        }
    }
}

