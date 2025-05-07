/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Es.V20250101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunRerankRequest : AbstractModel
    {
        
        /// <summary>
        /// 模型名称，可选模型列表：bge-reranker-large，bge-reranker-v2-m3。
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// 查询文本。
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 待排序的候选doc列表。
        /// </summary>
        [JsonProperty("Documents")]
        public string[] Documents{ get; set; }

        /// <summary>
        /// 排序返回的top文档数量, 如果没有指定则返回全部候选doc，如果指定的top_n值大于输入的候选doc数量，返回全部doc。
        /// </summary>
        [JsonProperty("TopN")]
        public long? TopN{ get; set; }

        /// <summary>
        /// 返回的排序结果列表里面是否返回每一条document原文，默认值False。
        /// </summary>
        [JsonProperty("ReturnDocuments")]
        public bool? ReturnDocuments{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamArraySimple(map, prefix + "Documents.", this.Documents);
            this.SetParamSimple(map, prefix + "TopN", this.TopN);
            this.SetParamSimple(map, prefix + "ReturnDocuments", this.ReturnDocuments);
        }
    }
}

