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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubtitleTransResultItem : AbstractModel
    {
        
        /// <summary>
        /// <p>翻译标识：</p><ul><li>Success</li><li>Error</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>源语言（如&quot;en&quot;）</p>
        /// </summary>
        [JsonProperty("TransSrc")]
        public string TransSrc{ get; set; }

        /// <summary>
        /// <p>目标语言（如&quot;zh&quot;）</p>
        /// </summary>
        [JsonProperty("TransDst")]
        public string TransDst{ get; set; }

        /// <summary>
        /// <p>字幕文件地址</p>
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// <p>翻译字幕压制视频路径。</p>
        /// </summary>
        [JsonProperty("SubtitleEmbedPath")]
        public string SubtitleEmbedPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TransSrc", this.TransSrc);
            this.SetParamSimple(map, prefix + "TransDst", this.TransDst);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "SubtitleEmbedPath", this.SubtitleEmbedPath);
        }
    }
}

