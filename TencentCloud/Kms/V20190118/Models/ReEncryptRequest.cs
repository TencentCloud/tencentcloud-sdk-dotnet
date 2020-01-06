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

    public class ReEncryptRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要重新加密的密文
        /// </summary>
        [JsonProperty("CiphertextBlob")]
        public string CiphertextBlob{ get; set; }

        /// <summary>
        /// 重新加密使用的CMK，如果为空，则使用密文原有的CMK重新加密（若密钥没有轮换则密文不会刷新）
        /// </summary>
        [JsonProperty("DestinationKeyId")]
        public string DestinationKeyId{ get; set; }

        /// <summary>
        /// CiphertextBlob 密文加密时使用的key/value对的json字符串。如果加密时未使用，则为空
        /// </summary>
        [JsonProperty("SourceEncryptionContext")]
        public string SourceEncryptionContext{ get; set; }

        /// <summary>
        /// 重新加密使用的key/value对的json字符串，如果使用该字段，则返回的新密文在解密时需要填入相同的字符串
        /// </summary>
        [JsonProperty("DestinationEncryptionContext")]
        public string DestinationEncryptionContext{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CiphertextBlob", this.CiphertextBlob);
            this.SetParamSimple(map, prefix + "DestinationKeyId", this.DestinationKeyId);
            this.SetParamSimple(map, prefix + "SourceEncryptionContext", this.SourceEncryptionContext);
            this.SetParamSimple(map, prefix + "DestinationEncryptionContext", this.DestinationEncryptionContext);
        }
    }
}

