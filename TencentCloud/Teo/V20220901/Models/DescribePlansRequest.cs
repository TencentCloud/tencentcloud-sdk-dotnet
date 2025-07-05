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

    public class DescribePlansRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件，Filters.Values 的上限为 20。详细的过滤条件如下：<li>plan-type<br>  按照【<strong>套餐类型</strong>】进行过滤。<br>  可选的类型有：<br>  plan-trial：试用版套餐；<br>  plan-personal：个人版套餐；<br>  plan-basic：基础版套餐； <br>  plan-standard：标准版套餐； <br>  plan-enterprise：企业版套餐。 </li><li>plan-id<br>  按照【<strong>套餐 ID</strong>】进行过滤。套餐 ID 形如：edgeone-268z103ob0sx。</li><li>area<br>  按照【<strong>套餐加速地域</strong>】进行过滤。</li>  服务区域，可选的类型有：<br>  mainland: 中国大陆；<br>  overseas: 全球（不包括中国大陆)；<br>  global: 全球（包括中国大陆)。<br><li>status<br>  按照【<strong>套餐状态</strong>】进行过滤。<br>  可选的状态有：<br>  normal：正常状态；<br>  expiring-soon：即将过期；<br>  expired：已到期;<br>  isolated：已隔离。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 排序字段，取值有：
        /// <li> enable-time：生效时间；</li>
        /// <li> expire-time：过期时间。</li>不填写使用默认值 enable-time。
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 排序方向，取值有：
        /// <li>asc：从小到大排序；</li>
        /// <li>desc：从大到小排序。</li>不填写使用默认值 desc。
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }

        /// <summary>
        /// 分页查询限制数目。默认值：20，最大值：200。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 分页查询偏移量。默认值：0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

