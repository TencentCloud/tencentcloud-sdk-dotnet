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

    public class CNAPIGwSecretKey : AbstractModel
    {
        
        /// <summary>
        /// 密钥id
        /// </summary>
        [JsonProperty("SecretKeyId")]
        public string SecretKeyId{ get; set; }

        /// <summary>
        /// 密钥名字
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 密钥类型：ApiKey/JWT
        /// </summary>
        [JsonProperty("SecretType")]
        public string SecretType{ get; set; }

        /// <summary>
        /// 状态:
        /// - Enable: 启用
        /// - Disable: 禁用
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 生成方式:KMS/System/Custom
        /// </summary>
        [JsonProperty("GenerateType")]
        public string GenerateType{ get; set; }

        /// <summary>
        /// 密钥值
        /// </summary>
        [JsonProperty("SecretValue")]
        public string SecretValue{ get; set; }

        /// <summary>
        /// KMS凭证名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KmsKeyName")]
        public string KmsKeyName{ get; set; }

        /// <summary>
        /// KMS凭证版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KmsKeyVersion")]
        public string KmsKeyVersion{ get; set; }

        /// <summary>
        /// 描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 是否可以绑定
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CanBind")]
        public bool? CanBind{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 绑定数
        /// </summary>
        [JsonProperty("BindCount")]
        public ulong? BindCount{ get; set; }

        /// <summary>
        /// 资源类型：
        /// - Consumer 消费者
        /// - LLM 模型服务
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecretKeyId", this.SecretKeyId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "SecretType", this.SecretType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "GenerateType", this.GenerateType);
            this.SetParamSimple(map, prefix + "SecretValue", this.SecretValue);
            this.SetParamSimple(map, prefix + "KmsKeyName", this.KmsKeyName);
            this.SetParamSimple(map, prefix + "KmsKeyVersion", this.KmsKeyVersion);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CanBind", this.CanBind);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "BindCount", this.BindCount);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
        }
    }
}

