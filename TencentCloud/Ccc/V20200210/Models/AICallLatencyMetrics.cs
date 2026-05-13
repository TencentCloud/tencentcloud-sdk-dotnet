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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AICallLatencyMetrics : AbstractModel
    {
        
        /// <summary>
        /// <p>asr时延（毫秒）</p><p>-1 表示无 asr时延</p>
        /// </summary>
        [JsonProperty("AsrLatency")]
        public long? AsrLatency{ get; set; }

        /// <summary>
        /// <p>llm首token时延(毫秒)</p>
        /// </summary>
        [JsonProperty("LLMFirstTokenLatency")]
        public long? LLMFirstTokenLatency{ get; set; }

        /// <summary>
        /// <p>tts时延（毫秒）</p><p>-1 表示无 tts时延</p>
        /// </summary>
        [JsonProperty("TTSLatency")]
        public long? TTSLatency{ get; set; }

        /// <summary>
        /// <p>总时延</p>
        /// </summary>
        [JsonProperty("TotalLatency")]
        public long? TotalLatency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AsrLatency", this.AsrLatency);
            this.SetParamSimple(map, prefix + "LLMFirstTokenLatency", this.LLMFirstTokenLatency);
            this.SetParamSimple(map, prefix + "TTSLatency", this.TTSLatency);
            this.SetParamSimple(map, prefix + "TotalLatency", this.TotalLatency);
        }
    }
}

