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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ShareKnowledgeBase : AbstractModel
    {
        
        /// <summary>
        /// 共享知识库ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KnowledgeBizId")]
        public string KnowledgeBizId{ get; set; }

        /// <summary>
        /// 检索范围
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SearchRange")]
        public SearchRange SearchRange{ get; set; }

        /// <summary>
        /// 知识库模型设置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KnowledgeModelConfig")]
        public KnowledgeModelConfig KnowledgeModelConfig{ get; set; }

        /// <summary>
        /// 检索策略配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SearchStrategy")]
        public SearchStrategy SearchStrategy{ get; set; }

        /// <summary>
        /// 检索配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Search")]
        public KnowledgeQaSearch[] Search{ get; set; }

        /// <summary>
        /// // 问答-回复灵活度 1：已采纳答案直接回复 2：已采纳润色后回复
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReplyFlexibility")]
        public long? ReplyFlexibility{ get; set; }

        /// <summary>
        /// 共享知识库名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KnowledgeName")]
        public string KnowledgeName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KnowledgeBizId", this.KnowledgeBizId);
            this.SetParamObj(map, prefix + "SearchRange.", this.SearchRange);
            this.SetParamObj(map, prefix + "KnowledgeModelConfig.", this.KnowledgeModelConfig);
            this.SetParamObj(map, prefix + "SearchStrategy.", this.SearchStrategy);
            this.SetParamArrayObj(map, prefix + "Search.", this.Search);
            this.SetParamSimple(map, prefix + "ReplyFlexibility", this.ReplyFlexibility);
            this.SetParamSimple(map, prefix + "KnowledgeName", this.KnowledgeName);
        }
    }
}

