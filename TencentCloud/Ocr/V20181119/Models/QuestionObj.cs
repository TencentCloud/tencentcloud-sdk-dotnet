/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class QuestionObj : AbstractModel
    {
        
        /// <summary>
        /// 题号
        /// </summary>
        [JsonProperty("QuestionTextNo")]
        public string QuestionTextNo{ get; set; }

        /// <summary>
        /// 题型：
        /// 1: "选择题"
        /// 2: "填空题"
        /// 3: "解答题"
        /// </summary>
        [JsonProperty("QuestionTextType")]
        public long? QuestionTextType{ get; set; }

        /// <summary>
        /// 题干
        /// </summary>
        [JsonProperty("QuestionText")]
        public string QuestionText{ get; set; }

        /// <summary>
        /// 选择题选项，包含1个或多个option
        /// </summary>
        [JsonProperty("QuestionOptions")]
        public string QuestionOptions{ get; set; }

        /// <summary>
        /// 所有子题的question属性
        /// </summary>
        [JsonProperty("QuestionSubquestion")]
        public string QuestionSubquestion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QuestionTextNo", this.QuestionTextNo);
            this.SetParamSimple(map, prefix + "QuestionTextType", this.QuestionTextType);
            this.SetParamSimple(map, prefix + "QuestionText", this.QuestionText);
            this.SetParamSimple(map, prefix + "QuestionOptions", this.QuestionOptions);
            this.SetParamSimple(map, prefix + "QuestionSubquestion", this.QuestionSubquestion);
        }
    }
}

