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

    public class CreateBackupVaultRequest : AbstractModel
    {
        
        /// <summary>
        /// 备份库名称
        /// </summary>
        [JsonProperty("VaultName")]
        public string VaultName{ get; set; }

        /// <summary>
        /// 备份库描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 加密方式: NONE/SSE-COS/SSE-KMS
        /// </summary>
        [JsonProperty("EncryptType")]
        public string EncryptType{ get; set; }

        /// <summary>
        /// KMS密钥ID（SSE-KMS时使用）
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VaultName", this.VaultName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "EncryptType", this.EncryptType);
            this.SetParamSimple(map, prefix + "KmsKeyId", this.KmsKeyId);
        }
    }
}

