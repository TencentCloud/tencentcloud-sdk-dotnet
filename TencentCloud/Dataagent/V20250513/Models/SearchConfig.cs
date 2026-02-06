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

    public class SearchConfig : AbstractModel
    {
        
        /// <summary>
        /// 检索类型：0:混合搜索 1：向量搜索 2：全文搜索
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 召回数量最大值
        /// </summary>
        [JsonProperty("Num")]
        public long? Num{ get; set; }

        /// <summary>
        /// 权重配置
        /// </summary>
        [JsonProperty("EmbeddingWeight")]
        public float? EmbeddingWeight{ get; set; }

        /// <summary>
        /// 0:关闭 1:开启，默认1
        /// </summary>
        [JsonProperty("Rerank")]
        public long? Rerank{ get; set; }

        /// <summary>
        /// 0:关闭 1:开启，默认0
        /// </summary>
        [JsonProperty("AutoRag")]
        public long? AutoRag{ get; set; }

        /// <summary>
        /// AutoRag关联的知识库ID列表
        /// </summary>
        [JsonProperty("KnowledgeBaseIds")]
        public string[] KnowledgeBaseIds{ get; set; }

        /// <summary>
        /// AutoRag搜索状态：0-未完成，1-已完成。仅当AutoRag=1时，该字段有效
        /// </summary>
        [JsonProperty("SearchStatus")]
        public long? SearchStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Num", this.Num);
            this.SetParamSimple(map, prefix + "EmbeddingWeight", this.EmbeddingWeight);
            this.SetParamSimple(map, prefix + "Rerank", this.Rerank);
            this.SetParamSimple(map, prefix + "AutoRag", this.AutoRag);
            this.SetParamArraySimple(map, prefix + "KnowledgeBaseIds.", this.KnowledgeBaseIds);
            this.SetParamSimple(map, prefix + "SearchStatus", this.SearchStatus);
        }
    }
}

