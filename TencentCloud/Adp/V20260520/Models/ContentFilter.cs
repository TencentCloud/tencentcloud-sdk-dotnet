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

    public class ContentFilter : AbstractModel
    {
        
        /// <summary>
        /// <p>图片最小高度（像素），小于则过滤；&lt;=0 表示不启用</p>
        /// </summary>
        [JsonProperty("ImageMinHeight")]
        public long? ImageMinHeight{ get; set; }

        /// <summary>
        /// <p>图片最小宽度（像素），小于则过滤；&lt;=0 表示不启用</p>
        /// </summary>
        [JsonProperty("ImageMinWidth")]
        public long? ImageMinWidth{ get; set; }

        /// <summary>
        /// <p>图片名称过滤规则（用分号 &#39;;&#39; 分隔的多条正则，如 &#39;icon;notice;warning;info.*&#39;）</p>
        /// </summary>
        [JsonProperty("ImageNamePatterns")]
        public string ImageNamePatterns{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageMinHeight", this.ImageMinHeight);
            this.SetParamSimple(map, prefix + "ImageMinWidth", this.ImageMinWidth);
            this.SetParamSimple(map, prefix + "ImageNamePatterns", this.ImageNamePatterns);
        }
    }
}

