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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CacheKeyConfigParameters : AbstractModel
    {
        
        /// <summary>
        /// 是否开启全路径缓存，取值有：
        /// <li>on：开启全路径缓存（即关闭参数忽略）；</li>
        /// <li>off：关闭全路径缓存（即开启参数忽略）。</li>
        /// </summary>
        [JsonProperty("FullURLCache")]
        public string FullURLCache{ get; set; }

        /// <summary>
        /// 是否忽略大小写缓存，取值有：
        /// <li>on：忽略；</li>
        /// <li>off：不忽略。</li>
        /// </summary>
        [JsonProperty("IgnoreCase")]
        public string IgnoreCase{ get; set; }

        /// <summary>
        /// 查询字符串保留配置参数。此字段和 FullURLCache 必须同时设置，但不能同为 on。
        /// </summary>
        [JsonProperty("QueryString")]
        public CacheKeyQueryString QueryString{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FullURLCache", this.FullURLCache);
            this.SetParamSimple(map, prefix + "IgnoreCase", this.IgnoreCase);
            this.SetParamObj(map, prefix + "QueryString.", this.QueryString);
        }
    }
}

