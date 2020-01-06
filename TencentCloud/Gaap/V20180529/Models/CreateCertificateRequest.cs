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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCertificateRequest : AbstractModel
    {
        
        /// <summary>
        /// 证书类型。其中：
        /// 0，表示基础认证配置；
        /// 1，表示客户端CA证书；
        /// 2，服务器SSL证书；
        /// 3，表示源站CA证书；
        /// 4，表示通道SSL证书。
        /// </summary>
        [JsonProperty("CertificateType")]
        public long? CertificateType{ get; set; }

        /// <summary>
        /// 证书内容。采用url编码。其中：
        /// 当证书类型为基础认证配置时，该参数填写用户名/密码对。格式：“用户名：密码”，例如：root:FSGdT。其中密码使用htpasswd或者openssl，例如：openssl passwd -crypt 123456。
        /// 当证书类型为CA/SSL证书时，该参数填写证书内容，格式为pem。
        /// </summary>
        [JsonProperty("CertificateContent")]
        public string CertificateContent{ get; set; }

        /// <summary>
        /// 证书名称
        /// </summary>
        [JsonProperty("CertificateAlias")]
        public string CertificateAlias{ get; set; }

        /// <summary>
        /// 密钥内容。采用url编码。仅当证书类型为SSL证书时，需要填写该参数。格式为pem。
        /// </summary>
        [JsonProperty("CertificateKey")]
        public string CertificateKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertificateType", this.CertificateType);
            this.SetParamSimple(map, prefix + "CertificateContent", this.CertificateContent);
            this.SetParamSimple(map, prefix + "CertificateAlias", this.CertificateAlias);
            this.SetParamSimple(map, prefix + "CertificateKey", this.CertificateKey);
        }
    }
}

