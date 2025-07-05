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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubtitleFormatsOperation : AbstractModel
    {
        
        /// <summary>
        /// 操作类型，取值范围：
        /// <li>add：添加 Formats 指定的格式列表；</li>
        /// <li>delete：删除 Formats 指定的格式列表；<l/i>
        /// <li>reset：将已配置的格式列表重置为  Formats 指定的格式列表。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 字幕格式列表，取值范围：
        /// <li>vtt：生成 WebVTT 字幕文件；</li>
        /// <li>srt：生成 SRT 字幕文件。</li>
        /// </summary>
        [JsonProperty("Formats")]
        public string[] Formats{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "Formats.", this.Formats);
        }
    }
}

