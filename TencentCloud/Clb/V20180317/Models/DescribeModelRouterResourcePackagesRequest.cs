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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeModelRouterResourcePackagesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>模型路由资源包Id。</p>
        /// </summary>
        [JsonProperty("ModelRouterResourcePackageIds")]
        public string[] ModelRouterResourcePackageIds{ get; set; }

        /// <summary>
        /// <p>数据偏移量。</p><p>默认值：0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>返回的数量，最大值为100。</p><p>取值范围：[1, 100]</p><p>默认值：20</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>排序参数，支持以下字段：&quot;buyTime&quot;, &quot;startTime&quot;, &quot;endTime&quot;</p>
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// <p>排序方式：asc，desc，默认asc</p>
        /// </summary>
        [JsonProperty("SortBy")]
        public string SortBy{ get; set; }

        /// <summary>
        /// <p>查询的过滤条件。</p><p>每次请求的Filters的上限为10，Filter.Values的上限为100。 Filter.Name和Filter.Values皆为必填项。详细的过滤条件如下： status - Integer - 是否必填：否 - 状态：0-有效 1-已退款 2-已过期 3-已用完。 effect_time_start - String - 是否必填：否 - 生效起始时间,YYYY-MM-DD HH:MM:SS格式。 effect_time_end - String - 是否必填：否 - 生效截止时间。 expire_time_start - String - 是否必填：否 - 失效起始时间。 expire_time_end - String - 是否必填：否 - 失效截止时间。</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ModelRouterResourcePackageIds.", this.ModelRouterResourcePackageIds);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "SortBy", this.SortBy);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

