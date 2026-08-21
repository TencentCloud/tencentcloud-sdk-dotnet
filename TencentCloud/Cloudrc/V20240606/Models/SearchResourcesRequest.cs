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

namespace TencentCloud.Cloudrc.V20240606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchResourcesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>视图ID</p>
        /// </summary>
        [JsonProperty("ViewId")]
        public string ViewId{ get; set; }

        /// <summary>
        /// <p>每页返回的最大记录数</p>
        /// </summary>
        [JsonProperty("MaxResults")]
        public long? MaxResults{ get; set; }

        /// <summary>
        /// <p>分页Token，首次查询不传</p>
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }

        /// <summary>
        /// <p>过滤条件列表</p>
        /// </summary>
        [JsonProperty("Filters")]
        public ExtendedFilter[] Filters{ get; set; }

        /// <summary>
        /// <p>排序条件</p><p>枚举值：</p><ul><li>CreateTime： 表示按资源创建时间排序</li><li>ExpireTime： 表示按资源到期时间排序</li><li>IpAddress： 表示按资源IP地址排序</li></ul>
        /// </summary>
        [JsonProperty("SortBy")]
        public string SortBy{ get; set; }

        /// <summary>
        /// <p>排序顺序</p><p>枚举值：</p><ul><li>Asc： 升序</li><li>Desc： 降序</li></ul><p>默认值：Asc</p>
        /// </summary>
        [JsonProperty("SortOrder")]
        public string SortOrder{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ViewId", this.ViewId);
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "SortBy", this.SortBy);
            this.SetParamSimple(map, prefix + "SortOrder", this.SortOrder);
        }
    }
}

