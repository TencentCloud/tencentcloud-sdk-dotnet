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

    public class CreateSharedKnowledgeRequest : AbstractModel
    {
        
        /// <summary>
        /// 共享知识库名称，字符数量范围：[1, 50]
        /// </summary>
        [JsonProperty("KnowledgeName")]
        public string KnowledgeName{ get; set; }

        /// <summary>
        /// 共享知识库描述，字符数量上限2000
        /// </summary>
        [JsonProperty("KnowledgeDescription")]
        public string KnowledgeDescription{ get; set; }

        /// <summary>
        /// Embedding模型，字符数量上限128
        /// </summary>
        [JsonProperty("EmbeddingModel")]
        public string EmbeddingModel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KnowledgeName", this.KnowledgeName);
            this.SetParamSimple(map, prefix + "KnowledgeDescription", this.KnowledgeDescription);
            this.SetParamSimple(map, prefix + "EmbeddingModel", this.EmbeddingModel);
        }
    }
}

