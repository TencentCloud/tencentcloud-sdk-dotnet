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

    public class Questionnaire : AbstractModel
    {
        
        /// <summary>
        /// <p>问卷的标题</p>
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// <p>问卷的问题列表</p>
        /// </summary>
        [JsonProperty("Questions")]
        public QuestionnaireQuestion[] Questions{ get; set; }

        /// <summary>
        /// <p>问卷的答案列表</p>
        /// </summary>
        [JsonProperty("Answers")]
        public QuestionnaireQuestionAnswer[] Answers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamArrayObj(map, prefix + "Questions.", this.Questions);
            this.SetParamArrayObj(map, prefix + "Answers.", this.Answers);
        }
    }
}

