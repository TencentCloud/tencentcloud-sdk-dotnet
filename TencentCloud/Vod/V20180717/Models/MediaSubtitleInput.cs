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

    public class MediaSubtitleInput : AbstractModel
    {
        
        /// <summary>
        /// 字幕名字，长度限制：64 个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 字幕语言。常见的取值如下：
        /// <li>zh：中文；</li>
        /// <li>en：英文；</li>
        /// <li>ja：日文；</li>
        /// <li>ko：韩文；</li>
        /// <li>vi：越南语；</li>
        /// <li>ms：马来语；</li>
        /// <li>th：泰语；</li>
        /// <li>pt：葡萄牙语；</li>
        /// <li>tr：土耳其语；</li>
        /// <li>ar：阿拉伯语；</li>
        /// <li>es：西班牙语；</li>
        /// <li>hi：印地语；</li>
        /// <li>fr：法语。</li>
        /// 其他取值参考 [RFC5646](https://tools.ietf.org/html/rfc5646)
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// 字幕格式。取值范围如下：
        /// <li>vtt</li>
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// 字幕内容，进行 [Base64](https://tools.ietf.org/html/rfc4648) 编码后的字符串。
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 字幕的唯一标识。长度不能超过16个字符，可以使用大小写字母、数字、下划线（_）或横杠（-）。不能与媒体文件中现有字幕的唯一标识重复。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "Id", this.Id);
        }
    }
}

