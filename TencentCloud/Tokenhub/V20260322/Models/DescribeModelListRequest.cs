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

namespace TencentCloud.Tokenhub.V20260322.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeModelListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>模型 ID 列表。最多支持 10 个，不支持重复。</p>
        /// </summary>
        [JsonProperty("ModelIds")]
        public string[] ModelIds{ get; set; }

        /// <summary>
        /// <p>模型名称列表。最多支持 10 个，不支持重复。</p>
        /// </summary>
        [JsonProperty("ModelNames")]
        public string[] ModelNames{ get; set; }

        /// <summary>
        /// <p>模型类型列表，筛选指定类型的模型。最多支持 10 个，不支持重复。取值：Text（文本）、Vision（视觉）、Multimodal（多模态）、Speech（语音）、Embedding（向量）。</p>
        /// </summary>
        [JsonProperty("ModelTypes")]
        public string[] ModelTypes{ get; set; }

        /// <summary>
        /// <p>模型标签</p>
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// <p>返回数量，默认为 20，最大值为 100。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>偏移量，默认为 0。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ModelIds.", this.ModelIds);
            this.SetParamArraySimple(map, prefix + "ModelNames.", this.ModelNames);
            this.SetParamArraySimple(map, prefix + "ModelTypes.", this.ModelTypes);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

