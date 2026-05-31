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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCloudNativeAPIGatewaySecretKeyRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// <p>密钥协议类型。</p><p>枚举值：</p><ul><li>ApiKey</li><li>Basic</li><li>Hmac</li><li>OAuth2</li><li>JWT</li></ul>
        /// </summary>
        [JsonProperty("SecretType")]
        public string SecretType{ get; set; }

        /// <summary>
        /// <p>密钥名称，2-60 字符。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>密钥生成方式。</p><p>枚举值：</p><ul><li>System：系统自动生成</li><li>Custom：用户自定义（需传 SecretValue）</li><li>KMS：使用 KMS 密钥（需传 KmsKeyName 与 KmsKeyVersion）</li></ul>
        /// </summary>
        [JsonProperty("GenerateType")]
        public string GenerateType{ get; set; }

        /// <summary>
        /// <p>密钥归属资源类型。</p><p>枚举值：</p><ul><li>Consumer：消费者</li><li>ModelService：模型服务</li></ul>
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// <p>KMS 密钥名称。GenerateType=KMS 时必填。</p>
        /// </summary>
        [JsonProperty("KmsKeyName")]
        public string KmsKeyName{ get; set; }

        /// <summary>
        /// <p>KMS 密钥版本。GenerateType=KMS 时必填。</p>
        /// </summary>
        [JsonProperty("KmsKeyVersion")]
        public string KmsKeyVersion{ get; set; }

        /// <summary>
        /// <p>密钥值，长度 8-256。GenerateType=Custom 时必填。</p>
        /// </summary>
        [JsonProperty("SecretValue")]
        public string SecretValue{ get; set; }

        /// <summary>
        /// <p>密钥描述。最长 200 字符。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "SecretType", this.SecretType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "GenerateType", this.GenerateType);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "KmsKeyName", this.KmsKeyName);
            this.SetParamSimple(map, prefix + "KmsKeyVersion", this.KmsKeyVersion);
            this.SetParamSimple(map, prefix + "SecretValue", this.SecretValue);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

