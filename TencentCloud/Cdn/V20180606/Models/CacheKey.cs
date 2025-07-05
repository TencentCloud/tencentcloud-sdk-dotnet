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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CacheKey : AbstractModel
    {
        
        /// <summary>
        /// 是否开启全路径缓存
        /// on：开启全路径缓存（即关闭参数忽略）
        /// off：关闭全路径缓存（即开启参数忽略）
        /// </summary>
        [JsonProperty("FullUrlCache")]
        public string FullUrlCache{ get; set; }

        /// <summary>
        /// 是否忽略大小写缓存
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IgnoreCase")]
        public string IgnoreCase{ get; set; }

        /// <summary>
        /// CacheKey中包含请求参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueryString")]
        public QueryStringKey QueryString{ get; set; }

        /// <summary>
        /// CacheKey中包含Cookie
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cookie")]
        public CookieKey Cookie{ get; set; }

        /// <summary>
        /// CacheKey中包含请求头部
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Header")]
        public HeaderKey Header{ get; set; }

        /// <summary>
        /// CacheKey中包含自定义字符串
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CacheTag")]
        public CacheTagKey CacheTag{ get; set; }

        /// <summary>
        /// CacheKey中包含请求协议
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Scheme")]
        public SchemeKey Scheme{ get; set; }

        /// <summary>
        /// 分路径缓存键配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KeyRules")]
        public KeyRule[] KeyRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FullUrlCache", this.FullUrlCache);
            this.SetParamSimple(map, prefix + "IgnoreCase", this.IgnoreCase);
            this.SetParamObj(map, prefix + "QueryString.", this.QueryString);
            this.SetParamObj(map, prefix + "Cookie.", this.Cookie);
            this.SetParamObj(map, prefix + "Header.", this.Header);
            this.SetParamObj(map, prefix + "CacheTag.", this.CacheTag);
            this.SetParamObj(map, prefix + "Scheme.", this.Scheme);
            this.SetParamArrayObj(map, prefix + "KeyRules.", this.KeyRules);
        }
    }
}

