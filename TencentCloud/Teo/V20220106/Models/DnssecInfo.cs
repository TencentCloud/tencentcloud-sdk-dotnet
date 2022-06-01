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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DnssecInfo : AbstractModel
    {
        
        /// <summary>
        /// 标志
        /// </summary>
        [JsonProperty("Flags")]
        public long? Flags{ get; set; }

        /// <summary>
        /// 加密算法
        /// </summary>
        [JsonProperty("Algorithm")]
        public string Algorithm{ get; set; }

        /// <summary>
        /// 加密类型
        /// </summary>
        [JsonProperty("KeyType")]
        public string KeyType{ get; set; }

        /// <summary>
        /// 摘要类型
        /// </summary>
        [JsonProperty("DigestType")]
        public string DigestType{ get; set; }

        /// <summary>
        /// 摘要算法
        /// </summary>
        [JsonProperty("DigestAlgorithm")]
        public string DigestAlgorithm{ get; set; }

        /// <summary>
        /// 摘要信息
        /// </summary>
        [JsonProperty("Digest")]
        public string Digest{ get; set; }

        /// <summary>
        /// DS 记录值
        /// </summary>
        [JsonProperty("DS")]
        public string DS{ get; set; }

        /// <summary>
        /// 密钥标签
        /// </summary>
        [JsonProperty("KeyTag")]
        public long? KeyTag{ get; set; }

        /// <summary>
        /// 公钥
        /// </summary>
        [JsonProperty("PublicKey")]
        public string PublicKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Flags", this.Flags);
            this.SetParamSimple(map, prefix + "Algorithm", this.Algorithm);
            this.SetParamSimple(map, prefix + "KeyType", this.KeyType);
            this.SetParamSimple(map, prefix + "DigestType", this.DigestType);
            this.SetParamSimple(map, prefix + "DigestAlgorithm", this.DigestAlgorithm);
            this.SetParamSimple(map, prefix + "Digest", this.Digest);
            this.SetParamSimple(map, prefix + "DS", this.DS);
            this.SetParamSimple(map, prefix + "KeyTag", this.KeyTag);
            this.SetParamSimple(map, prefix + "PublicKey", this.PublicKey);
        }
    }
}

