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

namespace TencentCloud.Drm.V20181115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeKeysResponse : AbstractModel
    {
        
        /// <summary>
        /// 加密密钥列表
        /// </summary>
        [JsonProperty("Keys")]
        public KeyInfo[] Keys{ get; set; }

        /// <summary>
        /// 用来加密密钥。
        /// 如果入参中带有RsaPublicKey，则SessionKey为使用Rsa公钥加密后的二进制数据，Base64编码字符串。
        /// 如果入参中没有RsaPublicKey，则SessionKey为原始数据的字符串形式。
        /// </summary>
        [JsonProperty("SessionKey")]
        public string SessionKey{ get; set; }

        /// <summary>
        /// 内容ID
        /// </summary>
        [JsonProperty("ContentId")]
        public string ContentId{ get; set; }

        /// <summary>
        /// Widevine方案的Pssh数据，Base64编码。
        /// Fairplay方案无该值。
        /// </summary>
        [JsonProperty("Pssh")]
        public string Pssh{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "Keys.", this.Keys);
            this.SetParamSimple(map, prefix + "SessionKey", this.SessionKey);
            this.SetParamSimple(map, prefix + "ContentId", this.ContentId);
            this.SetParamSimple(map, prefix + "Pssh", this.Pssh);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

