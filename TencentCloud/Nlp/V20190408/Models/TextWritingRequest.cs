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

namespace TencentCloud.Nlp.V20190408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TextWritingRequest : AbstractModel
    {
        
        /// <summary>
        /// 待续写的句子，文本统一使用utf-8格式编码，长度不超过200字符。
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 待续写文本的语言类型，支持语言如下：
        /// zh：中文
        /// en：英文
        /// </summary>
        [JsonProperty("SourceLang")]
        public string SourceLang{ get; set; }

        /// <summary>
        /// 返回续写结果的个数。数量需>=1且<=5。
        /// （注意实际结果可能小于指定个数）
        /// </summary>
        [JsonProperty("Number")]
        public long? Number{ get; set; }

        /// <summary>
        /// 指定续写领域，支持领域如下：
        /// general：通用领域，支持中英文补全
        /// academic：学术领域，仅支持英文补全
        /// 默认为general（通用领域）。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 指定续写风格，支持风格如下：
        /// science_fiction：科幻
        /// military_history：军事
        /// xuanhuan_wuxia：武侠
        /// urban_officialdom：职场
        /// 默认为xuanhuan_wuxia（武侠）。
        /// </summary>
        [JsonProperty("Style")]
        public string Style{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "SourceLang", this.SourceLang);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Style", this.Style);
        }
    }
}

