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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExportAIGWCustomGuardrailHitsResult : AbstractModel
    {
        
        /// <summary>
        /// <p>实际导出格式</p>
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// <p>实际编码进导出内容的审核记录数，最多 1000。</p>
        /// </summary>
        [JsonProperty("RowCount")]
        public long? RowCount{ get; set; }

        /// <summary>
        /// <p>是否达到单次最多 1000 条的导出截断条件；true 时可能还有更多记录，可缩小时间范围后分别导出。</p>
        /// </summary>
        [JsonProperty("Truncated")]
        public bool? Truncated{ get; set; }

        /// <summary>
        /// <p>CSV/JSON 文件内容的 Base64 编码字符串，需 Base64 解码后保存，不是下载 URL。</p>
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "RowCount", this.RowCount);
            this.SetParamSimple(map, prefix + "Truncated", this.Truncated);
            this.SetParamSimple(map, prefix + "Content", this.Content);
        }
    }
}

