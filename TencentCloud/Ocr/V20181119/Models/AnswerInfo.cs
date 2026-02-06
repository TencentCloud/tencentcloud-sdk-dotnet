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

    public class AnswerInfo : AbstractModel
    {
        
        /// <summary>
        /// 手写答案内容，比如选择题的手写的选项、填空题的手写内容
        /// </summary>
        [JsonProperty("HandwriteInfo")]
        public string HandwriteInfo{ get; set; }

        /// <summary>
        /// 答案是否正确
        /// </summary>
        [JsonProperty("IsCorrect")]
        public bool? IsCorrect{ get; set; }

        /// <summary>
        /// 答案分析结果
        /// </summary>
        [JsonProperty("AnswerAnalysis")]
        public string AnswerAnalysis{ get; set; }

        /// <summary>
        /// 答案区域的4个角点坐标, 是个长度为8的数组
        /// 
        /// [0,1,2,3,4,5,6,7]
        /// 
        /// (0,1) 左上角坐标
        /// (2,3) 右上角坐标
        /// (4,5) 右下角坐标
        /// (6,7) 左下角坐标
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HandwriteInfoPositions")]
        public long?[] HandwriteInfoPositions{ get; set; }

        /// <summary>
        /// 返回正确答案内容
        /// 
        /// QuestionConfigMap配置了（“TrueAnswer”：1）才生效返回
        /// </summary>
        [JsonProperty("RightAnswer")]
        public string RightAnswer{ get; set; }

        /// <summary>
        /// 返回题目的知识点内容
        /// 
        /// QuestionConfigMap配置了（“KnowledgePoints”：1）才生效返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KnowledgePoints")]
        public string[] KnowledgePoints{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HandwriteInfo", this.HandwriteInfo);
            this.SetParamSimple(map, prefix + "IsCorrect", this.IsCorrect);
            this.SetParamSimple(map, prefix + "AnswerAnalysis", this.AnswerAnalysis);
            this.SetParamArraySimple(map, prefix + "HandwriteInfoPositions.", this.HandwriteInfoPositions);
            this.SetParamSimple(map, prefix + "RightAnswer", this.RightAnswer);
            this.SetParamArraySimple(map, prefix + "KnowledgePoints.", this.KnowledgePoints);
        }
    }
}

