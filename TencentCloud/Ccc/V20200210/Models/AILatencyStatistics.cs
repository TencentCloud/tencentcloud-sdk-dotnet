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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AILatencyStatistics : AbstractModel
    {
        
        /// <summary>
        /// asr时延统计
        /// </summary>
        [JsonProperty("ASRLatency")]
        public AILatencyStatisticsInfo ASRLatency{ get; set; }

        /// <summary>
        /// tts时延统计
        /// </summary>
        [JsonProperty("TTSLatency")]
        public AILatencyStatisticsInfo TTSLatency{ get; set; }

        /// <summary>
        /// llm时延统计
        /// </summary>
        [JsonProperty("LLMLatency")]
        public AILatencyStatisticsInfo LLMLatency{ get; set; }

        /// <summary>
        /// 端到端时延统计
        /// </summary>
        [JsonProperty("ETELatency")]
        public AILatencyStatisticsInfo ETELatency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ASRLatency.", this.ASRLatency);
            this.SetParamObj(map, prefix + "TTSLatency.", this.TTSLatency);
            this.SetParamObj(map, prefix + "LLMLatency.", this.LLMLatency);
            this.SetParamObj(map, prefix + "ETELatency.", this.ETELatency);
        }
    }
}

