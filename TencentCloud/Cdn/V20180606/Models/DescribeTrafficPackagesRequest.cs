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

    public class DescribeTrafficPackagesRequest : AbstractModel
    {
        
        /// <summary>
        /// 分页查询起始地址，默认 0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页查询记录个数，默认100，最大1000
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 流量包排序方式，支持以下值：
        /// expireTimeDesc：默认值，按过期时间倒序
        /// expireTimeAsc：按过期时间正序
        /// createTimeDesc：按创建时间倒序
        /// createTimeAsc：按创建时间正序
        /// status：按状态排序，正常抵扣>未生效>已用尽>已过期
        /// channel：按来源排序，主动购买>自动续订>CDN赠送
        /// </summary>
        [JsonProperty("SortBy")]
        public string SortBy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "SortBy", this.SortBy);
        }
    }
}

