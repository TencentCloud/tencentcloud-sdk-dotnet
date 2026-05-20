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
        /// 密钥类型： ApiKey
        /// </summary>
        [JsonProperty("SecretType")]
        public string SecretType{ get; set; }

        /// <summary>
        /// 密钥名字
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 生成方式：  
        /// 
        /// 密钥类型 Consumer 时选项：  
        /// 
        /// - KMS
        /// - System 系统  
        /// - Custom  自定义  
        /// 
        /// 密钥类型是 LLM 时选项 
        /// 
        /// - KMS 
        /// - Custom  自定义 
        /// </summary>
        [JsonProperty("GenerateType")]
        public string GenerateType{ get; set; }

        /// <summary>
        /// 资源类型：
        /// - Consumer 消费者
        /// - LLM 模型服务
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// KMS 的凭证名字， GenerateType 时 kms 必填
        /// </summary>
        [JsonProperty("KmsKeyName")]
        public string KmsKeyName{ get; set; }

        /// <summary>
        /// KMS 的凭证版本， GenerateType 时 kms 必填
        /// </summary>
        [JsonProperty("KmsKeyVersion")]
        public string KmsKeyVersion{ get; set; }

        /// <summary>
        /// GenerateType 等于 Custom 是必填
        /// </summary>
        [JsonProperty("SecretValue")]
        public string SecretValue{ get; set; }

        /// <summary>
        /// 描述
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

