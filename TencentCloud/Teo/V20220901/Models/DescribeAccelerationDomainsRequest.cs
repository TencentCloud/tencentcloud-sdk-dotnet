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

    public class DescribeAccelerationDomainsRequest : AbstractModel
    {
        
        /// <summary>
        /// 加速域名所属站点 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 分页查询偏移量，默认为 0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页查询限制数目，默认值：20，上限：200。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 过滤条件，Filters.Values 的上限为 20。该参数不填写时，返回当前 zone-id 下所有域名信息。详细的过滤条件如下：
        /// <li>domain-name：按照加速域名进行过滤；</li>
        /// <li>origin-type：按照源站类型进行过滤；</li>
        /// <li>origin：按照主源站地址进行过滤；</li>
        /// <li>backup-origin： 按照备用源站地址进行过滤；</li>
        /// <li>domain-cname：按照 CNAME 进行过滤；</li>
        /// <li>share-cname：按照共享 CNAME 进行过滤；</li>
        /// </summary>
        [JsonProperty("Filters")]
        public AdvancedFilter[] Filters{ get; set; }

        /// <summary>
        /// 可根据该字段对返回结果进行排序，取值有：
        /// <li>created_on：加速域名创建时间；</li>
        /// <li>domain-name：加速域名。</li>不填写时，默认对返回结果按照 domain-name 排序。
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 排序方向，如果是字段值为数字，则根据数字大小排序；如果字段值为文本，则根据 ascill 码的大小排序。取值有：
        /// <li>asc：升序排列；</li>
        /// <li>desc：降序排列。</li>不填写使用默认值 asc。
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }

        /// <summary>
        /// 匹配方式，取值有：
        /// <li>all：返回匹配所有查询条件的加速域名；</li>
        /// <li>any：返回匹配任意一个查询条件的加速域名。</li>不填写时默认值为 all。
        /// </summary>
        [JsonProperty("Match")]
        public string Match{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "Match", this.Match);
        }
    }
}

