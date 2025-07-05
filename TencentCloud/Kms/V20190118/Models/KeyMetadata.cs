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

    public class KeyMetadata : AbstractModel
    {
        
        /// <summary>
        /// CMK的全局唯一标识
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// 作为密钥更容易辨识，更容易被人看懂的别名
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// 密钥创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// CMK的描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// CMK的状态， 取值为：Enabled | Disabled | PendingDelete | PendingImport | Archived
        /// </summary>
        [JsonProperty("KeyState")]
        public string KeyState{ get; set; }

        /// <summary>
        /// CMK用途，取值为: ENCRYPT_DECRYPT | ASYMMETRIC_DECRYPT_RSA_2048 | ASYMMETRIC_DECRYPT_SM2 | ASYMMETRIC_SIGN_VERIFY_SM2 | ASYMMETRIC_SIGN_VERIFY_RSA_2048 | ASYMMETRIC_SIGN_VERIFY_ECC
        /// </summary>
        [JsonProperty("KeyUsage")]
        public string KeyUsage{ get; set; }

        /// <summary>
        /// CMK类型，2 表示符合FIPS标准，4表示符合国密标准
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [JsonProperty("CreatorUin")]
        public ulong? CreatorUin{ get; set; }

        /// <summary>
        /// 是否开启了密钥轮换功能
        /// </summary>
        [JsonProperty("KeyRotationEnabled")]
        public bool? KeyRotationEnabled{ get; set; }

        /// <summary>
        /// CMK的创建者，用户创建的为 user，授权各云产品自动创建的为对应的产品名
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// 在密钥轮换开启状态下，下次轮换的时间
        /// </summary>
        [JsonProperty("NextRotateTime")]
        public ulong? NextRotateTime{ get; set; }

        /// <summary>
        /// 计划删除的时间
        /// </summary>
        [JsonProperty("DeletionDate")]
        public ulong? DeletionDate{ get; set; }

        /// <summary>
        /// CMK 密钥材料类型，由KMS创建的为： TENCENT_KMS， 由用户导入的类型为：EXTERNAL
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// 在Origin为  EXTERNAL 时有效，表示密钥材料的有效日期， 0 表示不过期
        /// </summary>
        [JsonProperty("ValidTo")]
        public ulong? ValidTo{ get; set; }

        /// <summary>
        /// 资源ID，格式：creatorUin/$creatorUin/$keyId
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// HSM 集群 ID（仅对 KMS 独占版/托管版服务实例有效）
        /// </summary>
        [JsonProperty("HsmClusterId")]
        public string HsmClusterId{ get; set; }

        /// <summary>
        /// 密钥轮转周期（天）
        /// </summary>
        [JsonProperty("RotateDays")]
        public ulong? RotateDays{ get; set; }

        /// <summary>
        /// 上次乱转时间（Unix timestamp）
        /// </summary>
        [JsonProperty("LastRotateTime")]
        public ulong? LastRotateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "KeyState", this.KeyState);
            this.SetParamSimple(map, prefix + "KeyUsage", this.KeyUsage);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CreatorUin", this.CreatorUin);
            this.SetParamSimple(map, prefix + "KeyRotationEnabled", this.KeyRotationEnabled);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
            this.SetParamSimple(map, prefix + "NextRotateTime", this.NextRotateTime);
            this.SetParamSimple(map, prefix + "DeletionDate", this.DeletionDate);
            this.SetParamSimple(map, prefix + "Origin", this.Origin);
            this.SetParamSimple(map, prefix + "ValidTo", this.ValidTo);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "HsmClusterId", this.HsmClusterId);
            this.SetParamSimple(map, prefix + "RotateDays", this.RotateDays);
            this.SetParamSimple(map, prefix + "LastRotateTime", this.LastRotateTime);
        }
    }
}

