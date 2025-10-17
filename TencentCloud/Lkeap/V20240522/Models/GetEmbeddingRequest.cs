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

    public class GetEmbeddingRequest : AbstractModel
    {
        
        /// <summary>
        /// 说明：选择生成向量的模型备注：可选[lke-text-embedding-v1,lke-text-embedding-v2,youtu-embedding-llm-v1]
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// 说明：需要 embedding 的文本
        /// 备注：单条query最多2000个字符，总条数最多7条
        /// </summary>
        [JsonProperty("Inputs")]
        public string[] Inputs{ get; set; }

        /// <summary>
        /// 说明：文本向量化的类型，为使得检索任务有更好的检索效果，建议区分查询文本（query）和文档文本（document）类型, 聚类、分类等对称任务可以不用特殊指定，采用系统默认值document即可。
        /// </summary>
        [JsonProperty("TextType")]
        public string TextType{ get; set; }

        /// <summary>
        /// 说明：自定义任务指令词，当且仅当TextType=query且Model为youtu-embedding-llm-v1时，生效
        /// </summary>
        [JsonProperty("Instruction")]
        public string Instruction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamArraySimple(map, prefix + "Inputs.", this.Inputs);
            this.SetParamSimple(map, prefix + "TextType", this.TextType);
            this.SetParamSimple(map, prefix + "Instruction", this.Instruction);
        }
    }
}

