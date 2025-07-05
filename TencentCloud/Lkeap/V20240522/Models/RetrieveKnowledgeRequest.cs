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

    public class RetrieveKnowledgeRequest : AbstractModel
    {
        
        /// <summary>
        /// 知识库ID。
        /// </summary>
        [JsonProperty("KnowledgeBaseId")]
        public string KnowledgeBaseId{ get; set; }

        /// <summary>
        /// 用于检索的文本。
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 检索方法，默认使用`HYBRID`混合检索。
        /// - `SEMANTIC`：语义检索
        /// - `FULL_TEXT`：全文检索
        /// - `HYBRID`：混合检索
        /// </summary>
        [JsonProperty("RetrievalMethod")]
        public string RetrievalMethod{ get; set; }

        /// <summary>
        /// 检索设置。
        /// </summary>
        [JsonProperty("RetrievalSetting")]
        public RetrievalSetting RetrievalSetting{ get; set; }

        /// <summary>
        /// 标签过滤。
        /// </summary>
        [JsonProperty("AttributeLabels")]
        public LabelItem[] AttributeLabels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KnowledgeBaseId", this.KnowledgeBaseId);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "RetrievalMethod", this.RetrievalMethod);
            this.SetParamObj(map, prefix + "RetrievalSetting.", this.RetrievalSetting);
            this.SetParamArrayObj(map, prefix + "AttributeLabels.", this.AttributeLabels);
        }
    }
}

