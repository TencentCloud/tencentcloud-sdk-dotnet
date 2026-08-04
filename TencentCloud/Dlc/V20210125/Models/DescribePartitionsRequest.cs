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

    public class DescribePartitionsRequest : AbstractModel
    {
        
        /// <summary>
        /// 页码，从1开始，默认为1
        /// </summary>
        [JsonProperty("Page")]
        public long? Page{ get; set; }

        /// <summary>
        /// 每页返回数量，默认为10
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 排序字段列表，按数组顺序依次应用，可选
        /// </summary>
        [JsonProperty("SortFields")]
        public SortField[] SortFields{ get; set; }

        /// <summary>
        /// 筛选条件列表，多个条件之间为AND关系，可选
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Page", this.Page);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamArrayObj(map, prefix + "SortFields.", this.SortFields);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

