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

namespace TencentCloud.Soe.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WordRsp : AbstractModel
    {
        
        /// <summary>
        /// 当前单词语音起始时间点，单位为ms，该字段段落模式下无意义。
        /// </summary>
        [JsonProperty("MemBeginTime")]
        public long? MemBeginTime{ get; set; }

        /// <summary>
        /// 当前单词语音终止时间点，单位为ms，该字段段落模式下无意义。
        /// </summary>
        [JsonProperty("MemEndTime")]
        public long? MemEndTime{ get; set; }

        /// <summary>
        /// 单词发音准确度，取值范围[-1, 100]，当取-1时指完全不匹配
        /// </summary>
        [JsonProperty("PronAccuracy")]
        public float? PronAccuracy{ get; set; }

        /// <summary>
        /// 单词发音流利度，取值范围[0, 1]
        /// </summary>
        [JsonProperty("PronFluency")]
        public float? PronFluency{ get; set; }

        /// <summary>
        /// 当前词
        /// </summary>
        [JsonProperty("Word")]
        public string Word{ get; set; }

        /// <summary>
        /// 当前词与输入语句的匹配情况，0：匹配单词、1：新增单词、2：缺少单词、3：错读的词、4：未录入单词。
        /// </summary>
        [JsonProperty("MatchTag")]
        public long? MatchTag{ get; set; }

        /// <summary>
        /// 音节评估详情
        /// </summary>
        [JsonProperty("PhoneInfos")]
        public PhoneInfo[] PhoneInfos{ get; set; }

        /// <summary>
        /// 参考词，目前为保留字段。
        /// </summary>
        [JsonProperty("ReferenceWord")]
        public string ReferenceWord{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MemBeginTime", this.MemBeginTime);
            this.SetParamSimple(map, prefix + "MemEndTime", this.MemEndTime);
            this.SetParamSimple(map, prefix + "PronAccuracy", this.PronAccuracy);
            this.SetParamSimple(map, prefix + "PronFluency", this.PronFluency);
            this.SetParamSimple(map, prefix + "Word", this.Word);
            this.SetParamSimple(map, prefix + "MatchTag", this.MatchTag);
            this.SetParamArrayObj(map, prefix + "PhoneInfos.", this.PhoneInfos);
            this.SetParamSimple(map, prefix + "ReferenceWord", this.ReferenceWord);
        }
    }
}

