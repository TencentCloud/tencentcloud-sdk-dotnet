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

namespace TencentCloud.Dataagent.V20250513.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KnowledgeTaskConfig : AbstractModel
    {
        
        /// <summary>
        /// 切片类型  0:自定义切片，1：智能切片
        /// </summary>
        [JsonProperty("ChunkType")]
        public long? ChunkType{ get; set; }

        /// <summary>
        /// /智能切片：最小值 1000，默认 4800 自定义切片：正整数即可,默认值 1000
        /// </summary>
        [JsonProperty("MaxChunkSize")]
        public long? MaxChunkSize{ get; set; }

        /// <summary>
        ///  切片分隔符,自定义切片使用：默认值为：["\n\n", "\n", "。", "！", "？", "，", ""]
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Delimiters")]
        public string[] Delimiters{ get; set; }

        /// <summary>
        /// 自定义切片使用:默认0 可重叠字符长度
        /// </summary>
        [JsonProperty("ChunkOverlap")]
        public long? ChunkOverlap{ get; set; }

        /// <summary>
        /// 表格类文档解析
        /// </summary>
        [JsonProperty("Columns")]
        public ColumnInfo[] Columns{ get; set; }

        /// <summary>
        /// 带检索的索引列表
        /// </summary>
        [JsonProperty("Indexes")]
        public long?[] Indexes{ get; set; }

        /// <summary>
        /// 0：不生成文档摘要，1：生成文档概要。默认0，当取1时，GenParaSummary必须也为1
        /// </summary>
        [JsonProperty("GenDocSummary")]
        public long? GenDocSummary{ get; set; }

        /// <summary>
        /// 0：不生成段落摘要，1：生成段落概要。默认0
        /// </summary>
        [JsonProperty("GenParaSummary")]
        public long? GenParaSummary{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChunkType", this.ChunkType);
            this.SetParamSimple(map, prefix + "MaxChunkSize", this.MaxChunkSize);
            this.SetParamArraySimple(map, prefix + "Delimiters.", this.Delimiters);
            this.SetParamSimple(map, prefix + "ChunkOverlap", this.ChunkOverlap);
            this.SetParamArrayObj(map, prefix + "Columns.", this.Columns);
            this.SetParamArraySimple(map, prefix + "Indexes.", this.Indexes);
            this.SetParamSimple(map, prefix + "GenDocSummary", this.GenDocSummary);
            this.SetParamSimple(map, prefix + "GenParaSummary", this.GenParaSummary);
        }
    }
}

