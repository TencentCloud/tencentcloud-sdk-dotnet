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
        /// 加速域名所属站点ID。不填写该参数默认返回所有站点下的加速域名。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 过滤条件，Filters.Values的上限为20。详细的过滤条件如下：
        /// <li>domain-name<br>   按照【<strong>加速域名名称</strong>】进行过滤。<br>   类型：String<br>   必选：否
        /// <li>origin-type<br>   按照【<strong>源站类型</strong>】进行过滤。<br>   类型：String<br>   必选：否
        /// <li>origin<br>   按照【<strong>主源站地址</strong>】进行过滤。<br>   类型：String<br>   必选：否
        /// <li>backup-origin<br>   按照【<strong>备用源站地址</strong>】进行过滤。<br>   类型：String<br>   必选：否
        /// <li>domain-cname<br>   按照【<strong>加速CNAME名</strong>】进行过滤。<br>   类型：String<br>   必选：否
        /// <li>share-cname<br>   按照【<strong>共享CNAME名</strong>】进行过滤。<br>   类型：String<br>   必选：否
        /// </summary>
        [JsonProperty("Filters")]
        public AdvancedFilter[] Filters{ get; set; }

        /// <summary>
        /// 列表排序方式，取值有：
        /// <li>asc：升序排列；</li>
        /// <li>desc：降序排列。</li>默认值为asc。
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }

        /// <summary>
        /// 匹配方式，取值有：
        /// <li>all：返回匹配所有查询条件的加速域名；</li>
        /// <li>any：返回匹配任意一个查询条件的加速域名。</li>默认值为all。
        /// </summary>
        [JsonProperty("Match")]
        public string Match{ get; set; }

        /// <summary>
        /// 分页查询限制数目，默认值：20，上限：200。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 分页查询偏移量，默认为 0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 排序依据，取值有：
        /// <li>created_on：加速域名创建时间；</li>
        /// <li>domain-name：加速域名名称；</li>
        /// </li>默认根据domain-name属性排序。
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "Match", this.Match);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Order", this.Order);
        }
    }
}

