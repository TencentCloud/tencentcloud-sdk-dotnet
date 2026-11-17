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

    public class AnswerElement : AbstractModel
    {
        
        /// <summary>
        /// <p>答案是否正确</p>
        /// </summary>
        [JsonProperty("IsCorrect")]
        public bool? IsCorrect{ get; set; }

        /// <summary>
        /// <p>【批改 API 专属特性】<br>当ModelType= yuanbao_correction_model，该字段返回空。通过ResultList. AnswerAnalysis返回题目维度答案解析<br>当ModelType= youtu_correction_model，返回答案维度答案解析</p>
        /// </summary>
        [JsonProperty("AnswerAnalysis")]
        public string AnswerAnalysis{ get; set; }

        /// <summary>
        /// <p>返回正确答案内容。为提升速度算式批改场景默认不输出正确答案</p>
        /// </summary>
        [JsonProperty("RightAnswer")]
        public string RightAnswer{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsCorrect", this.IsCorrect);
            this.SetParamSimple(map, prefix + "AnswerAnalysis", this.AnswerAnalysis);
            this.SetParamSimple(map, prefix + "RightAnswer", this.RightAnswer);
        }
    }
}

