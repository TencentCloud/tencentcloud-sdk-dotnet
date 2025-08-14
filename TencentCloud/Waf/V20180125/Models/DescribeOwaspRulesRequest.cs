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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeOwaspRulesRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要查询的域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 分页页数，默认为0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 每页容量，默认为10
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 排序字段，支持 RuleId, UpdateTime
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }

        /// <summary>
        /// 排序方式，支持asc、desc
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 筛选条件，支持 RuleId：规则ID、TypeId：规则类型、Desc：规则描述 、CveID：CVE编号、Status：规则状态、VulLevel：威胁等级
        /// </summary>
        [JsonProperty("Filters")]
        public FiltersItemNew[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "By", this.By);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

