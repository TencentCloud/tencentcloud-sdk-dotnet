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

namespace TencentCloud.Ssm.V20190923.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetSecretValueRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>指定凭据的名称。</p>
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// <p>指定要读取的凭据版本号。仅传 VersionId 时按该版本号精确读取；云产品及 Redis/MongoDB 凭据可通过 SSM_Current 读取当前版本。</p><p>入参限制：同时指定 VersionStage 时，两者必须指向同一版本，否则返回 ResourceNotFound。</p><p>自定义、云产品及 Redis/MongoDB 凭据在 VersionId 和 VersionStage 均未指定时，默认读取 Stage_Current 标签指向的版本；未设置该标签返回 InvalidParameterValue，不回退到 SSM_Current。</p>
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }

        /// <summary>
        /// <p>用于加密返回凭据值的 PEM 格式公钥，支持 RSA 2048 和 SM2。未指定时，凭据值按原有方式返回。</p>
        /// </summary>
        [JsonProperty("EncryptionPublicKey")]
        public string EncryptionPublicKey{ get; set; }

        /// <summary>
        /// <p>非对称加密算法，仅在指定 EncryptionPublicKey 时生效。支持 SM2、SM2_C1C3C2_ASN1、RSAES_PKCS1_V1_5、RSAES_OAEP_SHA_1、RSAES_OAEP_SHA_256，默认值为 SM2。</p>
        /// </summary>
        [JsonProperty("EncryptionAlgorithm")]
        public string EncryptionAlgorithm{ get; set; }

        /// <summary>
        /// <p>用于选择凭据版本的标签。支持自定义、云产品及 Redis/MongoDB 凭据。</p><p>枚举值：</p><ul><li>Stage_Current： 读取用户设置的当前版本标签所绑定的版本。标签不会自动设置，也不会跟随账号迁移。</li></ul><p>仅支持 Stage_Current，大小写敏感。仅传标签时按绑定关系取值；与 VersionId 同时传入时必须指向同一版本。两者均不传时默认解析 Stage_Current，未设置该标签返回 InvalidParameterValue。</p>
        /// </summary>
        [JsonProperty("VersionStage")]
        public string VersionStage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecretName", this.SecretName);
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
            this.SetParamSimple(map, prefix + "EncryptionPublicKey", this.EncryptionPublicKey);
            this.SetParamSimple(map, prefix + "EncryptionAlgorithm", this.EncryptionAlgorithm);
            this.SetParamSimple(map, prefix + "VersionStage", this.VersionStage);
        }
    }
}

