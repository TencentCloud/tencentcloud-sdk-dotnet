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

namespace TencentCloud.Kms.V20190118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GenerateDataKeyRequest : AbstractModel
    {
        
        /// <summary>
        /// CMK全局唯一标识符
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// 指定生成Datakey的加密算法以及Datakey大小，AES_128或者AES_256。KeySpec 和 NumberOfBytes 必须指定一个
        /// </summary>
        [JsonProperty("KeySpec")]
        public string KeySpec{ get; set; }

        /// <summary>
        /// 生成的DataKey的长度，同时指定NumberOfBytes和KeySpec时，以NumberOfBytes为准。最小值为1， 最大值为1024。KeySpec 和 NumberOfBytes 必须指定一个
        /// </summary>
        [JsonProperty("NumberOfBytes")]
        public ulong? NumberOfBytes{ get; set; }

        /// <summary>
        /// key/value对的json字符串，如果使用该字段，则返回的DataKey在解密时需要填入相同的字符串
        /// </summary>
        [JsonProperty("EncryptionContext")]
        public string EncryptionContext{ get; set; }

        /// <summary>
        /// PEM 格式公钥字符串，支持 RSA2048 和 SM2 公钥，用于对返回数据中的 Plaintext 值进行加密。若为空，则不对 Plaintext 值加密。
        /// </summary>
        [JsonProperty("EncryptionPublicKey")]
        public string EncryptionPublicKey{ get; set; }

        /// <summary>
        /// 非对称加密算法，配合 EncryptionPublicKey 对返回数据进行加密。目前支持：SM2（以 C1C3C2 格式返回密文），SM2_C1C3C2_ASN1 （以 C1C3C2 ASN1 格式返回密文），RSAES_PKCS1_V1_5，RSAES_OAEP_SHA_1，RSAES_OAEP_SHA_256。若为空，则默认为 SM2。
        /// </summary>
        [JsonProperty("EncryptionAlgorithm")]
        public string EncryptionAlgorithm{ get; set; }

        /// <summary>
        /// 表示生成的数据密钥是否被KMS托管。1:表示被KMS托管保存,0:表示KMS不托管。
        /// </summary>
        [JsonProperty("IsHostedByKms")]
        public ulong? IsHostedByKms{ get; set; }

        /// <summary>
        /// 数据密钥的名称，当IsHostedByKms为1时,必须填写。当IsHostedByKms为0时,可以不填，KMS不托管。
        /// </summary>
        [JsonProperty("DataKeyName")]
        public string DataKeyName{ get; set; }

        /// <summary>
        /// 数据密钥 的描述，最大100字节
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// KMS 独享版对应的 HSM 集群 ID。如果指定HsmClusterId，表明根密钥在此集群里，会校验KeyId是否和HsmClusterId对应。
        /// </summary>
        [JsonProperty("HsmClusterId")]
        public string HsmClusterId{ get; set; }

        /// <summary>
        /// 标签列表,当参数IsHostedByKms=1，数据密钥托管到kms时有效.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "KeySpec", this.KeySpec);
            this.SetParamSimple(map, prefix + "NumberOfBytes", this.NumberOfBytes);
            this.SetParamSimple(map, prefix + "EncryptionContext", this.EncryptionContext);
            this.SetParamSimple(map, prefix + "EncryptionPublicKey", this.EncryptionPublicKey);
            this.SetParamSimple(map, prefix + "EncryptionAlgorithm", this.EncryptionAlgorithm);
            this.SetParamSimple(map, prefix + "IsHostedByKms", this.IsHostedByKms);
            this.SetParamSimple(map, prefix + "DataKeyName", this.DataKeyName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "HsmClusterId", this.HsmClusterId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

