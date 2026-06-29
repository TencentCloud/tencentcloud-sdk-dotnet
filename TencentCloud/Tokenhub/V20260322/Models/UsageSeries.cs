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

    public class UsageSeries : AbstractModel
    {
        
        /// <summary>
        /// <p>[tokens 族]总 token 数用量时间周期内的 JSON 字符串形式，如 <code>&quot;[12,null,15]&quot;</code>。</p>
        /// </summary>
        [JsonProperty("TotalToken")]
        public string TotalToken{ get; set; }

        /// <summary>
        /// <p>[tokens 族]输入 token 数用量时间周期内的 JSON 字符串形式，如 <code>&quot;[7,null,9]&quot;</code>。</p>
        /// </summary>
        [JsonProperty("InputTotalToken")]
        public string InputTotalToken{ get; set; }

        /// <summary>
        /// <p>[tokens 族]输出 token 数用量时间周期内的 JSON 字符串形式，如 <code>&quot;[5,null,6]&quot;</code>。</p>
        /// </summary>
        [JsonProperty("OutputTotalToken")]
        public string OutputTotalToken{ get; set; }

        /// <summary>
        /// <p>[tokens 族]读缓存 token 数用量时间周期内的 JSON 字符串形式，如<code>&quot;[5,null,6]&quot;</code>。</p>
        /// </summary>
        [JsonProperty("CacheTotalToken")]
        public string CacheTotalToken{ get; set; }

        /// <summary>
        /// <p>[search 族] 搜索请求数用量时间周期内的 JSON 字符串形式，如<code>&quot;[5,null,6]&quot;</code>。</p>
        /// </summary>
        [JsonProperty("SearchRequestCount")]
        public string SearchRequestCount{ get; set; }

        /// <summary>
        /// <p>[search 族] 搜索引擎调用次数用量时间周期内的 JSON 字符串形式，如<code>&quot;[5,null,6]&quot;</code>。</p>
        /// </summary>
        [JsonProperty("SearchCount")]
        public string SearchCount{ get; set; }


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

