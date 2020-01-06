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

    public class DescribeKeysRequest : AbstractModel
    {
        
        /// <summary>
        /// 使用的DRM方案类型，接口取值WIDEVINE、FAIRPLAY、NORMALAES。
        /// </summary>
        [JsonProperty("DrmType")]
        public string DrmType{ get; set; }

        /// <summary>
        /// 加密的track列表，接口取值VIDEO、AUDIO。
        /// </summary>
        [JsonProperty("Tracks")]
        public string[] Tracks{ get; set; }

        /// <summary>
        /// 内容类型。接口取值VodVideo,LiveVideo
        /// </summary>
        [JsonProperty("ContentType")]
        public string ContentType{ get; set; }

        /// <summary>
        /// Base64编码的Rsa公钥，用来加密出参中的SessionKey。
        /// 如果该参数为空，则出参中SessionKey为明文。
        /// </summary>
        [JsonProperty("RsaPublicKey")]
        public string RsaPublicKey{ get; set; }

        /// <summary>
        /// 一个加密内容的唯一标识。
        /// 如果该参数为空，则后台自动生成
        /// </summary>
        [JsonProperty("ContentId")]
        public string ContentId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DrmType", this.DrmType);
            this.SetParamArraySimple(map, prefix + "Tracks.", this.Tracks);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamSimple(map, prefix + "RsaPublicKey", this.RsaPublicKey);
            this.SetParamSimple(map, prefix + "ContentId", this.ContentId);
        }
    }
}

