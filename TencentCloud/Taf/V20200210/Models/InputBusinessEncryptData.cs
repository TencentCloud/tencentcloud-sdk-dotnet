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

namespace TencentCloud.Taf.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InputBusinessEncryptData : AbstractModel
    {
        
        /// <summary>
        /// 加密方式；0：AES;1:DES
        /// </summary>
        [JsonProperty("EncryptMethod")]
        public ulong? EncryptMethod{ get; set; }

        /// <summary>
        /// 业务数据加密字符串
        /// </summary>
        [JsonProperty("EncryptData")]
        public string EncryptData{ get; set; }

        /// <summary>
        /// 加密模式；0：ECB,1:CBC;2:CTR;3:CFB;4:OFB
        /// </summary>
        [JsonProperty("EncryptMode")]
        public ulong? EncryptMode{ get; set; }

        /// <summary>
        /// 填充模式;0:ZERO ;1:PKCS5;3:PKCS7
        /// </summary>
        [JsonProperty("PaddingType")]
        public ulong? PaddingType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EncryptMethod", this.EncryptMethod);
            this.SetParamSimple(map, prefix + "EncryptData", this.EncryptData);
            this.SetParamSimple(map, prefix + "EncryptMode", this.EncryptMode);
            this.SetParamSimple(map, prefix + "PaddingType", this.PaddingType);
        }
    }
}

