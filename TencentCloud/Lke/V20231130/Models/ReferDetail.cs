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

    public class ReferDetail : AbstractModel
    {
        
        /// <summary>
        /// 引用ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReferBizId")]
        public string ReferBizId{ get; set; }

        /// <summary>
        /// 文档类型 (1 QA, 2 文档段)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DocType")]
        public ulong? DocType{ get; set; }

        /// <summary>
        /// 文档名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DocName")]
        public string DocName{ get; set; }

        /// <summary>
        /// 分片内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PageContent")]
        public string PageContent{ get; set; }

        /// <summary>
        /// 问题
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Question")]
        public string Question{ get; set; }

        /// <summary>
        /// 答案
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Answer")]
        public string Answer{ get; set; }

        /// <summary>
        /// 置信度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// 标记
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Mark")]
        public ulong? Mark{ get; set; }

        /// <summary>
        /// 分片高亮内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Highlights")]
        public Highlight[] Highlights{ get; set; }

        /// <summary>
        /// 原始内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrgData")]
        public string OrgData{ get; set; }

        /// <summary>
        /// 页码信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PageInfos")]
        public ulong?[] PageInfos{ get; set; }

        /// <summary>
        /// sheet信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SheetInfos")]
        public string[] SheetInfos{ get; set; }

        /// <summary>
        /// 文档ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DocBizId")]
        public string DocBizId{ get; set; }

        /// <summary>
        /// 知识库ID
        /// </summary>
        [JsonProperty("KnowledgeBizId")]
        public string KnowledgeBizId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReferBizId", this.ReferBizId);
            this.SetParamSimple(map, prefix + "DocType", this.DocType);
            this.SetParamSimple(map, prefix + "DocName", this.DocName);
            this.SetParamSimple(map, prefix + "PageContent", this.PageContent);
            this.SetParamSimple(map, prefix + "Question", this.Question);
            this.SetParamSimple(map, prefix + "Answer", this.Answer);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "Mark", this.Mark);
            this.SetParamArrayObj(map, prefix + "Highlights.", this.Highlights);
            this.SetParamSimple(map, prefix + "OrgData", this.OrgData);
            this.SetParamArraySimple(map, prefix + "PageInfos.", this.PageInfos);
            this.SetParamArraySimple(map, prefix + "SheetInfos.", this.SheetInfos);
            this.SetParamSimple(map, prefix + "DocBizId", this.DocBizId);
            this.SetParamSimple(map, prefix + "KnowledgeBizId", this.KnowledgeBizId);
        }
    }
}

