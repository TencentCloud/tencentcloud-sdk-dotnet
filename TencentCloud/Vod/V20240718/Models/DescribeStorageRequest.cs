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

namespace TencentCloud.Vod.V20240718.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeStorageRequest : AbstractModel
    {
        
        /// <summary>
        /// <b>点播专业版[应用](/document/product/266/14574) ID。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 过滤条件，Filters.Values 的上限为 20；若 Filters 长度为 0 则分页查询子应用 SubAppId 下的存储信息。 详细的过滤条件如下：
        /// <li>BucketId<br>   按照【<strong>存储桶 ID</strong>】进行过滤。<br>   类型：String<br>   必选：否</li>
        /// <li>StorageName<br>   按照【<strong>存储名称</strong>】进行过滤。<br>   类型：String<br>   必选：否</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 返回结果的排序。 SortBy.Field 取值有：
        /// <li>CreateTime：创建时间。</li>若不填，SortBy.Field 默认值为 CreateTime，SortBy.Order 默认值为 Asc。
        /// </summary>
        [JsonProperty("SortBy")]
        public SortBy SortBy{ get; set; }

        /// <summary>
        /// 分页返回的起始偏移量，默认值为 0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 分页返回的记录条数，默认值为 20，最大值为 1000。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamObj(map, prefix + "SortBy.", this.SortBy);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

