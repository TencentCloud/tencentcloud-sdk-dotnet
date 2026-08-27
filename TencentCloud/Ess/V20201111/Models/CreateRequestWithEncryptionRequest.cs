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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRequestWithEncryptionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>操作的接口名称。取值参考接口文档输入参数章节关于公共参数 Action 的说明。</p>
        /// </summary>
        [JsonProperty("RequestAction")]
        public string RequestAction{ get; set; }

        /// <summary>
        /// <p>加密算法使用的初始化向量。固定为 16 字节，将 IV 原始字节使用标准 Base64 编码后传入。</p>
        /// </summary>
        [JsonProperty("IV")]
        public string IV{ get; set; }

        /// <summary>
        /// <p>使用 AES-CBC 或 SM4-CBC 加密请求内容得到的密文。加密前请求内容采用 PKCS#7 Padding；将密文原始字节使用标准 Base64 编码后传入。</p>
        /// </summary>
        [JsonProperty("EncryptedData")]
        public string EncryptedData{ get; set; }

        /// <summary>
        /// <p>用于校验请求数据完整性。对 IV 原始字节和密文原始字节直接拼接（不加拼接符）后计算 HMAC-SHA256，再将计算结果使用标准 Base64 编码后传入。</p>
        /// </summary>
        [JsonProperty("EncryptionSignature")]
        public string EncryptionSignature{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RequestAction", this.RequestAction);
            this.SetParamSimple(map, prefix + "IV", this.IV);
            this.SetParamSimple(map, prefix + "EncryptedData", this.EncryptedData);
            this.SetParamSimple(map, prefix + "EncryptionSignature", this.EncryptionSignature);
        }
    }
}

