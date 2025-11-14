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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OriginCertificateVerify : AbstractModel
    {
        
        /// <summary>
        /// 源站证书校验模式。取值有：<li>disable:禁用源站证书校验。</li><li>custom_ca:使用指定受信任 CA 证书校验。</li>
        /// </summary>
        [JsonProperty("VerificationMode")]
        public string VerificationMode{ get; set; }

        /// <summary>
        /// 指定受信任的 CA 证书列表，源站证书需要由该 CA 签发才能校验通过。 注意：仅当 VerificationMode 为 custom_ca 时，需要传入该参数，指定受信任的CA证书信息。
        /// OriginCertificateVerify 在 ModifyHostsCertificate 作为入参使用时，该参数传入对应证书的 CertId 即可。您可以前往 [SSL 证书列表](https://console.cloud.tencent.com/ssl) 查看 CertId。	
        /// </summary>
        [JsonProperty("CustomCACerts")]
        public CertificateInfo[] CustomCACerts{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VerificationMode", this.VerificationMode);
            this.SetParamArrayObj(map, prefix + "CustomCACerts.", this.CustomCACerts);
        }
    }
}

