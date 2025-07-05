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

namespace TencentCloud.Trp.V20210515.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InputEncryptData : AbstractModel
    {
        
        /// <summary>
        /// 加密方式，0：AES加密；
        /// </summary>
        [JsonProperty("EncryptMethod")]
        public long? EncryptMethod{ get; set; }

        /// <summary>
        /// 加密算法中的块处理模式，1：CBC模式； 目前只支持CBC模式
        /// </summary>
        [JsonProperty("EncryptMode")]
        public long? EncryptMode{ get; set; }

        /// <summary>
        /// 填充模式，0：ZeroPadding；1：PKCS5Padding；2：
        /// PKCS7Padding。
        /// </summary>
        [JsonProperty("PaddingType")]
        public long? PaddingType{ get; set; }

        /// <summary>
        /// 加密数据，将AuthorizedData结构体数组（数组最大长度不超过20）序列化成JSON字符串，对得到的字符串加密并填充到该字段。
        /// </summary>
        [JsonProperty("EncryptData")]
        public string EncryptData{ get; set; }

        /// <summary>
        /// 用户是否授权，本接口取值：1，已授权。
        /// </summary>
        [JsonProperty("IsAuthorized")]
        public long? IsAuthorized{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EncryptMethod", this.EncryptMethod);
            this.SetParamSimple(map, prefix + "EncryptMode", this.EncryptMode);
            this.SetParamSimple(map, prefix + "PaddingType", this.PaddingType);
            this.SetParamSimple(map, prefix + "EncryptData", this.EncryptData);
            this.SetParamSimple(map, prefix + "IsAuthorized", this.IsAuthorized);
        }
    }
}

