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

    public class ModifyFairPlayPemRequest : AbstractModel
    {
        
        /// <summary>
        /// 加密后的fairplay方案申请时使用的私钥。
        /// 请使用腾讯云DRM 提供的公钥，使用rsa加密算法，PKCS1填充方式对私钥文件中的字段进行加密，并对加密结果进行base64编码。
        /// </summary>
        [JsonProperty("Pem")]
        public string Pem{ get; set; }

        /// <summary>
        /// 加密后的fairplay方案申请返回的ask数据。
        /// 请使用腾讯云DRM 提供的公钥，使用rsa加密算法，PKCS1填充方式对Ask字符串进行加密，并对加密结果进行base64编码。
        /// </summary>
        [JsonProperty("Ask")]
        public string Ask{ get; set; }

        /// <summary>
        /// 要修改的私钥id
        /// </summary>
        [JsonProperty("FairPlayPemId")]
        public ulong? FairPlayPemId{ get; set; }

        /// <summary>
        /// 私钥的解密密钥。
        /// openssl在生成rsa时，可能会需要设置加密密钥，请记住设置的密钥。
        /// 请使用腾讯云DRM 提供的公钥，使用rsa加密算法，PKCS1填充方式对解密密钥进行加密，并对加密结果进行base64编码。
        /// </summary>
        [JsonProperty("PemDecryptKey")]
        public string PemDecryptKey{ get; set; }

        /// <summary>
        /// 委托者Id,适用于托管自身证书的客户。普通客户无需填该字段。
        /// </summary>
        [JsonProperty("BailorId")]
        public ulong? BailorId{ get; set; }

        /// <summary>
        /// 私钥的优先级，优先级数值越高，优先级越高。
        /// 该值可以不传，后台将自动分配一个优先级。
        /// </summary>
        [JsonProperty("Priority")]
        public ulong? Priority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Pem", this.Pem);
            this.SetParamSimple(map, prefix + "Ask", this.Ask);
            this.SetParamSimple(map, prefix + "FairPlayPemId", this.FairPlayPemId);
            this.SetParamSimple(map, prefix + "PemDecryptKey", this.PemDecryptKey);
            this.SetParamSimple(map, prefix + "BailorId", this.BailorId);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
        }
    }
}

