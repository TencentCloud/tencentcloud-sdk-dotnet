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

namespace TencentCloud.Lkeap.V20240522.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyQARequest : AbstractModel
    {
        
        /// <summary>
        /// 知识库ID
        /// </summary>
        [JsonProperty("KnowledgeBaseId")]
        public string KnowledgeBaseId{ get; set; }

        /// <summary>
        /// 问答对ID
        /// </summary>
        [JsonProperty("QaId")]
        public string QaId{ get; set; }

        /// <summary>
        /// 问题，最大1000个英文字符
        /// </summary>
        [JsonProperty("Question")]
        public string Question{ get; set; }

        /// <summary>
        /// 答案，最大4000个英文字符
        /// </summary>
        [JsonProperty("Answer")]
        public string Answer{ get; set; }

        /// <summary>
        /// 属性标签
        /// </summary>
        [JsonProperty("AttributeLabels")]
        public AttributeLabelReferItem[] AttributeLabels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KnowledgeBaseId", this.KnowledgeBaseId);
            this.SetParamSimple(map, prefix + "QaId", this.QaId);
            this.SetParamSimple(map, prefix + "Question", this.Question);
            this.SetParamSimple(map, prefix + "Answer", this.Answer);
            this.SetParamArrayObj(map, prefix + "AttributeLabels.", this.AttributeLabels);
        }
    }
}

