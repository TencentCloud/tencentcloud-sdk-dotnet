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

namespace TencentCloud.Lkeap.V20240522.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RetrievalRecordMetadata : AbstractModel
    {
        
        /// <summary>
        /// 结果的类型。
        /// - `DOC`：文档
        /// - `QA`：问答对
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 检索结果的来源。
        /// - `SEMANTIC`：从语义检索中得到的结果
        /// - `FULL_TEXT`：从全文检索中得到的结果
        /// </summary>
        [JsonProperty("ResultSource")]
        public string ResultSource{ get; set; }

        /// <summary>
        /// 切片在文档中的页码，仅部分文档支持
        /// </summary>
        [JsonProperty("ChunkPageNumbers")]
        public long?[] ChunkPageNumbers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ResultSource", this.ResultSource);
            this.SetParamArraySimple(map, prefix + "ChunkPageNumbers.", this.ChunkPageNumbers);
        }
    }
}

