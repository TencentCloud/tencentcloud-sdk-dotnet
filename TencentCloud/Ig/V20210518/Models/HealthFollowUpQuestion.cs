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

namespace TencentCloud.Ig.V20210518.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HealthFollowUpQuestion : AbstractModel
    {
        
        /// <summary>
        /// <p>追问类型</p>
        /// </summary>
        [JsonProperty("PromptType")]
        public string PromptType{ get; set; }

        /// <summary>
        /// <p>追问选项列表</p>
        /// </summary>
        [JsonProperty("Choices")]
        public string[] Choices{ get; set; }

        /// <summary>
        /// <p>追问题型，单选或多选</p>
        /// </summary>
        [JsonProperty("QuestionType")]
        public string QuestionType{ get; set; }

        /// <summary>
        /// <p>追问特殊类型，如部位题、时间题</p>
        /// </summary>
        [JsonProperty("SpecialType")]
        public string SpecialType{ get; set; }

        /// <summary>
        /// <p>追问问题内容</p>
        /// </summary>
        [JsonProperty("Question")]
        public string Question{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PromptType", this.PromptType);
            this.SetParamArraySimple(map, prefix + "Choices.", this.Choices);
            this.SetParamSimple(map, prefix + "QuestionType", this.QuestionType);
            this.SetParamSimple(map, prefix + "SpecialType", this.SpecialType);
            this.SetParamSimple(map, prefix + "Question", this.Question);
        }
    }
}

