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

    public class SimpleCache : AbstractModel
    {
        
        /// <summary>
        /// 缓存过期时间规则
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CacheRules")]
        public SimpleCacheRule[] CacheRules{ get; set; }

        /// <summary>
        /// 遵循源站 Cache-Control: max-age 配置
        /// on：开启
        /// off：关闭
        /// 开启后，未能匹配 CacheRules 规则的资源将根据源站返回的 max-age 值进行节点缓存；匹配了 CacheRules 规则的资源将按照 CacheRules 中设置的缓存过期时间在节点进行缓存
        /// 与 CompareMaxAge 冲突，不能同时开启
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FollowOrigin")]
        public string FollowOrigin{ get; set; }

        /// <summary>
        /// 强制缓存
        /// on：开启
        /// off：关闭
        /// 默认为关闭状态，开启后，源站返回的 no-store、no-cache 资源，也将按照 CacheRules 规则进行缓存
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IgnoreCacheControl")]
        public string IgnoreCacheControl{ get; set; }

        /// <summary>
        /// 忽略源站的Set-Cookie头部
        /// on：开启
        /// off：关闭
        /// 默认为关闭状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IgnoreSetCookie")]
        public string IgnoreSetCookie{ get; set; }

        /// <summary>
        /// 高级缓存过期配置，开启时会对比源站返回的 max-age 值与 CacheRules 中设置的缓存过期时间，取最小值在节点进行缓存
        /// on：开启
        /// off：关闭
        /// 默认为关闭状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompareMaxAge")]
        public string CompareMaxAge{ get; set; }

        /// <summary>
        /// 总是回源站校验
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Revalidate")]
        public Revalidate Revalidate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "CacheRules.", this.CacheRules);
            this.SetParamSimple(map, prefix + "FollowOrigin", this.FollowOrigin);
            this.SetParamSimple(map, prefix + "IgnoreCacheControl", this.IgnoreCacheControl);
            this.SetParamSimple(map, prefix + "IgnoreSetCookie", this.IgnoreSetCookie);
            this.SetParamSimple(map, prefix + "CompareMaxAge", this.CompareMaxAge);
            this.SetParamObj(map, prefix + "Revalidate.", this.Revalidate);
        }
    }
}

