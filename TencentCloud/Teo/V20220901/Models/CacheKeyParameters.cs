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

    public class CacheKeyParameters : AbstractModel
    {
        
        /// <summary>
        /// 查询字符串全部保留开关，取值有：
        /// <li>on：开启；</li>
        /// <li>off：关闭。</li>注意：FullURLCache、IgnoreCase、Header、Scheme、Cookie 至少设置一个配置。此字段和 QueryString.Switch 必须同时设置，但不能同为 on。
        /// </summary>
        [JsonProperty("FullURLCache")]
        public string FullURLCache{ get; set; }

        /// <summary>
        /// 查询字符串保留配置参数。此字段和 FullURLCache 必须同时设置，但不能同为 on。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueryString")]
        public CacheKeyQueryString QueryString{ get; set; }

        /// <summary>
        /// 忽略大小写开关，取值有：
        /// <li>on：开启；</li>
        /// <li>off：关闭。</li>注意：FullURLCache、IgnoreCase、Header、Scheme、Cookie 至少设置一个配置。
        /// </summary>
        [JsonProperty("IgnoreCase")]
        public string IgnoreCase{ get; set; }

        /// <summary>
        /// HTTP 请求头配置参数。FullURLCache、IgnoreCase、Header、Scheme、Cookie 至少设置一个配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Header")]
        public CacheKeyHeader Header{ get; set; }

        /// <summary>
        /// 请求协议开关，取值有：
        /// <li>on：开启；</li>
        /// <li>off：关闭。</li>注意：FullURLCache、IgnoreCase、Header、Scheme、Cookie 至少设置一个配置。
        /// </summary>
        [JsonProperty("Scheme")]
        public string Scheme{ get; set; }

        /// <summary>
        /// Cookie 配置参数。FullURLCache、IgnoreCase、Header、Scheme、Cookie 至少设置一个配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cookie")]
        public CacheKeyCookie Cookie{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FullURLCache", this.FullURLCache);
            this.SetParamObj(map, prefix + "QueryString.", this.QueryString);
            this.SetParamSimple(map, prefix + "IgnoreCase", this.IgnoreCase);
            this.SetParamObj(map, prefix + "Header.", this.Header);
            this.SetParamSimple(map, prefix + "Scheme", this.Scheme);
            this.SetParamObj(map, prefix + "Cookie.", this.Cookie);
        }
    }
}

