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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConversationRecordTokenUsage : AbstractModel
    {
        
        /// <summary>
        /// <p>输入 token 总数</p>
        /// </summary>
        [JsonProperty("InputTokens")]
        public string InputTokens{ get; set; }

        /// <summary>
        /// <p>输出 token 总数</p>
        /// </summary>
        [JsonProperty("OutputTokens")]
        public string OutputTokens{ get; set; }

        /// <summary>
        /// <p>消耗 token 总数</p>
        /// </summary>
        [JsonProperty("TotalTokens")]
        public string TotalTokens{ get; set; }

        /// <summary>
        /// <p>缓存命中 token 总数</p>
        /// </summary>
        [JsonProperty("CachedTokens")]
        public string CachedTokens{ get; set; }

        /// <summary>
        /// <p>推理 token 总数</p>
        /// </summary>
        [JsonProperty("ReasoningTokens")]
        public string ReasoningTokens{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputTokens", this.InputTokens);
            this.SetParamSimple(map, prefix + "OutputTokens", this.OutputTokens);
            this.SetParamSimple(map, prefix + "TotalTokens", this.TotalTokens);
            this.SetParamSimple(map, prefix + "CachedTokens", this.CachedTokens);
            this.SetParamSimple(map, prefix + "ReasoningTokens", this.ReasoningTokens);
        }
    }
}

