/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class ImportKeyMaterialRequest : AbstractModel
    {
        
        /// <summary>
        /// 使用GetParametersForImport 返回的PublicKey加密后的密钥材料base64编码。对于国密版本region的KMS，导入的密钥材料长度要求为 128 bit，FIPS版本region的KMS， 导入的密钥材料长度要求为 256 bit。
        /// </summary>
        [JsonProperty("EncryptedKeyMaterial")]
        public string EncryptedKeyMaterial{ get; set; }

        /// <summary>
        /// 通过调用GetParametersForImport获得的导入令牌。
        /// </summary>
        [JsonProperty("ImportToken")]
        public string ImportToken{ get; set; }

        /// <summary>
        /// 指定导入密钥材料的CMK，需要和GetParametersForImport 指定的CMK相同。
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// 密钥材料过期时间 unix 时间戳，不指定或者 0 表示密钥材料不会过期，若指定过期时间，需要大于当前时间点，最大支持 2147443200。
        /// </summary>
        [JsonProperty("ValidTo")]
        public ulong? ValidTo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EncryptedKeyMaterial", this.EncryptedKeyMaterial);
            this.SetParamSimple(map, prefix + "ImportToken", this.ImportToken);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "ValidTo", this.ValidTo);
        }
    }
}

