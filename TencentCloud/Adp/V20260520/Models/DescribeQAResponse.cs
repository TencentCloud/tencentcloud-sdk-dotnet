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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeQAResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>分片高亮信息</p>
        /// </summary>
        [JsonProperty("HighlightList")]
        public QASegmentHighlight[] HighlightList{ get; set; }

        /// <summary>
        /// <p>分片内容</p>
        /// </summary>
        [JsonProperty("PageContent")]
        public string PageContent{ get; set; }

        /// <summary>
        /// <p>问题描述</p>
        /// </summary>
        [JsonProperty("QuestionDescription")]
        public string QuestionDescription{ get; set; }

        /// <summary>
        /// <p>相似问列表</p>
        /// </summary>
        [JsonProperty("SimilarQuestionList")]
        public SimilarQuestion[] SimilarQuestionList{ get; set; }

        /// <summary>
        /// <p>基础信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Summary")]
        public QASummary Summary{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "HighlightList.", this.HighlightList);
            this.SetParamSimple(map, prefix + "PageContent", this.PageContent);
            this.SetParamSimple(map, prefix + "QuestionDescription", this.QuestionDescription);
            this.SetParamArrayObj(map, prefix + "SimilarQuestionList.", this.SimilarQuestionList);
            this.SetParamObj(map, prefix + "Summary.", this.Summary);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

