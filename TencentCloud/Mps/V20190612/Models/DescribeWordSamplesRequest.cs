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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeWordSamplesRequest : AbstractModel
    {
        
        /// <summary>
        /// <b>关键词应用场景过滤条件，可选值：</b>
        /// 1. Recognition.Ocr：通过光学字符识别技术，进行内容识别；
        /// 2. Recognition.Asr：通过语音识别技术，进行内容识别；
        /// 3. Review.Ocr：通过光学字符识别技术，进行内容审核；
        /// 4. Review.Asr：通过语音识别技术，进行内容审核；
        /// <b>可合并简写为：</b>
        /// 5. Recognition：通过光学字符识别技术、语音识别技术，进行内容识别，等价于 1+2；
        /// 6. Review：通过光学字符识别技术、语音识别技术，进行内容审核，等价于 3+4；
        /// 可多选，元素间关系为 or，即关键词的应用场景包含该字段集合中任意元素的记录，均符合该条件。
        /// </summary>
        [JsonProperty("Usages")]
        public string[] Usages{ get; set; }

        /// <summary>
        /// 关键词过滤条件，数组长度限制：100 个词。
        /// </summary>
        [JsonProperty("Keywords")]
        public string[] Keywords{ get; set; }

        /// <summary>
        /// 标签过滤条件，数组长度限制：20 个词。
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// 分页偏移量，默认值：0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回记录条数，默认值：100，最大值：100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Usages.", this.Usages);
            this.SetParamArraySimple(map, prefix + "Keywords.", this.Keywords);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

