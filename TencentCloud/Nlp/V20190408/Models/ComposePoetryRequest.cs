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

    public class ComposePoetryRequest : AbstractModel
    {
        
        /// <summary>
        /// 生成诗词的关键词。
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 生成诗词的类型。0：藏头或藏身；1：藏头；2：藏身。默认为0。
        /// </summary>
        [JsonProperty("PoetryType")]
        public long? PoetryType{ get; set; }

        /// <summary>
        /// 诗的体裁。0：五言律诗或七言律诗；5：五言律诗；7：七言律诗。默认为0。
        /// </summary>
        [JsonProperty("Genre")]
        public long? Genre{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "PoetryType", this.PoetryType);
            this.SetParamSimple(map, prefix + "Genre", this.Genre);
        }
    }
}

