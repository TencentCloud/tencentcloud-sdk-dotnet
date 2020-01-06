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

    public class GenerateDataKeyRequest : AbstractModel
    {
        
        /// <summary>
        /// CMK全局唯一标识符
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// 指定生成Datakey的加密算法以及Datakey大小，AES_128或者AES_256。KeySpec 和 NumberOfBytes 必须指定一个
        /// </summary>
        [JsonProperty("KeySpec")]
        public string KeySpec{ get; set; }

        /// <summary>
        /// 生成的DataKey的长度，同时指定NumberOfBytes和KeySpec时，以NumberOfBytes为准。最小值为1， 最大值为1024。KeySpec 和 NumberOfBytes 必须指定一个
        /// </summary>
        [JsonProperty("NumberOfBytes")]
        public ulong? NumberOfBytes{ get; set; }

        /// <summary>
        /// key/value对的json字符串，如果使用该字段，则返回的DataKey在解密时需要填入相同的字符串
        /// </summary>
        [JsonProperty("EncryptionContext")]
        public string EncryptionContext{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "KeySpec", this.KeySpec);
            this.SetParamSimple(map, prefix + "NumberOfBytes", this.NumberOfBytes);
            this.SetParamSimple(map, prefix + "EncryptionContext", this.EncryptionContext);
        }
    }
}

