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

    public class QAMetadata : AbstractModel
    {
        
        /// <summary>
        /// <p>答案</p>
        /// </summary>
        [JsonProperty("Answer")]
        public string Answer{ get; set; }

        /// <summary>
        /// <p>问答字符数</p>
        /// </summary>
        [JsonProperty("QaCharCount")]
        public string QaCharCount{ get; set; }

        /// <summary>
        /// <p>问答大小（字节，含相似问）</p>
        /// </summary>
        [JsonProperty("QaSize")]
        public string QaSize{ get; set; }

        /// <summary>
        /// <p>问题</p>
        /// </summary>
        [JsonProperty("Question")]
        public string Question{ get; set; }

        /// <summary>
        /// <p>元数据引用字段名列表（用于显示问答哪些分类和属性被设置为元数据）</p>
        /// </summary>
        [JsonProperty("RefFieldNameList")]
        public string[] RefFieldNameList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Answer", this.Answer);
            this.SetParamSimple(map, prefix + "QaCharCount", this.QaCharCount);
            this.SetParamSimple(map, prefix + "QaSize", this.QaSize);
            this.SetParamSimple(map, prefix + "Question", this.Question);
            this.SetParamArraySimple(map, prefix + "RefFieldNameList.", this.RefFieldNameList);
        }
    }
}

