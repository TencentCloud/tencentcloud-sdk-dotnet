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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResultList : AbstractModel
    {
        
        /// <summary>
        /// <p>题干</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Question")]
        public Element[] Question{ get; set; }

        /// <summary>
        /// <p>选项</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Option")]
        public Element[] Option{ get; set; }

        /// <summary>
        /// <p>插图</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Figure")]
        public Element[] Figure{ get; set; }

        /// <summary>
        /// <p>表格</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Table")]
        public Element[] Table{ get; set; }

        /// <summary>
        /// <p>答案</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Answer")]
        public Element[] Answer{ get; set; }

        /// <summary>
        /// <p>解析</p>
        /// </summary>
        [JsonProperty("Parse")]
        public Element[] Parse{ get; set; }

        /// <summary>
        /// <p>整题的坐标，多页单题跨页/单页单题跨栏场景下，存在一道题有多个坐标</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Coord")]
        public Polygon[] Coord{ get; set; }

        /// <summary>
        /// <p>单题跨栏/跨页场景下：配合CoordPageIndex一起使用，支持多坐标显示在不同页，按顺序对齐</p><p>默认值：[]</p>
        /// </summary>
        [JsonProperty("CoordPageIndex")]
        public long?[] CoordPageIndex{ get; set; }

        /// <summary>
        /// <p>【批改 API 专属特性】返回步骤批改场景下的正确答案内容</p>
        /// </summary>
        [JsonProperty("RightAnswer")]
        public string RightAnswer{ get; set; }

        /// <summary>
        /// <p>学科（如语文、数学、英语）</p>
        /// </summary>
        [JsonProperty("Subject")]
        public string Subject{ get; set; }

        /// <summary>
        /// <p>返回题目的知识点内容</p>
        /// </summary>
        [JsonProperty("KnowledgePoints")]
        public string[] KnowledgePoints{ get; set; }

        /// <summary>
        /// <p>【批改 API 专属特性】</p><ol><li>当ModelType= yuanbao_correction_model 且快速模式下，通过该字段返回题目维度的答案解析</li><li>其他批改配置参数情况，该字段返回空，通过AnswerElement. AnswerAnalysis返回答案维度答案解析</li></ol>
        /// </summary>
        [JsonProperty("AnswerAnalysis")]
        public string AnswerAnalysis{ get; set; }

        /// <summary>
        /// <p>年级：小学/初中/高中</p>
        /// </summary>
        [JsonProperty("Grade")]
        public string Grade{ get; set; }

        /// <summary>
        /// <p>【批改 API专属特性】返回题目维度的批改置信度（0-100）值越高表示答案准确度越高<br>备注：仅有ModelType=youtu_correction_model模型且非快速模式支持返回。</p>
        /// </summary>
        [JsonProperty("Confidence")]
        public long? Confidence{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Question.", this.Question);
            this.SetParamArrayObj(map, prefix + "Option.", this.Option);
            this.SetParamArrayObj(map, prefix + "Figure.", this.Figure);
            this.SetParamArrayObj(map, prefix + "Table.", this.Table);
            this.SetParamArrayObj(map, prefix + "Answer.", this.Answer);
            this.SetParamArrayObj(map, prefix + "Parse.", this.Parse);
            this.SetParamArrayObj(map, prefix + "Coord.", this.Coord);
            this.SetParamArraySimple(map, prefix + "CoordPageIndex.", this.CoordPageIndex);
            this.SetParamSimple(map, prefix + "RightAnswer", this.RightAnswer);
            this.SetParamSimple(map, prefix + "Subject", this.Subject);
            this.SetParamArraySimple(map, prefix + "KnowledgePoints.", this.KnowledgePoints);
            this.SetParamSimple(map, prefix + "AnswerAnalysis", this.AnswerAnalysis);
            this.SetParamSimple(map, prefix + "Grade", this.Grade);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
        }
    }
}

