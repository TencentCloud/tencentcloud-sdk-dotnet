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

namespace TencentCloud.Tci.V20190318.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TextItem : AbstractModel
    {
        
        /// <summary>
        /// 当前句子包含的所有单词信息
        /// </summary>
        [JsonProperty("Words")]
        public Word[] Words{ get; set; }

        /// <summary>
        /// 当前句子的置信度
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// 当前句子语音的起始时间点，单位为ms
        /// </summary>
        [JsonProperty("Mbtm")]
        public long? Mbtm{ get; set; }

        /// <summary>
        /// 当前句子语音的终止时间点，单位为ms
        /// </summary>
        [JsonProperty("Metm")]
        public long? Metm{ get; set; }

        /// <summary>
        /// 保留参数，暂无意义
        /// </summary>
        [JsonProperty("Tag")]
        public long? Tag{ get; set; }

        /// <summary>
        /// 当前句子
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 当前句子的字节数
        /// </summary>
        [JsonProperty("TextSize")]
        public long? TextSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Words.", this.Words);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "Mbtm", this.Mbtm);
            this.SetParamSimple(map, prefix + "Metm", this.Metm);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "TextSize", this.TextSize);
        }
    }
}

