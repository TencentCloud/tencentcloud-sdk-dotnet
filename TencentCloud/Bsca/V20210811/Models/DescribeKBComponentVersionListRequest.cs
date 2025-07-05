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

namespace TencentCloud.Bsca.V20210811.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeKBComponentVersionListRequest : AbstractModel
    {
        
        /// <summary>
        /// 要查询的组件 PURL
        /// </summary>
        [JsonProperty("PURL")]
        public PURL PURL{ get; set; }

        /// <summary>
        /// 页号
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 排序方式，可以是"ASC"或"DESC"，默认"DESC"
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 排序字段，可能的字段包括“Version”、"PublishTime"
        /// </summary>
        [JsonProperty("OrderBy")]
        public string[] OrderBy{ get; set; }

        /// <summary>
        /// Tag筛选
        /// </summary>
        [JsonProperty("Filter")]
        public ComponentTagFilter Filter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "PURL.", this.PURL);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamArraySimple(map, prefix + "OrderBy.", this.OrderBy);
            this.SetParamObj(map, prefix + "Filter.", this.Filter);
        }
    }
}

