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

    public class QASummary : AbstractModel
    {
        
        /// <summary>
        /// <p>所属分类路径（包含分类 ID、从根节点开始的分类 ID 路径和分类名称路径）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CategoryPath")]
        public CategoryPath CategoryPath{ get; set; }

        /// <summary>
        /// <p>知识生效范围</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KnowledgeScope")]
        public KnowledgeScope KnowledgeScope{ get; set; }

        /// <summary>
        /// <p>生命周期信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Lifecycle")]
        public QALifecycle Lifecycle{ get; set; }

        /// <summary>
        /// <p>元信息（问题/答案/大小统计）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Metadata")]
        public QAMetadata Metadata{ get; set; }

        /// <summary>
        /// <p>操作者信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperatorInfo")]
        public QAOperator OperatorInfo{ get; set; }

        /// <summary>
        /// <p>QA ID</p>
        /// </summary>
        [JsonProperty("QaId")]
        public string QaId{ get; set; }

        /// <summary>
        /// <p>相似问统计</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SimilarQuestion")]
        public SimilarQuestionStat SimilarQuestion{ get; set; }

        /// <summary>
        /// <p>来源信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceInfo")]
        public QASourceInfo SourceInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "CategoryPath.", this.CategoryPath);
            this.SetParamObj(map, prefix + "KnowledgeScope.", this.KnowledgeScope);
            this.SetParamObj(map, prefix + "Lifecycle.", this.Lifecycle);
            this.SetParamObj(map, prefix + "Metadata.", this.Metadata);
            this.SetParamObj(map, prefix + "OperatorInfo.", this.OperatorInfo);
            this.SetParamSimple(map, prefix + "QaId", this.QaId);
            this.SetParamObj(map, prefix + "SimilarQuestion.", this.SimilarQuestion);
            this.SetParamObj(map, prefix + "SourceInfo.", this.SourceInfo);
        }
    }
}

