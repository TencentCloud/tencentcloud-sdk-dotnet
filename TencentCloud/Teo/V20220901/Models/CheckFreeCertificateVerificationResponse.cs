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

    public class CheckFreeCertificateVerificationResponse : AbstractModel
    {
        
        /// <summary>
        /// 免费证书申请成功时，该证书颁发给的域名。
        /// 注意：一个域名只允许申请一本免费证书， 如果已经有泛域名申请了免费证书的情况下，其子域名会匹配使用该泛域名证书。
        /// </summary>
        [JsonProperty("CommonName")]
        public string CommonName{ get; set; }

        /// <summary>
        /// 免费证书申请成功时，该证书使用的签名算法，当前仅支持 RSA 2048。
        /// </summary>
        [JsonProperty("SignatureAlgorithm")]
        public string SignatureAlgorithm{ get; set; }

        /// <summary>
        /// 免费证书申请成功时，该证书的过期时间。时间为世界标准时间（UTC）， 遵循 ISO 8601 标准的日期和时间格式。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CommonName", this.CommonName);
            this.SetParamSimple(map, prefix + "SignatureAlgorithm", this.SignatureAlgorithm);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

