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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SpekeDrm : AbstractModel
    {
        
        /// <summary>
        /// 资源标记，该字段内容为用户自定义；
        /// 支持1-128个字符的数字、字母、下划线(`_`)、中划线(-)。
        /// 该字段对应Speke请求中的cid字段。
        /// 注：不同DRM厂商对该字段的限制有所区别（如：华曦达不支持该字段带`_`），具体规则请与DRM厂商进行确认。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// DRM厂商访问地址，该字段内容从DRM厂商获取。
        /// 
        /// 注: 不同DRM厂商对子流的数量限制不一样，如 PallyCon 限制不能超过5条子流，DRMtoday厂商最多仅支持9条子流加密
        /// </summary>
        [JsonProperty("KeyServerUrl")]
        public string KeyServerUrl{ get; set; }

        /// <summary>
        /// 加密初始化向量(十六进制32字节字符串)，该字段内容为用户自定义。
        /// </summary>
        [JsonProperty("Vector")]
        public string Vector{ get; set; }

        /// <summary>
        /// 加密方式，可选值：
        /// cbcs：PlayReady，Widevine，FairPlay，WideVine+FairPlay，Widevine+Playready，Playready+Fairplay，Widevine+Playready+Fairplay支持；
        /// cenc：PlayReady，Widevine，Widevine+Playready支持；
        /// 
        /// 若不填
        /// FairPlay 默认cbcs;
        /// PlayReady，Widevine 默认cenc;
        /// WideVine+FairPlay，Playready+Fairplay，Widevine+Playready+Fairplay默认cbcs;
        /// Widevine+Playready默认cenc;
        /// </summary>
        [JsonProperty("EncryptionMethod")]
        public string EncryptionMethod{ get; set; }

        /// <summary>
        /// 子流加密规则，默认 preset0
        /// preset0：全部子流使用同一个key加密；
        /// preset1：每个子流使用不同的key加密；
        /// </summary>
        [JsonProperty("EncryptionPreset")]
        public string EncryptionPreset{ get; set; }


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
        }
    }
}

