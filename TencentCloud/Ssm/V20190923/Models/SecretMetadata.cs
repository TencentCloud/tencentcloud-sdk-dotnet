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

    public class SecretMetadata : AbstractModel
    {
        
        /// <summary>
        /// <p>凭据名称</p>
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// <p>凭据的描述信息</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>用于加密凭据的KMS KeyId</p>
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }

        /// <summary>
        /// <p>创建者UIN</p>
        /// </summary>
        [JsonProperty("CreateUin")]
        public ulong? CreateUin{ get; set; }

        /// <summary>
        /// <p>凭据状态：Enabled、Disabled、PendingDelete、Creating、Failed</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>凭据删除日期，对于status为PendingDelete 的有效，unix时间戳</p>
        /// </summary>
        [JsonProperty("DeleteTime")]
        public ulong? DeleteTime{ get; set; }

        /// <summary>
        /// <p>凭据创建时间，unix时间戳</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// <p>用于加密凭据的KMS CMK类型，DEFAULT 表示SecretsManager 创建的默认密钥， CUSTOMER 表示用户指定的密钥</p>
        /// </summary>
        [JsonProperty("KmsKeyType")]
        public string KmsKeyType{ get; set; }

        /// <summary>
        /// <p>1:--开启轮转；0--禁止轮转</p>
        /// </summary>
        [JsonProperty("RotationStatus")]
        public long? RotationStatus{ get; set; }

        /// <summary>
        /// <p>下一次轮转开始时间，uinx 时间戳</p>
        /// </summary>
        [JsonProperty("NextRotationTime")]
        public ulong? NextRotationTime{ get; set; }

        /// <summary>
        /// <p>0 -- 用户自定义凭据；<br>1 -- 云产品凭据；<br>2 -- SSH密钥对凭据；<br>3 -- 云API密钥对凭据；<br>4 -- Redis类型凭据；</p>
        /// </summary>
        [JsonProperty("SecretType")]
        public long? SecretType{ get; set; }

        /// <summary>
        /// <p>云产品名称，仅在SecretType为1，即凭据类型为云产品凭据时生效</p>
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// <p>当凭据类型为SSH密钥对凭据时，此字段有效，用于表示SSH密钥对凭据的名称。</p>
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// <p>当凭据类型为SSH密钥对凭据时，此字段有效，用于表示SSH密钥对所属的项目ID。</p>
        /// </summary>
        [JsonProperty("ProjectID")]
        public long? ProjectID{ get; set; }

        /// <summary>
        /// <p>当凭据类型为SSH密钥对凭据时，此字段有效，用于表示SSH密钥对所关联的CVM实例ID。</p>
        /// </summary>
        [JsonProperty("AssociatedInstanceIDs")]
        public string[] AssociatedInstanceIDs{ get; set; }

        /// <summary>
        /// <p>当凭据类型为云API密钥对凭据时，此字段有效，用于表示云API密钥对所属的用户UIN。</p>
        /// </summary>
        [JsonProperty("TargetUin")]
        public ulong? TargetUin{ get; set; }

        /// <summary>
        /// <p>轮转的频率，以天作为单位，在轮转开启状态下生效。</p>
        /// </summary>
        [JsonProperty("RotationFrequency")]
        public long? RotationFrequency{ get; set; }

        /// <summary>
        /// <p>云产品凭据对应的云产品实例 ID 号。</p>
        /// </summary>
        [JsonProperty("ResourceID")]
        public string ResourceID{ get; set; }

        /// <summary>
        /// <p>用户指定的轮转开始时间。</p>
        /// </summary>
        [JsonProperty("RotationBeginTime")]
        public string RotationBeginTime{ get; set; }

        /// <summary>
        /// <p>凭据加密类型</p><p>枚举值：</p><ul><li>0： KMS 密钥加密</li><li>1： 软密钥加密</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("EncryptType")]
        public ulong? EncryptType{ get; set; }

        /// <summary>
        /// <p>凭据密钥加密切换中</p>
        /// </summary>
        [JsonProperty("EncryptSwitching")]
        public bool? EncryptSwitching{ get; set; }

        /// <summary>
        /// <p>创建者 UIN 字符串</p>
        /// </summary>
        [JsonProperty("CreateUinString")]
        public string CreateUinString{ get; set; }

        /// <summary>
        /// <p>所属者 UIN 字符串</p><p>用以兼容uint64,防止精度丢失</p>
        /// </summary>
        [JsonProperty("TargetUinString")]
        public string TargetUinString{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecretName", this.SecretName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "KmsKeyId", this.KmsKeyId);
            this.SetParamSimple(map, prefix + "CreateUin", this.CreateUin);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "DeleteTime", this.DeleteTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "KmsKeyType", this.KmsKeyType);
            this.SetParamSimple(map, prefix + "RotationStatus", this.RotationStatus);
            this.SetParamSimple(map, prefix + "NextRotationTime", this.NextRotationTime);
            this.SetParamSimple(map, prefix + "SecretType", this.SecretType);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "ProjectID", this.ProjectID);
            this.SetParamArraySimple(map, prefix + "AssociatedInstanceIDs.", this.AssociatedInstanceIDs);
            this.SetParamSimple(map, prefix + "TargetUin", this.TargetUin);
            this.SetParamSimple(map, prefix + "RotationFrequency", this.RotationFrequency);
            this.SetParamSimple(map, prefix + "ResourceID", this.ResourceID);
            this.SetParamSimple(map, prefix + "RotationBeginTime", this.RotationBeginTime);
            this.SetParamSimple(map, prefix + "EncryptType", this.EncryptType);
            this.SetParamSimple(map, prefix + "EncryptSwitching", this.EncryptSwitching);
            this.SetParamSimple(map, prefix + "CreateUinString", this.CreateUinString);
            this.SetParamSimple(map, prefix + "TargetUinString", this.TargetUinString);
        }
    }
}

