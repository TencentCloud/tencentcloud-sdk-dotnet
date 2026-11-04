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

    public class GenerateVLEmbeddingRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>选择生成向量的模型。取值：</p><ul><li>0：vl-embedding-4b</li><li>1：vl-embedding-8b</li><li>2：vl-embedding-2b</li></ul>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>内容类型标识。取值：</p><ul><li>1：文本</li><li>2：图像 URL</li><li>3：视频 URL</li><li>4：图文混合</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>文本内容。仅当 Type 为 1 或 4 时必填，单条文本不超过 2000 字符。</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>图像地址，支持公网 http/https 链接或 base64 内容。仅当 Type 为 2 或 4 时必填。</p>
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// <p>视频地址，支持公网 http/https 链接或 base64 内容。仅当 Type 为 3 时必填。</p>
        /// </summary>
        [JsonProperty("VideoUrl")]
        public string VideoUrl{ get; set; }

        /// <summary>
        /// <p>检索场景，未传入该参数时将自动匹配。取值：</p><ul><li>0：自动匹配</li><li>1：图搜图（找同款、相似图），仅 Type 为 2 或 4 时可用</li><li>2：图文搜图（图 + 问题），仅 Type 为 4 时可用</li><li>3：文搜图（纯文本搜图），仅 Type 为 1 或 4 时可用</li><li>4：文搜视频（纯文本搜视频），仅 Type 为 1 或 4 时可用</li><li>5：图搜视频、图文搜视频，仅 Type 为 2 或 4 时可用</li></ul>
        /// </summary>
        [JsonProperty("SearchMode")]
        public string SearchMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "VideoUrl", this.VideoUrl);
            this.SetParamSimple(map, prefix + "SearchMode", this.SearchMode);
        }
    }
}

