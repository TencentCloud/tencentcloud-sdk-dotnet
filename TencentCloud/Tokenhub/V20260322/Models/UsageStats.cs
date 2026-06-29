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

namespace TencentCloud.Tokenhub.V20260322.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UsageStats : AbstractModel
    {
        
        /// <summary>
        /// <p>[tokens 族] 时间周期内的累计总 token 数。</p>
        /// </summary>
        [JsonProperty("TotalToken")]
        public long? TotalToken{ get; set; }

        /// <summary>
        /// <p>[tokens 族] 时间周期内的累计输入 token 数。</p>
        /// </summary>
        [JsonProperty("InputTotalToken")]
        public long? InputTotalToken{ get; set; }

        /// <summary>
        /// <p>[tokens 族] 时间周期内的累计输出 token 数。</p>
        /// </summary>
        [JsonProperty("OutputTotalToken")]
        public long? OutputTotalToken{ get; set; }

        /// <summary>
        /// <p>[tokens 族] 时间周期内的累计读缓存 token 数（命中缓存部分）</p>
        /// </summary>
        [JsonProperty("CacheTotalToken")]
        public long? CacheTotalToken{ get; set; }

        /// <summary>
        /// <p>[search 族] 整段累计联网搜索请求数</p>
        /// </summary>
        [JsonProperty("SearchRequestCount")]
        public long? SearchRequestCount{ get; set; }

        /// <summary>
        /// <p>[search 族] 整段累计搜索引擎调用次数</p>
        /// </summary>
        [JsonProperty("SearchCount")]
        public long? SearchCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalToken", this.TotalToken);
            this.SetParamSimple(map, prefix + "InputTotalToken", this.InputTotalToken);
            this.SetParamSimple(map, prefix + "OutputTotalToken", this.OutputTotalToken);
            this.SetParamSimple(map, prefix + "CacheTotalToken", this.CacheTotalToken);
            this.SetParamSimple(map, prefix + "SearchRequestCount", this.SearchRequestCount);
            this.SetParamSimple(map, prefix + "SearchCount", this.SearchCount);
        }
    }
}

