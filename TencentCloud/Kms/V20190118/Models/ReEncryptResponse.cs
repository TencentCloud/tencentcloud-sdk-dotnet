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

    public class ReEncryptResponse : AbstractModel
    {
        
        /// <summary>
        /// 重新加密后的密文
        /// </summary>
        [JsonProperty("CiphertextBlob")]
        public string CiphertextBlob{ get; set; }

        /// <summary>
        /// 重新加密使用的CMK
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// 重新加密前密文使用的CMK
        /// </summary>
        [JsonProperty("SourceKeyId")]
        public string SourceKeyId{ get; set; }

        /// <summary>
        /// true表示密文已经重新加密。同一个CMK进行重加密，在密钥没有发生轮换的情况下不会进行实际重新加密操作，返回原密文
        /// </summary>
        [JsonProperty("ReEncrypted")]
        public bool? ReEncrypted{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CiphertextBlob", this.CiphertextBlob);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "SourceKeyId", this.SourceKeyId);
            this.SetParamSimple(map, prefix + "ReEncrypted", this.ReEncrypted);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

