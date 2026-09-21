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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ComparisonDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>合同对比差异点唯一ID。</p>
        /// </summary>
        [JsonProperty("ComparisonPointId")]
        public string ComparisonPointId{ get; set; }

        /// <summary>
        /// <p>对比前后差异类型，具体如下：</p><ul><li> **add**：新增</li><li> **change**：变更</li><li> **delete**：删除</li></ul>
        /// </summary>
        [JsonProperty("ComparisonType")]
        public string ComparisonType{ get; set; }

        /// <summary>
        /// <p>对比内容类型，具体如下：</p><ul><li> **text**：文本</li><li> **table**：表格</li><li> **picture**：图片</li></ul>
        /// </summary>
        [JsonProperty("ContentType")]
        public string ContentType{ get; set; }

        /// <summary>
        /// <p>原文文本。</p>
        /// </summary>
        [JsonProperty("OriginText")]
        public string OriginText{ get; set; }

        /// <summary>
        /// <p>对比文本。</p>
        /// </summary>
        [JsonProperty("DiffText")]
        public string DiffText{ get; set; }

        /// <summary>
        /// <p>合同文本的格式类型。<br>类型如下：</p><ul><li> **0**：段落（正文）</li><li> **1**：标点符号</li><li> **2**：页眉页脚</li><li> **3**：目录</li><li> **4**：印章</li><li> **5**：序号</li><li> **6**：水印</li><li> **7**：下划线内容（填写区）</li></ul>
        /// </summary>
        [JsonProperty("FormatType")]
        public long? FormatType{ get; set; }

        /// <summary>
        /// <p>页码：对比点所在页码。</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComparisonPointId", this.ComparisonPointId);
            this.SetParamSimple(map, prefix + "ComparisonType", this.ComparisonType);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamSimple(map, prefix + "OriginText", this.OriginText);
            this.SetParamSimple(map, prefix + "DiffText", this.DiffText);
            this.SetParamSimple(map, prefix + "FormatType", this.FormatType);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
        }
    }
}

