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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HTTPServiceCacheAction : AbstractModel
    {
        
        /// <summary>
        /// <p>HTTPService 缓存动作类型</p><p>枚举值：</p><ul><li>Cache： 节点缓存 + 浏览器缓存统一动作（节点秒数 CacheTime、浏览器秒数 MaxAgeTime）</li><li>CacheKey： 仅开启EO边缘加速通道下发</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>节点缓存配置。Type=Cache 时必填</p>
        /// </summary>
        [JsonProperty("Cache")]
        public HTTPServiceCacheParams Cache{ get; set; }

        /// <summary>
        /// <p>自定义缓存键。Type=CacheKey 时必填</p>
        /// </summary>
        [JsonProperty("CacheKey")]
        public HTTPServiceCacheKeyParams CacheKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "Cache.", this.Cache);
            this.SetParamObj(map, prefix + "CacheKey.", this.CacheKey);
        }
    }
}

