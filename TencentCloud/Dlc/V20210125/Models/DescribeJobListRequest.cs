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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeJobListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>页码，从1开始，默认为1.</p>
        /// </summary>
        [JsonProperty("Page")]
        public long? Page{ get; set; }

        /// <summary>
        /// <p>每页返回数量，默认为10.</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// <p>高级过滤条件列表，元素 Name 为过滤字段名（PascalCase，可用字段与操作符约束见各接口 Filters 说明），Values 为过滤值列表；未列入白名单或非 PascalCase 的 Name 报 InvalidParameter。</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>排序字段列表，元素 Field 为排序字段名（PascalCase，与响应字段命名对齐，可用字段见各接口 SortFields 说明），Order 为排序方向（ASC/DESC，不传默认 DESC）；未列入白名单或非 PascalCase 的 Field 报 InvalidParameter。</p>
        /// </summary>
        [JsonProperty("SortFields")]
        public SortField[] SortFields{ get; set; }

        /// <summary>
        /// <p>创建时间下限（Unix 毫秒时间戳）。</p>
        /// </summary>
        [JsonProperty("CreateTimeStart")]
        public long? CreateTimeStart{ get; set; }

        /// <summary>
        /// <p>创建时间上限（Unix 毫秒时间戳）。</p>
        /// </summary>
        [JsonProperty("CreateTimeEnd")]
        public long? CreateTimeEnd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Page", this.Page);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArrayObj(map, prefix + "SortFields.", this.SortFields);
            this.SetParamSimple(map, prefix + "CreateTimeStart", this.CreateTimeStart);
            this.SetParamSimple(map, prefix + "CreateTimeEnd", this.CreateTimeEnd);
        }
    }
}

