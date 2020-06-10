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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CacheKey : AbstractModel
    {
        
        /// <summary>
        /// 是否开启全路径缓存
        /// on：开启全路径缓存（即关闭参数过滤）
        /// off：关闭全路径缓存（即开启参数过滤）
        /// </summary>
        [JsonProperty("FullUrlCache")]
        public string FullUrlCache{ get; set; }

        /// <summary>
        /// 是否使用请求参数作为CacheKey的一部分
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueryString")]
        public QueryStringKey QueryString{ get; set; }

        /// <summary>
        /// 是否使用请求头部作为CacheKey的一部分
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Header")]
        public HeaderKey Header{ get; set; }

        /// <summary>
        /// 是否使用Cookie作为CacheKey的一部分
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cookie")]
        public CookieKey Cookie{ get; set; }

        /// <summary>
        /// 是否使用请求协议作为CacheKey的一部分
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Scheme")]
        public SchemeKey Scheme{ get; set; }

        /// <summary>
        /// 是否使用自定义字符串作为CacheKey的一部分
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CacheTag")]
        public CacheTagKey CacheTag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FullUrlCache", this.FullUrlCache);
            this.SetParamObj(map, prefix + "QueryString.", this.QueryString);
            this.SetParamObj(map, prefix + "Header.", this.Header);
            this.SetParamObj(map, prefix + "Cookie.", this.Cookie);
            this.SetParamObj(map, prefix + "Scheme.", this.Scheme);
            this.SetParamObj(map, prefix + "CacheTag.", this.CacheTag);
        }
    }
}

