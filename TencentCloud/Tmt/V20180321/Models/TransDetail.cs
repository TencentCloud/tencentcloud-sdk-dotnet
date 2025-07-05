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

namespace TencentCloud.Tmt.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TransDetail : AbstractModel
    {
        
        /// <summary>
        /// 当前行的原文本
        /// </summary>
        [JsonProperty("SourceLineText")]
        public string SourceLineText{ get; set; }

        /// <summary>
        /// 当前行的译文
        /// </summary>
        [JsonProperty("TargetLineText")]
        public string TargetLineText{ get; set; }

        /// <summary>
        /// 段落文本框位置
        /// </summary>
        [JsonProperty("BoundingBox")]
        public BoundingBox BoundingBox{ get; set; }

        /// <summary>
        /// 行数
        /// </summary>
        [JsonProperty("LinesCount")]
        public long? LinesCount{ get; set; }

        /// <summary>
        /// 行高
        /// </summary>
        [JsonProperty("LineHeight")]
        public long? LineHeight{ get; set; }

        /// <summary>
        /// 正常段落spam_code字段为0；如果存在spam_code字段且值大于0（1: 命中垃圾检查；2: 命中安全策略；3: 其他。），则命中安全检查被过滤。
        /// </summary>
        [JsonProperty("SpamCode")]
        public long? SpamCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceLineText", this.SourceLineText);
            this.SetParamSimple(map, prefix + "TargetLineText", this.TargetLineText);
            this.SetParamObj(map, prefix + "BoundingBox.", this.BoundingBox);
            this.SetParamSimple(map, prefix + "LinesCount", this.LinesCount);
            this.SetParamSimple(map, prefix + "LineHeight", this.LineHeight);
            this.SetParamSimple(map, prefix + "SpamCode", this.SpamCode);
        }
    }
}

