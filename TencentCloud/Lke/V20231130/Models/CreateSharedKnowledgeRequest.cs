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
        /// <p>共享知识库名称，字符数量范围：[1, 50]</p>
        /// </summary>
        [JsonProperty("KnowledgeName")]
        public string KnowledgeName{ get; set; }

        /// <summary>
        /// <p>共享知识库描述，字符数量上限2000</p>
        /// </summary>
        [JsonProperty("KnowledgeDescription")]
        public string KnowledgeDescription{ get; set; }

        /// <summary>
        /// <p>Embedding模型，字符数量上限128</p>
        /// </summary>
        [JsonProperty("EmbeddingModel")]
        [System.Obsolete]
        public string EmbeddingModel{ get; set; }

        /// <summary>
        /// <p>共享知识库类型，0普通，1公众号</p>
        /// </summary>
        [JsonProperty("KnowledgeType")]
        public long? KnowledgeType{ get; set; }

        /// <summary>
        /// <p>ES存储配置</p>
        /// </summary>
        [JsonProperty("EsConfig")]
        public ESConfig EsConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KnowledgeName", this.KnowledgeName);
            this.SetParamSimple(map, prefix + "KnowledgeDescription", this.KnowledgeDescription);
            this.SetParamSimple(map, prefix + "EmbeddingModel", this.EmbeddingModel);
            this.SetParamSimple(map, prefix + "KnowledgeType", this.KnowledgeType);
            this.SetParamObj(map, prefix + "EsConfig.", this.EsConfig);
        }
    }
}

