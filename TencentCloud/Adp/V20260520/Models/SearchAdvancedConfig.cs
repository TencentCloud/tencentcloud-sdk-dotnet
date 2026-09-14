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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchAdvancedConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>最终 rerank 配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FinalRerankConfig")]
        public FinalRerankConfig FinalRerankConfig{ get; set; }

        /// <summary>
        /// <p>各知识库的检索配置</p>
        /// </summary>
        [JsonProperty("KbRetrievalList")]
        public KBRetrievalConfig[] KbRetrievalList{ get; set; }

        /// <summary>
        /// <p>检索知识类型：1=文档和问答，2=拒答<table><tbody><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>SEARCH_KNOWLEDGE_TYPE_UNKNOWN</td><td>0</td><td></td></tr><tr><td>SEARCH_KNOWLEDGE_TYPE_DOC_QA</td><td>1</td><td>文档和问答</td></tr><tr><td>SEARCH_KNOWLEDGE_TYPE_REJECTED_QUESTION</td><td>2</td><td>拒答</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("KnowledgeType")]
        public long? KnowledgeType{ get; set; }

        /// <summary>
        /// <p>最终返回结果数</p>
        /// </summary>
        [JsonProperty("RecallCount")]
        public ulong? RecallCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "FinalRerankConfig.", this.FinalRerankConfig);
            this.SetParamArrayObj(map, prefix + "KbRetrievalList.", this.KbRetrievalList);
            this.SetParamSimple(map, prefix + "KnowledgeType", this.KnowledgeType);
            this.SetParamSimple(map, prefix + "RecallCount", this.RecallCount);
        }
    }
}

