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
        /// <p>说明：选择生成向量的模型</p><p>枚举值：</p><ul><li>lke-text-embedding-v1： 文本embedding v1</li><li>lke-text-embedding-v2： 文本embedding v2</li></ul>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>说明：需要 embedding 的文本<br>备注：单条query最多2000个字符，总条数最多7条</p>
        /// </summary>
        [JsonProperty("Inputs")]
        public string[] Inputs{ get; set; }

        /// <summary>
        /// <p>说明：文本向量化的类型，为使得检索任务有更好的检索效果，建议区分查询文本（query）和文档文本（document）类型, 聚类、分类等对称任务可以不用特殊指定，采用系统默认值document即可。</p>
        /// </summary>
        [JsonProperty("TextType")]
        public string TextType{ get; set; }

        /// <summary>
        /// <p>说明：自定义任务指令词，当且仅当TextType=query且Model为lke-text-embedding-v1时，生效</p>
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

