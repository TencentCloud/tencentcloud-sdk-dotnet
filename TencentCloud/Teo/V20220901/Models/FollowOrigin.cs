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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FollowOrigin : AbstractModel
    {
        
        /// <summary>
        /// 遵循源站配置开关，取值有：
        /// <li>on：开启；</li>
        /// <li>off：关闭。</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 源站未返回 Cache-Control 头时, 设置默认的缓存时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultCacheTime")]
        public long? DefaultCacheTime{ get; set; }

        /// <summary>
        /// 源站未返回 Cache-Control 头时, 设置缓存/不缓存
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultCache")]
        public string DefaultCache{ get; set; }

        /// <summary>
        /// 源站未返回 Cache-Control 头时, 使用/不使用默认缓存策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultCacheStrategy")]
        public string DefaultCacheStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "DefaultCacheTime", this.DefaultCacheTime);
            this.SetParamSimple(map, prefix + "DefaultCache", this.DefaultCache);
            this.SetParamSimple(map, prefix + "DefaultCacheStrategy", this.DefaultCacheStrategy);
        }
    }
}

