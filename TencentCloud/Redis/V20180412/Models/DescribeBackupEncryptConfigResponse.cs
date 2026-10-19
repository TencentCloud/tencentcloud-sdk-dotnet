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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBackupEncryptConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>备份是否加密</p><p>枚举值：</p><ul><li>true： 加密</li><li>false： 不加密</li></ul>
        /// </summary>
        [JsonProperty("BackupEncrypt")]
        public bool? BackupEncrypt{ get; set; }

        /// <summary>
        /// <p>加密密钥类型。</p><p>枚举值：</p><ul><li>0： 腾讯云托管（默认）</li><li>1： 用户自定义 KMS 密钥</li></ul>
        /// </summary>
        [JsonProperty("EncryptKeyType")]
        public long? EncryptKeyType{ get; set; }

        /// <summary>
        /// <p>KMS的密钥ID。</p><p>参数格式：xxxxxxx-xxxx-xxxx-xxxx-xxxxxxx</p>
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }

        /// <summary>
        /// <p>KMS地域信息。</p><p>参数格式：ap-xxxx</p>
        /// </summary>
        [JsonProperty("KmsRegion")]
        public string KmsRegion{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackupEncrypt", this.BackupEncrypt);
            this.SetParamSimple(map, prefix + "EncryptKeyType", this.EncryptKeyType);
            this.SetParamSimple(map, prefix + "KmsKeyId", this.KmsKeyId);
            this.SetParamSimple(map, prefix + "KmsRegion", this.KmsRegion);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

