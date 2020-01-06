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

    public class TransmitAudioStreamResponse : AbstractModel
    {
        
        /// <summary>
        /// 返回的当前音频的统计信息。当进度为100时返回。
        /// </summary>
        [JsonProperty("AsrStat")]
        public ASRStat AsrStat{ get; set; }

        /// <summary>
        /// 返回当前音频流的详细信息，如果是流模式，返回的是对应流的详细信息，如果是 URL模式，返回的是查询的那一段seq对应的音频的详细信息。
        /// </summary>
        [JsonProperty("Texts")]
        public WholeTextItem[] Texts{ get; set; }

        /// <summary>
        /// 返回词汇库中的单词出现的详细时间信息。
        /// </summary>
        [JsonProperty("VocabAnalysisDetailInfo")]
        public VocabDetailInfomation[] VocabAnalysisDetailInfo{ get; set; }

        /// <summary>
        /// 返回词汇库中的单词出现的次数信息。
        /// </summary>
        [JsonProperty("VocabAnalysisStatInfo")]
        public VocabStatInfomation[] VocabAnalysisStatInfo{ get; set; }

        /// <summary>
        /// 音频全部文本。
        /// </summary>
        [JsonProperty("AllTexts")]
        public string AllTexts{ get; set; }

        /// <summary>
        /// 临时保存的音频链接
        /// </summary>
        [JsonProperty("AudioUrl")]
        public string AudioUrl{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "AsrStat.", this.AsrStat);
            this.SetParamArrayObj(map, prefix + "Texts.", this.Texts);
            this.SetParamArrayObj(map, prefix + "VocabAnalysisDetailInfo.", this.VocabAnalysisDetailInfo);
            this.SetParamArrayObj(map, prefix + "VocabAnalysisStatInfo.", this.VocabAnalysisStatInfo);
            this.SetParamSimple(map, prefix + "AllTexts", this.AllTexts);
            this.SetParamSimple(map, prefix + "AudioUrl", this.AudioUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

