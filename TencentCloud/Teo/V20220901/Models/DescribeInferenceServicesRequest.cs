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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInferenceServicesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>站点ID。</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>过滤条件，上限 20 个，多个条件为且关系，Filters.Values 的上限为 20。详细的过滤条件如下：<li>service-name：按照服务名称进行过滤；</li><li>service-id：按照服务 ID 过滤；</li><li>status：按照服务状态过滤。</li>模糊查询时仅支持过滤字段名为 service-name。</p>
        /// </summary>
        [JsonProperty("Filters")]
        public AdvancedFilter[] Filters{ get; set; }

        /// <summary>
        /// <p>分页查询偏移量。默认值：0。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>分页查询限制数目。默认值：20，最大值：200。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>可根据该字段对返回结果进行排序，取值有：<li>create-time：创建时间。</li>不填写时默认按照 create-time 排序。</p>
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// <p>排序方向，如果是字段值为数字，则根据数字大小排序；如果字段值为文本，则根据 ASCII 码的大小排序。取值有：<li>asc：从小到大排序；</li><li>desc：从大到小排序。</li>不填写使用默认值 desc。</p>
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
        }
    }
}

