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

    public class CertificateOutput : AbstractModel
    {
        
        /// <summary>
        /// 认证类型，UNIDIRECTIONAL：单向认证，MUTUAL：双向认证
        /// </summary>
        [JsonProperty("SSLMode")]
        public string SSLMode{ get; set; }

        /// <summary>
        /// 是否开启客户端证书验证，只在双向认证时生效。
        /// </summary>
        [JsonProperty("SSLVerifyClient")]
        public string SSLVerifyClient{ get; set; }

        /// <summary>
        /// 服务端证书的ID。
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// 客户端证书的 ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertCaId")]
        public string CertCaId{ get; set; }

        /// <summary>
        /// 多本服务器证书场景扩展的服务器证书ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtCertIds")]
        public string[] ExtCertIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SSLMode", this.SSLMode);
            this.SetParamSimple(map, prefix + "SSLVerifyClient", this.SSLVerifyClient);
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "CertCaId", this.CertCaId);
            this.SetParamArraySimple(map, prefix + "ExtCertIds.", this.ExtCertIds);
        }
    }
}

