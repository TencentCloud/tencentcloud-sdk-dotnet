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

namespace TencentCloud.Tag.V20180813.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetResourcesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>资源六段式列表。腾讯云使用资源六段式描述一个资源。<br>例如：ResourceList.1 = qcs::${ServiceType}:${Region}:${Account}:${ResourcePreifx}/${ResourceId}。<br>如果传入了此参数会返回所有匹配的资源列表，指定的MaxResults会失效。<br>N取值范围：0~9</p>
        /// </summary>
        [JsonProperty("ResourceList")]
        public string[] ResourceList{ get; set; }

        /// <summary>
        /// <p>标签过滤数组，最多支持6组标签。会查询同时绑定了这多组标签的资源。<br>每组标签中的TagValue最多支持10个。</p>
        /// </summary>
        [JsonProperty("TagFilters")]
        public TagFilter[] TagFilters{ get; set; }

        /// <summary>
        /// <p>从上一页的响应中获取的下一页的Token值。<br>如果是第一次请求，设置为空。</p>
        /// </summary>
        [JsonProperty("PaginationToken")]
        public string PaginationToken{ get; set; }

        /// <summary>
        /// <p>每一页返回的数据最大条数，最大200。<br>缺省值：50。</p>
        /// </summary>
        [JsonProperty("MaxResults")]
        public ulong? MaxResults{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ResourceList.", this.ResourceList);
            this.SetParamArrayObj(map, prefix + "TagFilters.", this.TagFilters);
            this.SetParamSimple(map, prefix + "PaginationToken", this.PaginationToken);
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
        }
    }
}

