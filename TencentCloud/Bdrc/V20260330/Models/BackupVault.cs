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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupVault : AbstractModel
    {
        
        /// <summary>
        /// 备份库ID
        /// </summary>
        [JsonProperty("VaultId")]
        public string VaultId{ get; set; }

        /// <summary>
        /// 备份库名称
        /// </summary>
        [JsonProperty("VaultName")]
        public string VaultName{ get; set; }

        /// <summary>
        /// 备份库描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 备份库状态：READ_WRITE / READ_ONLY / UNAVAILABLE / DELETING
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 加密方式：NONE / SSE-COS / SSE-KMS
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EncryptType")]
        public string EncryptType{ get; set; }

        /// <summary>
        /// KMS密钥ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }

        /// <summary>
        /// 备份库类型：COMMON
        /// </summary>
        [JsonProperty("VaultType")]
        public string VaultType{ get; set; }

        /// <summary>
        /// 关联的备份策略按类型统计
        /// </summary>
        [JsonProperty("BackupPolicySet")]
        public TypeCount[] BackupPolicySet{ get; set; }

        /// <summary>
        /// 备份点按类型统计（不含已删除）
        /// </summary>
        [JsonProperty("BackupSet")]
        public TypeCount[] BackupSet{ get; set; }

        /// <summary>
        /// 地域信息
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 源端数据量
        /// </summary>
        [JsonProperty("SourceDataSize")]
        public ulong? SourceDataSize{ get; set; }

        /// <summary>
        /// 存储库数据量
        /// </summary>
        [JsonProperty("VaultDataSize")]
        public ulong? VaultDataSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VaultId", this.VaultId);
            this.SetParamSimple(map, prefix + "VaultName", this.VaultName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EncryptType", this.EncryptType);
            this.SetParamSimple(map, prefix + "KmsKeyId", this.KmsKeyId);
            this.SetParamSimple(map, prefix + "VaultType", this.VaultType);
            this.SetParamArrayObj(map, prefix + "BackupPolicySet.", this.BackupPolicySet);
            this.SetParamArrayObj(map, prefix + "BackupSet.", this.BackupSet);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "SourceDataSize", this.SourceDataSize);
            this.SetParamSimple(map, prefix + "VaultDataSize", this.VaultDataSize);
        }
    }
}

