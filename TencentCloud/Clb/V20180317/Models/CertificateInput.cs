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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CertificateInput : AbstractModel
    {
        
        /// <summary>
        /// 认证类型，UNIDIRECTIONAL：单向认证，MUTUAL：双向认证
        /// </summary>
        [JsonProperty("SSLMode")]
        public string SSLMode{ get; set; }

        /// <summary>
        /// 服务端证书的 ID，如果不填写此项则必须上传证书，包括 CertContent，CertKey，CertName。
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// 客户端证书的 ID，当监听器采用双向认证，即 SSLMode=MUTUAL 时，如果不填写此项则必须上传客户端证书，包括 CertCaContent，CertCaName。
        /// </summary>
        [JsonProperty("CertCaId")]
        public string CertCaId{ get; set; }

        /// <summary>
        /// 上传服务端证书的名称，如果没有 CertId，则此项必传。
        /// </summary>
        [JsonProperty("CertName")]
        public string CertName{ get; set; }

        /// <summary>
        /// 上传服务端证书的 key，如果没有 CertId，则此项必传。
        /// </summary>
        [JsonProperty("CertKey")]
        public string CertKey{ get; set; }

        /// <summary>
        /// 上传服务端证书的内容，如果没有 CertId，则此项必传。
        /// </summary>
        [JsonProperty("CertContent")]
        public string CertContent{ get; set; }

        /// <summary>
        /// 上传客户端 CA 证书的名称，如果 SSLMode=mutual，如果没有 CertCaId，则此项必传。
        /// </summary>
        [JsonProperty("CertCaName")]
        public string CertCaName{ get; set; }

        /// <summary>
        /// 上传客户端证书的内容，如果 SSLMode=mutual，如果没有 CertCaId，则此项必传。
        /// </summary>
        [JsonProperty("CertCaContent")]
        public string CertCaContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SSLMode", this.SSLMode);
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "CertCaId", this.CertCaId);
            this.SetParamSimple(map, prefix + "CertName", this.CertName);
            this.SetParamSimple(map, prefix + "CertKey", this.CertKey);
            this.SetParamSimple(map, prefix + "CertContent", this.CertContent);
            this.SetParamSimple(map, prefix + "CertCaName", this.CertCaName);
            this.SetParamSimple(map, prefix + "CertCaContent", this.CertCaContent);
        }
    }
}

