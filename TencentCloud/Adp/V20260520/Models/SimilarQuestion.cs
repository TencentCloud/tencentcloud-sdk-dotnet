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

    public class SimilarQuestion : AbstractModel
    {
        
        /// <summary>
        /// <p>相似问内容</p>
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// <p>是否 AI 生成</p>
        /// </summary>
        [JsonProperty("IsAiGenerated")]
        public bool? IsAiGenerated{ get; set; }

        /// <summary>
        /// <p>相似问 ID</p>
        /// </summary>
        [JsonProperty("SimilarQuestionId")]
        public string SimilarQuestionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "IsAiGenerated", this.IsAiGenerated);
            this.SetParamSimple(map, prefix + "SimilarQuestionId", this.SimilarQuestionId);
        }
    }
}

