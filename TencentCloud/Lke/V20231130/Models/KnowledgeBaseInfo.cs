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

    public class KnowledgeBaseInfo : AbstractModel
    {
        
        /// <summary>
        /// 共享知识库业务ID
        /// </summary>
        [JsonProperty("KnowledgeBizId")]
        public string KnowledgeBizId{ get; set; }

        /// <summary>
        /// 共享知识库名称
        /// </summary>
        [JsonProperty("KnowledgeName")]
        public string KnowledgeName{ get; set; }

        /// <summary>
        /// 共享知识库描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KnowledgeDescription")]
        public string KnowledgeDescription{ get; set; }

        /// <summary>
        /// Embedding模型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EmbeddingModel")]
        public string EmbeddingModel{ get; set; }

        /// <summary>
        /// 问答提取模型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QaExtractModel")]
        public string QaExtractModel{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 共享知识库类型，0普通，1公众号
        /// </summary>
        [JsonProperty("KnowledgeType")]
        public long? KnowledgeType{ get; set; }

        /// <summary>
        /// 拥有者id
        /// </summary>
        [JsonProperty("OwnerStaffId")]
        public string OwnerStaffId{ get; set; }

        /// <summary>
        /// 知识库文档数量,当前仅支持公众号知识库
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DocTotal")]
        public long? DocTotal{ get; set; }

        /// <summary>
        /// 知识库处理中状态标记，1：向量embedding变更中
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcessingFlags")]
        public long?[] ProcessingFlags{ get; set; }

        /// <summary>
        /// 知识库拥有者的名字
        /// </summary>
        [JsonProperty("OwnerStaffName")]
        public string OwnerStaffName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KnowledgeBizId", this.KnowledgeBizId);
            this.SetParamSimple(map, prefix + "KnowledgeName", this.KnowledgeName);
            this.SetParamSimple(map, prefix + "KnowledgeDescription", this.KnowledgeDescription);
            this.SetParamSimple(map, prefix + "EmbeddingModel", this.EmbeddingModel);
            this.SetParamSimple(map, prefix + "QaExtractModel", this.QaExtractModel);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "KnowledgeType", this.KnowledgeType);
            this.SetParamSimple(map, prefix + "OwnerStaffId", this.OwnerStaffId);
            this.SetParamSimple(map, prefix + "DocTotal", this.DocTotal);
            this.SetParamArraySimple(map, prefix + "ProcessingFlags.", this.ProcessingFlags);
            this.SetParamSimple(map, prefix + "OwnerStaffName", this.OwnerStaffName);
        }
    }
}

