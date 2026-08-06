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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KongServiceRoute : AbstractModel
    {
        
        /// <summary>
        /// <p>服务信息</p>
        /// </summary>
        [JsonProperty("Service")]
        public KongServicePreview Service{ get; set; }

        /// <summary>
        /// <p>路由总数</p>
        /// </summary>
        [JsonProperty("RouteTotalCount")]
        public long? RouteTotalCount{ get; set; }

        /// <summary>
        /// <p>是否还有更多路由</p>
        /// </summary>
        [JsonProperty("RouteHasMore")]
        public bool? RouteHasMore{ get; set; }

        /// <summary>
        /// <p>路由列表</p>
        /// </summary>
        [JsonProperty("Routes")]
        public KongRoutePreview[] Routes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Service.", this.Service);
            this.SetParamSimple(map, prefix + "RouteTotalCount", this.RouteTotalCount);
            this.SetParamSimple(map, prefix + "RouteHasMore", this.RouteHasMore);
            this.SetParamArrayObj(map, prefix + "Routes.", this.Routes);
        }
    }
}

