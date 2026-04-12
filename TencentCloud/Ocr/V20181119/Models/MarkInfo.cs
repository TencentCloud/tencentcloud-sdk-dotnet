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

    public class MarkInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>题目的题干信息</p>
        /// </summary>
        [JsonProperty("MarkItemTitle")]
        public string MarkItemTitle{ get; set; }

        /// <summary>
        /// <p>批改答案列表（每个小题存在多个答案，比如多个填空区域答案，循序按照从左到右，从上到下排列）</p>
        /// </summary>
        [JsonProperty("AnswerInfos")]
        public AnswerInfo[] AnswerInfos{ get; set; }

        /// <summary>
        /// <p>嵌套题目结构（如果有多层嵌套则会返回子题信息，如果没有嵌套题目则返回空）</p>
        /// </summary>
        [JsonProperty("MarkInfos")]
        public MarkInfo[] MarkInfos{ get; set; }

        /// <summary>
        /// <p>题干坐标</p><p>单位：px</p>
        /// </summary>
        [JsonProperty("QuestionPositions")]
        public long?[] QuestionPositions{ get; set; }

        /// <summary>
        /// <p>题干插图坐标列表，每个元素包含一张插图的4个角点坐标</p>
        /// </summary>
        [JsonProperty("QuestionImagePositions")]
        public Positions[] QuestionImagePositions{ get; set; }

        /// <summary>
        /// <p>题目级正确答案（步骤批改时使用，包含完整解题步骤）</p>
        /// </summary>
        [JsonProperty("RightAnswer")]
        public string RightAnswer{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MarkItemTitle", this.MarkItemTitle);
            this.SetParamArrayObj(map, prefix + "AnswerInfos.", this.AnswerInfos);
            this.SetParamArrayObj(map, prefix + "MarkInfos.", this.MarkInfos);
            this.SetParamArraySimple(map, prefix + "QuestionPositions.", this.QuestionPositions);
            this.SetParamArrayObj(map, prefix + "QuestionImagePositions.", this.QuestionImagePositions);
            this.SetParamSimple(map, prefix + "RightAnswer", this.RightAnswer);
        }
    }
}

