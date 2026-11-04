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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GenerateTextEmbeddingRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>选择生成向量的模型（不同模型计费单价不同）。取值：</p><ul><li>0：text-embedding-0.6b</li><li>1：text-embedding-4b</li></ul>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>输入文本列表。单次最多 7 条，单条不超过 2000 字符。</p>
        /// </summary>
        [JsonProperty("Inputs")]
        public string[] Inputs{ get; set; }

        /// <summary>
        /// <p>文本向量化类型。取值：</p><ul><li>query：查询文本，用于检索场景的查询侧</li><li>document：文档文本，用于检索场景的文档侧</li></ul><p>默认为 document</p>
        /// </summary>
        [JsonProperty("TextType")]
        public string TextType{ get; set; }

        /// <summary>
        /// <p>自定义任务指令词，用于指定向量化任务。最大 2000 字符。不传时按 TextType 使用系统默认指令词。</p>
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

