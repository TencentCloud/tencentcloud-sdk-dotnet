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

namespace TencentCloud.Es.V20250101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChunkConfig : AbstractModel
    {
        
        /// <summary>
        /// 最大分片长度
        /// </summary>
        [JsonProperty("MaxChunkSize")]
        public ulong? MaxChunkSize{ get; set; }

        /// <summary>
        /// 分隔符列表
        /// </summary>
        [JsonProperty("Delimiters")]
        public string[] Delimiters{ get; set; }

        /// <summary>
        /// 相邻切片重合字符数，需要小于分片长度
        /// </summary>
        [JsonProperty("ChunkOverlap")]
        public ulong? ChunkOverlap{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxChunkSize", this.MaxChunkSize);
            this.SetParamArraySimple(map, prefix + "Delimiters.", this.Delimiters);
            this.SetParamSimple(map, prefix + "ChunkOverlap", this.ChunkOverlap);
        }
    }
}

