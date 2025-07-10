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

    public class AgentKnowledge : AbstractModel
    {
        
        /// <summary>
        /// 知识库id
        /// </summary>
        [JsonProperty("KnowledgeBizId")]
        public string KnowledgeBizId{ get; set; }

        /// <summary>
        /// 0-应用内知识库
        /// 1-共享知识库
        /// </summary>
        [JsonProperty("KnowledgeType")]
        public long? KnowledgeType{ get; set; }

        /// <summary>
        /// 0-全部知识
        /// 1-按文档和问答
        /// 2-按标签
        /// </summary>
        [JsonProperty("Filter")]
        public long? Filter{ get; set; }

        /// <summary>
        /// 文档id
        /// </summary>
        [JsonProperty("DocBizIds")]
        public string[] DocBizIds{ get; set; }

        /// <summary>
        /// true:包含所有问答
        /// false:不包含问答
        /// </summary>
        [JsonProperty("AllQa")]
        public bool? AllQa{ get; set; }

        /// <summary>
        /// 文档标签过滤器
        /// </summary>
        [JsonProperty("Tag")]
        public AgentKnowledgeFilterTag Tag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KnowledgeBizId", this.KnowledgeBizId);
            this.SetParamSimple(map, prefix + "KnowledgeType", this.KnowledgeType);
            this.SetParamSimple(map, prefix + "Filter", this.Filter);
            this.SetParamArraySimple(map, prefix + "DocBizIds.", this.DocBizIds);
            this.SetParamSimple(map, prefix + "AllQa", this.AllQa);
            this.SetParamObj(map, prefix + "Tag.", this.Tag);
        }
    }
}

