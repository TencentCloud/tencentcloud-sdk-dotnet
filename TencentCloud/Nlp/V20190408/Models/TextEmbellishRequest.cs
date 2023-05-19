/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class TextEmbellishRequest : AbstractModel
    {
        
        /// <summary>
        /// 待润色的文本。中文文本长度需<=50字符；英文文本长度需<=30个单词。
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 待润色文本的语言类型，支持语言如下：
        /// zh：中文
        /// en：英文
        /// </summary>
        [JsonProperty("SourceLang")]
        public string SourceLang{ get; set; }

        /// <summary>
        /// 返回润色结果的个数。数量需>=1且<=5。
        /// （注意实际结果可能小于指定个数）
        /// </summary>
        [JsonProperty("Number")]
        public long? Number{ get; set; }

        /// <summary>
        /// 控制润色类型，类型如下：
        /// both：同时返回改写和扩写
        /// expansion：扩写
        /// rewriting：改写
        /// m2a：从现代文改写为古文
        /// a2m：从古文改写为现代文
        /// 默认为both。
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
            this.SetParamSimple(map, prefix + "Style", this.Style);
        }
    }
}

