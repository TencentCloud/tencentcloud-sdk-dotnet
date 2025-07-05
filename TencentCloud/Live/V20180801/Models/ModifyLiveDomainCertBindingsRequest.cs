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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLiveDomainCertBindingsRequest : AbstractModel
    {
        
        /// <summary>
        /// 要绑定证书的播放域名/状态 信息列表。
        /// 如果CloudCertId和证书公钥私钥对均不传，且域名列表已有绑定规则，只批量更新域名https规则的启用状态，并把未上传至腾讯云ssl的已有自有证书上传。
        /// </summary>
        [JsonProperty("DomainInfos")]
        public LiveCertDomainInfo[] DomainInfos{ get; set; }

        /// <summary>
        /// 腾讯云ssl的证书Id。
        /// 见 https://cloud.tencent.com/document/api/400/41665
        /// </summary>
        [JsonProperty("CloudCertId")]
        public string CloudCertId{ get; set; }

        /// <summary>
        /// 证书公钥。
        /// CloudCertId和公钥私钥对二选一，若CloudCertId将会舍弃公钥和私钥参数，否则将自动先把公钥私钥对上传至ssl新建证书，并使用上传成功后返回的CloudCertId。
        /// </summary>
        [JsonProperty("CertificatePublicKey")]
        public string CertificatePublicKey{ get; set; }

        /// <summary>
        /// 证书私钥。
        /// CloudCertId和公钥私钥对二选一，若传CloudCertId将会舍弃公钥和私钥参数，否则将自动先把公钥私钥对上传至ssl新建证书，并使用上传成功后返回的CloudCertId。
        /// </summary>
        [JsonProperty("CertificatePrivateKey")]
        public string CertificatePrivateKey{ get; set; }

        /// <summary>
        /// 上传至ssl证书中心的备注信息，只有新建证书时有效。传CloudCertId时会忽略。
        /// </summary>
        [JsonProperty("CertificateAlias")]
        public string CertificateAlias{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "DomainInfos.", this.DomainInfos);
            this.SetParamSimple(map, prefix + "CloudCertId", this.CloudCertId);
            this.SetParamSimple(map, prefix + "CertificatePublicKey", this.CertificatePublicKey);
            this.SetParamSimple(map, prefix + "CertificatePrivateKey", this.CertificatePrivateKey);
            this.SetParamSimple(map, prefix + "CertificateAlias", this.CertificateAlias);
        }
    }
}

