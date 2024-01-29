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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCertificateVerifyResultRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 证书类型。 0：仅配置HTTP监听端口，没有证书 1：证书来源为自有证书 2：证书来源为托管证书
        /// </summary>
        [JsonProperty("CertType")]
        public long? CertType{ get; set; }

        /// <summary>
        /// CertType为1时，需要填充此参数，表示自有证书的证书链
        /// </summary>
        [JsonProperty("Certificate")]
        public string Certificate{ get; set; }

        /// <summary>
        /// CertType为2时，需要填充此参数，表示腾讯云SSL平台托管的证书id
        /// </summary>
        [JsonProperty("CertID")]
        public string CertID{ get; set; }

        /// <summary>
        /// CertType为1时，需要填充此参数，表示自有证书的私钥
        /// </summary>
        [JsonProperty("PrivateKey")]
        public string PrivateKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
            this.SetParamSimple(map, prefix + "Certificate", this.Certificate);
            this.SetParamSimple(map, prefix + "CertID", this.CertID);
            this.SetParamSimple(map, prefix + "PrivateKey", this.PrivateKey);
        }
    }
}

