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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SPEKEDrm : AbstractModel
    {
        
        /// <summary>
        /// <p>资源标记，该字段内容为用户自定义； 支持1-128个字符的数字、字母、下划线(_)、中划线(-)。 该字段对应Speke请求中的cid字段。 注：不同DRM厂商对该字段的限制有所区别（如：华曦达不支持该字段带_），具体规则请与DRM厂商进行确认。</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>DRM厂商访问地址，该字段内容从DRM厂商获取。注: 不同DRM厂商对子流的数量限制不一样，如 PallyCon 限制不能超过5条子流，DRMtoday厂商最多仅支持9条子流加密</p>
        /// </summary>
        [JsonProperty("KeyServerUrl")]
        public string KeyServerUrl{ get; set; }

        /// <summary>
        /// <p>加密初始化向量(十六进制32字节字符串)，该字段内容为用户自定义。</p>
        /// </summary>
        [JsonProperty("Vector")]
        public string Vector{ get; set; }

        /// <summary>
        /// <p>加密方式，可选值：<br>cbcs：PlayReady，Widevine，FairPlay，Widevine+FairPlay，Widevine+PlayReady，PlayReady+FairPlay，Widevine+PlayReady+FairPlay支持；<br>cenc：PlayReady，Widevine，Widevine+PlayReady支持；<br>若不填FairPlay 默认cbcs；<br>PlayReady，Widevine 默认cenc；<br>Widevine+FairPlay，PlayReady+FairPlay，Widevine+PlayReady+FairPlay默认cbcs；<br>Widevine+PlayReady默认cenc；</p>
        /// </summary>
        [JsonProperty("EncryptionMethod")]
        public string EncryptionMethod{ get; set; }

        /// <summary>
        /// <p>子流加密规则，默认 preset0<br>preset0：全部子流使用同一个key加密；<br>preset1：每个子流使用不同的key加密；</p>
        /// </summary>
        [JsonProperty("EncryptionPreset")]
        public string EncryptionPreset{ get; set; }

        /// <summary>
        /// <p>DRM厂商请求方式。</p><p>枚举值：</p><ul><li>POST： 大多数DRM厂商使用POST方式请求。</li><li>GET： 部分DRM厂商支持GET方式请求。使用该种方式请求时，需要在KeyServerUrl字段带上各项请求信息。</li></ul><p>默认值：POST</p>
        /// </summary>
        [JsonProperty("KeyAcquireMode")]
        public string KeyAcquireMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "KeyServerUrl", this.KeyServerUrl);
            this.SetParamSimple(map, prefix + "Vector", this.Vector);
            this.SetParamSimple(map, prefix + "EncryptionMethod", this.EncryptionMethod);
            this.SetParamSimple(map, prefix + "EncryptionPreset", this.EncryptionPreset);
            this.SetParamSimple(map, prefix + "KeyAcquireMode", this.KeyAcquireMode);
        }
    }
}

