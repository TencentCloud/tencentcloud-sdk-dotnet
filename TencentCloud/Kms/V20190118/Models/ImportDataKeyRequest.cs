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

    public class ImportDataKeyRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据密钥的名称
        /// </summary>
        [JsonProperty("DataKeyName")]
        public string DataKeyName{ get; set; }

        /// <summary>
        /// 如果导入的是明文数据密钥，则是base64 转换后的明文数据密钥，  如果导入的是密文数据密钥，则是由KMS GenerateDataKey接口生成的密文数据密钥。
        /// </summary>
        [JsonProperty("ImportKeyMaterial")]
        public string ImportKeyMaterial{ get; set; }

        /// <summary>
        /// 1:密文导入(由KMS接口生成的密文数据密钥)，2:明文导入。
        /// </summary>
        [JsonProperty("ImportType")]
        public ulong? ImportType{ get; set; }

        /// <summary>
        /// 数据密钥 的描述，最大100字节
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 当导入密文数据密钥时，无需传入根密钥,如果传入会校验此KeyId是否和密文中一致。
        /// 当导入明文数据密钥，KeyId 不能为空，会根据指定的根密钥加密数据密钥。
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// KMS 独享版对应的 HSM 集群 ID。如果指定HsmClusterId，表明根密钥在此集群里，会校验KeyId是否和HsmClusterId对应。
        /// </summary>
        [JsonProperty("HsmClusterId")]
        public string HsmClusterId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataKeyName", this.DataKeyName);
            this.SetParamSimple(map, prefix + "ImportKeyMaterial", this.ImportKeyMaterial);
            this.SetParamSimple(map, prefix + "ImportType", this.ImportType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "HsmClusterId", this.HsmClusterId);
        }
    }
}

