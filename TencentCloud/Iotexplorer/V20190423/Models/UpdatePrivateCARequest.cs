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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdatePrivateCARequest : AbstractModel
    {
        
        /// <summary>
        /// <p>证书名称。</p>
        /// </summary>
        [JsonProperty("CertName")]
        public string CertName{ get; set; }

        /// <summary>
        /// <p>证书内容，PEM 格式文本，需为 CA 证书。</p>
        /// </summary>
        [JsonProperty("CertText")]
        public string CertText{ get; set; }

        /// <summary>
        /// <p>验证证书内容，PEM 格式文本。须由所上传的 CA 签发，且 CN 为 sha256(&quot;iothub_主账号Uin&quot;) 的小写十六进制值，用于验证您持有 CA 私钥。</p>
        /// </summary>
        [JsonProperty("VerifyCertText")]
        public string VerifyCertText{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertName", this.CertName);
            this.SetParamSimple(map, prefix + "CertText", this.CertText);
            this.SetParamSimple(map, prefix + "VerifyCertText", this.VerifyCertText);
        }
    }
}

