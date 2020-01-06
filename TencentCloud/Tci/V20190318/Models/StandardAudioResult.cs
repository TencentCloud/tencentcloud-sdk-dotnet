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

    public class StandardAudioResult : AbstractModel
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
        /// 状态描述
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 结果数量
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "AsrStat.", this.AsrStat);
            this.SetParamArrayObj(map, prefix + "Texts.", this.Texts);
            this.SetParamArrayObj(map, prefix + "VocabAnalysisDetailInfo.", this.VocabAnalysisDetailInfo);
            this.SetParamArrayObj(map, prefix + "VocabAnalysisStatInfo.", this.VocabAnalysisStatInfo);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
        }
    }
}

