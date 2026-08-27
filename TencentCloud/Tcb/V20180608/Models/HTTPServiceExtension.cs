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

    public class HTTPServiceExtension : AbstractModel
    {
        
        /// <summary>
        /// <p>添加请求头列表</p>
        /// </summary>
        [JsonProperty("HeadersHandler")]
        public HTTPServiceHeadersHandler HeadersHandler{ get; set; }

        /// <summary>
        /// <p>HTTPService 缓存配置，包含Cache 节点缓存 / MaxAge 浏览器缓存 / CacheKey 自定义缓存键</p>
        /// </summary>
        [JsonProperty("Cache")]
        public HTTPServiceCacheSet Cache{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "HeadersHandler.", this.HeadersHandler);
            this.SetParamObj(map, prefix + "Cache.", this.Cache);
        }
    }
}

